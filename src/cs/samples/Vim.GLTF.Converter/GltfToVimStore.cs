using SharpGLTF.Schema2;
using System;
using System.Linq;
using Vim.Format;
using Vim.Format.ObjectModel;
using Vim.Math3d;

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

        ///// <summary>
        ///// Used to accumulate the 3D mesh information (vertices, indices, materials) - see DocumentBuilder.Mesh
        ///// </summary>
        //private readonly MeshMap _meshes = new MeshMap();

        ///// <summary>
        ///// Used to accumulate the instance information (4x4 transformation matrix, mesh index, instance flags) - see DocumentBuilder.Instance
        ///// </summary>
        //private readonly InstanceMap _instances = new InstanceMap();

        /// <summary>
        /// Contains the 
        /// </summary>
        
        private void WriteVim(string vimFilePath)
        {
            var vimDocumentBuilder = ToDocumentBuilder(GeneratorString, VersionString);
            vimDocumentBuilder.Write(vimFilePath);
        }

        private void StoreElementAndNode(DocumentBuilder.Instance instance)
        {

        }

        private void StoreGltfMaterial(SharpGLTF.Schema2.Material gltfMaterial)
        {
            // TODO
        }

        /// <summary>
        /// Stores the GLTF mesh with the following associations:
        /// - 1:1 VIM Element entity
        /// - 1:* VIM Node entities (one per GLTF primitive composing the mesh)
        /// - 1:* VIM Instance objects (one per GLTF primitive composing the mesh)
        /// - 1:* VIM Mesh objects *?
        /// </summary>
        private void StoreGltfMesh(SharpGLTF.Schema2.Mesh gltfMesh)
        {
            var meshIndex = Meshes.Count;
            var vimMesh = new DocumentBuilder.Mesh(
                // TODO: vertex data, index data
            );
            Meshes.Add(vimMesh);

            var vimInstance = new DocumentBuilder.Instance()
            {
                MeshIndex = meshIndex,
                Transform = Matrix4x4.Identity,
            };
            Instances.Add(vimInstance);

            // Add some stubbed element data.
            // TODO
            var element = new Vim.Format.ObjectModel.Element()
            {

            };

            var node = new Vim.Format.ObjectModel.Node { _Element = element.Index };
            ObjectModelBuilder.Add(node);
        }

        private void StoreGltfNode(SharpGLTF.Schema2.Node gltfNode)
        {
            // Store each node as a VIM Element
            gltfNode.Name

            gltfModel.LogicalMeshes
        }

        private void StoreGltfScene(SharpGLTF.Schema2.Scene gltfScene)
        {
            gltfModel.LogicalNodes
        }
        
        /// <summary>
        /// Main entry point 
        /// </summary>
        /// <param name="gltfFilePath"></param>
        /// <param name="vimFilePath"></param>
        public void Convert(string gltfFilePath, string vimFilePath)
        {
            var gltfModel = ModelRoot.Load(gltfFilePath);

            var gltfScene = gltfModel.LogicalScenes.FirstOrDefault();
            StoreGltfScene(gltfScene);

            WriteVim(vimFilePath);

            

            // Each GLTF mesh is interpreted as an instance in VIM
            for (var meshIndex = 0; meshIndex < gltfModel.LogicalMeshes.Count; meshIndex++)
            {
                var mesh = gltfModel.LogicalMeshes[meshIndex];
                Console.WriteLine($"\nMesh {meshIndex}:");
                Console.WriteLine($"  Mesh Name: {mesh.Name}");

                // Iterate through mesh primitives (these correspond to submeshes)
                for (var primitiveIndex = 0; primitiveIndex < mesh.Primitives.Count; primitiveIndex++)
                {
                    var primitive = mesh.Primitives[primitiveIndex];
                    Console.WriteLine($"  Primitive {primitiveIndex}:");

                    // Read vertex attributes
                    foreach (var attribute in primitive.VertexAccessors)
                    {
                        Console.WriteLine($"    Attribute: {attribute.Key}");
                        Console.WriteLine($"      Vertex Count: {attribute.Value.Count}");
                        Console.WriteLine($"      Data Type: {attribute.Value.Dimensions}");
                    }

                    // Read indices
                    if (primitive.IndexAccessor != null)
                    {
                        Console.WriteLine($"    Indices Count: {primitive.IndexAccessor.Count}");
                    }

                    // Material information
                    if (primitive.Material != null)
                    {
                        Console.WriteLine($"    Material Name: {primitive.Material.Name}");
                        Console.WriteLine($"    Alpha Mode: {primitive.Material.Alpha}");
                    }
                }
            }
        }
    }
}
