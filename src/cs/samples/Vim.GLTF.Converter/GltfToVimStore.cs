using SharpGLTF.Schema2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Vim.Format;
using Vim.Format.ObjectModel;
using Vim.Math3d;
using Node = Vim.Format.ObjectModel.Node;

// Aliasing some types to reduce verbosity
//using MeshMap = System.Collections.Generic.Dictionary<int, (int index, Vim.Format.DocumentBuilder.Mesh gb)>;
//using InstanceMap = System.Collections.Generic.Dictionary<int, (int index, Vim.Format.DocumentBuilder.Instance instance)>;

namespace Vim.Gltf.Converter
{
    public class GltfToVimStore : ObjectModelStore
    {
        // ASSEMBLY VERSION INFO
        private static readonly Version AssemblyVersion = typeof(GltfToVimStore).Assembly.GetName().Version;
        public static readonly string VersionString = $"v{AssemblyVersion.Major}.{AssemblyVersion.Minor}.{AssemblyVersion.Build}";
        private const string GeneratorString = "Vim.Gltf.Converter";

        /// <summary>
        /// Converts a GLTF file into a VIM file.
        /// </summary>
        public static void Convert(string gltfFilePath, string vimFilePath)
        {
            var store = new GltfToVimStore(gltfFilePath);
            store.VisitGltf();
            store.WriteVim(vimFilePath);
        }

        private readonly string _gltfFilePath;
        private readonly SharpGLTF.Schema2.ModelRoot _gltfModelRoot;

        private DisplayUnit _defaultDisplayUnit;

        /// <summary>
        /// Private constructor. Please use the static function ConvertGltfToVim to convert a GLTF file into a VIM file.
        /// </summary>
        private GltfToVimStore(string gltfFilePath)
        {
            _gltfFilePath = gltfFilePath;
            _gltfModelRoot = ModelRoot.Load(gltfFilePath);
        }

        /// <summary>
        /// Visits the GLTF hierarchy and aggregates the data as VIM objects.
        /// </summary>
        private void VisitGltf()
        {
            _defaultDisplayUnit = StoreDefaultDisplayUnit();
            var defaultCategory = StoreDefaultCategory();
            var rootBimDocument = StoreGltfModel(_gltfFilePath, _gltfModelRoot, defaultCategory);
            var defaultFamily = StoreDefaultFamily(rootBimDocument, defaultCategory);
            var defaultFamilyType = StoreDefaultFamilyType(rootBimDocument, defaultCategory, defaultFamily);

            var scene = _gltfModelRoot.DefaultScene;
            StoreGltfScene(scene, rootBimDocument, defaultCategory);

            foreach (var node in scene.VisualChildren)
                StoreGltfNodeRecursively(node, rootBimDocument, defaultCategory, defaultFamilyType, Matrix4x4.Identity);
        }

        /// <summary>
        /// Stores a default empty display unit entity.
        /// </summary>
        private DisplayUnit StoreDefaultDisplayUnit()
            => ObjectModelBuilder.Add(DisplayUnit.Empty);

        /// <summary>
        /// Since GLTF does not contain Category information, we will store a single default Category
        /// entity which will be applied to all elements.
        /// </summary>
        private Category StoreDefaultCategory()
            => ObjectModelBuilder.Add(new Category
            {
                Id = VimConstants.SyntheticCategoryId,
                BuiltInCategory = "GLTF_CATEGORY",
                Name = "GLTF Object",
                CategoryType = "GLTF",
            });

        /// <summary>
        /// Since GLTF does not contain Family information, we will store a single default Family
        /// entity which will be applied to the default FamilyType entity.
        /// </summary>
        private Family StoreDefaultFamily(
            BimDocument bimDocument,
            Category category)
        {
            var familyElement = ObjectModelBuilder.Add(new Element
            {
                Id = VimConstants.SyntheticElementId,
                Name = "GLTF Family",
                _BimDocument = { Index = bimDocument.Index },
                _Category = { Index = category.Index }
            }); 

            return ObjectModelBuilder.Add(new Family
            {
                _Element = { Index = familyElement.Index },
            });
        }

        /// <summary>
        /// Since GLTF does not contain FamilyType information, we will store a single default FamilyType
        /// entity which will be applied to the FamilyInstance entities created thereafter.
        /// </summary>
        private FamilyType StoreDefaultFamilyType(
            BimDocument bimDocument,
            Category category,
            Family family)
        {
            var familyTypeElement = ObjectModelBuilder.Add(new Element
            {
                Id = VimConstants.SyntheticElementId,
                Name = "GLTF Family Type",
                _BimDocument = { Index = bimDocument.Index },
                _Category = { Index = category.Index }
            });

            return ObjectModelBuilder.Add(new FamilyType
            {
                _Element = { Index = familyTypeElement.Index },
                _Family = { Index = family.Index }
            });
        }

        /// <summary>
        /// Stores the root GLTF model as a BimDocument entity.
        /// </summary>
        private BimDocument StoreGltfModel(string gltfFilePath, SharpGLTF.Schema2.ModelRoot gltfModel, Category category)
        {
            // Create a BIM document representing the GLTF model.
            var bimDocument = ObjectModelBuilder.Add(new BimDocument
            {
                Title = Path.GetFileNameWithoutExtension(gltfFilePath),
                Name = Path.GetFileName(gltfFilePath),
                PathName = gltfFilePath,
            });

            // Create an element to hold the BIM document's parameters.
            var elementEntity = ObjectModelBuilder.Add(bimDocument.CreateParameterHolderElement());
            elementEntity._Category.Index = category.Index;
            elementEntity._BimDocument.Index = bimDocument.Index;
            bimDocument._Element.Index = elementEntity.Index;

            // Store BIM document parameters as strings representing some of the gltfModel's properties.
            StoreParameter(elementEntity, nameof(gltfModel.ExtensionsUsed), string.Join(",", gltfModel.ExtensionsUsed));
            StoreParameter(elementEntity, nameof(gltfModel.ExtensionsRequired), string.Join(",", gltfModel.ExtensionsRequired));
            StoreParameter(elementEntity, nameof(gltfModel.MeshQuantizationAllowed), gltfModel.MeshQuantizationAllowed.ToString());

            return bimDocument;
        }

        /// <summary>
        /// Store the parameter values associated with the element.
        /// </summary>
        private void StoreParameter(Element elementEntity, string name, string value)
        {
            // Get (or add) the cached parameter descriptor associated with the name.
            var parameterDescriptor = ObjectModelBuilder.GetOrAdd(name, _ => new ParameterDescriptor()
            {
                Name = name,
                _DisplayUnit = { Index = _defaultDisplayUnit.Index },
            }).Entity;

            // Store the parameter value. We use AddUntracked because it doesn't waste time doing a cache lookup.
            ObjectModelBuilder.AddUntracked(new Parameter
            {
                Values = (value, value),
                _ParameterDescriptor = { Index = parameterDescriptor.Index },
                _Element = { Index = elementEntity.Index }
            });
        }

        /// <summary>
        /// Stores a GLTF scene as a VIM Site entity.
        /// </summary>
        private void StoreGltfScene(
            SharpGLTF.Schema2.Scene gltfScene,
            BimDocument bimDocument,
            Category category)
        {
            // For illustrative purposes, we'll convert a GLTF scene into a Site entity.
            var siteElement = ObjectModelBuilder.Add(new Element()
            {
                Id = gltfScene.LogicalIndex,
                Name = gltfScene.Name,
                _BimDocument = { Index = bimDocument.Index },
                _Category = { Index = category.Index },
            });

            ObjectModelBuilder.Add(new Site
            {
                _Element = { Index = siteElement.Index }
            });
        }

        /// <summary>
        /// Stores a GLTF node as a VIM Family Instance entity.
        /// </summary>
        private void StoreGltfNodeRecursively(
            SharpGLTF.Schema2.Node gltfNode,
            BimDocument bimDocument,
            Category category,
            FamilyType familyType,
            Matrix4x4 parentMatrix)
        {
            // Create the element associated to the node.
            var familyInstanceElement = ObjectModelBuilder.Add(new Element
            {
                Id = gltfNode.LogicalIndex,
                Name = gltfNode.Name,
                _BimDocument = { Index = bimDocument.Index },
                _Category = { Index = category.Index },
            });

            // Store some sample parameters related to the GLTF node.
            StoreParameter(familyInstanceElement, nameof(gltfNode.IsSkinJoint), gltfNode.IsSkinJoint.ToString());
            StoreParameter(familyInstanceElement, nameof(gltfNode.IsSkinSkeleton), gltfNode.IsSkinSkeleton.ToString());
            StoreParameter(familyInstanceElement, nameof(gltfNode.IsTransformAnimated), gltfNode.IsTransformAnimated.ToString());

            // Create a family instance pointing to the element and family type.
            ObjectModelBuilder.Add(new FamilyInstance
            {
                _Element = { Index = familyInstanceElement.Index },
                _FamilyType = { Index = familyType.Index }
            });

            // Store the GLTF node's mesh as a VIM mesh.
            var vimMeshIndex = StoreGltfMesh(gltfNode.Mesh);

            // Store the GLTF node's transform as a VIM instance
            var vimInstance = new DocumentBuilder.Instance
            {
                Transform = parentMatrix * ConvertToVimMatrix(gltfNode.LocalMatrix),
                MeshIndex = vimMeshIndex,
            };
            Instances.Add(vimInstance);

            // Store the node associated to the geometric instance.
            // This 1:1 relationship connects the entities with the geometric instances.
            ObjectModelBuilder.Add(new Node
            {
                _Element = { Index = familyInstanceElement.Index },
            });
        }

        private static Matrix4x4 ConvertToVimMatrix(System.Numerics.Matrix4x4 a)
            => new Matrix4x4(
                m11: a.M11, m12: a.M12, m13: a.M13, m14: a.M14,
                m21: a.M21, m22: a.M22, m23: a.M23, m24: a.M24,
                m31: a.M31, m32: a.M32, m33: a.M33, m34: a.M34,
                m41: a.M41, m42: a.M42, m43: a.M43, m44: a.M44);

        /// <summary>
        /// Stores the GLTF mesh and its materials.
        /// </summary>
        private int StoreGltfMesh(SharpGLTF.Schema2.Mesh gltfMesh)
        {
            var vertices = new List<Vector3>();
            var indices = new List<int>();
            var faceMaterials = new List<int>();

            foreach (var gltfPrimitive in gltfMesh.Primitives)
            {
                // TODO: store vertex and index attributes...

                // TODO: store material/color info per submesh...
            }

            var meshIndex = Meshes.Count;
            var vimMesh = new DocumentBuilder.Mesh(
                vertices,
                indices,
                faceMaterials
            );
            Meshes.Add(vimMesh);


            return meshIndex;
        }

        private void StoreGltfMaterial(SharpGLTF.Schema2.Material gltfMaterial)
        {
            // TODO
        }

        private void WriteVim(string vimFilePath)
        {
            var vimDocumentBuilder = ToDocumentBuilder(GeneratorString, VersionString);
            vimDocumentBuilder.Write(vimFilePath);
        }

        


        
        ///// <summary>
        ///// Main entry point 
        ///// </summary>
        ///// <param name="gltfFilePath"></param>
        ///// <param name="vimFilePath"></param>
        //public void Convert(string gltfFilePath, string vimFilePath)
        //{
        //    var gltfModel = 

        //    var gltfScene = gltfModel.LogicalScenes.FirstOrDefault();
        //    StoreGltfScene(gltfScene);

        //    WriteVim(vimFilePath);

            

        //    // Each GLTF mesh is interpreted as an instance in VIM
        //    for (var meshIndex = 0; meshIndex < gltfModel.LogicalMeshes.Count; meshIndex++)
        //    {
        //        var mesh = gltfModel.LogicalMeshes[meshIndex];
        //        Console.WriteLine($"\nMesh {meshIndex}:");
        //        Console.WriteLine($"  Mesh Name: {mesh.Name}");

        //        // Iterate through mesh primitives (these correspond to submeshes)
        //        for (var primitiveIndex = 0; primitiveIndex < mesh.Primitives.Count; primitiveIndex++)
        //        {
        //            var primitive = mesh.Primitives[primitiveIndex];
        //            Console.WriteLine($"  Primitive {primitiveIndex}:");

        //            // Read vertex attributes
        //            foreach (var attribute in primitive.VertexAccessors)
        //            {
        //                Console.WriteLine($"    Attribute: {attribute.Key}");
        //                Console.WriteLine($"      Vertex Count: {attribute.Value.Count}");
        //                Console.WriteLine($"      Data Type: {attribute.Value.Dimensions}");
        //            }

        //            // Read indices
        //            if (primitive.IndexAccessor != null)
        //            {
        //                Console.WriteLine($"    Indices Count: {primitive.IndexAccessor.Count}");
        //            }

        //            // Material information
        //            if (primitive.Material != null)
        //            {
        //                Console.WriteLine($"    Material Name: {primitive.Material.Name}");
        //                Console.WriteLine($"    Alpha Mode: {primitive.Material.Alpha}");
        //            }
        //        }
        //    }
        //}
    }
}
