// AUTO-GENERATED FILE, DO NOT MODIFY.
// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Linq;
using Vim.Math3d;
using Vim.LinqArray;
using Vim.Format.ObjectModel;
using Vim.Util;

namespace Vim.Format.ObjectModel {
    // AUTO-GENERATED
    public partial class Asset
    {
        public Asset()
        {
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Asset other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (BufferName == other.BufferName);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class DisplayUnit
    {
        public DisplayUnit()
        {
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is DisplayUnit other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Spec == other.Spec) &&
                    (Type == other.Type) &&
                    (Label == other.Label);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ParameterDescriptor
    {
        public Vim.Format.ObjectModel.DisplayUnit DisplayUnit => _DisplayUnit.Value;
        public ParameterDescriptor()
        {
            _DisplayUnit = new Relation<Vim.Format.ObjectModel.DisplayUnit>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ParameterDescriptor other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Name == other.Name) &&
                    (Group == other.Group) &&
                    (ParameterType == other.ParameterType) &&
                    (IsInstance == other.IsInstance) &&
                    (IsShared == other.IsShared) &&
                    (IsReadOnly == other.IsReadOnly) &&
                    (Flags == other.Flags) &&
                    (Guid == other.Guid) &&
                    (StorageType == other.StorageType) &&
                    (_DisplayUnit?.Index == other._DisplayUnit?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Parameter
    {
        public Vim.Format.ObjectModel.ParameterDescriptor ParameterDescriptor => _ParameterDescriptor.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Parameter()
        {
            _ParameterDescriptor = new Relation<Vim.Format.ObjectModel.ParameterDescriptor>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Parameter other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Value == other.Value) &&
                    (_ParameterDescriptor?.Index == other._ParameterDescriptor?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Element
    {
        public Vim.Format.ObjectModel.Level Level => _Level.Value;
        public Vim.Format.ObjectModel.Phase PhaseCreated => _PhaseCreated.Value;
        public Vim.Format.ObjectModel.Phase PhaseDemolished => _PhaseDemolished.Value;
        public Vim.Format.ObjectModel.Category Category => _Category.Value;
        public Vim.Format.ObjectModel.Workset Workset => _Workset.Value;
        public Vim.Format.ObjectModel.DesignOption DesignOption => _DesignOption.Value;
        public Vim.Format.ObjectModel.View OwnerView => _OwnerView.Value;
        public Vim.Format.ObjectModel.Group Group => _Group.Value;
        public Vim.Format.ObjectModel.AssemblyInstance AssemblyInstance => _AssemblyInstance.Value;
        public Vim.Format.ObjectModel.BimDocument BimDocument => _BimDocument.Value;
        public Vim.Format.ObjectModel.Room Room => _Room.Value;
        public Element()
        {
            _Level = new Relation<Vim.Format.ObjectModel.Level>();
            _PhaseCreated = new Relation<Vim.Format.ObjectModel.Phase>();
            _PhaseDemolished = new Relation<Vim.Format.ObjectModel.Phase>();
            _Category = new Relation<Vim.Format.ObjectModel.Category>();
            _Workset = new Relation<Vim.Format.ObjectModel.Workset>();
            _DesignOption = new Relation<Vim.Format.ObjectModel.DesignOption>();
            _OwnerView = new Relation<Vim.Format.ObjectModel.View>();
            _Group = new Relation<Vim.Format.ObjectModel.Group>();
            _AssemblyInstance = new Relation<Vim.Format.ObjectModel.AssemblyInstance>();
            _BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>();
            _Room = new Relation<Vim.Format.ObjectModel.Room>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Element other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Id == other.Id) &&
                    (Type == other.Type) &&
                    (Name == other.Name) &&
                    (UniqueId == other.UniqueId) &&
                    (Location_X == other.Location_X) &&
                    (Location_Y == other.Location_Y) &&
                    (Location_Z == other.Location_Z) &&
                    (FamilyName == other.FamilyName) &&
                    (IsPinned == other.IsPinned) &&
                    (_Level?.Index == other._Level?.Index) &&
                    (_PhaseCreated?.Index == other._PhaseCreated?.Index) &&
                    (_PhaseDemolished?.Index == other._PhaseDemolished?.Index) &&
                    (_Category?.Index == other._Category?.Index) &&
                    (_Workset?.Index == other._Workset?.Index) &&
                    (_DesignOption?.Index == other._DesignOption?.Index) &&
                    (_OwnerView?.Index == other._OwnerView?.Index) &&
                    (_Group?.Index == other._Group?.Index) &&
                    (_AssemblyInstance?.Index == other._AssemblyInstance?.Index) &&
                    (_BimDocument?.Index == other._BimDocument?.Index) &&
                    (_Room?.Index == other._Room?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Workset
    {
        public Vim.Format.ObjectModel.BimDocument BimDocument => _BimDocument.Value;
        public Workset()
        {
            _BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Workset other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Id == other.Id) &&
                    (Name == other.Name) &&
                    (Kind == other.Kind) &&
                    (IsOpen == other.IsOpen) &&
                    (IsEditable == other.IsEditable) &&
                    (Owner == other.Owner) &&
                    (UniqueId == other.UniqueId) &&
                    (_BimDocument?.Index == other._BimDocument?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class AssemblyInstance
    {
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public AssemblyInstance()
        {
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is AssemblyInstance other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (AssemblyTypeName == other.AssemblyTypeName) &&
                    (Position_X == other.Position_X) &&
                    (Position_Y == other.Position_Y) &&
                    (Position_Z == other.Position_Z) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Group
    {
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Group()
        {
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Group other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (GroupType == other.GroupType) &&
                    (Position_X == other.Position_X) &&
                    (Position_Y == other.Position_Y) &&
                    (Position_Z == other.Position_Z) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class DesignOption
    {
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public DesignOption()
        {
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is DesignOption other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (IsPrimary == other.IsPrimary) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Level
    {
        public Vim.Format.ObjectModel.FamilyType FamilyType => _FamilyType.Value;
        public Vim.Format.ObjectModel.Building Building => _Building.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Level()
        {
            _FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>();
            _Building = new Relation<Vim.Format.ObjectModel.Building>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Level other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Elevation == other.Elevation) &&
                    (_FamilyType?.Index == other._FamilyType?.Index) &&
                    (_Building?.Index == other._Building?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Phase
    {
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Phase()
        {
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Phase other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Room
    {
        public Vim.Format.ObjectModel.Level UpperLimit => _UpperLimit.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Room()
        {
            _UpperLimit = new Relation<Vim.Format.ObjectModel.Level>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Room other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (BaseOffset == other.BaseOffset) &&
                    (LimitOffset == other.LimitOffset) &&
                    (UnboundedHeight == other.UnboundedHeight) &&
                    (Volume == other.Volume) &&
                    (Perimeter == other.Perimeter) &&
                    (Area == other.Area) &&
                    (Number == other.Number) &&
                    (_UpperLimit?.Index == other._UpperLimit?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class BimDocument
    {
        public Vim.Format.ObjectModel.View ActiveView => _ActiveView.Value;
        public Vim.Format.ObjectModel.Family OwnerFamily => _OwnerFamily.Value;
        public Vim.Format.ObjectModel.BimDocument Parent => _Parent.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public BimDocument()
        {
            _ActiveView = new Relation<Vim.Format.ObjectModel.View>();
            _OwnerFamily = new Relation<Vim.Format.ObjectModel.Family>();
            _Parent = new Relation<Vim.Format.ObjectModel.BimDocument>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is BimDocument other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Title == other.Title) &&
                    (IsMetric == other.IsMetric) &&
                    (NumSaves == other.NumSaves) &&
                    (IsLinked == other.IsLinked) &&
                    (IsDetached == other.IsDetached) &&
                    (IsWorkshared == other.IsWorkshared) &&
                    (PathName == other.PathName) &&
                    (Latitude == other.Latitude) &&
                    (Longitude == other.Longitude) &&
                    (TimeZone == other.TimeZone) &&
                    (PlaceName == other.PlaceName) &&
                    (WeatherStationName == other.WeatherStationName) &&
                    (Elevation == other.Elevation) &&
                    (ProjectLocation == other.ProjectLocation) &&
                    (IssueDate == other.IssueDate) &&
                    (Status == other.Status) &&
                    (ClientName == other.ClientName) &&
                    (Address == other.Address) &&
                    (Name == other.Name) &&
                    (Number == other.Number) &&
                    (Author == other.Author) &&
                    (BuildingName == other.BuildingName) &&
                    (OrganizationName == other.OrganizationName) &&
                    (OrganizationDescription == other.OrganizationDescription) &&
                    (Product == other.Product) &&
                    (Version == other.Version) &&
                    (User == other.User) &&
                    (_ActiveView?.Index == other._ActiveView?.Index) &&
                    (_OwnerFamily?.Index == other._OwnerFamily?.Index) &&
                    (_Parent?.Index == other._Parent?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class DisplayUnitInBimDocument
    {
        public Vim.Format.ObjectModel.DisplayUnit DisplayUnit => _DisplayUnit.Value;
        public Vim.Format.ObjectModel.BimDocument BimDocument => _BimDocument.Value;
        public DisplayUnitInBimDocument()
        {
            _DisplayUnit = new Relation<Vim.Format.ObjectModel.DisplayUnit>();
            _BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is DisplayUnitInBimDocument other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_DisplayUnit?.Index == other._DisplayUnit?.Index) &&
                    (_BimDocument?.Index == other._BimDocument?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class PhaseOrderInBimDocument
    {
        public Vim.Format.ObjectModel.Phase Phase => _Phase.Value;
        public Vim.Format.ObjectModel.BimDocument BimDocument => _BimDocument.Value;
        public PhaseOrderInBimDocument()
        {
            _Phase = new Relation<Vim.Format.ObjectModel.Phase>();
            _BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is PhaseOrderInBimDocument other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (OrderIndex == other.OrderIndex) &&
                    (_Phase?.Index == other._Phase?.Index) &&
                    (_BimDocument?.Index == other._BimDocument?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Category
    {
        public Vim.Format.ObjectModel.Category Parent => _Parent.Value;
        public Vim.Format.ObjectModel.Material Material => _Material.Value;
        public Category()
        {
            _Parent = new Relation<Vim.Format.ObjectModel.Category>();
            _Material = new Relation<Vim.Format.ObjectModel.Material>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Category other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Name == other.Name) &&
                    (Id == other.Id) &&
                    (CategoryType == other.CategoryType) &&
                    (LineColor_X == other.LineColor_X) &&
                    (LineColor_Y == other.LineColor_Y) &&
                    (LineColor_Z == other.LineColor_Z) &&
                    (BuiltInCategory == other.BuiltInCategory) &&
                    (_Parent?.Index == other._Parent?.Index) &&
                    (_Material?.Index == other._Material?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Family
    {
        public Vim.Format.ObjectModel.Category FamilyCategory => _FamilyCategory.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Family()
        {
            _FamilyCategory = new Relation<Vim.Format.ObjectModel.Category>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Family other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (StructuralMaterialType == other.StructuralMaterialType) &&
                    (StructuralSectionShape == other.StructuralSectionShape) &&
                    (IsSystemFamily == other.IsSystemFamily) &&
                    (IsInPlace == other.IsInPlace) &&
                    (_FamilyCategory?.Index == other._FamilyCategory?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class FamilyType
    {
        public Vim.Format.ObjectModel.Family Family => _Family.Value;
        public Vim.Format.ObjectModel.CompoundStructure CompoundStructure => _CompoundStructure.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public FamilyType()
        {
            _Family = new Relation<Vim.Format.ObjectModel.Family>();
            _CompoundStructure = new Relation<Vim.Format.ObjectModel.CompoundStructure>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is FamilyType other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (IsSystemFamilyType == other.IsSystemFamilyType) &&
                    (_Family?.Index == other._Family?.Index) &&
                    (_CompoundStructure?.Index == other._CompoundStructure?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class FamilyInstance
    {
        public Vim.Format.ObjectModel.FamilyType FamilyType => _FamilyType.Value;
        public Vim.Format.ObjectModel.Element Host => _Host.Value;
        public Vim.Format.ObjectModel.Room FromRoom => _FromRoom.Value;
        public Vim.Format.ObjectModel.Room ToRoom => _ToRoom.Value;
        public Vim.Format.ObjectModel.Element SuperComponent => _SuperComponent.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public FamilyInstance()
        {
            _FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>();
            _Host = new Relation<Vim.Format.ObjectModel.Element>();
            _FromRoom = new Relation<Vim.Format.ObjectModel.Room>();
            _ToRoom = new Relation<Vim.Format.ObjectModel.Room>();
            _SuperComponent = new Relation<Vim.Format.ObjectModel.Element>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is FamilyInstance other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (FacingFlipped == other.FacingFlipped) &&
                    (FacingOrientation_X == other.FacingOrientation_X) &&
                    (FacingOrientation_Y == other.FacingOrientation_Y) &&
                    (FacingOrientation_Z == other.FacingOrientation_Z) &&
                    (HandFlipped == other.HandFlipped) &&
                    (Mirrored == other.Mirrored) &&
                    (HasModifiedGeometry == other.HasModifiedGeometry) &&
                    (Scale == other.Scale) &&
                    (BasisX_X == other.BasisX_X) &&
                    (BasisX_Y == other.BasisX_Y) &&
                    (BasisX_Z == other.BasisX_Z) &&
                    (BasisY_X == other.BasisY_X) &&
                    (BasisY_Y == other.BasisY_Y) &&
                    (BasisY_Z == other.BasisY_Z) &&
                    (BasisZ_X == other.BasisZ_X) &&
                    (BasisZ_Y == other.BasisZ_Y) &&
                    (BasisZ_Z == other.BasisZ_Z) &&
                    (Translation_X == other.Translation_X) &&
                    (Translation_Y == other.Translation_Y) &&
                    (Translation_Z == other.Translation_Z) &&
                    (HandOrientation_X == other.HandOrientation_X) &&
                    (HandOrientation_Y == other.HandOrientation_Y) &&
                    (HandOrientation_Z == other.HandOrientation_Z) &&
                    (_FamilyType?.Index == other._FamilyType?.Index) &&
                    (_Host?.Index == other._Host?.Index) &&
                    (_FromRoom?.Index == other._FromRoom?.Index) &&
                    (_ToRoom?.Index == other._ToRoom?.Index) &&
                    (_SuperComponent?.Index == other._SuperComponent?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class View
    {
        public Vim.Format.ObjectModel.Camera Camera => _Camera.Value;
        public Vim.Format.ObjectModel.FamilyType FamilyType => _FamilyType.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public View()
        {
            _Camera = new Relation<Vim.Format.ObjectModel.Camera>();
            _FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is View other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Title == other.Title) &&
                    (ViewType == other.ViewType) &&
                    (Up_X == other.Up_X) &&
                    (Up_Y == other.Up_Y) &&
                    (Up_Z == other.Up_Z) &&
                    (Right_X == other.Right_X) &&
                    (Right_Y == other.Right_Y) &&
                    (Right_Z == other.Right_Z) &&
                    (Origin_X == other.Origin_X) &&
                    (Origin_Y == other.Origin_Y) &&
                    (Origin_Z == other.Origin_Z) &&
                    (ViewDirection_X == other.ViewDirection_X) &&
                    (ViewDirection_Y == other.ViewDirection_Y) &&
                    (ViewDirection_Z == other.ViewDirection_Z) &&
                    (ViewPosition_X == other.ViewPosition_X) &&
                    (ViewPosition_Y == other.ViewPosition_Y) &&
                    (ViewPosition_Z == other.ViewPosition_Z) &&
                    (Scale == other.Scale) &&
                    (Outline_Min_X == other.Outline_Min_X) &&
                    (Outline_Min_Y == other.Outline_Min_Y) &&
                    (Outline_Max_X == other.Outline_Max_X) &&
                    (Outline_Max_Y == other.Outline_Max_Y) &&
                    (DetailLevel == other.DetailLevel) &&
                    (_Camera?.Index == other._Camera?.Index) &&
                    (_FamilyType?.Index == other._FamilyType?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ElementInView
    {
        public Vim.Format.ObjectModel.View View => _View.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public ElementInView()
        {
            _View = new Relation<Vim.Format.ObjectModel.View>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ElementInView other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_View?.Index == other._View?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ShapeInView
    {
        public Vim.Format.ObjectModel.Shape Shape => _Shape.Value;
        public Vim.Format.ObjectModel.View View => _View.Value;
        public ShapeInView()
        {
            _Shape = new Relation<Vim.Format.ObjectModel.Shape>();
            _View = new Relation<Vim.Format.ObjectModel.View>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ShapeInView other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_Shape?.Index == other._Shape?.Index) &&
                    (_View?.Index == other._View?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class AssetInView
    {
        public Vim.Format.ObjectModel.Asset Asset => _Asset.Value;
        public Vim.Format.ObjectModel.View View => _View.Value;
        public AssetInView()
        {
            _Asset = new Relation<Vim.Format.ObjectModel.Asset>();
            _View = new Relation<Vim.Format.ObjectModel.View>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is AssetInView other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_Asset?.Index == other._Asset?.Index) &&
                    (_View?.Index == other._View?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class AssetInViewSheet
    {
        public Vim.Format.ObjectModel.Asset Asset => _Asset.Value;
        public Vim.Format.ObjectModel.ViewSheet ViewSheet => _ViewSheet.Value;
        public AssetInViewSheet()
        {
            _Asset = new Relation<Vim.Format.ObjectModel.Asset>();
            _ViewSheet = new Relation<Vim.Format.ObjectModel.ViewSheet>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is AssetInViewSheet other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_Asset?.Index == other._Asset?.Index) &&
                    (_ViewSheet?.Index == other._ViewSheet?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class LevelInView
    {
        public Vim.Format.ObjectModel.Level Level => _Level.Value;
        public Vim.Format.ObjectModel.View View => _View.Value;
        public LevelInView()
        {
            _Level = new Relation<Vim.Format.ObjectModel.Level>();
            _View = new Relation<Vim.Format.ObjectModel.View>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is LevelInView other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Extents_Min_X == other.Extents_Min_X) &&
                    (Extents_Min_Y == other.Extents_Min_Y) &&
                    (Extents_Min_Z == other.Extents_Min_Z) &&
                    (Extents_Max_X == other.Extents_Max_X) &&
                    (Extents_Max_Y == other.Extents_Max_Y) &&
                    (Extents_Max_Z == other.Extents_Max_Z) &&
                    (_Level?.Index == other._Level?.Index) &&
                    (_View?.Index == other._View?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Camera
    {
        public Camera()
        {
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Camera other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Id == other.Id) &&
                    (IsPerspective == other.IsPerspective) &&
                    (VerticalExtent == other.VerticalExtent) &&
                    (HorizontalExtent == other.HorizontalExtent) &&
                    (FarDistance == other.FarDistance) &&
                    (NearDistance == other.NearDistance) &&
                    (TargetDistance == other.TargetDistance) &&
                    (RightOffset == other.RightOffset) &&
                    (UpOffset == other.UpOffset);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Material
    {
        public Vim.Format.ObjectModel.Asset ColorTextureFile => _ColorTextureFile.Value;
        public Vim.Format.ObjectModel.Asset NormalTextureFile => _NormalTextureFile.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Material()
        {
            _ColorTextureFile = new Relation<Vim.Format.ObjectModel.Asset>();
            _NormalTextureFile = new Relation<Vim.Format.ObjectModel.Asset>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Material other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Name == other.Name) &&
                    (MaterialCategory == other.MaterialCategory) &&
                    (Color_X == other.Color_X) &&
                    (Color_Y == other.Color_Y) &&
                    (Color_Z == other.Color_Z) &&
                    (ColorUvScaling_X == other.ColorUvScaling_X) &&
                    (ColorUvScaling_Y == other.ColorUvScaling_Y) &&
                    (ColorUvOffset_X == other.ColorUvOffset_X) &&
                    (ColorUvOffset_Y == other.ColorUvOffset_Y) &&
                    (NormalUvScaling_X == other.NormalUvScaling_X) &&
                    (NormalUvScaling_Y == other.NormalUvScaling_Y) &&
                    (NormalUvOffset_X == other.NormalUvOffset_X) &&
                    (NormalUvOffset_Y == other.NormalUvOffset_Y) &&
                    (NormalAmount == other.NormalAmount) &&
                    (Glossiness == other.Glossiness) &&
                    (Smoothness == other.Smoothness) &&
                    (Transparency == other.Transparency) &&
                    (_ColorTextureFile?.Index == other._ColorTextureFile?.Index) &&
                    (_NormalTextureFile?.Index == other._NormalTextureFile?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class MaterialInElement
    {
        public Vim.Format.ObjectModel.Material Material => _Material.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public MaterialInElement()
        {
            _Material = new Relation<Vim.Format.ObjectModel.Material>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is MaterialInElement other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Area == other.Area) &&
                    (Volume == other.Volume) &&
                    (IsPaint == other.IsPaint) &&
                    (_Material?.Index == other._Material?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class CompoundStructureLayer
    {
        public Vim.Format.ObjectModel.Material Material => _Material.Value;
        public Vim.Format.ObjectModel.CompoundStructure CompoundStructure => _CompoundStructure.Value;
        public CompoundStructureLayer()
        {
            _Material = new Relation<Vim.Format.ObjectModel.Material>();
            _CompoundStructure = new Relation<Vim.Format.ObjectModel.CompoundStructure>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is CompoundStructureLayer other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (OrderIndex == other.OrderIndex) &&
                    (Width == other.Width) &&
                    (MaterialFunctionAssignment == other.MaterialFunctionAssignment) &&
                    (_Material?.Index == other._Material?.Index) &&
                    (_CompoundStructure?.Index == other._CompoundStructure?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class CompoundStructure
    {
        public Vim.Format.ObjectModel.CompoundStructureLayer StructuralLayer => _StructuralLayer.Value;
        public CompoundStructure()
        {
            _StructuralLayer = new Relation<Vim.Format.ObjectModel.CompoundStructureLayer>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is CompoundStructure other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Width == other.Width) &&
                    (_StructuralLayer?.Index == other._StructuralLayer?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Node
    {
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Node()
        {
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Node other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Geometry
    {
        public Geometry()
        {
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Geometry other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Box_Min_X == other.Box_Min_X) &&
                    (Box_Min_Y == other.Box_Min_Y) &&
                    (Box_Min_Z == other.Box_Min_Z) &&
                    (Box_Max_X == other.Box_Max_X) &&
                    (Box_Max_Y == other.Box_Max_Y) &&
                    (Box_Max_Z == other.Box_Max_Z) &&
                    (VertexCount == other.VertexCount) &&
                    (FaceCount == other.FaceCount);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Shape
    {
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Shape()
        {
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Shape other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ShapeCollection
    {
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public ShapeCollection()
        {
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ShapeCollection other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ShapeInShapeCollection
    {
        public Vim.Format.ObjectModel.Shape Shape => _Shape.Value;
        public Vim.Format.ObjectModel.ShapeCollection ShapeCollection => _ShapeCollection.Value;
        public ShapeInShapeCollection()
        {
            _Shape = new Relation<Vim.Format.ObjectModel.Shape>();
            _ShapeCollection = new Relation<Vim.Format.ObjectModel.ShapeCollection>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ShapeInShapeCollection other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_Shape?.Index == other._Shape?.Index) &&
                    (_ShapeCollection?.Index == other._ShapeCollection?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class System
    {
        public Vim.Format.ObjectModel.FamilyType FamilyType => _FamilyType.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public System()
        {
            _FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is System other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (SystemType == other.SystemType) &&
                    (_FamilyType?.Index == other._FamilyType?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ElementInSystem
    {
        public Vim.Format.ObjectModel.System System => _System.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public ElementInSystem()
        {
            _System = new Relation<Vim.Format.ObjectModel.System>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ElementInSystem other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Roles == other.Roles) &&
                    (_System?.Index == other._System?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Warning
    {
        public Vim.Format.ObjectModel.BimDocument BimDocument => _BimDocument.Value;
        public Warning()
        {
            _BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Warning other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Guid == other.Guid) &&
                    (Severity == other.Severity) &&
                    (Description == other.Description) &&
                    (_BimDocument?.Index == other._BimDocument?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ElementInWarning
    {
        public Vim.Format.ObjectModel.Warning Warning => _Warning.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public ElementInWarning()
        {
            _Warning = new Relation<Vim.Format.ObjectModel.Warning>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ElementInWarning other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_Warning?.Index == other._Warning?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class BasePoint
    {
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public BasePoint()
        {
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is BasePoint other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (IsSurveyPoint == other.IsSurveyPoint) &&
                    (Position_X == other.Position_X) &&
                    (Position_Y == other.Position_Y) &&
                    (Position_Z == other.Position_Z) &&
                    (SharedPosition_X == other.SharedPosition_X) &&
                    (SharedPosition_Y == other.SharedPosition_Y) &&
                    (SharedPosition_Z == other.SharedPosition_Z) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class PhaseFilter
    {
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public PhaseFilter()
        {
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is PhaseFilter other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (New == other.New) &&
                    (Existing == other.Existing) &&
                    (Demolished == other.Demolished) &&
                    (Temporary == other.Temporary) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Grid
    {
        public Vim.Format.ObjectModel.FamilyType FamilyType => _FamilyType.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Grid()
        {
            _FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Grid other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (StartPoint_X == other.StartPoint_X) &&
                    (StartPoint_Y == other.StartPoint_Y) &&
                    (StartPoint_Z == other.StartPoint_Z) &&
                    (EndPoint_X == other.EndPoint_X) &&
                    (EndPoint_Y == other.EndPoint_Y) &&
                    (EndPoint_Z == other.EndPoint_Z) &&
                    (IsCurved == other.IsCurved) &&
                    (Extents_Min_X == other.Extents_Min_X) &&
                    (Extents_Min_Y == other.Extents_Min_Y) &&
                    (Extents_Min_Z == other.Extents_Min_Z) &&
                    (Extents_Max_X == other.Extents_Max_X) &&
                    (Extents_Max_Y == other.Extents_Max_Y) &&
                    (Extents_Max_Z == other.Extents_Max_Z) &&
                    (_FamilyType?.Index == other._FamilyType?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Area
    {
        public Vim.Format.ObjectModel.AreaScheme AreaScheme => _AreaScheme.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Area()
        {
            _AreaScheme = new Relation<Vim.Format.ObjectModel.AreaScheme>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Area other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Value == other.Value) &&
                    (Perimeter == other.Perimeter) &&
                    (Number == other.Number) &&
                    (IsGrossInterior == other.IsGrossInterior) &&
                    (_AreaScheme?.Index == other._AreaScheme?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class AreaScheme
    {
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public AreaScheme()
        {
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is AreaScheme other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (IsGrossBuildingArea == other.IsGrossBuildingArea) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Schedule
    {
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Schedule()
        {
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Schedule other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ScheduleColumn
    {
        public Vim.Format.ObjectModel.Schedule Schedule => _Schedule.Value;
        public ScheduleColumn()
        {
            _Schedule = new Relation<Vim.Format.ObjectModel.Schedule>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ScheduleColumn other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Name == other.Name) &&
                    (ColumnIndex == other.ColumnIndex) &&
                    (_Schedule?.Index == other._Schedule?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ScheduleCell
    {
        public Vim.Format.ObjectModel.ScheduleColumn ScheduleColumn => _ScheduleColumn.Value;
        public ScheduleCell()
        {
            _ScheduleColumn = new Relation<Vim.Format.ObjectModel.ScheduleColumn>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ScheduleCell other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Value == other.Value) &&
                    (RowIndex == other.RowIndex) &&
                    (_ScheduleColumn?.Index == other._ScheduleColumn?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ViewSheetSet
    {
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public ViewSheetSet()
        {
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ViewSheetSet other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ViewSheet
    {
        public Vim.Format.ObjectModel.FamilyType FamilyType => _FamilyType.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public ViewSheet()
        {
            _FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ViewSheet other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_FamilyType?.Index == other._FamilyType?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ViewSheetInViewSheetSet
    {
        public Vim.Format.ObjectModel.ViewSheet ViewSheet => _ViewSheet.Value;
        public Vim.Format.ObjectModel.ViewSheetSet ViewSheetSet => _ViewSheetSet.Value;
        public ViewSheetInViewSheetSet()
        {
            _ViewSheet = new Relation<Vim.Format.ObjectModel.ViewSheet>();
            _ViewSheetSet = new Relation<Vim.Format.ObjectModel.ViewSheetSet>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ViewSheetInViewSheetSet other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_ViewSheet?.Index == other._ViewSheet?.Index) &&
                    (_ViewSheetSet?.Index == other._ViewSheetSet?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ViewInViewSheetSet
    {
        public Vim.Format.ObjectModel.View View => _View.Value;
        public Vim.Format.ObjectModel.ViewSheetSet ViewSheetSet => _ViewSheetSet.Value;
        public ViewInViewSheetSet()
        {
            _View = new Relation<Vim.Format.ObjectModel.View>();
            _ViewSheetSet = new Relation<Vim.Format.ObjectModel.ViewSheetSet>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ViewInViewSheetSet other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_View?.Index == other._View?.Index) &&
                    (_ViewSheetSet?.Index == other._ViewSheetSet?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class ViewInViewSheet
    {
        public Vim.Format.ObjectModel.View View => _View.Value;
        public Vim.Format.ObjectModel.ViewSheet ViewSheet => _ViewSheet.Value;
        public ViewInViewSheet()
        {
            _View = new Relation<Vim.Format.ObjectModel.View>();
            _ViewSheet = new Relation<Vim.Format.ObjectModel.ViewSheet>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is ViewInViewSheet other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (_View?.Index == other._View?.Index) &&
                    (_ViewSheet?.Index == other._ViewSheet?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Site
    {
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Site()
        {
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Site other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Latitude == other.Latitude) &&
                    (Longitude == other.Longitude) &&
                    (Address == other.Address) &&
                    (Elevation == other.Elevation) &&
                    (Number == other.Number) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    // AUTO-GENERATED
    public partial class Building
    {
        public Vim.Format.ObjectModel.Site Site => _Site.Value;
        public Vim.Format.ObjectModel.Element Element => _Element.Value;
        public Building()
        {
            _Site = new Relation<Vim.Format.ObjectModel.Site>();
            _Element = new Relation<Vim.Format.ObjectModel.Element>();
        }
        
        public override bool FieldsAreEqual(object obj)
        {
            if ((obj is Building other))
            {
                var fieldsAreEqual =
                    (Index == other.Index) &&
                    (Elevation == other.Elevation) &&
                    (TerrainElevation == other.TerrainElevation) &&
                    (Address == other.Address) &&
                    (_Site?.Index == other._Site?.Index) &&
                    (_Element?.Index == other._Element?.Index);
                if (!fieldsAreEqual)
                {
                    return false;
                }
                
                return true;
            }
            return false;
        }
        
    } // end of class
    
    public partial class DocumentModel
    {
        public ElementIndexMaps ElementIndexMaps { get; }
        
        // Asset
        
        public EntityTable AssetEntityTable { get; }
        
        public IArray<String> AssetBufferName { get; }
        public String GetAssetBufferName(int index, String defaultValue = "") => AssetBufferName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public int NumAsset => AssetEntityTable?.NumRows ?? 0;
        public IArray<Asset> AssetList { get; }
        public Asset GetAsset(int n)
        {
            if (n < 0) return null;
            var r = new Asset();
            r.Document = Document;
            r.Index = n;
            r.BufferName = AssetBufferName.ElementAtOrDefault(n);
            return r;
        }
        
        
        // DisplayUnit
        
        public EntityTable DisplayUnitEntityTable { get; }
        
        public IArray<String> DisplayUnitSpec { get; }
        public String GetDisplayUnitSpec(int index, String defaultValue = "") => DisplayUnitSpec?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> DisplayUnitType { get; }
        public String GetDisplayUnitType(int index, String defaultValue = "") => DisplayUnitType?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> DisplayUnitLabel { get; }
        public String GetDisplayUnitLabel(int index, String defaultValue = "") => DisplayUnitLabel?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public int NumDisplayUnit => DisplayUnitEntityTable?.NumRows ?? 0;
        public IArray<DisplayUnit> DisplayUnitList { get; }
        public DisplayUnit GetDisplayUnit(int n)
        {
            if (n < 0) return null;
            var r = new DisplayUnit();
            r.Document = Document;
            r.Index = n;
            r.Spec = DisplayUnitSpec.ElementAtOrDefault(n);
            r.Type = DisplayUnitType.ElementAtOrDefault(n);
            r.Label = DisplayUnitLabel.ElementAtOrDefault(n);
            return r;
        }
        
        
        // ParameterDescriptor
        
        public EntityTable ParameterDescriptorEntityTable { get; }
        
        public IArray<String> ParameterDescriptorName { get; }
        public String GetParameterDescriptorName(int index, String defaultValue = "") => ParameterDescriptorName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> ParameterDescriptorGroup { get; }
        public String GetParameterDescriptorGroup(int index, String defaultValue = "") => ParameterDescriptorGroup?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> ParameterDescriptorParameterType { get; }
        public String GetParameterDescriptorParameterType(int index, String defaultValue = "") => ParameterDescriptorParameterType?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> ParameterDescriptorIsInstance { get; }
        public Boolean GetParameterDescriptorIsInstance(int index, Boolean defaultValue = default) => ParameterDescriptorIsInstance?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> ParameterDescriptorIsShared { get; }
        public Boolean GetParameterDescriptorIsShared(int index, Boolean defaultValue = default) => ParameterDescriptorIsShared?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> ParameterDescriptorIsReadOnly { get; }
        public Boolean GetParameterDescriptorIsReadOnly(int index, Boolean defaultValue = default) => ParameterDescriptorIsReadOnly?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Int32> ParameterDescriptorFlags { get; }
        public Int32 GetParameterDescriptorFlags(int index, Int32 defaultValue = default) => ParameterDescriptorFlags?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> ParameterDescriptorGuid { get; }
        public String GetParameterDescriptorGuid(int index, String defaultValue = "") => ParameterDescriptorGuid?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Int32> ParameterDescriptorStorageType { get; }
        public Int32 GetParameterDescriptorStorageType(int index, Int32 defaultValue = default) => ParameterDescriptorStorageType?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> ParameterDescriptorDisplayUnitIndex { get; }
        public int GetParameterDescriptorDisplayUnitIndex(int index) => ParameterDescriptorDisplayUnitIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumParameterDescriptor => ParameterDescriptorEntityTable?.NumRows ?? 0;
        public IArray<ParameterDescriptor> ParameterDescriptorList { get; }
        public ParameterDescriptor GetParameterDescriptor(int n)
        {
            if (n < 0) return null;
            var r = new ParameterDescriptor();
            r.Document = Document;
            r.Index = n;
            r.Name = ParameterDescriptorName.ElementAtOrDefault(n);
            r.Group = ParameterDescriptorGroup.ElementAtOrDefault(n);
            r.ParameterType = ParameterDescriptorParameterType.ElementAtOrDefault(n);
            r.IsInstance = ParameterDescriptorIsInstance.ElementAtOrDefault(n);
            r.IsShared = ParameterDescriptorIsShared.ElementAtOrDefault(n);
            r.IsReadOnly = ParameterDescriptorIsReadOnly.ElementAtOrDefault(n);
            r.Flags = ParameterDescriptorFlags.ElementAtOrDefault(n);
            r.Guid = ParameterDescriptorGuid.ElementAtOrDefault(n);
            r.StorageType = ParameterDescriptorStorageType.ElementAtOrDefault(n);
            r._DisplayUnit = new Relation<Vim.Format.ObjectModel.DisplayUnit>(GetParameterDescriptorDisplayUnitIndex(n), GetDisplayUnit);
            return r;
        }
        
        
        // Parameter
        
        public EntityTable ParameterEntityTable { get; }
        
        public IArray<String> ParameterValue { get; }
        public String GetParameterValue(int index, String defaultValue = "") => ParameterValue?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> ParameterParameterDescriptorIndex { get; }
        public int GetParameterParameterDescriptorIndex(int index) => ParameterParameterDescriptorIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ParameterElementIndex { get; }
        public int GetParameterElementIndex(int index) => ParameterElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumParameter => ParameterEntityTable?.NumRows ?? 0;
        public IArray<Parameter> ParameterList { get; }
        public Parameter GetParameter(int n)
        {
            if (n < 0) return null;
            var r = new Parameter();
            r.Document = Document;
            r.Index = n;
            r.Value = ParameterValue.ElementAtOrDefault(n);
            r._ParameterDescriptor = new Relation<Vim.Format.ObjectModel.ParameterDescriptor>(GetParameterParameterDescriptorIndex(n), GetParameterDescriptor);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetParameterElementIndex(n), GetElement);
            return r;
        }
        
        
        // Element
        
        public EntityTable ElementEntityTable { get; }
        
        public IArray<Int64> ElementId { get; }
        public Int64 GetElementId(int index, Int64 defaultValue = default) => ElementId?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> ElementType { get; }
        public String GetElementType(int index, String defaultValue = "") => ElementType?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> ElementName { get; }
        public String GetElementName(int index, String defaultValue = "") => ElementName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> ElementUniqueId { get; }
        public String GetElementUniqueId(int index, String defaultValue = "") => ElementUniqueId?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> ElementLocation_X { get; }
        public Single GetElementLocation_X(int index, Single defaultValue = default) => ElementLocation_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> ElementLocation_Y { get; }
        public Single GetElementLocation_Y(int index, Single defaultValue = default) => ElementLocation_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> ElementLocation_Z { get; }
        public Single GetElementLocation_Z(int index, Single defaultValue = default) => ElementLocation_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> ElementFamilyName { get; }
        public String GetElementFamilyName(int index, String defaultValue = "") => ElementFamilyName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> ElementIsPinned { get; }
        public Boolean GetElementIsPinned(int index, Boolean defaultValue = default) => ElementIsPinned?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> ElementLevelIndex { get; }
        public int GetElementLevelIndex(int index) => ElementLevelIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ElementPhaseCreatedIndex { get; }
        public int GetElementPhaseCreatedIndex(int index) => ElementPhaseCreatedIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ElementPhaseDemolishedIndex { get; }
        public int GetElementPhaseDemolishedIndex(int index) => ElementPhaseDemolishedIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ElementCategoryIndex { get; }
        public int GetElementCategoryIndex(int index) => ElementCategoryIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ElementWorksetIndex { get; }
        public int GetElementWorksetIndex(int index) => ElementWorksetIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ElementDesignOptionIndex { get; }
        public int GetElementDesignOptionIndex(int index) => ElementDesignOptionIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ElementOwnerViewIndex { get; }
        public int GetElementOwnerViewIndex(int index) => ElementOwnerViewIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ElementGroupIndex { get; }
        public int GetElementGroupIndex(int index) => ElementGroupIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ElementAssemblyInstanceIndex { get; }
        public int GetElementAssemblyInstanceIndex(int index) => ElementAssemblyInstanceIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ElementBimDocumentIndex { get; }
        public int GetElementBimDocumentIndex(int index) => ElementBimDocumentIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ElementRoomIndex { get; }
        public int GetElementRoomIndex(int index) => ElementRoomIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumElement => ElementEntityTable?.NumRows ?? 0;
        public IArray<Element> ElementList { get; }
        public Element GetElement(int n)
        {
            if (n < 0) return null;
            var r = new Element();
            r.Document = Document;
            r.Index = n;
            r.Id = ElementId.ElementAtOrDefault(n);
            r.Type = ElementType.ElementAtOrDefault(n);
            r.Name = ElementName.ElementAtOrDefault(n);
            r.UniqueId = ElementUniqueId.ElementAtOrDefault(n);
            r.Location_X = ElementLocation_X.ElementAtOrDefault(n);
            r.Location_Y = ElementLocation_Y.ElementAtOrDefault(n);
            r.Location_Z = ElementLocation_Z.ElementAtOrDefault(n);
            r.FamilyName = ElementFamilyName.ElementAtOrDefault(n);
            r.IsPinned = ElementIsPinned.ElementAtOrDefault(n);
            r._Level = new Relation<Vim.Format.ObjectModel.Level>(GetElementLevelIndex(n), GetLevel);
            r._PhaseCreated = new Relation<Vim.Format.ObjectModel.Phase>(GetElementPhaseCreatedIndex(n), GetPhase);
            r._PhaseDemolished = new Relation<Vim.Format.ObjectModel.Phase>(GetElementPhaseDemolishedIndex(n), GetPhase);
            r._Category = new Relation<Vim.Format.ObjectModel.Category>(GetElementCategoryIndex(n), GetCategory);
            r._Workset = new Relation<Vim.Format.ObjectModel.Workset>(GetElementWorksetIndex(n), GetWorkset);
            r._DesignOption = new Relation<Vim.Format.ObjectModel.DesignOption>(GetElementDesignOptionIndex(n), GetDesignOption);
            r._OwnerView = new Relation<Vim.Format.ObjectModel.View>(GetElementOwnerViewIndex(n), GetView);
            r._Group = new Relation<Vim.Format.ObjectModel.Group>(GetElementGroupIndex(n), GetGroup);
            r._AssemblyInstance = new Relation<Vim.Format.ObjectModel.AssemblyInstance>(GetElementAssemblyInstanceIndex(n), GetAssemblyInstance);
            r._BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>(GetElementBimDocumentIndex(n), GetBimDocument);
            r._Room = new Relation<Vim.Format.ObjectModel.Room>(GetElementRoomIndex(n), GetRoom);
            return r;
        }
        
        
        // Workset
        
        public EntityTable WorksetEntityTable { get; }
        
        public IArray<Int32> WorksetId { get; }
        public Int32 GetWorksetId(int index, Int32 defaultValue = default) => WorksetId?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> WorksetName { get; }
        public String GetWorksetName(int index, String defaultValue = "") => WorksetName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> WorksetKind { get; }
        public String GetWorksetKind(int index, String defaultValue = "") => WorksetKind?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> WorksetIsOpen { get; }
        public Boolean GetWorksetIsOpen(int index, Boolean defaultValue = default) => WorksetIsOpen?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> WorksetIsEditable { get; }
        public Boolean GetWorksetIsEditable(int index, Boolean defaultValue = default) => WorksetIsEditable?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> WorksetOwner { get; }
        public String GetWorksetOwner(int index, String defaultValue = "") => WorksetOwner?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> WorksetUniqueId { get; }
        public String GetWorksetUniqueId(int index, String defaultValue = "") => WorksetUniqueId?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> WorksetBimDocumentIndex { get; }
        public int GetWorksetBimDocumentIndex(int index) => WorksetBimDocumentIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumWorkset => WorksetEntityTable?.NumRows ?? 0;
        public IArray<Workset> WorksetList { get; }
        public Workset GetWorkset(int n)
        {
            if (n < 0) return null;
            var r = new Workset();
            r.Document = Document;
            r.Index = n;
            r.Id = WorksetId.ElementAtOrDefault(n);
            r.Name = WorksetName.ElementAtOrDefault(n);
            r.Kind = WorksetKind.ElementAtOrDefault(n);
            r.IsOpen = WorksetIsOpen.ElementAtOrDefault(n);
            r.IsEditable = WorksetIsEditable.ElementAtOrDefault(n);
            r.Owner = WorksetOwner.ElementAtOrDefault(n);
            r.UniqueId = WorksetUniqueId.ElementAtOrDefault(n);
            r._BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>(GetWorksetBimDocumentIndex(n), GetBimDocument);
            return r;
        }
        
        
        // AssemblyInstance
        
        public EntityTable AssemblyInstanceEntityTable { get; }
        
        public IArray<String> AssemblyInstanceAssemblyTypeName { get; }
        public String GetAssemblyInstanceAssemblyTypeName(int index, String defaultValue = "") => AssemblyInstanceAssemblyTypeName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> AssemblyInstancePosition_X { get; }
        public Single GetAssemblyInstancePosition_X(int index, Single defaultValue = default) => AssemblyInstancePosition_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> AssemblyInstancePosition_Y { get; }
        public Single GetAssemblyInstancePosition_Y(int index, Single defaultValue = default) => AssemblyInstancePosition_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> AssemblyInstancePosition_Z { get; }
        public Single GetAssemblyInstancePosition_Z(int index, Single defaultValue = default) => AssemblyInstancePosition_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> AssemblyInstanceElementIndex { get; }
        public int GetAssemblyInstanceElementIndex(int index) => AssemblyInstanceElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumAssemblyInstance => AssemblyInstanceEntityTable?.NumRows ?? 0;
        public IArray<AssemblyInstance> AssemblyInstanceList { get; }
        public AssemblyInstance GetAssemblyInstance(int n)
        {
            if (n < 0) return null;
            var r = new AssemblyInstance();
            r.Document = Document;
            r.Index = n;
            r.AssemblyTypeName = AssemblyInstanceAssemblyTypeName.ElementAtOrDefault(n);
            r.Position_X = AssemblyInstancePosition_X.ElementAtOrDefault(n);
            r.Position_Y = AssemblyInstancePosition_Y.ElementAtOrDefault(n);
            r.Position_Z = AssemblyInstancePosition_Z.ElementAtOrDefault(n);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetAssemblyInstanceElementIndex(n), GetElement);
            return r;
        }
        
        
        // Group
        
        public EntityTable GroupEntityTable { get; }
        
        public IArray<String> GroupGroupType { get; }
        public String GetGroupGroupType(int index, String defaultValue = "") => GroupGroupType?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> GroupPosition_X { get; }
        public Single GetGroupPosition_X(int index, Single defaultValue = default) => GroupPosition_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> GroupPosition_Y { get; }
        public Single GetGroupPosition_Y(int index, Single defaultValue = default) => GroupPosition_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> GroupPosition_Z { get; }
        public Single GetGroupPosition_Z(int index, Single defaultValue = default) => GroupPosition_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> GroupElementIndex { get; }
        public int GetGroupElementIndex(int index) => GroupElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumGroup => GroupEntityTable?.NumRows ?? 0;
        public IArray<Group> GroupList { get; }
        public Group GetGroup(int n)
        {
            if (n < 0) return null;
            var r = new Group();
            r.Document = Document;
            r.Index = n;
            r.GroupType = GroupGroupType.ElementAtOrDefault(n);
            r.Position_X = GroupPosition_X.ElementAtOrDefault(n);
            r.Position_Y = GroupPosition_Y.ElementAtOrDefault(n);
            r.Position_Z = GroupPosition_Z.ElementAtOrDefault(n);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetGroupElementIndex(n), GetElement);
            return r;
        }
        
        
        // DesignOption
        
        public EntityTable DesignOptionEntityTable { get; }
        
        public IArray<Boolean> DesignOptionIsPrimary { get; }
        public Boolean GetDesignOptionIsPrimary(int index, Boolean defaultValue = default) => DesignOptionIsPrimary?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> DesignOptionElementIndex { get; }
        public int GetDesignOptionElementIndex(int index) => DesignOptionElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumDesignOption => DesignOptionEntityTable?.NumRows ?? 0;
        public IArray<DesignOption> DesignOptionList { get; }
        public DesignOption GetDesignOption(int n)
        {
            if (n < 0) return null;
            var r = new DesignOption();
            r.Document = Document;
            r.Index = n;
            r.IsPrimary = DesignOptionIsPrimary.ElementAtOrDefault(n);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetDesignOptionElementIndex(n), GetElement);
            return r;
        }
        
        
        // Level
        
        public EntityTable LevelEntityTable { get; }
        
        public IArray<Double> LevelElevation { get; }
        public Double GetLevelElevation(int index, Double defaultValue = default) => LevelElevation?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> LevelFamilyTypeIndex { get; }
        public int GetLevelFamilyTypeIndex(int index) => LevelFamilyTypeIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> LevelBuildingIndex { get; }
        public int GetLevelBuildingIndex(int index) => LevelBuildingIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> LevelElementIndex { get; }
        public int GetLevelElementIndex(int index) => LevelElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumLevel => LevelEntityTable?.NumRows ?? 0;
        public IArray<Level> LevelList { get; }
        public Level GetLevel(int n)
        {
            if (n < 0) return null;
            var r = new Level();
            r.Document = Document;
            r.Index = n;
            r.Elevation = LevelElevation.ElementAtOrDefault(n);
            r._FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>(GetLevelFamilyTypeIndex(n), GetFamilyType);
            r._Building = new Relation<Vim.Format.ObjectModel.Building>(GetLevelBuildingIndex(n), GetBuilding);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetLevelElementIndex(n), GetElement);
            return r;
        }
        
        
        // Phase
        
        public EntityTable PhaseEntityTable { get; }
        
        public IArray<int> PhaseElementIndex { get; }
        public int GetPhaseElementIndex(int index) => PhaseElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumPhase => PhaseEntityTable?.NumRows ?? 0;
        public IArray<Phase> PhaseList { get; }
        public Phase GetPhase(int n)
        {
            if (n < 0) return null;
            var r = new Phase();
            r.Document = Document;
            r.Index = n;
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetPhaseElementIndex(n), GetElement);
            return r;
        }
        
        
        // Room
        
        public EntityTable RoomEntityTable { get; }
        
        public IArray<Double> RoomBaseOffset { get; }
        public Double GetRoomBaseOffset(int index, Double defaultValue = default) => RoomBaseOffset?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> RoomLimitOffset { get; }
        public Double GetRoomLimitOffset(int index, Double defaultValue = default) => RoomLimitOffset?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> RoomUnboundedHeight { get; }
        public Double GetRoomUnboundedHeight(int index, Double defaultValue = default) => RoomUnboundedHeight?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> RoomVolume { get; }
        public Double GetRoomVolume(int index, Double defaultValue = default) => RoomVolume?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> RoomPerimeter { get; }
        public Double GetRoomPerimeter(int index, Double defaultValue = default) => RoomPerimeter?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> RoomArea { get; }
        public Double GetRoomArea(int index, Double defaultValue = default) => RoomArea?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> RoomNumber { get; }
        public String GetRoomNumber(int index, String defaultValue = "") => RoomNumber?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> RoomUpperLimitIndex { get; }
        public int GetRoomUpperLimitIndex(int index) => RoomUpperLimitIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> RoomElementIndex { get; }
        public int GetRoomElementIndex(int index) => RoomElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumRoom => RoomEntityTable?.NumRows ?? 0;
        public IArray<Room> RoomList { get; }
        public Room GetRoom(int n)
        {
            if (n < 0) return null;
            var r = new Room();
            r.Document = Document;
            r.Index = n;
            r.BaseOffset = RoomBaseOffset.ElementAtOrDefault(n);
            r.LimitOffset = RoomLimitOffset.ElementAtOrDefault(n);
            r.UnboundedHeight = RoomUnboundedHeight.ElementAtOrDefault(n);
            r.Volume = RoomVolume.ElementAtOrDefault(n);
            r.Perimeter = RoomPerimeter.ElementAtOrDefault(n);
            r.Area = RoomArea.ElementAtOrDefault(n);
            r.Number = RoomNumber.ElementAtOrDefault(n);
            r._UpperLimit = new Relation<Vim.Format.ObjectModel.Level>(GetRoomUpperLimitIndex(n), GetLevel);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetRoomElementIndex(n), GetElement);
            return r;
        }
        
        
        // BimDocument
        
        public EntityTable BimDocumentEntityTable { get; }
        
        public IArray<String> BimDocumentTitle { get; }
        public String GetBimDocumentTitle(int index, String defaultValue = "") => BimDocumentTitle?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> BimDocumentIsMetric { get; }
        public Boolean GetBimDocumentIsMetric(int index, Boolean defaultValue = default) => BimDocumentIsMetric?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentGuid { get; }
        public String GetBimDocumentGuid(int index, String defaultValue = "") => BimDocumentGuid?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Int32> BimDocumentNumSaves { get; }
        public Int32 GetBimDocumentNumSaves(int index, Int32 defaultValue = default) => BimDocumentNumSaves?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> BimDocumentIsLinked { get; }
        public Boolean GetBimDocumentIsLinked(int index, Boolean defaultValue = default) => BimDocumentIsLinked?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> BimDocumentIsDetached { get; }
        public Boolean GetBimDocumentIsDetached(int index, Boolean defaultValue = default) => BimDocumentIsDetached?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> BimDocumentIsWorkshared { get; }
        public Boolean GetBimDocumentIsWorkshared(int index, Boolean defaultValue = default) => BimDocumentIsWorkshared?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentPathName { get; }
        public String GetBimDocumentPathName(int index, String defaultValue = "") => BimDocumentPathName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> BimDocumentLatitude { get; }
        public Double GetBimDocumentLatitude(int index, Double defaultValue = default) => BimDocumentLatitude?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> BimDocumentLongitude { get; }
        public Double GetBimDocumentLongitude(int index, Double defaultValue = default) => BimDocumentLongitude?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> BimDocumentTimeZone { get; }
        public Double GetBimDocumentTimeZone(int index, Double defaultValue = default) => BimDocumentTimeZone?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentPlaceName { get; }
        public String GetBimDocumentPlaceName(int index, String defaultValue = "") => BimDocumentPlaceName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentWeatherStationName { get; }
        public String GetBimDocumentWeatherStationName(int index, String defaultValue = "") => BimDocumentWeatherStationName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> BimDocumentElevation { get; }
        public Double GetBimDocumentElevation(int index, Double defaultValue = default) => BimDocumentElevation?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentProjectLocation { get; }
        public String GetBimDocumentProjectLocation(int index, String defaultValue = "") => BimDocumentProjectLocation?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentIssueDate { get; }
        public String GetBimDocumentIssueDate(int index, String defaultValue = "") => BimDocumentIssueDate?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentStatus { get; }
        public String GetBimDocumentStatus(int index, String defaultValue = "") => BimDocumentStatus?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentClientName { get; }
        public String GetBimDocumentClientName(int index, String defaultValue = "") => BimDocumentClientName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentAddress { get; }
        public String GetBimDocumentAddress(int index, String defaultValue = "") => BimDocumentAddress?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentName { get; }
        public String GetBimDocumentName(int index, String defaultValue = "") => BimDocumentName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentNumber { get; }
        public String GetBimDocumentNumber(int index, String defaultValue = "") => BimDocumentNumber?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentAuthor { get; }
        public String GetBimDocumentAuthor(int index, String defaultValue = "") => BimDocumentAuthor?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentBuildingName { get; }
        public String GetBimDocumentBuildingName(int index, String defaultValue = "") => BimDocumentBuildingName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentOrganizationName { get; }
        public String GetBimDocumentOrganizationName(int index, String defaultValue = "") => BimDocumentOrganizationName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentOrganizationDescription { get; }
        public String GetBimDocumentOrganizationDescription(int index, String defaultValue = "") => BimDocumentOrganizationDescription?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentProduct { get; }
        public String GetBimDocumentProduct(int index, String defaultValue = "") => BimDocumentProduct?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentVersion { get; }
        public String GetBimDocumentVersion(int index, String defaultValue = "") => BimDocumentVersion?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BimDocumentUser { get; }
        public String GetBimDocumentUser(int index, String defaultValue = "") => BimDocumentUser?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> BimDocumentActiveViewIndex { get; }
        public int GetBimDocumentActiveViewIndex(int index) => BimDocumentActiveViewIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> BimDocumentOwnerFamilyIndex { get; }
        public int GetBimDocumentOwnerFamilyIndex(int index) => BimDocumentOwnerFamilyIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> BimDocumentParentIndex { get; }
        public int GetBimDocumentParentIndex(int index) => BimDocumentParentIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> BimDocumentElementIndex { get; }
        public int GetBimDocumentElementIndex(int index) => BimDocumentElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumBimDocument => BimDocumentEntityTable?.NumRows ?? 0;
        public IArray<BimDocument> BimDocumentList { get; }
        public BimDocument GetBimDocument(int n)
        {
            if (n < 0) return null;
            var r = new BimDocument();
            r.Document = Document;
            r.Index = n;
            r.Title = BimDocumentTitle.ElementAtOrDefault(n);
            r.IsMetric = BimDocumentIsMetric.ElementAtOrDefault(n);
            r.Guid = BimDocumentGuid.ElementAtOrDefault(n);
            r.NumSaves = BimDocumentNumSaves.ElementAtOrDefault(n);
            r.IsLinked = BimDocumentIsLinked.ElementAtOrDefault(n);
            r.IsDetached = BimDocumentIsDetached.ElementAtOrDefault(n);
            r.IsWorkshared = BimDocumentIsWorkshared.ElementAtOrDefault(n);
            r.PathName = BimDocumentPathName.ElementAtOrDefault(n);
            r.Latitude = BimDocumentLatitude.ElementAtOrDefault(n);
            r.Longitude = BimDocumentLongitude.ElementAtOrDefault(n);
            r.TimeZone = BimDocumentTimeZone.ElementAtOrDefault(n);
            r.PlaceName = BimDocumentPlaceName.ElementAtOrDefault(n);
            r.WeatherStationName = BimDocumentWeatherStationName.ElementAtOrDefault(n);
            r.Elevation = BimDocumentElevation.ElementAtOrDefault(n);
            r.ProjectLocation = BimDocumentProjectLocation.ElementAtOrDefault(n);
            r.IssueDate = BimDocumentIssueDate.ElementAtOrDefault(n);
            r.Status = BimDocumentStatus.ElementAtOrDefault(n);
            r.ClientName = BimDocumentClientName.ElementAtOrDefault(n);
            r.Address = BimDocumentAddress.ElementAtOrDefault(n);
            r.Name = BimDocumentName.ElementAtOrDefault(n);
            r.Number = BimDocumentNumber.ElementAtOrDefault(n);
            r.Author = BimDocumentAuthor.ElementAtOrDefault(n);
            r.BuildingName = BimDocumentBuildingName.ElementAtOrDefault(n);
            r.OrganizationName = BimDocumentOrganizationName.ElementAtOrDefault(n);
            r.OrganizationDescription = BimDocumentOrganizationDescription.ElementAtOrDefault(n);
            r.Product = BimDocumentProduct.ElementAtOrDefault(n);
            r.Version = BimDocumentVersion.ElementAtOrDefault(n);
            r.User = BimDocumentUser.ElementAtOrDefault(n);
            r._ActiveView = new Relation<Vim.Format.ObjectModel.View>(GetBimDocumentActiveViewIndex(n), GetView);
            r._OwnerFamily = new Relation<Vim.Format.ObjectModel.Family>(GetBimDocumentOwnerFamilyIndex(n), GetFamily);
            r._Parent = new Relation<Vim.Format.ObjectModel.BimDocument>(GetBimDocumentParentIndex(n), GetBimDocument);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetBimDocumentElementIndex(n), GetElement);
            return r;
        }
        
        
        // DisplayUnitInBimDocument
        
        public EntityTable DisplayUnitInBimDocumentEntityTable { get; }
        
        public IArray<int> DisplayUnitInBimDocumentDisplayUnitIndex { get; }
        public int GetDisplayUnitInBimDocumentDisplayUnitIndex(int index) => DisplayUnitInBimDocumentDisplayUnitIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> DisplayUnitInBimDocumentBimDocumentIndex { get; }
        public int GetDisplayUnitInBimDocumentBimDocumentIndex(int index) => DisplayUnitInBimDocumentBimDocumentIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumDisplayUnitInBimDocument => DisplayUnitInBimDocumentEntityTable?.NumRows ?? 0;
        public IArray<DisplayUnitInBimDocument> DisplayUnitInBimDocumentList { get; }
        public DisplayUnitInBimDocument GetDisplayUnitInBimDocument(int n)
        {
            if (n < 0) return null;
            var r = new DisplayUnitInBimDocument();
            r.Document = Document;
            r.Index = n;
            r._DisplayUnit = new Relation<Vim.Format.ObjectModel.DisplayUnit>(GetDisplayUnitInBimDocumentDisplayUnitIndex(n), GetDisplayUnit);
            r._BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>(GetDisplayUnitInBimDocumentBimDocumentIndex(n), GetBimDocument);
            return r;
        }
        
        
        // PhaseOrderInBimDocument
        
        public EntityTable PhaseOrderInBimDocumentEntityTable { get; }
        
        public IArray<Int32> PhaseOrderInBimDocumentOrderIndex { get; }
        public Int32 GetPhaseOrderInBimDocumentOrderIndex(int index, Int32 defaultValue = default) => PhaseOrderInBimDocumentOrderIndex?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> PhaseOrderInBimDocumentPhaseIndex { get; }
        public int GetPhaseOrderInBimDocumentPhaseIndex(int index) => PhaseOrderInBimDocumentPhaseIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> PhaseOrderInBimDocumentBimDocumentIndex { get; }
        public int GetPhaseOrderInBimDocumentBimDocumentIndex(int index) => PhaseOrderInBimDocumentBimDocumentIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumPhaseOrderInBimDocument => PhaseOrderInBimDocumentEntityTable?.NumRows ?? 0;
        public IArray<PhaseOrderInBimDocument> PhaseOrderInBimDocumentList { get; }
        public PhaseOrderInBimDocument GetPhaseOrderInBimDocument(int n)
        {
            if (n < 0) return null;
            var r = new PhaseOrderInBimDocument();
            r.Document = Document;
            r.Index = n;
            r.OrderIndex = PhaseOrderInBimDocumentOrderIndex.ElementAtOrDefault(n);
            r._Phase = new Relation<Vim.Format.ObjectModel.Phase>(GetPhaseOrderInBimDocumentPhaseIndex(n), GetPhase);
            r._BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>(GetPhaseOrderInBimDocumentBimDocumentIndex(n), GetBimDocument);
            return r;
        }
        
        
        // Category
        
        public EntityTable CategoryEntityTable { get; }
        
        public IArray<String> CategoryName { get; }
        public String GetCategoryName(int index, String defaultValue = "") => CategoryName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Int64> CategoryId { get; }
        public Int64 GetCategoryId(int index, Int64 defaultValue = default) => CategoryId?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> CategoryCategoryType { get; }
        public String GetCategoryCategoryType(int index, String defaultValue = "") => CategoryCategoryType?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> CategoryLineColor_X { get; }
        public Double GetCategoryLineColor_X(int index, Double defaultValue = default) => CategoryLineColor_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> CategoryLineColor_Y { get; }
        public Double GetCategoryLineColor_Y(int index, Double defaultValue = default) => CategoryLineColor_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> CategoryLineColor_Z { get; }
        public Double GetCategoryLineColor_Z(int index, Double defaultValue = default) => CategoryLineColor_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> CategoryBuiltInCategory { get; }
        public String GetCategoryBuiltInCategory(int index, String defaultValue = "") => CategoryBuiltInCategory?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> CategoryParentIndex { get; }
        public int GetCategoryParentIndex(int index) => CategoryParentIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> CategoryMaterialIndex { get; }
        public int GetCategoryMaterialIndex(int index) => CategoryMaterialIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumCategory => CategoryEntityTable?.NumRows ?? 0;
        public IArray<Category> CategoryList { get; }
        public Category GetCategory(int n)
        {
            if (n < 0) return null;
            var r = new Category();
            r.Document = Document;
            r.Index = n;
            r.Name = CategoryName.ElementAtOrDefault(n);
            r.Id = CategoryId.ElementAtOrDefault(n);
            r.CategoryType = CategoryCategoryType.ElementAtOrDefault(n);
            r.LineColor_X = CategoryLineColor_X.ElementAtOrDefault(n);
            r.LineColor_Y = CategoryLineColor_Y.ElementAtOrDefault(n);
            r.LineColor_Z = CategoryLineColor_Z.ElementAtOrDefault(n);
            r.BuiltInCategory = CategoryBuiltInCategory.ElementAtOrDefault(n);
            r._Parent = new Relation<Vim.Format.ObjectModel.Category>(GetCategoryParentIndex(n), GetCategory);
            r._Material = new Relation<Vim.Format.ObjectModel.Material>(GetCategoryMaterialIndex(n), GetMaterial);
            return r;
        }
        
        
        // Family
        
        public EntityTable FamilyEntityTable { get; }
        
        public IArray<String> FamilyStructuralMaterialType { get; }
        public String GetFamilyStructuralMaterialType(int index, String defaultValue = "") => FamilyStructuralMaterialType?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> FamilyStructuralSectionShape { get; }
        public String GetFamilyStructuralSectionShape(int index, String defaultValue = "") => FamilyStructuralSectionShape?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> FamilyIsSystemFamily { get; }
        public Boolean GetFamilyIsSystemFamily(int index, Boolean defaultValue = default) => FamilyIsSystemFamily?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> FamilyIsInPlace { get; }
        public Boolean GetFamilyIsInPlace(int index, Boolean defaultValue = default) => FamilyIsInPlace?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> FamilyFamilyCategoryIndex { get; }
        public int GetFamilyFamilyCategoryIndex(int index) => FamilyFamilyCategoryIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> FamilyElementIndex { get; }
        public int GetFamilyElementIndex(int index) => FamilyElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumFamily => FamilyEntityTable?.NumRows ?? 0;
        public IArray<Family> FamilyList { get; }
        public Family GetFamily(int n)
        {
            if (n < 0) return null;
            var r = new Family();
            r.Document = Document;
            r.Index = n;
            r.StructuralMaterialType = FamilyStructuralMaterialType.ElementAtOrDefault(n);
            r.StructuralSectionShape = FamilyStructuralSectionShape.ElementAtOrDefault(n);
            r.IsSystemFamily = FamilyIsSystemFamily.ElementAtOrDefault(n);
            r.IsInPlace = FamilyIsInPlace.ElementAtOrDefault(n);
            r._FamilyCategory = new Relation<Vim.Format.ObjectModel.Category>(GetFamilyFamilyCategoryIndex(n), GetCategory);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetFamilyElementIndex(n), GetElement);
            return r;
        }
        
        
        // FamilyType
        
        public EntityTable FamilyTypeEntityTable { get; }
        
        public IArray<Boolean> FamilyTypeIsSystemFamilyType { get; }
        public Boolean GetFamilyTypeIsSystemFamilyType(int index, Boolean defaultValue = default) => FamilyTypeIsSystemFamilyType?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> FamilyTypeFamilyIndex { get; }
        public int GetFamilyTypeFamilyIndex(int index) => FamilyTypeFamilyIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> FamilyTypeCompoundStructureIndex { get; }
        public int GetFamilyTypeCompoundStructureIndex(int index) => FamilyTypeCompoundStructureIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> FamilyTypeElementIndex { get; }
        public int GetFamilyTypeElementIndex(int index) => FamilyTypeElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumFamilyType => FamilyTypeEntityTable?.NumRows ?? 0;
        public IArray<FamilyType> FamilyTypeList { get; }
        public FamilyType GetFamilyType(int n)
        {
            if (n < 0) return null;
            var r = new FamilyType();
            r.Document = Document;
            r.Index = n;
            r.IsSystemFamilyType = FamilyTypeIsSystemFamilyType.ElementAtOrDefault(n);
            r._Family = new Relation<Vim.Format.ObjectModel.Family>(GetFamilyTypeFamilyIndex(n), GetFamily);
            r._CompoundStructure = new Relation<Vim.Format.ObjectModel.CompoundStructure>(GetFamilyTypeCompoundStructureIndex(n), GetCompoundStructure);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetFamilyTypeElementIndex(n), GetElement);
            return r;
        }
        
        
        // FamilyInstance
        
        public EntityTable FamilyInstanceEntityTable { get; }
        
        public IArray<Boolean> FamilyInstanceFacingFlipped { get; }
        public Boolean GetFamilyInstanceFacingFlipped(int index, Boolean defaultValue = default) => FamilyInstanceFacingFlipped?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceFacingOrientation_X { get; }
        public Single GetFamilyInstanceFacingOrientation_X(int index, Single defaultValue = default) => FamilyInstanceFacingOrientation_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceFacingOrientation_Y { get; }
        public Single GetFamilyInstanceFacingOrientation_Y(int index, Single defaultValue = default) => FamilyInstanceFacingOrientation_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceFacingOrientation_Z { get; }
        public Single GetFamilyInstanceFacingOrientation_Z(int index, Single defaultValue = default) => FamilyInstanceFacingOrientation_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> FamilyInstanceHandFlipped { get; }
        public Boolean GetFamilyInstanceHandFlipped(int index, Boolean defaultValue = default) => FamilyInstanceHandFlipped?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> FamilyInstanceMirrored { get; }
        public Boolean GetFamilyInstanceMirrored(int index, Boolean defaultValue = default) => FamilyInstanceMirrored?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> FamilyInstanceHasModifiedGeometry { get; }
        public Boolean GetFamilyInstanceHasModifiedGeometry(int index, Boolean defaultValue = default) => FamilyInstanceHasModifiedGeometry?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceScale { get; }
        public Single GetFamilyInstanceScale(int index, Single defaultValue = default) => FamilyInstanceScale?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceBasisX_X { get; }
        public Single GetFamilyInstanceBasisX_X(int index, Single defaultValue = default) => FamilyInstanceBasisX_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceBasisX_Y { get; }
        public Single GetFamilyInstanceBasisX_Y(int index, Single defaultValue = default) => FamilyInstanceBasisX_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceBasisX_Z { get; }
        public Single GetFamilyInstanceBasisX_Z(int index, Single defaultValue = default) => FamilyInstanceBasisX_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceBasisY_X { get; }
        public Single GetFamilyInstanceBasisY_X(int index, Single defaultValue = default) => FamilyInstanceBasisY_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceBasisY_Y { get; }
        public Single GetFamilyInstanceBasisY_Y(int index, Single defaultValue = default) => FamilyInstanceBasisY_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceBasisY_Z { get; }
        public Single GetFamilyInstanceBasisY_Z(int index, Single defaultValue = default) => FamilyInstanceBasisY_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceBasisZ_X { get; }
        public Single GetFamilyInstanceBasisZ_X(int index, Single defaultValue = default) => FamilyInstanceBasisZ_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceBasisZ_Y { get; }
        public Single GetFamilyInstanceBasisZ_Y(int index, Single defaultValue = default) => FamilyInstanceBasisZ_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceBasisZ_Z { get; }
        public Single GetFamilyInstanceBasisZ_Z(int index, Single defaultValue = default) => FamilyInstanceBasisZ_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceTranslation_X { get; }
        public Single GetFamilyInstanceTranslation_X(int index, Single defaultValue = default) => FamilyInstanceTranslation_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceTranslation_Y { get; }
        public Single GetFamilyInstanceTranslation_Y(int index, Single defaultValue = default) => FamilyInstanceTranslation_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceTranslation_Z { get; }
        public Single GetFamilyInstanceTranslation_Z(int index, Single defaultValue = default) => FamilyInstanceTranslation_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceHandOrientation_X { get; }
        public Single GetFamilyInstanceHandOrientation_X(int index, Single defaultValue = default) => FamilyInstanceHandOrientation_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceHandOrientation_Y { get; }
        public Single GetFamilyInstanceHandOrientation_Y(int index, Single defaultValue = default) => FamilyInstanceHandOrientation_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> FamilyInstanceHandOrientation_Z { get; }
        public Single GetFamilyInstanceHandOrientation_Z(int index, Single defaultValue = default) => FamilyInstanceHandOrientation_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> FamilyInstanceFamilyTypeIndex { get; }
        public int GetFamilyInstanceFamilyTypeIndex(int index) => FamilyInstanceFamilyTypeIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> FamilyInstanceHostIndex { get; }
        public int GetFamilyInstanceHostIndex(int index) => FamilyInstanceHostIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> FamilyInstanceFromRoomIndex { get; }
        public int GetFamilyInstanceFromRoomIndex(int index) => FamilyInstanceFromRoomIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> FamilyInstanceToRoomIndex { get; }
        public int GetFamilyInstanceToRoomIndex(int index) => FamilyInstanceToRoomIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> FamilyInstanceSuperComponentIndex { get; }
        public int GetFamilyInstanceSuperComponentIndex(int index) => FamilyInstanceSuperComponentIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> FamilyInstanceElementIndex { get; }
        public int GetFamilyInstanceElementIndex(int index) => FamilyInstanceElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumFamilyInstance => FamilyInstanceEntityTable?.NumRows ?? 0;
        public IArray<FamilyInstance> FamilyInstanceList { get; }
        public FamilyInstance GetFamilyInstance(int n)
        {
            if (n < 0) return null;
            var r = new FamilyInstance();
            r.Document = Document;
            r.Index = n;
            r.FacingFlipped = FamilyInstanceFacingFlipped.ElementAtOrDefault(n);
            r.FacingOrientation_X = FamilyInstanceFacingOrientation_X.ElementAtOrDefault(n);
            r.FacingOrientation_Y = FamilyInstanceFacingOrientation_Y.ElementAtOrDefault(n);
            r.FacingOrientation_Z = FamilyInstanceFacingOrientation_Z.ElementAtOrDefault(n);
            r.HandFlipped = FamilyInstanceHandFlipped.ElementAtOrDefault(n);
            r.Mirrored = FamilyInstanceMirrored.ElementAtOrDefault(n);
            r.HasModifiedGeometry = FamilyInstanceHasModifiedGeometry.ElementAtOrDefault(n);
            r.Scale = FamilyInstanceScale.ElementAtOrDefault(n);
            r.BasisX_X = FamilyInstanceBasisX_X.ElementAtOrDefault(n);
            r.BasisX_Y = FamilyInstanceBasisX_Y.ElementAtOrDefault(n);
            r.BasisX_Z = FamilyInstanceBasisX_Z.ElementAtOrDefault(n);
            r.BasisY_X = FamilyInstanceBasisY_X.ElementAtOrDefault(n);
            r.BasisY_Y = FamilyInstanceBasisY_Y.ElementAtOrDefault(n);
            r.BasisY_Z = FamilyInstanceBasisY_Z.ElementAtOrDefault(n);
            r.BasisZ_X = FamilyInstanceBasisZ_X.ElementAtOrDefault(n);
            r.BasisZ_Y = FamilyInstanceBasisZ_Y.ElementAtOrDefault(n);
            r.BasisZ_Z = FamilyInstanceBasisZ_Z.ElementAtOrDefault(n);
            r.Translation_X = FamilyInstanceTranslation_X.ElementAtOrDefault(n);
            r.Translation_Y = FamilyInstanceTranslation_Y.ElementAtOrDefault(n);
            r.Translation_Z = FamilyInstanceTranslation_Z.ElementAtOrDefault(n);
            r.HandOrientation_X = FamilyInstanceHandOrientation_X.ElementAtOrDefault(n);
            r.HandOrientation_Y = FamilyInstanceHandOrientation_Y.ElementAtOrDefault(n);
            r.HandOrientation_Z = FamilyInstanceHandOrientation_Z.ElementAtOrDefault(n);
            r._FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>(GetFamilyInstanceFamilyTypeIndex(n), GetFamilyType);
            r._Host = new Relation<Vim.Format.ObjectModel.Element>(GetFamilyInstanceHostIndex(n), GetElement);
            r._FromRoom = new Relation<Vim.Format.ObjectModel.Room>(GetFamilyInstanceFromRoomIndex(n), GetRoom);
            r._ToRoom = new Relation<Vim.Format.ObjectModel.Room>(GetFamilyInstanceToRoomIndex(n), GetRoom);
            r._SuperComponent = new Relation<Vim.Format.ObjectModel.Element>(GetFamilyInstanceSuperComponentIndex(n), GetElement);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetFamilyInstanceElementIndex(n), GetElement);
            return r;
        }
        
        
        // View
        
        public EntityTable ViewEntityTable { get; }
        
        public IArray<String> ViewTitle { get; }
        public String GetViewTitle(int index, String defaultValue = "") => ViewTitle?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> ViewViewType { get; }
        public String GetViewViewType(int index, String defaultValue = "") => ViewViewType?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewUp_X { get; }
        public Double GetViewUp_X(int index, Double defaultValue = default) => ViewUp_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewUp_Y { get; }
        public Double GetViewUp_Y(int index, Double defaultValue = default) => ViewUp_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewUp_Z { get; }
        public Double GetViewUp_Z(int index, Double defaultValue = default) => ViewUp_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewRight_X { get; }
        public Double GetViewRight_X(int index, Double defaultValue = default) => ViewRight_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewRight_Y { get; }
        public Double GetViewRight_Y(int index, Double defaultValue = default) => ViewRight_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewRight_Z { get; }
        public Double GetViewRight_Z(int index, Double defaultValue = default) => ViewRight_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewOrigin_X { get; }
        public Double GetViewOrigin_X(int index, Double defaultValue = default) => ViewOrigin_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewOrigin_Y { get; }
        public Double GetViewOrigin_Y(int index, Double defaultValue = default) => ViewOrigin_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewOrigin_Z { get; }
        public Double GetViewOrigin_Z(int index, Double defaultValue = default) => ViewOrigin_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewViewDirection_X { get; }
        public Double GetViewViewDirection_X(int index, Double defaultValue = default) => ViewViewDirection_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewViewDirection_Y { get; }
        public Double GetViewViewDirection_Y(int index, Double defaultValue = default) => ViewViewDirection_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewViewDirection_Z { get; }
        public Double GetViewViewDirection_Z(int index, Double defaultValue = default) => ViewViewDirection_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewViewPosition_X { get; }
        public Double GetViewViewPosition_X(int index, Double defaultValue = default) => ViewViewPosition_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewViewPosition_Y { get; }
        public Double GetViewViewPosition_Y(int index, Double defaultValue = default) => ViewViewPosition_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewViewPosition_Z { get; }
        public Double GetViewViewPosition_Z(int index, Double defaultValue = default) => ViewViewPosition_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewScale { get; }
        public Double GetViewScale(int index, Double defaultValue = default) => ViewScale?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewOutline_Min_X { get; }
        public Double GetViewOutline_Min_X(int index, Double defaultValue = default) => ViewOutline_Min_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewOutline_Min_Y { get; }
        public Double GetViewOutline_Min_Y(int index, Double defaultValue = default) => ViewOutline_Min_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewOutline_Max_X { get; }
        public Double GetViewOutline_Max_X(int index, Double defaultValue = default) => ViewOutline_Max_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> ViewOutline_Max_Y { get; }
        public Double GetViewOutline_Max_Y(int index, Double defaultValue = default) => ViewOutline_Max_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Int32> ViewDetailLevel { get; }
        public Int32 GetViewDetailLevel(int index, Int32 defaultValue = default) => ViewDetailLevel?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> ViewCameraIndex { get; }
        public int GetViewCameraIndex(int index) => ViewCameraIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ViewFamilyTypeIndex { get; }
        public int GetViewFamilyTypeIndex(int index) => ViewFamilyTypeIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ViewElementIndex { get; }
        public int GetViewElementIndex(int index) => ViewElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumView => ViewEntityTable?.NumRows ?? 0;
        public IArray<View> ViewList { get; }
        public View GetView(int n)
        {
            if (n < 0) return null;
            var r = new View();
            r.Document = Document;
            r.Index = n;
            r.Title = ViewTitle.ElementAtOrDefault(n);
            r.ViewType = ViewViewType.ElementAtOrDefault(n);
            r.Up_X = ViewUp_X.ElementAtOrDefault(n);
            r.Up_Y = ViewUp_Y.ElementAtOrDefault(n);
            r.Up_Z = ViewUp_Z.ElementAtOrDefault(n);
            r.Right_X = ViewRight_X.ElementAtOrDefault(n);
            r.Right_Y = ViewRight_Y.ElementAtOrDefault(n);
            r.Right_Z = ViewRight_Z.ElementAtOrDefault(n);
            r.Origin_X = ViewOrigin_X.ElementAtOrDefault(n);
            r.Origin_Y = ViewOrigin_Y.ElementAtOrDefault(n);
            r.Origin_Z = ViewOrigin_Z.ElementAtOrDefault(n);
            r.ViewDirection_X = ViewViewDirection_X.ElementAtOrDefault(n);
            r.ViewDirection_Y = ViewViewDirection_Y.ElementAtOrDefault(n);
            r.ViewDirection_Z = ViewViewDirection_Z.ElementAtOrDefault(n);
            r.ViewPosition_X = ViewViewPosition_X.ElementAtOrDefault(n);
            r.ViewPosition_Y = ViewViewPosition_Y.ElementAtOrDefault(n);
            r.ViewPosition_Z = ViewViewPosition_Z.ElementAtOrDefault(n);
            r.Scale = ViewScale.ElementAtOrDefault(n);
            r.Outline_Min_X = ViewOutline_Min_X.ElementAtOrDefault(n);
            r.Outline_Min_Y = ViewOutline_Min_Y.ElementAtOrDefault(n);
            r.Outline_Max_X = ViewOutline_Max_X.ElementAtOrDefault(n);
            r.Outline_Max_Y = ViewOutline_Max_Y.ElementAtOrDefault(n);
            r.DetailLevel = ViewDetailLevel.ElementAtOrDefault(n);
            r._Camera = new Relation<Vim.Format.ObjectModel.Camera>(GetViewCameraIndex(n), GetCamera);
            r._FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>(GetViewFamilyTypeIndex(n), GetFamilyType);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetViewElementIndex(n), GetElement);
            return r;
        }
        
        
        // ElementInView
        
        public EntityTable ElementInViewEntityTable { get; }
        
        public IArray<int> ElementInViewViewIndex { get; }
        public int GetElementInViewViewIndex(int index) => ElementInViewViewIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ElementInViewElementIndex { get; }
        public int GetElementInViewElementIndex(int index) => ElementInViewElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumElementInView => ElementInViewEntityTable?.NumRows ?? 0;
        public IArray<ElementInView> ElementInViewList { get; }
        public ElementInView GetElementInView(int n)
        {
            if (n < 0) return null;
            var r = new ElementInView();
            r.Document = Document;
            r.Index = n;
            r._View = new Relation<Vim.Format.ObjectModel.View>(GetElementInViewViewIndex(n), GetView);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementInViewElementIndex(n), GetElement);
            return r;
        }
        
        
        // ShapeInView
        
        public EntityTable ShapeInViewEntityTable { get; }
        
        public IArray<int> ShapeInViewShapeIndex { get; }
        public int GetShapeInViewShapeIndex(int index) => ShapeInViewShapeIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ShapeInViewViewIndex { get; }
        public int GetShapeInViewViewIndex(int index) => ShapeInViewViewIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumShapeInView => ShapeInViewEntityTable?.NumRows ?? 0;
        public IArray<ShapeInView> ShapeInViewList { get; }
        public ShapeInView GetShapeInView(int n)
        {
            if (n < 0) return null;
            var r = new ShapeInView();
            r.Document = Document;
            r.Index = n;
            r._Shape = new Relation<Vim.Format.ObjectModel.Shape>(GetShapeInViewShapeIndex(n), GetShape);
            r._View = new Relation<Vim.Format.ObjectModel.View>(GetShapeInViewViewIndex(n), GetView);
            return r;
        }
        
        
        // AssetInView
        
        public EntityTable AssetInViewEntityTable { get; }
        
        public IArray<int> AssetInViewAssetIndex { get; }
        public int GetAssetInViewAssetIndex(int index) => AssetInViewAssetIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> AssetInViewViewIndex { get; }
        public int GetAssetInViewViewIndex(int index) => AssetInViewViewIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumAssetInView => AssetInViewEntityTable?.NumRows ?? 0;
        public IArray<AssetInView> AssetInViewList { get; }
        public AssetInView GetAssetInView(int n)
        {
            if (n < 0) return null;
            var r = new AssetInView();
            r.Document = Document;
            r.Index = n;
            r._Asset = new Relation<Vim.Format.ObjectModel.Asset>(GetAssetInViewAssetIndex(n), GetAsset);
            r._View = new Relation<Vim.Format.ObjectModel.View>(GetAssetInViewViewIndex(n), GetView);
            return r;
        }
        
        
        // AssetInViewSheet
        
        public EntityTable AssetInViewSheetEntityTable { get; }
        
        public IArray<int> AssetInViewSheetAssetIndex { get; }
        public int GetAssetInViewSheetAssetIndex(int index) => AssetInViewSheetAssetIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> AssetInViewSheetViewSheetIndex { get; }
        public int GetAssetInViewSheetViewSheetIndex(int index) => AssetInViewSheetViewSheetIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumAssetInViewSheet => AssetInViewSheetEntityTable?.NumRows ?? 0;
        public IArray<AssetInViewSheet> AssetInViewSheetList { get; }
        public AssetInViewSheet GetAssetInViewSheet(int n)
        {
            if (n < 0) return null;
            var r = new AssetInViewSheet();
            r.Document = Document;
            r.Index = n;
            r._Asset = new Relation<Vim.Format.ObjectModel.Asset>(GetAssetInViewSheetAssetIndex(n), GetAsset);
            r._ViewSheet = new Relation<Vim.Format.ObjectModel.ViewSheet>(GetAssetInViewSheetViewSheetIndex(n), GetViewSheet);
            return r;
        }
        
        
        // LevelInView
        
        public EntityTable LevelInViewEntityTable { get; }
        
        public IArray<Double> LevelInViewExtents_Min_X { get; }
        public Double GetLevelInViewExtents_Min_X(int index, Double defaultValue = default) => LevelInViewExtents_Min_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> LevelInViewExtents_Min_Y { get; }
        public Double GetLevelInViewExtents_Min_Y(int index, Double defaultValue = default) => LevelInViewExtents_Min_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> LevelInViewExtents_Min_Z { get; }
        public Double GetLevelInViewExtents_Min_Z(int index, Double defaultValue = default) => LevelInViewExtents_Min_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> LevelInViewExtents_Max_X { get; }
        public Double GetLevelInViewExtents_Max_X(int index, Double defaultValue = default) => LevelInViewExtents_Max_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> LevelInViewExtents_Max_Y { get; }
        public Double GetLevelInViewExtents_Max_Y(int index, Double defaultValue = default) => LevelInViewExtents_Max_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> LevelInViewExtents_Max_Z { get; }
        public Double GetLevelInViewExtents_Max_Z(int index, Double defaultValue = default) => LevelInViewExtents_Max_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> LevelInViewLevelIndex { get; }
        public int GetLevelInViewLevelIndex(int index) => LevelInViewLevelIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> LevelInViewViewIndex { get; }
        public int GetLevelInViewViewIndex(int index) => LevelInViewViewIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumLevelInView => LevelInViewEntityTable?.NumRows ?? 0;
        public IArray<LevelInView> LevelInViewList { get; }
        public LevelInView GetLevelInView(int n)
        {
            if (n < 0) return null;
            var r = new LevelInView();
            r.Document = Document;
            r.Index = n;
            r.Extents_Min_X = LevelInViewExtents_Min_X.ElementAtOrDefault(n);
            r.Extents_Min_Y = LevelInViewExtents_Min_Y.ElementAtOrDefault(n);
            r.Extents_Min_Z = LevelInViewExtents_Min_Z.ElementAtOrDefault(n);
            r.Extents_Max_X = LevelInViewExtents_Max_X.ElementAtOrDefault(n);
            r.Extents_Max_Y = LevelInViewExtents_Max_Y.ElementAtOrDefault(n);
            r.Extents_Max_Z = LevelInViewExtents_Max_Z.ElementAtOrDefault(n);
            r._Level = new Relation<Vim.Format.ObjectModel.Level>(GetLevelInViewLevelIndex(n), GetLevel);
            r._View = new Relation<Vim.Format.ObjectModel.View>(GetLevelInViewViewIndex(n), GetView);
            return r;
        }
        
        
        // Camera
        
        public EntityTable CameraEntityTable { get; }
        
        public IArray<Int32> CameraId { get; }
        public Int32 GetCameraId(int index, Int32 defaultValue = default) => CameraId?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Int32> CameraIsPerspective { get; }
        public Int32 GetCameraIsPerspective(int index, Int32 defaultValue = default) => CameraIsPerspective?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> CameraVerticalExtent { get; }
        public Double GetCameraVerticalExtent(int index, Double defaultValue = default) => CameraVerticalExtent?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> CameraHorizontalExtent { get; }
        public Double GetCameraHorizontalExtent(int index, Double defaultValue = default) => CameraHorizontalExtent?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> CameraFarDistance { get; }
        public Double GetCameraFarDistance(int index, Double defaultValue = default) => CameraFarDistance?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> CameraNearDistance { get; }
        public Double GetCameraNearDistance(int index, Double defaultValue = default) => CameraNearDistance?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> CameraTargetDistance { get; }
        public Double GetCameraTargetDistance(int index, Double defaultValue = default) => CameraTargetDistance?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> CameraRightOffset { get; }
        public Double GetCameraRightOffset(int index, Double defaultValue = default) => CameraRightOffset?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> CameraUpOffset { get; }
        public Double GetCameraUpOffset(int index, Double defaultValue = default) => CameraUpOffset?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public int NumCamera => CameraEntityTable?.NumRows ?? 0;
        public IArray<Camera> CameraList { get; }
        public Camera GetCamera(int n)
        {
            if (n < 0) return null;
            var r = new Camera();
            r.Document = Document;
            r.Index = n;
            r.Id = CameraId.ElementAtOrDefault(n);
            r.IsPerspective = CameraIsPerspective.ElementAtOrDefault(n);
            r.VerticalExtent = CameraVerticalExtent.ElementAtOrDefault(n);
            r.HorizontalExtent = CameraHorizontalExtent.ElementAtOrDefault(n);
            r.FarDistance = CameraFarDistance.ElementAtOrDefault(n);
            r.NearDistance = CameraNearDistance.ElementAtOrDefault(n);
            r.TargetDistance = CameraTargetDistance.ElementAtOrDefault(n);
            r.RightOffset = CameraRightOffset.ElementAtOrDefault(n);
            r.UpOffset = CameraUpOffset.ElementAtOrDefault(n);
            return r;
        }
        
        
        // Material
        
        public EntityTable MaterialEntityTable { get; }
        
        public IArray<String> MaterialName { get; }
        public String GetMaterialName(int index, String defaultValue = "") => MaterialName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> MaterialMaterialCategory { get; }
        public String GetMaterialMaterialCategory(int index, String defaultValue = "") => MaterialMaterialCategory?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialColor_X { get; }
        public Double GetMaterialColor_X(int index, Double defaultValue = default) => MaterialColor_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialColor_Y { get; }
        public Double GetMaterialColor_Y(int index, Double defaultValue = default) => MaterialColor_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialColor_Z { get; }
        public Double GetMaterialColor_Z(int index, Double defaultValue = default) => MaterialColor_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialColorUvScaling_X { get; }
        public Double GetMaterialColorUvScaling_X(int index, Double defaultValue = default) => MaterialColorUvScaling_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialColorUvScaling_Y { get; }
        public Double GetMaterialColorUvScaling_Y(int index, Double defaultValue = default) => MaterialColorUvScaling_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialColorUvOffset_X { get; }
        public Double GetMaterialColorUvOffset_X(int index, Double defaultValue = default) => MaterialColorUvOffset_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialColorUvOffset_Y { get; }
        public Double GetMaterialColorUvOffset_Y(int index, Double defaultValue = default) => MaterialColorUvOffset_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialNormalUvScaling_X { get; }
        public Double GetMaterialNormalUvScaling_X(int index, Double defaultValue = default) => MaterialNormalUvScaling_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialNormalUvScaling_Y { get; }
        public Double GetMaterialNormalUvScaling_Y(int index, Double defaultValue = default) => MaterialNormalUvScaling_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialNormalUvOffset_X { get; }
        public Double GetMaterialNormalUvOffset_X(int index, Double defaultValue = default) => MaterialNormalUvOffset_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialNormalUvOffset_Y { get; }
        public Double GetMaterialNormalUvOffset_Y(int index, Double defaultValue = default) => MaterialNormalUvOffset_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialNormalAmount { get; }
        public Double GetMaterialNormalAmount(int index, Double defaultValue = default) => MaterialNormalAmount?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialGlossiness { get; }
        public Double GetMaterialGlossiness(int index, Double defaultValue = default) => MaterialGlossiness?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialSmoothness { get; }
        public Double GetMaterialSmoothness(int index, Double defaultValue = default) => MaterialSmoothness?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialTransparency { get; }
        public Double GetMaterialTransparency(int index, Double defaultValue = default) => MaterialTransparency?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> MaterialColorTextureFileIndex { get; }
        public int GetMaterialColorTextureFileIndex(int index) => MaterialColorTextureFileIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> MaterialNormalTextureFileIndex { get; }
        public int GetMaterialNormalTextureFileIndex(int index) => MaterialNormalTextureFileIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> MaterialElementIndex { get; }
        public int GetMaterialElementIndex(int index) => MaterialElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumMaterial => MaterialEntityTable?.NumRows ?? 0;
        public IArray<Material> MaterialList { get; }
        public Material GetMaterial(int n)
        {
            if (n < 0) return null;
            var r = new Material();
            r.Document = Document;
            r.Index = n;
            r.Name = MaterialName.ElementAtOrDefault(n);
            r.MaterialCategory = MaterialMaterialCategory.ElementAtOrDefault(n);
            r.Color_X = MaterialColor_X.ElementAtOrDefault(n);
            r.Color_Y = MaterialColor_Y.ElementAtOrDefault(n);
            r.Color_Z = MaterialColor_Z.ElementAtOrDefault(n);
            r.ColorUvScaling_X = MaterialColorUvScaling_X.ElementAtOrDefault(n);
            r.ColorUvScaling_Y = MaterialColorUvScaling_Y.ElementAtOrDefault(n);
            r.ColorUvOffset_X = MaterialColorUvOffset_X.ElementAtOrDefault(n);
            r.ColorUvOffset_Y = MaterialColorUvOffset_Y.ElementAtOrDefault(n);
            r.NormalUvScaling_X = MaterialNormalUvScaling_X.ElementAtOrDefault(n);
            r.NormalUvScaling_Y = MaterialNormalUvScaling_Y.ElementAtOrDefault(n);
            r.NormalUvOffset_X = MaterialNormalUvOffset_X.ElementAtOrDefault(n);
            r.NormalUvOffset_Y = MaterialNormalUvOffset_Y.ElementAtOrDefault(n);
            r.NormalAmount = MaterialNormalAmount.ElementAtOrDefault(n);
            r.Glossiness = MaterialGlossiness.ElementAtOrDefault(n);
            r.Smoothness = MaterialSmoothness.ElementAtOrDefault(n);
            r.Transparency = MaterialTransparency.ElementAtOrDefault(n);
            r._ColorTextureFile = new Relation<Vim.Format.ObjectModel.Asset>(GetMaterialColorTextureFileIndex(n), GetAsset);
            r._NormalTextureFile = new Relation<Vim.Format.ObjectModel.Asset>(GetMaterialNormalTextureFileIndex(n), GetAsset);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetMaterialElementIndex(n), GetElement);
            return r;
        }
        
        
        // MaterialInElement
        
        public EntityTable MaterialInElementEntityTable { get; }
        
        public IArray<Double> MaterialInElementArea { get; }
        public Double GetMaterialInElementArea(int index, Double defaultValue = default) => MaterialInElementArea?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> MaterialInElementVolume { get; }
        public Double GetMaterialInElementVolume(int index, Double defaultValue = default) => MaterialInElementVolume?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> MaterialInElementIsPaint { get; }
        public Boolean GetMaterialInElementIsPaint(int index, Boolean defaultValue = default) => MaterialInElementIsPaint?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> MaterialInElementMaterialIndex { get; }
        public int GetMaterialInElementMaterialIndex(int index) => MaterialInElementMaterialIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> MaterialInElementElementIndex { get; }
        public int GetMaterialInElementElementIndex(int index) => MaterialInElementElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumMaterialInElement => MaterialInElementEntityTable?.NumRows ?? 0;
        public IArray<MaterialInElement> MaterialInElementList { get; }
        public MaterialInElement GetMaterialInElement(int n)
        {
            if (n < 0) return null;
            var r = new MaterialInElement();
            r.Document = Document;
            r.Index = n;
            r.Area = MaterialInElementArea.ElementAtOrDefault(n);
            r.Volume = MaterialInElementVolume.ElementAtOrDefault(n);
            r.IsPaint = MaterialInElementIsPaint.ElementAtOrDefault(n);
            r._Material = new Relation<Vim.Format.ObjectModel.Material>(GetMaterialInElementMaterialIndex(n), GetMaterial);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetMaterialInElementElementIndex(n), GetElement);
            return r;
        }
        
        
        // CompoundStructureLayer
        
        public EntityTable CompoundStructureLayerEntityTable { get; }
        
        public IArray<Int32> CompoundStructureLayerOrderIndex { get; }
        public Int32 GetCompoundStructureLayerOrderIndex(int index, Int32 defaultValue = default) => CompoundStructureLayerOrderIndex?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> CompoundStructureLayerWidth { get; }
        public Double GetCompoundStructureLayerWidth(int index, Double defaultValue = default) => CompoundStructureLayerWidth?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> CompoundStructureLayerMaterialFunctionAssignment { get; }
        public String GetCompoundStructureLayerMaterialFunctionAssignment(int index, String defaultValue = "") => CompoundStructureLayerMaterialFunctionAssignment?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> CompoundStructureLayerMaterialIndex { get; }
        public int GetCompoundStructureLayerMaterialIndex(int index) => CompoundStructureLayerMaterialIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> CompoundStructureLayerCompoundStructureIndex { get; }
        public int GetCompoundStructureLayerCompoundStructureIndex(int index) => CompoundStructureLayerCompoundStructureIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumCompoundStructureLayer => CompoundStructureLayerEntityTable?.NumRows ?? 0;
        public IArray<CompoundStructureLayer> CompoundStructureLayerList { get; }
        public CompoundStructureLayer GetCompoundStructureLayer(int n)
        {
            if (n < 0) return null;
            var r = new CompoundStructureLayer();
            r.Document = Document;
            r.Index = n;
            r.OrderIndex = CompoundStructureLayerOrderIndex.ElementAtOrDefault(n);
            r.Width = CompoundStructureLayerWidth.ElementAtOrDefault(n);
            r.MaterialFunctionAssignment = CompoundStructureLayerMaterialFunctionAssignment.ElementAtOrDefault(n);
            r._Material = new Relation<Vim.Format.ObjectModel.Material>(GetCompoundStructureLayerMaterialIndex(n), GetMaterial);
            r._CompoundStructure = new Relation<Vim.Format.ObjectModel.CompoundStructure>(GetCompoundStructureLayerCompoundStructureIndex(n), GetCompoundStructure);
            return r;
        }
        
        
        // CompoundStructure
        
        public EntityTable CompoundStructureEntityTable { get; }
        
        public IArray<Double> CompoundStructureWidth { get; }
        public Double GetCompoundStructureWidth(int index, Double defaultValue = default) => CompoundStructureWidth?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> CompoundStructureStructuralLayerIndex { get; }
        public int GetCompoundStructureStructuralLayerIndex(int index) => CompoundStructureStructuralLayerIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumCompoundStructure => CompoundStructureEntityTable?.NumRows ?? 0;
        public IArray<CompoundStructure> CompoundStructureList { get; }
        public CompoundStructure GetCompoundStructure(int n)
        {
            if (n < 0) return null;
            var r = new CompoundStructure();
            r.Document = Document;
            r.Index = n;
            r.Width = CompoundStructureWidth.ElementAtOrDefault(n);
            r._StructuralLayer = new Relation<Vim.Format.ObjectModel.CompoundStructureLayer>(GetCompoundStructureStructuralLayerIndex(n), GetCompoundStructureLayer);
            return r;
        }
        
        
        // Node
        
        public EntityTable NodeEntityTable { get; }
        
        public IArray<int> NodeElementIndex { get; }
        public int GetNodeElementIndex(int index) => NodeElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumNode => NodeEntityTable?.NumRows ?? 0;
        public IArray<Node> NodeList { get; }
        public Node GetNode(int n)
        {
            if (n < 0) return null;
            var r = new Node();
            r.Document = Document;
            r.Index = n;
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetNodeElementIndex(n), GetElement);
            return r;
        }
        
        
        // Geometry
        
        public EntityTable GeometryEntityTable { get; }
        
        public IArray<Single> GeometryBox_Min_X { get; }
        public Single GetGeometryBox_Min_X(int index, Single defaultValue = default) => GeometryBox_Min_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> GeometryBox_Min_Y { get; }
        public Single GetGeometryBox_Min_Y(int index, Single defaultValue = default) => GeometryBox_Min_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> GeometryBox_Min_Z { get; }
        public Single GetGeometryBox_Min_Z(int index, Single defaultValue = default) => GeometryBox_Min_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> GeometryBox_Max_X { get; }
        public Single GetGeometryBox_Max_X(int index, Single defaultValue = default) => GeometryBox_Max_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> GeometryBox_Max_Y { get; }
        public Single GetGeometryBox_Max_Y(int index, Single defaultValue = default) => GeometryBox_Max_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Single> GeometryBox_Max_Z { get; }
        public Single GetGeometryBox_Max_Z(int index, Single defaultValue = default) => GeometryBox_Max_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Int32> GeometryVertexCount { get; }
        public Int32 GetGeometryVertexCount(int index, Int32 defaultValue = default) => GeometryVertexCount?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Int32> GeometryFaceCount { get; }
        public Int32 GetGeometryFaceCount(int index, Int32 defaultValue = default) => GeometryFaceCount?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public int NumGeometry => GeometryEntityTable?.NumRows ?? 0;
        public IArray<Geometry> GeometryList { get; }
        public Geometry GetGeometry(int n)
        {
            if (n < 0) return null;
            var r = new Geometry();
            r.Document = Document;
            r.Index = n;
            r.Box_Min_X = GeometryBox_Min_X.ElementAtOrDefault(n);
            r.Box_Min_Y = GeometryBox_Min_Y.ElementAtOrDefault(n);
            r.Box_Min_Z = GeometryBox_Min_Z.ElementAtOrDefault(n);
            r.Box_Max_X = GeometryBox_Max_X.ElementAtOrDefault(n);
            r.Box_Max_Y = GeometryBox_Max_Y.ElementAtOrDefault(n);
            r.Box_Max_Z = GeometryBox_Max_Z.ElementAtOrDefault(n);
            r.VertexCount = GeometryVertexCount.ElementAtOrDefault(n);
            r.FaceCount = GeometryFaceCount.ElementAtOrDefault(n);
            return r;
        }
        
        
        // Shape
        
        public EntityTable ShapeEntityTable { get; }
        
        public IArray<int> ShapeElementIndex { get; }
        public int GetShapeElementIndex(int index) => ShapeElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumShape => ShapeEntityTable?.NumRows ?? 0;
        public IArray<Shape> ShapeList { get; }
        public Shape GetShape(int n)
        {
            if (n < 0) return null;
            var r = new Shape();
            r.Document = Document;
            r.Index = n;
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetShapeElementIndex(n), GetElement);
            return r;
        }
        
        
        // ShapeCollection
        
        public EntityTable ShapeCollectionEntityTable { get; }
        
        public IArray<int> ShapeCollectionElementIndex { get; }
        public int GetShapeCollectionElementIndex(int index) => ShapeCollectionElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumShapeCollection => ShapeCollectionEntityTable?.NumRows ?? 0;
        public IArray<ShapeCollection> ShapeCollectionList { get; }
        public ShapeCollection GetShapeCollection(int n)
        {
            if (n < 0) return null;
            var r = new ShapeCollection();
            r.Document = Document;
            r.Index = n;
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetShapeCollectionElementIndex(n), GetElement);
            return r;
        }
        
        
        // ShapeInShapeCollection
        
        public EntityTable ShapeInShapeCollectionEntityTable { get; }
        
        public IArray<int> ShapeInShapeCollectionShapeIndex { get; }
        public int GetShapeInShapeCollectionShapeIndex(int index) => ShapeInShapeCollectionShapeIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ShapeInShapeCollectionShapeCollectionIndex { get; }
        public int GetShapeInShapeCollectionShapeCollectionIndex(int index) => ShapeInShapeCollectionShapeCollectionIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumShapeInShapeCollection => ShapeInShapeCollectionEntityTable?.NumRows ?? 0;
        public IArray<ShapeInShapeCollection> ShapeInShapeCollectionList { get; }
        public ShapeInShapeCollection GetShapeInShapeCollection(int n)
        {
            if (n < 0) return null;
            var r = new ShapeInShapeCollection();
            r.Document = Document;
            r.Index = n;
            r._Shape = new Relation<Vim.Format.ObjectModel.Shape>(GetShapeInShapeCollectionShapeIndex(n), GetShape);
            r._ShapeCollection = new Relation<Vim.Format.ObjectModel.ShapeCollection>(GetShapeInShapeCollectionShapeCollectionIndex(n), GetShapeCollection);
            return r;
        }
        
        
        // System
        
        public EntityTable SystemEntityTable { get; }
        
        public IArray<Int32> SystemSystemType { get; }
        public Int32 GetSystemSystemType(int index, Int32 defaultValue = default) => SystemSystemType?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> SystemFamilyTypeIndex { get; }
        public int GetSystemFamilyTypeIndex(int index) => SystemFamilyTypeIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> SystemElementIndex { get; }
        public int GetSystemElementIndex(int index) => SystemElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumSystem => SystemEntityTable?.NumRows ?? 0;
        public IArray<System> SystemList { get; }
        public System GetSystem(int n)
        {
            if (n < 0) return null;
            var r = new System();
            r.Document = Document;
            r.Index = n;
            r.SystemType = SystemSystemType.ElementAtOrDefault(n);
            r._FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>(GetSystemFamilyTypeIndex(n), GetFamilyType);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetSystemElementIndex(n), GetElement);
            return r;
        }
        
        
        // ElementInSystem
        
        public EntityTable ElementInSystemEntityTable { get; }
        
        public IArray<Int32> ElementInSystemRoles { get; }
        public Int32 GetElementInSystemRoles(int index, Int32 defaultValue = default) => ElementInSystemRoles?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> ElementInSystemSystemIndex { get; }
        public int GetElementInSystemSystemIndex(int index) => ElementInSystemSystemIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ElementInSystemElementIndex { get; }
        public int GetElementInSystemElementIndex(int index) => ElementInSystemElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumElementInSystem => ElementInSystemEntityTable?.NumRows ?? 0;
        public IArray<ElementInSystem> ElementInSystemList { get; }
        public ElementInSystem GetElementInSystem(int n)
        {
            if (n < 0) return null;
            var r = new ElementInSystem();
            r.Document = Document;
            r.Index = n;
            r.Roles = ElementInSystemRoles.ElementAtOrDefault(n);
            r._System = new Relation<Vim.Format.ObjectModel.System>(GetElementInSystemSystemIndex(n), GetSystem);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementInSystemElementIndex(n), GetElement);
            return r;
        }
        
        
        // Warning
        
        public EntityTable WarningEntityTable { get; }
        
        public IArray<String> WarningGuid { get; }
        public String GetWarningGuid(int index, String defaultValue = "") => WarningGuid?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> WarningSeverity { get; }
        public String GetWarningSeverity(int index, String defaultValue = "") => WarningSeverity?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> WarningDescription { get; }
        public String GetWarningDescription(int index, String defaultValue = "") => WarningDescription?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> WarningBimDocumentIndex { get; }
        public int GetWarningBimDocumentIndex(int index) => WarningBimDocumentIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumWarning => WarningEntityTable?.NumRows ?? 0;
        public IArray<Warning> WarningList { get; }
        public Warning GetWarning(int n)
        {
            if (n < 0) return null;
            var r = new Warning();
            r.Document = Document;
            r.Index = n;
            r.Guid = WarningGuid.ElementAtOrDefault(n);
            r.Severity = WarningSeverity.ElementAtOrDefault(n);
            r.Description = WarningDescription.ElementAtOrDefault(n);
            r._BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>(GetWarningBimDocumentIndex(n), GetBimDocument);
            return r;
        }
        
        
        // ElementInWarning
        
        public EntityTable ElementInWarningEntityTable { get; }
        
        public IArray<int> ElementInWarningWarningIndex { get; }
        public int GetElementInWarningWarningIndex(int index) => ElementInWarningWarningIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ElementInWarningElementIndex { get; }
        public int GetElementInWarningElementIndex(int index) => ElementInWarningElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumElementInWarning => ElementInWarningEntityTable?.NumRows ?? 0;
        public IArray<ElementInWarning> ElementInWarningList { get; }
        public ElementInWarning GetElementInWarning(int n)
        {
            if (n < 0) return null;
            var r = new ElementInWarning();
            r.Document = Document;
            r.Index = n;
            r._Warning = new Relation<Vim.Format.ObjectModel.Warning>(GetElementInWarningWarningIndex(n), GetWarning);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementInWarningElementIndex(n), GetElement);
            return r;
        }
        
        
        // BasePoint
        
        public EntityTable BasePointEntityTable { get; }
        
        public IArray<Boolean> BasePointIsSurveyPoint { get; }
        public Boolean GetBasePointIsSurveyPoint(int index, Boolean defaultValue = default) => BasePointIsSurveyPoint?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> BasePointPosition_X { get; }
        public Double GetBasePointPosition_X(int index, Double defaultValue = default) => BasePointPosition_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> BasePointPosition_Y { get; }
        public Double GetBasePointPosition_Y(int index, Double defaultValue = default) => BasePointPosition_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> BasePointPosition_Z { get; }
        public Double GetBasePointPosition_Z(int index, Double defaultValue = default) => BasePointPosition_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> BasePointSharedPosition_X { get; }
        public Double GetBasePointSharedPosition_X(int index, Double defaultValue = default) => BasePointSharedPosition_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> BasePointSharedPosition_Y { get; }
        public Double GetBasePointSharedPosition_Y(int index, Double defaultValue = default) => BasePointSharedPosition_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> BasePointSharedPosition_Z { get; }
        public Double GetBasePointSharedPosition_Z(int index, Double defaultValue = default) => BasePointSharedPosition_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> BasePointElementIndex { get; }
        public int GetBasePointElementIndex(int index) => BasePointElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumBasePoint => BasePointEntityTable?.NumRows ?? 0;
        public IArray<BasePoint> BasePointList { get; }
        public BasePoint GetBasePoint(int n)
        {
            if (n < 0) return null;
            var r = new BasePoint();
            r.Document = Document;
            r.Index = n;
            r.IsSurveyPoint = BasePointIsSurveyPoint.ElementAtOrDefault(n);
            r.Position_X = BasePointPosition_X.ElementAtOrDefault(n);
            r.Position_Y = BasePointPosition_Y.ElementAtOrDefault(n);
            r.Position_Z = BasePointPosition_Z.ElementAtOrDefault(n);
            r.SharedPosition_X = BasePointSharedPosition_X.ElementAtOrDefault(n);
            r.SharedPosition_Y = BasePointSharedPosition_Y.ElementAtOrDefault(n);
            r.SharedPosition_Z = BasePointSharedPosition_Z.ElementAtOrDefault(n);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetBasePointElementIndex(n), GetElement);
            return r;
        }
        
        
        // PhaseFilter
        
        public EntityTable PhaseFilterEntityTable { get; }
        
        public IArray<Int32> PhaseFilterNew { get; }
        public Int32 GetPhaseFilterNew(int index, Int32 defaultValue = default) => PhaseFilterNew?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Int32> PhaseFilterExisting { get; }
        public Int32 GetPhaseFilterExisting(int index, Int32 defaultValue = default) => PhaseFilterExisting?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Int32> PhaseFilterDemolished { get; }
        public Int32 GetPhaseFilterDemolished(int index, Int32 defaultValue = default) => PhaseFilterDemolished?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Int32> PhaseFilterTemporary { get; }
        public Int32 GetPhaseFilterTemporary(int index, Int32 defaultValue = default) => PhaseFilterTemporary?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> PhaseFilterElementIndex { get; }
        public int GetPhaseFilterElementIndex(int index) => PhaseFilterElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumPhaseFilter => PhaseFilterEntityTable?.NumRows ?? 0;
        public IArray<PhaseFilter> PhaseFilterList { get; }
        public PhaseFilter GetPhaseFilter(int n)
        {
            if (n < 0) return null;
            var r = new PhaseFilter();
            r.Document = Document;
            r.Index = n;
            r.New = PhaseFilterNew.ElementAtOrDefault(n);
            r.Existing = PhaseFilterExisting.ElementAtOrDefault(n);
            r.Demolished = PhaseFilterDemolished.ElementAtOrDefault(n);
            r.Temporary = PhaseFilterTemporary.ElementAtOrDefault(n);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetPhaseFilterElementIndex(n), GetElement);
            return r;
        }
        
        
        // Grid
        
        public EntityTable GridEntityTable { get; }
        
        public IArray<Double> GridStartPoint_X { get; }
        public Double GetGridStartPoint_X(int index, Double defaultValue = default) => GridStartPoint_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> GridStartPoint_Y { get; }
        public Double GetGridStartPoint_Y(int index, Double defaultValue = default) => GridStartPoint_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> GridStartPoint_Z { get; }
        public Double GetGridStartPoint_Z(int index, Double defaultValue = default) => GridStartPoint_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> GridEndPoint_X { get; }
        public Double GetGridEndPoint_X(int index, Double defaultValue = default) => GridEndPoint_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> GridEndPoint_Y { get; }
        public Double GetGridEndPoint_Y(int index, Double defaultValue = default) => GridEndPoint_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> GridEndPoint_Z { get; }
        public Double GetGridEndPoint_Z(int index, Double defaultValue = default) => GridEndPoint_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> GridIsCurved { get; }
        public Boolean GetGridIsCurved(int index, Boolean defaultValue = default) => GridIsCurved?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> GridExtents_Min_X { get; }
        public Double GetGridExtents_Min_X(int index, Double defaultValue = default) => GridExtents_Min_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> GridExtents_Min_Y { get; }
        public Double GetGridExtents_Min_Y(int index, Double defaultValue = default) => GridExtents_Min_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> GridExtents_Min_Z { get; }
        public Double GetGridExtents_Min_Z(int index, Double defaultValue = default) => GridExtents_Min_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> GridExtents_Max_X { get; }
        public Double GetGridExtents_Max_X(int index, Double defaultValue = default) => GridExtents_Max_X?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> GridExtents_Max_Y { get; }
        public Double GetGridExtents_Max_Y(int index, Double defaultValue = default) => GridExtents_Max_Y?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> GridExtents_Max_Z { get; }
        public Double GetGridExtents_Max_Z(int index, Double defaultValue = default) => GridExtents_Max_Z?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> GridFamilyTypeIndex { get; }
        public int GetGridFamilyTypeIndex(int index) => GridFamilyTypeIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> GridElementIndex { get; }
        public int GetGridElementIndex(int index) => GridElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumGrid => GridEntityTable?.NumRows ?? 0;
        public IArray<Grid> GridList { get; }
        public Grid GetGrid(int n)
        {
            if (n < 0) return null;
            var r = new Grid();
            r.Document = Document;
            r.Index = n;
            r.StartPoint_X = GridStartPoint_X.ElementAtOrDefault(n);
            r.StartPoint_Y = GridStartPoint_Y.ElementAtOrDefault(n);
            r.StartPoint_Z = GridStartPoint_Z.ElementAtOrDefault(n);
            r.EndPoint_X = GridEndPoint_X.ElementAtOrDefault(n);
            r.EndPoint_Y = GridEndPoint_Y.ElementAtOrDefault(n);
            r.EndPoint_Z = GridEndPoint_Z.ElementAtOrDefault(n);
            r.IsCurved = GridIsCurved.ElementAtOrDefault(n);
            r.Extents_Min_X = GridExtents_Min_X.ElementAtOrDefault(n);
            r.Extents_Min_Y = GridExtents_Min_Y.ElementAtOrDefault(n);
            r.Extents_Min_Z = GridExtents_Min_Z.ElementAtOrDefault(n);
            r.Extents_Max_X = GridExtents_Max_X.ElementAtOrDefault(n);
            r.Extents_Max_Y = GridExtents_Max_Y.ElementAtOrDefault(n);
            r.Extents_Max_Z = GridExtents_Max_Z.ElementAtOrDefault(n);
            r._FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>(GetGridFamilyTypeIndex(n), GetFamilyType);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetGridElementIndex(n), GetElement);
            return r;
        }
        
        
        // Area
        
        public EntityTable AreaEntityTable { get; }
        
        public IArray<Double> AreaValue { get; }
        public Double GetAreaValue(int index, Double defaultValue = default) => AreaValue?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> AreaPerimeter { get; }
        public Double GetAreaPerimeter(int index, Double defaultValue = default) => AreaPerimeter?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> AreaNumber { get; }
        public String GetAreaNumber(int index, String defaultValue = "") => AreaNumber?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Boolean> AreaIsGrossInterior { get; }
        public Boolean GetAreaIsGrossInterior(int index, Boolean defaultValue = default) => AreaIsGrossInterior?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> AreaAreaSchemeIndex { get; }
        public int GetAreaAreaSchemeIndex(int index) => AreaAreaSchemeIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> AreaElementIndex { get; }
        public int GetAreaElementIndex(int index) => AreaElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumArea => AreaEntityTable?.NumRows ?? 0;
        public IArray<Area> AreaList { get; }
        public Area GetArea(int n)
        {
            if (n < 0) return null;
            var r = new Area();
            r.Document = Document;
            r.Index = n;
            r.Value = AreaValue.ElementAtOrDefault(n);
            r.Perimeter = AreaPerimeter.ElementAtOrDefault(n);
            r.Number = AreaNumber.ElementAtOrDefault(n);
            r.IsGrossInterior = AreaIsGrossInterior.ElementAtOrDefault(n);
            r._AreaScheme = new Relation<Vim.Format.ObjectModel.AreaScheme>(GetAreaAreaSchemeIndex(n), GetAreaScheme);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetAreaElementIndex(n), GetElement);
            return r;
        }
        
        
        // AreaScheme
        
        public EntityTable AreaSchemeEntityTable { get; }
        
        public IArray<Boolean> AreaSchemeIsGrossBuildingArea { get; }
        public Boolean GetAreaSchemeIsGrossBuildingArea(int index, Boolean defaultValue = default) => AreaSchemeIsGrossBuildingArea?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> AreaSchemeElementIndex { get; }
        public int GetAreaSchemeElementIndex(int index) => AreaSchemeElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumAreaScheme => AreaSchemeEntityTable?.NumRows ?? 0;
        public IArray<AreaScheme> AreaSchemeList { get; }
        public AreaScheme GetAreaScheme(int n)
        {
            if (n < 0) return null;
            var r = new AreaScheme();
            r.Document = Document;
            r.Index = n;
            r.IsGrossBuildingArea = AreaSchemeIsGrossBuildingArea.ElementAtOrDefault(n);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetAreaSchemeElementIndex(n), GetElement);
            return r;
        }
        
        
        // Schedule
        
        public EntityTable ScheduleEntityTable { get; }
        
        public IArray<int> ScheduleElementIndex { get; }
        public int GetScheduleElementIndex(int index) => ScheduleElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumSchedule => ScheduleEntityTable?.NumRows ?? 0;
        public IArray<Schedule> ScheduleList { get; }
        public Schedule GetSchedule(int n)
        {
            if (n < 0) return null;
            var r = new Schedule();
            r.Document = Document;
            r.Index = n;
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetScheduleElementIndex(n), GetElement);
            return r;
        }
        
        
        // ScheduleColumn
        
        public EntityTable ScheduleColumnEntityTable { get; }
        
        public IArray<String> ScheduleColumnName { get; }
        public String GetScheduleColumnName(int index, String defaultValue = "") => ScheduleColumnName?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Int32> ScheduleColumnColumnIndex { get; }
        public Int32 GetScheduleColumnColumnIndex(int index, Int32 defaultValue = default) => ScheduleColumnColumnIndex?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> ScheduleColumnScheduleIndex { get; }
        public int GetScheduleColumnScheduleIndex(int index) => ScheduleColumnScheduleIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumScheduleColumn => ScheduleColumnEntityTable?.NumRows ?? 0;
        public IArray<ScheduleColumn> ScheduleColumnList { get; }
        public ScheduleColumn GetScheduleColumn(int n)
        {
            if (n < 0) return null;
            var r = new ScheduleColumn();
            r.Document = Document;
            r.Index = n;
            r.Name = ScheduleColumnName.ElementAtOrDefault(n);
            r.ColumnIndex = ScheduleColumnColumnIndex.ElementAtOrDefault(n);
            r._Schedule = new Relation<Vim.Format.ObjectModel.Schedule>(GetScheduleColumnScheduleIndex(n), GetSchedule);
            return r;
        }
        
        
        // ScheduleCell
        
        public EntityTable ScheduleCellEntityTable { get; }
        
        public IArray<String> ScheduleCellValue { get; }
        public String GetScheduleCellValue(int index, String defaultValue = "") => ScheduleCellValue?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Int32> ScheduleCellRowIndex { get; }
        public Int32 GetScheduleCellRowIndex(int index, Int32 defaultValue = default) => ScheduleCellRowIndex?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> ScheduleCellScheduleColumnIndex { get; }
        public int GetScheduleCellScheduleColumnIndex(int index) => ScheduleCellScheduleColumnIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumScheduleCell => ScheduleCellEntityTable?.NumRows ?? 0;
        public IArray<ScheduleCell> ScheduleCellList { get; }
        public ScheduleCell GetScheduleCell(int n)
        {
            if (n < 0) return null;
            var r = new ScheduleCell();
            r.Document = Document;
            r.Index = n;
            r.Value = ScheduleCellValue.ElementAtOrDefault(n);
            r.RowIndex = ScheduleCellRowIndex.ElementAtOrDefault(n);
            r._ScheduleColumn = new Relation<Vim.Format.ObjectModel.ScheduleColumn>(GetScheduleCellScheduleColumnIndex(n), GetScheduleColumn);
            return r;
        }
        
        
        // ViewSheetSet
        
        public EntityTable ViewSheetSetEntityTable { get; }
        
        public IArray<int> ViewSheetSetElementIndex { get; }
        public int GetViewSheetSetElementIndex(int index) => ViewSheetSetElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumViewSheetSet => ViewSheetSetEntityTable?.NumRows ?? 0;
        public IArray<ViewSheetSet> ViewSheetSetList { get; }
        public ViewSheetSet GetViewSheetSet(int n)
        {
            if (n < 0) return null;
            var r = new ViewSheetSet();
            r.Document = Document;
            r.Index = n;
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetViewSheetSetElementIndex(n), GetElement);
            return r;
        }
        
        
        // ViewSheet
        
        public EntityTable ViewSheetEntityTable { get; }
        
        public IArray<int> ViewSheetFamilyTypeIndex { get; }
        public int GetViewSheetFamilyTypeIndex(int index) => ViewSheetFamilyTypeIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ViewSheetElementIndex { get; }
        public int GetViewSheetElementIndex(int index) => ViewSheetElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumViewSheet => ViewSheetEntityTable?.NumRows ?? 0;
        public IArray<ViewSheet> ViewSheetList { get; }
        public ViewSheet GetViewSheet(int n)
        {
            if (n < 0) return null;
            var r = new ViewSheet();
            r.Document = Document;
            r.Index = n;
            r._FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>(GetViewSheetFamilyTypeIndex(n), GetFamilyType);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetViewSheetElementIndex(n), GetElement);
            return r;
        }
        
        
        // ViewSheetInViewSheetSet
        
        public EntityTable ViewSheetInViewSheetSetEntityTable { get; }
        
        public IArray<int> ViewSheetInViewSheetSetViewSheetIndex { get; }
        public int GetViewSheetInViewSheetSetViewSheetIndex(int index) => ViewSheetInViewSheetSetViewSheetIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ViewSheetInViewSheetSetViewSheetSetIndex { get; }
        public int GetViewSheetInViewSheetSetViewSheetSetIndex(int index) => ViewSheetInViewSheetSetViewSheetSetIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumViewSheetInViewSheetSet => ViewSheetInViewSheetSetEntityTable?.NumRows ?? 0;
        public IArray<ViewSheetInViewSheetSet> ViewSheetInViewSheetSetList { get; }
        public ViewSheetInViewSheetSet GetViewSheetInViewSheetSet(int n)
        {
            if (n < 0) return null;
            var r = new ViewSheetInViewSheetSet();
            r.Document = Document;
            r.Index = n;
            r._ViewSheet = new Relation<Vim.Format.ObjectModel.ViewSheet>(GetViewSheetInViewSheetSetViewSheetIndex(n), GetViewSheet);
            r._ViewSheetSet = new Relation<Vim.Format.ObjectModel.ViewSheetSet>(GetViewSheetInViewSheetSetViewSheetSetIndex(n), GetViewSheetSet);
            return r;
        }
        
        
        // ViewInViewSheetSet
        
        public EntityTable ViewInViewSheetSetEntityTable { get; }
        
        public IArray<int> ViewInViewSheetSetViewIndex { get; }
        public int GetViewInViewSheetSetViewIndex(int index) => ViewInViewSheetSetViewIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ViewInViewSheetSetViewSheetSetIndex { get; }
        public int GetViewInViewSheetSetViewSheetSetIndex(int index) => ViewInViewSheetSetViewSheetSetIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumViewInViewSheetSet => ViewInViewSheetSetEntityTable?.NumRows ?? 0;
        public IArray<ViewInViewSheetSet> ViewInViewSheetSetList { get; }
        public ViewInViewSheetSet GetViewInViewSheetSet(int n)
        {
            if (n < 0) return null;
            var r = new ViewInViewSheetSet();
            r.Document = Document;
            r.Index = n;
            r._View = new Relation<Vim.Format.ObjectModel.View>(GetViewInViewSheetSetViewIndex(n), GetView);
            r._ViewSheetSet = new Relation<Vim.Format.ObjectModel.ViewSheetSet>(GetViewInViewSheetSetViewSheetSetIndex(n), GetViewSheetSet);
            return r;
        }
        
        
        // ViewInViewSheet
        
        public EntityTable ViewInViewSheetEntityTable { get; }
        
        public IArray<int> ViewInViewSheetViewIndex { get; }
        public int GetViewInViewSheetViewIndex(int index) => ViewInViewSheetViewIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> ViewInViewSheetViewSheetIndex { get; }
        public int GetViewInViewSheetViewSheetIndex(int index) => ViewInViewSheetViewSheetIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumViewInViewSheet => ViewInViewSheetEntityTable?.NumRows ?? 0;
        public IArray<ViewInViewSheet> ViewInViewSheetList { get; }
        public ViewInViewSheet GetViewInViewSheet(int n)
        {
            if (n < 0) return null;
            var r = new ViewInViewSheet();
            r.Document = Document;
            r.Index = n;
            r._View = new Relation<Vim.Format.ObjectModel.View>(GetViewInViewSheetViewIndex(n), GetView);
            r._ViewSheet = new Relation<Vim.Format.ObjectModel.ViewSheet>(GetViewInViewSheetViewSheetIndex(n), GetViewSheet);
            return r;
        }
        
        
        // Site
        
        public EntityTable SiteEntityTable { get; }
        
        public IArray<Double> SiteLatitude { get; }
        public Double GetSiteLatitude(int index, Double defaultValue = default) => SiteLatitude?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> SiteLongitude { get; }
        public Double GetSiteLongitude(int index, Double defaultValue = default) => SiteLongitude?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> SiteAddress { get; }
        public String GetSiteAddress(int index, String defaultValue = "") => SiteAddress?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> SiteElevation { get; }
        public Double GetSiteElevation(int index, Double defaultValue = default) => SiteElevation?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> SiteNumber { get; }
        public String GetSiteNumber(int index, String defaultValue = "") => SiteNumber?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> SiteElementIndex { get; }
        public int GetSiteElementIndex(int index) => SiteElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumSite => SiteEntityTable?.NumRows ?? 0;
        public IArray<Site> SiteList { get; }
        public Site GetSite(int n)
        {
            if (n < 0) return null;
            var r = new Site();
            r.Document = Document;
            r.Index = n;
            r.Latitude = SiteLatitude.ElementAtOrDefault(n);
            r.Longitude = SiteLongitude.ElementAtOrDefault(n);
            r.Address = SiteAddress.ElementAtOrDefault(n);
            r.Elevation = SiteElevation.ElementAtOrDefault(n);
            r.Number = SiteNumber.ElementAtOrDefault(n);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetSiteElementIndex(n), GetElement);
            return r;
        }
        
        
        // Building
        
        public EntityTable BuildingEntityTable { get; }
        
        public IArray<Double> BuildingElevation { get; }
        public Double GetBuildingElevation(int index, Double defaultValue = default) => BuildingElevation?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<Double> BuildingTerrainElevation { get; }
        public Double GetBuildingTerrainElevation(int index, Double defaultValue = default) => BuildingTerrainElevation?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<String> BuildingAddress { get; }
        public String GetBuildingAddress(int index, String defaultValue = "") => BuildingAddress?.ElementAtOrDefault(index, defaultValue) ?? defaultValue;
        public IArray<int> BuildingSiteIndex { get; }
        public int GetBuildingSiteIndex(int index) => BuildingSiteIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public IArray<int> BuildingElementIndex { get; }
        public int GetBuildingElementIndex(int index) => BuildingElementIndex?.ElementAtOrDefault(index, EntityRelation.None) ?? EntityRelation.None;
        public int NumBuilding => BuildingEntityTable?.NumRows ?? 0;
        public IArray<Building> BuildingList { get; }
        public Building GetBuilding(int n)
        {
            if (n < 0) return null;
            var r = new Building();
            r.Document = Document;
            r.Index = n;
            r.Elevation = BuildingElevation.ElementAtOrDefault(n);
            r.TerrainElevation = BuildingTerrainElevation.ElementAtOrDefault(n);
            r.Address = BuildingAddress.ElementAtOrDefault(n);
            r._Site = new Relation<Vim.Format.ObjectModel.Site>(GetBuildingSiteIndex(n), GetSite);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetBuildingElementIndex(n), GetElement);
            return r;
        }
        
        // All entity collections
        public Dictionary<string, IEnumerable<Entity>> AllEntities => new Dictionary<string, IEnumerable<Entity>>() {
            {"Vim.Asset", AssetList.ToEnumerable()},
            {"Vim.DisplayUnit", DisplayUnitList.ToEnumerable()},
            {"Vim.ParameterDescriptor", ParameterDescriptorList.ToEnumerable()},
            {"Vim.Parameter", ParameterList.ToEnumerable()},
            {"Vim.Element", ElementList.ToEnumerable()},
            {"Vim.Workset", WorksetList.ToEnumerable()},
            {"Vim.AssemblyInstance", AssemblyInstanceList.ToEnumerable()},
            {"Vim.Group", GroupList.ToEnumerable()},
            {"Vim.DesignOption", DesignOptionList.ToEnumerable()},
            {"Vim.Level", LevelList.ToEnumerable()},
            {"Vim.Phase", PhaseList.ToEnumerable()},
            {"Vim.Room", RoomList.ToEnumerable()},
            {"Vim.BimDocument", BimDocumentList.ToEnumerable()},
            {"Vim.DisplayUnitInBimDocument", DisplayUnitInBimDocumentList.ToEnumerable()},
            {"Vim.PhaseOrderInBimDocument", PhaseOrderInBimDocumentList.ToEnumerable()},
            {"Vim.Category", CategoryList.ToEnumerable()},
            {"Vim.Family", FamilyList.ToEnumerable()},
            {"Vim.FamilyType", FamilyTypeList.ToEnumerable()},
            {"Vim.FamilyInstance", FamilyInstanceList.ToEnumerable()},
            {"Vim.View", ViewList.ToEnumerable()},
            {"Vim.ElementInView", ElementInViewList.ToEnumerable()},
            {"Vim.ShapeInView", ShapeInViewList.ToEnumerable()},
            {"Vim.AssetInView", AssetInViewList.ToEnumerable()},
            {"Vim.AssetInViewSheet", AssetInViewSheetList.ToEnumerable()},
            {"Vim.LevelInView", LevelInViewList.ToEnumerable()},
            {"Vim.Camera", CameraList.ToEnumerable()},
            {"Vim.Material", MaterialList.ToEnumerable()},
            {"Vim.MaterialInElement", MaterialInElementList.ToEnumerable()},
            {"Vim.CompoundStructureLayer", CompoundStructureLayerList.ToEnumerable()},
            {"Vim.CompoundStructure", CompoundStructureList.ToEnumerable()},
            {"Vim.Node", NodeList.ToEnumerable()},
            {"Vim.Geometry", GeometryList.ToEnumerable()},
            {"Vim.Shape", ShapeList.ToEnumerable()},
            {"Vim.ShapeCollection", ShapeCollectionList.ToEnumerable()},
            {"Vim.ShapeInShapeCollection", ShapeInShapeCollectionList.ToEnumerable()},
            {"Vim.System", SystemList.ToEnumerable()},
            {"Vim.ElementInSystem", ElementInSystemList.ToEnumerable()},
            {"Vim.Warning", WarningList.ToEnumerable()},
            {"Vim.ElementInWarning", ElementInWarningList.ToEnumerable()},
            {"Vim.BasePoint", BasePointList.ToEnumerable()},
            {"Vim.PhaseFilter", PhaseFilterList.ToEnumerable()},
            {"Vim.Grid", GridList.ToEnumerable()},
            {"Vim.Area", AreaList.ToEnumerable()},
            {"Vim.AreaScheme", AreaSchemeList.ToEnumerable()},
            {"Vim.Schedule", ScheduleList.ToEnumerable()},
            {"Vim.ScheduleColumn", ScheduleColumnList.ToEnumerable()},
            {"Vim.ScheduleCell", ScheduleCellList.ToEnumerable()},
            {"Vim.ViewSheetSet", ViewSheetSetList.ToEnumerable()},
            {"Vim.ViewSheet", ViewSheetList.ToEnumerable()},
            {"Vim.ViewSheetInViewSheetSet", ViewSheetInViewSheetSetList.ToEnumerable()},
            {"Vim.ViewInViewSheetSet", ViewInViewSheetSetList.ToEnumerable()},
            {"Vim.ViewInViewSheet", ViewInViewSheetList.ToEnumerable()},
            {"Vim.Site", SiteList.ToEnumerable()},
            {"Vim.Building", BuildingList.ToEnumerable()},
        };
        
        // Entity types from table names
        public Dictionary<string, Type> EntityTypes => new Dictionary<string, Type>() {
            {"Vim.Asset", typeof(Asset)},
            {"Vim.DisplayUnit", typeof(DisplayUnit)},
            {"Vim.ParameterDescriptor", typeof(ParameterDescriptor)},
            {"Vim.Parameter", typeof(Parameter)},
            {"Vim.Element", typeof(Element)},
            {"Vim.Workset", typeof(Workset)},
            {"Vim.AssemblyInstance", typeof(AssemblyInstance)},
            {"Vim.Group", typeof(Group)},
            {"Vim.DesignOption", typeof(DesignOption)},
            {"Vim.Level", typeof(Level)},
            {"Vim.Phase", typeof(Phase)},
            {"Vim.Room", typeof(Room)},
            {"Vim.BimDocument", typeof(BimDocument)},
            {"Vim.DisplayUnitInBimDocument", typeof(DisplayUnitInBimDocument)},
            {"Vim.PhaseOrderInBimDocument", typeof(PhaseOrderInBimDocument)},
            {"Vim.Category", typeof(Category)},
            {"Vim.Family", typeof(Family)},
            {"Vim.FamilyType", typeof(FamilyType)},
            {"Vim.FamilyInstance", typeof(FamilyInstance)},
            {"Vim.View", typeof(View)},
            {"Vim.ElementInView", typeof(ElementInView)},
            {"Vim.ShapeInView", typeof(ShapeInView)},
            {"Vim.AssetInView", typeof(AssetInView)},
            {"Vim.AssetInViewSheet", typeof(AssetInViewSheet)},
            {"Vim.LevelInView", typeof(LevelInView)},
            {"Vim.Camera", typeof(Camera)},
            {"Vim.Material", typeof(Material)},
            {"Vim.MaterialInElement", typeof(MaterialInElement)},
            {"Vim.CompoundStructureLayer", typeof(CompoundStructureLayer)},
            {"Vim.CompoundStructure", typeof(CompoundStructure)},
            {"Vim.Node", typeof(Node)},
            {"Vim.Geometry", typeof(Geometry)},
            {"Vim.Shape", typeof(Shape)},
            {"Vim.ShapeCollection", typeof(ShapeCollection)},
            {"Vim.ShapeInShapeCollection", typeof(ShapeInShapeCollection)},
            {"Vim.System", typeof(System)},
            {"Vim.ElementInSystem", typeof(ElementInSystem)},
            {"Vim.Warning", typeof(Warning)},
            {"Vim.ElementInWarning", typeof(ElementInWarning)},
            {"Vim.BasePoint", typeof(BasePoint)},
            {"Vim.PhaseFilter", typeof(PhaseFilter)},
            {"Vim.Grid", typeof(Grid)},
            {"Vim.Area", typeof(Area)},
            {"Vim.AreaScheme", typeof(AreaScheme)},
            {"Vim.Schedule", typeof(Schedule)},
            {"Vim.ScheduleColumn", typeof(ScheduleColumn)},
            {"Vim.ScheduleCell", typeof(ScheduleCell)},
            {"Vim.ViewSheetSet", typeof(ViewSheetSet)},
            {"Vim.ViewSheet", typeof(ViewSheet)},
            {"Vim.ViewSheetInViewSheetSet", typeof(ViewSheetInViewSheetSet)},
            {"Vim.ViewInViewSheetSet", typeof(ViewInViewSheetSet)},
            {"Vim.ViewInViewSheet", typeof(ViewInViewSheet)},
            {"Vim.Site", typeof(Site)},
            {"Vim.Building", typeof(Building)},
        };
        public DocumentModel(Document d, bool inParallel = true)
        {
            Document = d;
            
            // Initialize entity tables
            AssetEntityTable = Document.GetTable("Vim.Asset");
            DisplayUnitEntityTable = Document.GetTable("Vim.DisplayUnit");
            ParameterDescriptorEntityTable = Document.GetTable("Vim.ParameterDescriptor");
            ParameterEntityTable = Document.GetTable("Vim.Parameter");
            ElementEntityTable = Document.GetTable("Vim.Element");
            WorksetEntityTable = Document.GetTable("Vim.Workset");
            AssemblyInstanceEntityTable = Document.GetTable("Vim.AssemblyInstance");
            GroupEntityTable = Document.GetTable("Vim.Group");
            DesignOptionEntityTable = Document.GetTable("Vim.DesignOption");
            LevelEntityTable = Document.GetTable("Vim.Level");
            PhaseEntityTable = Document.GetTable("Vim.Phase");
            RoomEntityTable = Document.GetTable("Vim.Room");
            BimDocumentEntityTable = Document.GetTable("Vim.BimDocument");
            DisplayUnitInBimDocumentEntityTable = Document.GetTable("Vim.DisplayUnitInBimDocument");
            PhaseOrderInBimDocumentEntityTable = Document.GetTable("Vim.PhaseOrderInBimDocument");
            CategoryEntityTable = Document.GetTable("Vim.Category");
            FamilyEntityTable = Document.GetTable("Vim.Family");
            FamilyTypeEntityTable = Document.GetTable("Vim.FamilyType");
            FamilyInstanceEntityTable = Document.GetTable("Vim.FamilyInstance");
            ViewEntityTable = Document.GetTable("Vim.View");
            ElementInViewEntityTable = Document.GetTable("Vim.ElementInView");
            ShapeInViewEntityTable = Document.GetTable("Vim.ShapeInView");
            AssetInViewEntityTable = Document.GetTable("Vim.AssetInView");
            AssetInViewSheetEntityTable = Document.GetTable("Vim.AssetInViewSheet");
            LevelInViewEntityTable = Document.GetTable("Vim.LevelInView");
            CameraEntityTable = Document.GetTable("Vim.Camera");
            MaterialEntityTable = Document.GetTable("Vim.Material");
            MaterialInElementEntityTable = Document.GetTable("Vim.MaterialInElement");
            CompoundStructureLayerEntityTable = Document.GetTable("Vim.CompoundStructureLayer");
            CompoundStructureEntityTable = Document.GetTable("Vim.CompoundStructure");
            NodeEntityTable = Document.GetTable("Vim.Node");
            GeometryEntityTable = Document.GetTable("Vim.Geometry");
            ShapeEntityTable = Document.GetTable("Vim.Shape");
            ShapeCollectionEntityTable = Document.GetTable("Vim.ShapeCollection");
            ShapeInShapeCollectionEntityTable = Document.GetTable("Vim.ShapeInShapeCollection");
            SystemEntityTable = Document.GetTable("Vim.System");
            ElementInSystemEntityTable = Document.GetTable("Vim.ElementInSystem");
            WarningEntityTable = Document.GetTable("Vim.Warning");
            ElementInWarningEntityTable = Document.GetTable("Vim.ElementInWarning");
            BasePointEntityTable = Document.GetTable("Vim.BasePoint");
            PhaseFilterEntityTable = Document.GetTable("Vim.PhaseFilter");
            GridEntityTable = Document.GetTable("Vim.Grid");
            AreaEntityTable = Document.GetTable("Vim.Area");
            AreaSchemeEntityTable = Document.GetTable("Vim.AreaScheme");
            ScheduleEntityTable = Document.GetTable("Vim.Schedule");
            ScheduleColumnEntityTable = Document.GetTable("Vim.ScheduleColumn");
            ScheduleCellEntityTable = Document.GetTable("Vim.ScheduleCell");
            ViewSheetSetEntityTable = Document.GetTable("Vim.ViewSheetSet");
            ViewSheetEntityTable = Document.GetTable("Vim.ViewSheet");
            ViewSheetInViewSheetSetEntityTable = Document.GetTable("Vim.ViewSheetInViewSheetSet");
            ViewInViewSheetSetEntityTable = Document.GetTable("Vim.ViewInViewSheetSet");
            ViewInViewSheetEntityTable = Document.GetTable("Vim.ViewInViewSheet");
            SiteEntityTable = Document.GetTable("Vim.Site");
            BuildingEntityTable = Document.GetTable("Vim.Building");
            
            // Initialize entity arrays
            AssetBufferName = AssetEntityTable?.GetStringColumnValues("string:BufferName") ?? Array.Empty<String>().ToIArray();
            DisplayUnitSpec = DisplayUnitEntityTable?.GetStringColumnValues("string:Spec") ?? Array.Empty<String>().ToIArray();
            DisplayUnitType = DisplayUnitEntityTable?.GetStringColumnValues("string:Type") ?? Array.Empty<String>().ToIArray();
            DisplayUnitLabel = DisplayUnitEntityTable?.GetStringColumnValues("string:Label") ?? Array.Empty<String>().ToIArray();
            ParameterDescriptorName = ParameterDescriptorEntityTable?.GetStringColumnValues("string:Name") ?? Array.Empty<String>().ToIArray();
            ParameterDescriptorGroup = ParameterDescriptorEntityTable?.GetStringColumnValues("string:Group") ?? Array.Empty<String>().ToIArray();
            ParameterDescriptorParameterType = ParameterDescriptorEntityTable?.GetStringColumnValues("string:ParameterType") ?? Array.Empty<String>().ToIArray();
            ParameterDescriptorIsInstance = ParameterDescriptorEntityTable?.GetDataColumnValues<Boolean>("byte:IsInstance") ?? Array.Empty<Boolean>().ToIArray();
            ParameterDescriptorIsShared = ParameterDescriptorEntityTable?.GetDataColumnValues<Boolean>("byte:IsShared") ?? Array.Empty<Boolean>().ToIArray();
            ParameterDescriptorIsReadOnly = ParameterDescriptorEntityTable?.GetDataColumnValues<Boolean>("byte:IsReadOnly") ?? Array.Empty<Boolean>().ToIArray();
            ParameterDescriptorFlags = ParameterDescriptorEntityTable?.GetDataColumnValues<Int32>("int:Flags") ?? Array.Empty<Int32>().ToIArray();
            ParameterDescriptorGuid = ParameterDescriptorEntityTable?.GetStringColumnValues("string:Guid") ?? Array.Empty<String>().ToIArray();
            ParameterDescriptorStorageType = ParameterDescriptorEntityTable?.GetDataColumnValues<Int32>("int:StorageType") ?? Array.Empty<Int32>().ToIArray();
            ParameterValue = ParameterEntityTable?.GetStringColumnValues("string:Value") ?? Array.Empty<String>().ToIArray();
            ElementId = (ElementEntityTable?.GetDataColumnValues<Int64>("long:Id") ?? ElementEntityTable?.GetDataColumnValues<Int32>("int:Id")?.Select(v => (Int64) v)) ?? Array.Empty<Int64>().ToIArray();
            ElementType = ElementEntityTable?.GetStringColumnValues("string:Type") ?? Array.Empty<String>().ToIArray();
            ElementName = ElementEntityTable?.GetStringColumnValues("string:Name") ?? Array.Empty<String>().ToIArray();
            ElementUniqueId = ElementEntityTable?.GetStringColumnValues("string:UniqueId") ?? Array.Empty<String>().ToIArray();
            ElementLocation_X = ElementEntityTable?.GetDataColumnValues<Single>("float:Location.X") ?? Array.Empty<Single>().ToIArray();
            ElementLocation_Y = ElementEntityTable?.GetDataColumnValues<Single>("float:Location.Y") ?? Array.Empty<Single>().ToIArray();
            ElementLocation_Z = ElementEntityTable?.GetDataColumnValues<Single>("float:Location.Z") ?? Array.Empty<Single>().ToIArray();
            ElementFamilyName = ElementEntityTable?.GetStringColumnValues("string:FamilyName") ?? Array.Empty<String>().ToIArray();
            ElementIsPinned = ElementEntityTable?.GetDataColumnValues<Boolean>("byte:IsPinned") ?? Array.Empty<Boolean>().ToIArray();
            WorksetId = WorksetEntityTable?.GetDataColumnValues<Int32>("int:Id") ?? Array.Empty<Int32>().ToIArray();
            WorksetName = WorksetEntityTable?.GetStringColumnValues("string:Name") ?? Array.Empty<String>().ToIArray();
            WorksetKind = WorksetEntityTable?.GetStringColumnValues("string:Kind") ?? Array.Empty<String>().ToIArray();
            WorksetIsOpen = WorksetEntityTable?.GetDataColumnValues<Boolean>("byte:IsOpen") ?? Array.Empty<Boolean>().ToIArray();
            WorksetIsEditable = WorksetEntityTable?.GetDataColumnValues<Boolean>("byte:IsEditable") ?? Array.Empty<Boolean>().ToIArray();
            WorksetOwner = WorksetEntityTable?.GetStringColumnValues("string:Owner") ?? Array.Empty<String>().ToIArray();
            WorksetUniqueId = WorksetEntityTable?.GetStringColumnValues("string:UniqueId") ?? Array.Empty<String>().ToIArray();
            AssemblyInstanceAssemblyTypeName = AssemblyInstanceEntityTable?.GetStringColumnValues("string:AssemblyTypeName") ?? Array.Empty<String>().ToIArray();
            AssemblyInstancePosition_X = AssemblyInstanceEntityTable?.GetDataColumnValues<Single>("float:Position.X") ?? Array.Empty<Single>().ToIArray();
            AssemblyInstancePosition_Y = AssemblyInstanceEntityTable?.GetDataColumnValues<Single>("float:Position.Y") ?? Array.Empty<Single>().ToIArray();
            AssemblyInstancePosition_Z = AssemblyInstanceEntityTable?.GetDataColumnValues<Single>("float:Position.Z") ?? Array.Empty<Single>().ToIArray();
            GroupGroupType = GroupEntityTable?.GetStringColumnValues("string:GroupType") ?? Array.Empty<String>().ToIArray();
            GroupPosition_X = GroupEntityTable?.GetDataColumnValues<Single>("float:Position.X") ?? Array.Empty<Single>().ToIArray();
            GroupPosition_Y = GroupEntityTable?.GetDataColumnValues<Single>("float:Position.Y") ?? Array.Empty<Single>().ToIArray();
            GroupPosition_Z = GroupEntityTable?.GetDataColumnValues<Single>("float:Position.Z") ?? Array.Empty<Single>().ToIArray();
            DesignOptionIsPrimary = DesignOptionEntityTable?.GetDataColumnValues<Boolean>("byte:IsPrimary") ?? Array.Empty<Boolean>().ToIArray();
            LevelElevation = LevelEntityTable?.GetDataColumnValues<Double>("double:Elevation") ?? Array.Empty<Double>().ToIArray();
            RoomBaseOffset = RoomEntityTable?.GetDataColumnValues<Double>("double:BaseOffset") ?? Array.Empty<Double>().ToIArray();
            RoomLimitOffset = RoomEntityTable?.GetDataColumnValues<Double>("double:LimitOffset") ?? Array.Empty<Double>().ToIArray();
            RoomUnboundedHeight = RoomEntityTable?.GetDataColumnValues<Double>("double:UnboundedHeight") ?? Array.Empty<Double>().ToIArray();
            RoomVolume = RoomEntityTable?.GetDataColumnValues<Double>("double:Volume") ?? Array.Empty<Double>().ToIArray();
            RoomPerimeter = RoomEntityTable?.GetDataColumnValues<Double>("double:Perimeter") ?? Array.Empty<Double>().ToIArray();
            RoomArea = RoomEntityTable?.GetDataColumnValues<Double>("double:Area") ?? Array.Empty<Double>().ToIArray();
            RoomNumber = RoomEntityTable?.GetStringColumnValues("string:Number") ?? Array.Empty<String>().ToIArray();
            BimDocumentTitle = BimDocumentEntityTable?.GetStringColumnValues("string:Title") ?? Array.Empty<String>().ToIArray();
            BimDocumentIsMetric = BimDocumentEntityTable?.GetDataColumnValues<Boolean>("byte:IsMetric") ?? Array.Empty<Boolean>().ToIArray();
            BimDocumentGuid = BimDocumentEntityTable?.GetStringColumnValues("string:Guid") ?? Array.Empty<String>().ToIArray();
            BimDocumentNumSaves = BimDocumentEntityTable?.GetDataColumnValues<Int32>("int:NumSaves") ?? Array.Empty<Int32>().ToIArray();
            BimDocumentIsLinked = BimDocumentEntityTable?.GetDataColumnValues<Boolean>("byte:IsLinked") ?? Array.Empty<Boolean>().ToIArray();
            BimDocumentIsDetached = BimDocumentEntityTable?.GetDataColumnValues<Boolean>("byte:IsDetached") ?? Array.Empty<Boolean>().ToIArray();
            BimDocumentIsWorkshared = BimDocumentEntityTable?.GetDataColumnValues<Boolean>("byte:IsWorkshared") ?? Array.Empty<Boolean>().ToIArray();
            BimDocumentPathName = BimDocumentEntityTable?.GetStringColumnValues("string:PathName") ?? Array.Empty<String>().ToIArray();
            BimDocumentLatitude = BimDocumentEntityTable?.GetDataColumnValues<Double>("double:Latitude") ?? Array.Empty<Double>().ToIArray();
            BimDocumentLongitude = BimDocumentEntityTable?.GetDataColumnValues<Double>("double:Longitude") ?? Array.Empty<Double>().ToIArray();
            BimDocumentTimeZone = BimDocumentEntityTable?.GetDataColumnValues<Double>("double:TimeZone") ?? Array.Empty<Double>().ToIArray();
            BimDocumentPlaceName = BimDocumentEntityTable?.GetStringColumnValues("string:PlaceName") ?? Array.Empty<String>().ToIArray();
            BimDocumentWeatherStationName = BimDocumentEntityTable?.GetStringColumnValues("string:WeatherStationName") ?? Array.Empty<String>().ToIArray();
            BimDocumentElevation = BimDocumentEntityTable?.GetDataColumnValues<Double>("double:Elevation") ?? Array.Empty<Double>().ToIArray();
            BimDocumentProjectLocation = BimDocumentEntityTable?.GetStringColumnValues("string:ProjectLocation") ?? Array.Empty<String>().ToIArray();
            BimDocumentIssueDate = BimDocumentEntityTable?.GetStringColumnValues("string:IssueDate") ?? Array.Empty<String>().ToIArray();
            BimDocumentStatus = BimDocumentEntityTable?.GetStringColumnValues("string:Status") ?? Array.Empty<String>().ToIArray();
            BimDocumentClientName = BimDocumentEntityTable?.GetStringColumnValues("string:ClientName") ?? Array.Empty<String>().ToIArray();
            BimDocumentAddress = BimDocumentEntityTable?.GetStringColumnValues("string:Address") ?? Array.Empty<String>().ToIArray();
            BimDocumentName = BimDocumentEntityTable?.GetStringColumnValues("string:Name") ?? Array.Empty<String>().ToIArray();
            BimDocumentNumber = BimDocumentEntityTable?.GetStringColumnValues("string:Number") ?? Array.Empty<String>().ToIArray();
            BimDocumentAuthor = BimDocumentEntityTable?.GetStringColumnValues("string:Author") ?? Array.Empty<String>().ToIArray();
            BimDocumentBuildingName = BimDocumentEntityTable?.GetStringColumnValues("string:BuildingName") ?? Array.Empty<String>().ToIArray();
            BimDocumentOrganizationName = BimDocumentEntityTable?.GetStringColumnValues("string:OrganizationName") ?? Array.Empty<String>().ToIArray();
            BimDocumentOrganizationDescription = BimDocumentEntityTable?.GetStringColumnValues("string:OrganizationDescription") ?? Array.Empty<String>().ToIArray();
            BimDocumentProduct = BimDocumentEntityTable?.GetStringColumnValues("string:Product") ?? Array.Empty<String>().ToIArray();
            BimDocumentVersion = BimDocumentEntityTable?.GetStringColumnValues("string:Version") ?? Array.Empty<String>().ToIArray();
            BimDocumentUser = BimDocumentEntityTable?.GetStringColumnValues("string:User") ?? Array.Empty<String>().ToIArray();
            PhaseOrderInBimDocumentOrderIndex = PhaseOrderInBimDocumentEntityTable?.GetDataColumnValues<Int32>("int:OrderIndex") ?? Array.Empty<Int32>().ToIArray();
            CategoryName = CategoryEntityTable?.GetStringColumnValues("string:Name") ?? Array.Empty<String>().ToIArray();
            CategoryId = (CategoryEntityTable?.GetDataColumnValues<Int64>("long:Id") ?? CategoryEntityTable?.GetDataColumnValues<Int32>("int:Id")?.Select(v => (Int64) v)) ?? Array.Empty<Int64>().ToIArray();
            CategoryCategoryType = CategoryEntityTable?.GetStringColumnValues("string:CategoryType") ?? Array.Empty<String>().ToIArray();
            CategoryLineColor_X = CategoryEntityTable?.GetDataColumnValues<Double>("double:LineColor.X") ?? Array.Empty<Double>().ToIArray();
            CategoryLineColor_Y = CategoryEntityTable?.GetDataColumnValues<Double>("double:LineColor.Y") ?? Array.Empty<Double>().ToIArray();
            CategoryLineColor_Z = CategoryEntityTable?.GetDataColumnValues<Double>("double:LineColor.Z") ?? Array.Empty<Double>().ToIArray();
            CategoryBuiltInCategory = CategoryEntityTable?.GetStringColumnValues("string:BuiltInCategory") ?? Array.Empty<String>().ToIArray();
            FamilyStructuralMaterialType = FamilyEntityTable?.GetStringColumnValues("string:StructuralMaterialType") ?? Array.Empty<String>().ToIArray();
            FamilyStructuralSectionShape = FamilyEntityTable?.GetStringColumnValues("string:StructuralSectionShape") ?? Array.Empty<String>().ToIArray();
            FamilyIsSystemFamily = FamilyEntityTable?.GetDataColumnValues<Boolean>("byte:IsSystemFamily") ?? Array.Empty<Boolean>().ToIArray();
            FamilyIsInPlace = FamilyEntityTable?.GetDataColumnValues<Boolean>("byte:IsInPlace") ?? Array.Empty<Boolean>().ToIArray();
            FamilyTypeIsSystemFamilyType = FamilyTypeEntityTable?.GetDataColumnValues<Boolean>("byte:IsSystemFamilyType") ?? Array.Empty<Boolean>().ToIArray();
            FamilyInstanceFacingFlipped = FamilyInstanceEntityTable?.GetDataColumnValues<Boolean>("byte:FacingFlipped") ?? Array.Empty<Boolean>().ToIArray();
            FamilyInstanceFacingOrientation_X = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:FacingOrientation.X") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceFacingOrientation_Y = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:FacingOrientation.Y") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceFacingOrientation_Z = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:FacingOrientation.Z") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceHandFlipped = FamilyInstanceEntityTable?.GetDataColumnValues<Boolean>("byte:HandFlipped") ?? Array.Empty<Boolean>().ToIArray();
            FamilyInstanceMirrored = FamilyInstanceEntityTable?.GetDataColumnValues<Boolean>("byte:Mirrored") ?? Array.Empty<Boolean>().ToIArray();
            FamilyInstanceHasModifiedGeometry = FamilyInstanceEntityTable?.GetDataColumnValues<Boolean>("byte:HasModifiedGeometry") ?? Array.Empty<Boolean>().ToIArray();
            FamilyInstanceScale = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:Scale") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceBasisX_X = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:BasisX.X") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceBasisX_Y = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:BasisX.Y") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceBasisX_Z = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:BasisX.Z") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceBasisY_X = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:BasisY.X") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceBasisY_Y = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:BasisY.Y") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceBasisY_Z = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:BasisY.Z") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceBasisZ_X = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:BasisZ.X") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceBasisZ_Y = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:BasisZ.Y") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceBasisZ_Z = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:BasisZ.Z") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceTranslation_X = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:Translation.X") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceTranslation_Y = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:Translation.Y") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceTranslation_Z = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:Translation.Z") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceHandOrientation_X = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:HandOrientation.X") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceHandOrientation_Y = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:HandOrientation.Y") ?? Array.Empty<Single>().ToIArray();
            FamilyInstanceHandOrientation_Z = FamilyInstanceEntityTable?.GetDataColumnValues<Single>("float:HandOrientation.Z") ?? Array.Empty<Single>().ToIArray();
            ViewTitle = ViewEntityTable?.GetStringColumnValues("string:Title") ?? Array.Empty<String>().ToIArray();
            ViewViewType = ViewEntityTable?.GetStringColumnValues("string:ViewType") ?? Array.Empty<String>().ToIArray();
            ViewUp_X = ViewEntityTable?.GetDataColumnValues<Double>("double:Up.X") ?? Array.Empty<Double>().ToIArray();
            ViewUp_Y = ViewEntityTable?.GetDataColumnValues<Double>("double:Up.Y") ?? Array.Empty<Double>().ToIArray();
            ViewUp_Z = ViewEntityTable?.GetDataColumnValues<Double>("double:Up.Z") ?? Array.Empty<Double>().ToIArray();
            ViewRight_X = ViewEntityTable?.GetDataColumnValues<Double>("double:Right.X") ?? Array.Empty<Double>().ToIArray();
            ViewRight_Y = ViewEntityTable?.GetDataColumnValues<Double>("double:Right.Y") ?? Array.Empty<Double>().ToIArray();
            ViewRight_Z = ViewEntityTable?.GetDataColumnValues<Double>("double:Right.Z") ?? Array.Empty<Double>().ToIArray();
            ViewOrigin_X = ViewEntityTable?.GetDataColumnValues<Double>("double:Origin.X") ?? Array.Empty<Double>().ToIArray();
            ViewOrigin_Y = ViewEntityTable?.GetDataColumnValues<Double>("double:Origin.Y") ?? Array.Empty<Double>().ToIArray();
            ViewOrigin_Z = ViewEntityTable?.GetDataColumnValues<Double>("double:Origin.Z") ?? Array.Empty<Double>().ToIArray();
            ViewViewDirection_X = ViewEntityTable?.GetDataColumnValues<Double>("double:ViewDirection.X") ?? Array.Empty<Double>().ToIArray();
            ViewViewDirection_Y = ViewEntityTable?.GetDataColumnValues<Double>("double:ViewDirection.Y") ?? Array.Empty<Double>().ToIArray();
            ViewViewDirection_Z = ViewEntityTable?.GetDataColumnValues<Double>("double:ViewDirection.Z") ?? Array.Empty<Double>().ToIArray();
            ViewViewPosition_X = ViewEntityTable?.GetDataColumnValues<Double>("double:ViewPosition.X") ?? Array.Empty<Double>().ToIArray();
            ViewViewPosition_Y = ViewEntityTable?.GetDataColumnValues<Double>("double:ViewPosition.Y") ?? Array.Empty<Double>().ToIArray();
            ViewViewPosition_Z = ViewEntityTable?.GetDataColumnValues<Double>("double:ViewPosition.Z") ?? Array.Empty<Double>().ToIArray();
            ViewScale = ViewEntityTable?.GetDataColumnValues<Double>("double:Scale") ?? Array.Empty<Double>().ToIArray();
            ViewOutline_Min_X = ViewEntityTable?.GetDataColumnValues<Double>("double:Outline.Min.X") ?? Array.Empty<Double>().ToIArray();
            ViewOutline_Min_Y = ViewEntityTable?.GetDataColumnValues<Double>("double:Outline.Min.Y") ?? Array.Empty<Double>().ToIArray();
            ViewOutline_Max_X = ViewEntityTable?.GetDataColumnValues<Double>("double:Outline.Max.X") ?? Array.Empty<Double>().ToIArray();
            ViewOutline_Max_Y = ViewEntityTable?.GetDataColumnValues<Double>("double:Outline.Max.Y") ?? Array.Empty<Double>().ToIArray();
            ViewDetailLevel = ViewEntityTable?.GetDataColumnValues<Int32>("int:DetailLevel") ?? Array.Empty<Int32>().ToIArray();
            LevelInViewExtents_Min_X = LevelInViewEntityTable?.GetDataColumnValues<Double>("double:Extents.Min.X") ?? Array.Empty<Double>().ToIArray();
            LevelInViewExtents_Min_Y = LevelInViewEntityTable?.GetDataColumnValues<Double>("double:Extents.Min.Y") ?? Array.Empty<Double>().ToIArray();
            LevelInViewExtents_Min_Z = LevelInViewEntityTable?.GetDataColumnValues<Double>("double:Extents.Min.Z") ?? Array.Empty<Double>().ToIArray();
            LevelInViewExtents_Max_X = LevelInViewEntityTable?.GetDataColumnValues<Double>("double:Extents.Max.X") ?? Array.Empty<Double>().ToIArray();
            LevelInViewExtents_Max_Y = LevelInViewEntityTable?.GetDataColumnValues<Double>("double:Extents.Max.Y") ?? Array.Empty<Double>().ToIArray();
            LevelInViewExtents_Max_Z = LevelInViewEntityTable?.GetDataColumnValues<Double>("double:Extents.Max.Z") ?? Array.Empty<Double>().ToIArray();
            CameraId = CameraEntityTable?.GetDataColumnValues<Int32>("int:Id") ?? Array.Empty<Int32>().ToIArray();
            CameraIsPerspective = CameraEntityTable?.GetDataColumnValues<Int32>("int:IsPerspective") ?? Array.Empty<Int32>().ToIArray();
            CameraVerticalExtent = CameraEntityTable?.GetDataColumnValues<Double>("double:VerticalExtent") ?? Array.Empty<Double>().ToIArray();
            CameraHorizontalExtent = CameraEntityTable?.GetDataColumnValues<Double>("double:HorizontalExtent") ?? Array.Empty<Double>().ToIArray();
            CameraFarDistance = CameraEntityTable?.GetDataColumnValues<Double>("double:FarDistance") ?? Array.Empty<Double>().ToIArray();
            CameraNearDistance = CameraEntityTable?.GetDataColumnValues<Double>("double:NearDistance") ?? Array.Empty<Double>().ToIArray();
            CameraTargetDistance = CameraEntityTable?.GetDataColumnValues<Double>("double:TargetDistance") ?? Array.Empty<Double>().ToIArray();
            CameraRightOffset = CameraEntityTable?.GetDataColumnValues<Double>("double:RightOffset") ?? Array.Empty<Double>().ToIArray();
            CameraUpOffset = CameraEntityTable?.GetDataColumnValues<Double>("double:UpOffset") ?? Array.Empty<Double>().ToIArray();
            MaterialName = MaterialEntityTable?.GetStringColumnValues("string:Name") ?? Array.Empty<String>().ToIArray();
            MaterialMaterialCategory = MaterialEntityTable?.GetStringColumnValues("string:MaterialCategory") ?? Array.Empty<String>().ToIArray();
            MaterialColor_X = MaterialEntityTable?.GetDataColumnValues<Double>("double:Color.X") ?? Array.Empty<Double>().ToIArray();
            MaterialColor_Y = MaterialEntityTable?.GetDataColumnValues<Double>("double:Color.Y") ?? Array.Empty<Double>().ToIArray();
            MaterialColor_Z = MaterialEntityTable?.GetDataColumnValues<Double>("double:Color.Z") ?? Array.Empty<Double>().ToIArray();
            MaterialColorUvScaling_X = MaterialEntityTable?.GetDataColumnValues<Double>("double:ColorUvScaling.X") ?? Array.Empty<Double>().ToIArray();
            MaterialColorUvScaling_Y = MaterialEntityTable?.GetDataColumnValues<Double>("double:ColorUvScaling.Y") ?? Array.Empty<Double>().ToIArray();
            MaterialColorUvOffset_X = MaterialEntityTable?.GetDataColumnValues<Double>("double:ColorUvOffset.X") ?? Array.Empty<Double>().ToIArray();
            MaterialColorUvOffset_Y = MaterialEntityTable?.GetDataColumnValues<Double>("double:ColorUvOffset.Y") ?? Array.Empty<Double>().ToIArray();
            MaterialNormalUvScaling_X = MaterialEntityTable?.GetDataColumnValues<Double>("double:NormalUvScaling.X") ?? Array.Empty<Double>().ToIArray();
            MaterialNormalUvScaling_Y = MaterialEntityTable?.GetDataColumnValues<Double>("double:NormalUvScaling.Y") ?? Array.Empty<Double>().ToIArray();
            MaterialNormalUvOffset_X = MaterialEntityTable?.GetDataColumnValues<Double>("double:NormalUvOffset.X") ?? Array.Empty<Double>().ToIArray();
            MaterialNormalUvOffset_Y = MaterialEntityTable?.GetDataColumnValues<Double>("double:NormalUvOffset.Y") ?? Array.Empty<Double>().ToIArray();
            MaterialNormalAmount = MaterialEntityTable?.GetDataColumnValues<Double>("double:NormalAmount") ?? Array.Empty<Double>().ToIArray();
            MaterialGlossiness = MaterialEntityTable?.GetDataColumnValues<Double>("double:Glossiness") ?? Array.Empty<Double>().ToIArray();
            MaterialSmoothness = MaterialEntityTable?.GetDataColumnValues<Double>("double:Smoothness") ?? Array.Empty<Double>().ToIArray();
            MaterialTransparency = MaterialEntityTable?.GetDataColumnValues<Double>("double:Transparency") ?? Array.Empty<Double>().ToIArray();
            MaterialInElementArea = MaterialInElementEntityTable?.GetDataColumnValues<Double>("double:Area") ?? Array.Empty<Double>().ToIArray();
            MaterialInElementVolume = MaterialInElementEntityTable?.GetDataColumnValues<Double>("double:Volume") ?? Array.Empty<Double>().ToIArray();
            MaterialInElementIsPaint = MaterialInElementEntityTable?.GetDataColumnValues<Boolean>("byte:IsPaint") ?? Array.Empty<Boolean>().ToIArray();
            CompoundStructureLayerOrderIndex = CompoundStructureLayerEntityTable?.GetDataColumnValues<Int32>("int:OrderIndex") ?? Array.Empty<Int32>().ToIArray();
            CompoundStructureLayerWidth = CompoundStructureLayerEntityTable?.GetDataColumnValues<Double>("double:Width") ?? Array.Empty<Double>().ToIArray();
            CompoundStructureLayerMaterialFunctionAssignment = CompoundStructureLayerEntityTable?.GetStringColumnValues("string:MaterialFunctionAssignment") ?? Array.Empty<String>().ToIArray();
            CompoundStructureWidth = CompoundStructureEntityTable?.GetDataColumnValues<Double>("double:Width") ?? Array.Empty<Double>().ToIArray();
            GeometryBox_Min_X = GeometryEntityTable?.GetDataColumnValues<Single>("float:Box.Min.X") ?? Array.Empty<Single>().ToIArray();
            GeometryBox_Min_Y = GeometryEntityTable?.GetDataColumnValues<Single>("float:Box.Min.Y") ?? Array.Empty<Single>().ToIArray();
            GeometryBox_Min_Z = GeometryEntityTable?.GetDataColumnValues<Single>("float:Box.Min.Z") ?? Array.Empty<Single>().ToIArray();
            GeometryBox_Max_X = GeometryEntityTable?.GetDataColumnValues<Single>("float:Box.Max.X") ?? Array.Empty<Single>().ToIArray();
            GeometryBox_Max_Y = GeometryEntityTable?.GetDataColumnValues<Single>("float:Box.Max.Y") ?? Array.Empty<Single>().ToIArray();
            GeometryBox_Max_Z = GeometryEntityTable?.GetDataColumnValues<Single>("float:Box.Max.Z") ?? Array.Empty<Single>().ToIArray();
            GeometryVertexCount = GeometryEntityTable?.GetDataColumnValues<Int32>("int:VertexCount") ?? Array.Empty<Int32>().ToIArray();
            GeometryFaceCount = GeometryEntityTable?.GetDataColumnValues<Int32>("int:FaceCount") ?? Array.Empty<Int32>().ToIArray();
            SystemSystemType = SystemEntityTable?.GetDataColumnValues<Int32>("int:SystemType") ?? Array.Empty<Int32>().ToIArray();
            ElementInSystemRoles = ElementInSystemEntityTable?.GetDataColumnValues<Int32>("int:Roles") ?? Array.Empty<Int32>().ToIArray();
            WarningGuid = WarningEntityTable?.GetStringColumnValues("string:Guid") ?? Array.Empty<String>().ToIArray();
            WarningSeverity = WarningEntityTable?.GetStringColumnValues("string:Severity") ?? Array.Empty<String>().ToIArray();
            WarningDescription = WarningEntityTable?.GetStringColumnValues("string:Description") ?? Array.Empty<String>().ToIArray();
            BasePointIsSurveyPoint = BasePointEntityTable?.GetDataColumnValues<Boolean>("byte:IsSurveyPoint") ?? Array.Empty<Boolean>().ToIArray();
            BasePointPosition_X = BasePointEntityTable?.GetDataColumnValues<Double>("double:Position.X") ?? Array.Empty<Double>().ToIArray();
            BasePointPosition_Y = BasePointEntityTable?.GetDataColumnValues<Double>("double:Position.Y") ?? Array.Empty<Double>().ToIArray();
            BasePointPosition_Z = BasePointEntityTable?.GetDataColumnValues<Double>("double:Position.Z") ?? Array.Empty<Double>().ToIArray();
            BasePointSharedPosition_X = BasePointEntityTable?.GetDataColumnValues<Double>("double:SharedPosition.X") ?? Array.Empty<Double>().ToIArray();
            BasePointSharedPosition_Y = BasePointEntityTable?.GetDataColumnValues<Double>("double:SharedPosition.Y") ?? Array.Empty<Double>().ToIArray();
            BasePointSharedPosition_Z = BasePointEntityTable?.GetDataColumnValues<Double>("double:SharedPosition.Z") ?? Array.Empty<Double>().ToIArray();
            PhaseFilterNew = PhaseFilterEntityTable?.GetDataColumnValues<Int32>("int:New") ?? Array.Empty<Int32>().ToIArray();
            PhaseFilterExisting = PhaseFilterEntityTable?.GetDataColumnValues<Int32>("int:Existing") ?? Array.Empty<Int32>().ToIArray();
            PhaseFilterDemolished = PhaseFilterEntityTable?.GetDataColumnValues<Int32>("int:Demolished") ?? Array.Empty<Int32>().ToIArray();
            PhaseFilterTemporary = PhaseFilterEntityTable?.GetDataColumnValues<Int32>("int:Temporary") ?? Array.Empty<Int32>().ToIArray();
            GridStartPoint_X = GridEntityTable?.GetDataColumnValues<Double>("double:StartPoint.X") ?? Array.Empty<Double>().ToIArray();
            GridStartPoint_Y = GridEntityTable?.GetDataColumnValues<Double>("double:StartPoint.Y") ?? Array.Empty<Double>().ToIArray();
            GridStartPoint_Z = GridEntityTable?.GetDataColumnValues<Double>("double:StartPoint.Z") ?? Array.Empty<Double>().ToIArray();
            GridEndPoint_X = GridEntityTable?.GetDataColumnValues<Double>("double:EndPoint.X") ?? Array.Empty<Double>().ToIArray();
            GridEndPoint_Y = GridEntityTable?.GetDataColumnValues<Double>("double:EndPoint.Y") ?? Array.Empty<Double>().ToIArray();
            GridEndPoint_Z = GridEntityTable?.GetDataColumnValues<Double>("double:EndPoint.Z") ?? Array.Empty<Double>().ToIArray();
            GridIsCurved = GridEntityTable?.GetDataColumnValues<Boolean>("byte:IsCurved") ?? Array.Empty<Boolean>().ToIArray();
            GridExtents_Min_X = GridEntityTable?.GetDataColumnValues<Double>("double:Extents.Min.X") ?? Array.Empty<Double>().ToIArray();
            GridExtents_Min_Y = GridEntityTable?.GetDataColumnValues<Double>("double:Extents.Min.Y") ?? Array.Empty<Double>().ToIArray();
            GridExtents_Min_Z = GridEntityTable?.GetDataColumnValues<Double>("double:Extents.Min.Z") ?? Array.Empty<Double>().ToIArray();
            GridExtents_Max_X = GridEntityTable?.GetDataColumnValues<Double>("double:Extents.Max.X") ?? Array.Empty<Double>().ToIArray();
            GridExtents_Max_Y = GridEntityTable?.GetDataColumnValues<Double>("double:Extents.Max.Y") ?? Array.Empty<Double>().ToIArray();
            GridExtents_Max_Z = GridEntityTable?.GetDataColumnValues<Double>("double:Extents.Max.Z") ?? Array.Empty<Double>().ToIArray();
            AreaValue = AreaEntityTable?.GetDataColumnValues<Double>("double:Value") ?? Array.Empty<Double>().ToIArray();
            AreaPerimeter = AreaEntityTable?.GetDataColumnValues<Double>("double:Perimeter") ?? Array.Empty<Double>().ToIArray();
            AreaNumber = AreaEntityTable?.GetStringColumnValues("string:Number") ?? Array.Empty<String>().ToIArray();
            AreaIsGrossInterior = AreaEntityTable?.GetDataColumnValues<Boolean>("byte:IsGrossInterior") ?? Array.Empty<Boolean>().ToIArray();
            AreaSchemeIsGrossBuildingArea = AreaSchemeEntityTable?.GetDataColumnValues<Boolean>("byte:IsGrossBuildingArea") ?? Array.Empty<Boolean>().ToIArray();
            ScheduleColumnName = ScheduleColumnEntityTable?.GetStringColumnValues("string:Name") ?? Array.Empty<String>().ToIArray();
            ScheduleColumnColumnIndex = ScheduleColumnEntityTable?.GetDataColumnValues<Int32>("int:ColumnIndex") ?? Array.Empty<Int32>().ToIArray();
            ScheduleCellValue = ScheduleCellEntityTable?.GetStringColumnValues("string:Value") ?? Array.Empty<String>().ToIArray();
            ScheduleCellRowIndex = ScheduleCellEntityTable?.GetDataColumnValues<Int32>("int:RowIndex") ?? Array.Empty<Int32>().ToIArray();
            SiteLatitude = SiteEntityTable?.GetDataColumnValues<Double>("double:Latitude") ?? Array.Empty<Double>().ToIArray();
            SiteLongitude = SiteEntityTable?.GetDataColumnValues<Double>("double:Longitude") ?? Array.Empty<Double>().ToIArray();
            SiteAddress = SiteEntityTable?.GetStringColumnValues("string:Address") ?? Array.Empty<String>().ToIArray();
            SiteElevation = SiteEntityTable?.GetDataColumnValues<Double>("double:Elevation") ?? Array.Empty<Double>().ToIArray();
            SiteNumber = SiteEntityTable?.GetStringColumnValues("string:Number") ?? Array.Empty<String>().ToIArray();
            BuildingElevation = BuildingEntityTable?.GetDataColumnValues<Double>("double:Elevation") ?? Array.Empty<Double>().ToIArray();
            BuildingTerrainElevation = BuildingEntityTable?.GetDataColumnValues<Double>("double:TerrainElevation") ?? Array.Empty<Double>().ToIArray();
            BuildingAddress = BuildingEntityTable?.GetStringColumnValues("string:Address") ?? Array.Empty<String>().ToIArray();
            
            // Initialize entity relational columns
            ParameterDescriptorDisplayUnitIndex = ParameterDescriptorEntityTable?.GetIndexColumnValues("index:Vim.DisplayUnit:DisplayUnit") ?? Array.Empty<int>().ToIArray();
            ParameterParameterDescriptorIndex = ParameterEntityTable?.GetIndexColumnValues("index:Vim.ParameterDescriptor:ParameterDescriptor") ?? Array.Empty<int>().ToIArray();
            ParameterElementIndex = ParameterEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            ElementLevelIndex = ElementEntityTable?.GetIndexColumnValues("index:Vim.Level:Level") ?? Array.Empty<int>().ToIArray();
            ElementPhaseCreatedIndex = ElementEntityTable?.GetIndexColumnValues("index:Vim.Phase:PhaseCreated") ?? Array.Empty<int>().ToIArray();
            ElementPhaseDemolishedIndex = ElementEntityTable?.GetIndexColumnValues("index:Vim.Phase:PhaseDemolished") ?? Array.Empty<int>().ToIArray();
            ElementCategoryIndex = ElementEntityTable?.GetIndexColumnValues("index:Vim.Category:Category") ?? Array.Empty<int>().ToIArray();
            ElementWorksetIndex = ElementEntityTable?.GetIndexColumnValues("index:Vim.Workset:Workset") ?? Array.Empty<int>().ToIArray();
            ElementDesignOptionIndex = ElementEntityTable?.GetIndexColumnValues("index:Vim.DesignOption:DesignOption") ?? Array.Empty<int>().ToIArray();
            ElementOwnerViewIndex = ElementEntityTable?.GetIndexColumnValues("index:Vim.View:OwnerView") ?? Array.Empty<int>().ToIArray();
            ElementGroupIndex = ElementEntityTable?.GetIndexColumnValues("index:Vim.Group:Group") ?? Array.Empty<int>().ToIArray();
            ElementAssemblyInstanceIndex = ElementEntityTable?.GetIndexColumnValues("index:Vim.AssemblyInstance:AssemblyInstance") ?? Array.Empty<int>().ToIArray();
            ElementBimDocumentIndex = ElementEntityTable?.GetIndexColumnValues("index:Vim.BimDocument:BimDocument") ?? Array.Empty<int>().ToIArray();
            ElementRoomIndex = ElementEntityTable?.GetIndexColumnValues("index:Vim.Room:Room") ?? Array.Empty<int>().ToIArray();
            WorksetBimDocumentIndex = WorksetEntityTable?.GetIndexColumnValues("index:Vim.BimDocument:BimDocument") ?? Array.Empty<int>().ToIArray();
            AssemblyInstanceElementIndex = AssemblyInstanceEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            GroupElementIndex = GroupEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            DesignOptionElementIndex = DesignOptionEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            LevelFamilyTypeIndex = LevelEntityTable?.GetIndexColumnValues("index:Vim.FamilyType:FamilyType") ?? Array.Empty<int>().ToIArray();
            LevelBuildingIndex = LevelEntityTable?.GetIndexColumnValues("index:Vim.Building:Building") ?? Array.Empty<int>().ToIArray();
            LevelElementIndex = LevelEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            PhaseElementIndex = PhaseEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            RoomUpperLimitIndex = RoomEntityTable?.GetIndexColumnValues("index:Vim.Level:UpperLimit") ?? Array.Empty<int>().ToIArray();
            RoomElementIndex = RoomEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            BimDocumentActiveViewIndex = BimDocumentEntityTable?.GetIndexColumnValues("index:Vim.View:ActiveView") ?? Array.Empty<int>().ToIArray();
            BimDocumentOwnerFamilyIndex = BimDocumentEntityTable?.GetIndexColumnValues("index:Vim.Family:OwnerFamily") ?? Array.Empty<int>().ToIArray();
            BimDocumentParentIndex = BimDocumentEntityTable?.GetIndexColumnValues("index:Vim.BimDocument:Parent") ?? Array.Empty<int>().ToIArray();
            BimDocumentElementIndex = BimDocumentEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            DisplayUnitInBimDocumentDisplayUnitIndex = DisplayUnitInBimDocumentEntityTable?.GetIndexColumnValues("index:Vim.DisplayUnit:DisplayUnit") ?? Array.Empty<int>().ToIArray();
            DisplayUnitInBimDocumentBimDocumentIndex = DisplayUnitInBimDocumentEntityTable?.GetIndexColumnValues("index:Vim.BimDocument:BimDocument") ?? Array.Empty<int>().ToIArray();
            PhaseOrderInBimDocumentPhaseIndex = PhaseOrderInBimDocumentEntityTable?.GetIndexColumnValues("index:Vim.Phase:Phase") ?? Array.Empty<int>().ToIArray();
            PhaseOrderInBimDocumentBimDocumentIndex = PhaseOrderInBimDocumentEntityTable?.GetIndexColumnValues("index:Vim.BimDocument:BimDocument") ?? Array.Empty<int>().ToIArray();
            CategoryParentIndex = CategoryEntityTable?.GetIndexColumnValues("index:Vim.Category:Parent") ?? Array.Empty<int>().ToIArray();
            CategoryMaterialIndex = CategoryEntityTable?.GetIndexColumnValues("index:Vim.Material:Material") ?? Array.Empty<int>().ToIArray();
            FamilyFamilyCategoryIndex = FamilyEntityTable?.GetIndexColumnValues("index:Vim.Category:FamilyCategory") ?? Array.Empty<int>().ToIArray();
            FamilyElementIndex = FamilyEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            FamilyTypeFamilyIndex = FamilyTypeEntityTable?.GetIndexColumnValues("index:Vim.Family:Family") ?? Array.Empty<int>().ToIArray();
            FamilyTypeCompoundStructureIndex = FamilyTypeEntityTable?.GetIndexColumnValues("index:Vim.CompoundStructure:CompoundStructure") ?? Array.Empty<int>().ToIArray();
            FamilyTypeElementIndex = FamilyTypeEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            FamilyInstanceFamilyTypeIndex = FamilyInstanceEntityTable?.GetIndexColumnValues("index:Vim.FamilyType:FamilyType") ?? Array.Empty<int>().ToIArray();
            FamilyInstanceHostIndex = FamilyInstanceEntityTable?.GetIndexColumnValues("index:Vim.Element:Host") ?? Array.Empty<int>().ToIArray();
            FamilyInstanceFromRoomIndex = FamilyInstanceEntityTable?.GetIndexColumnValues("index:Vim.Room:FromRoom") ?? Array.Empty<int>().ToIArray();
            FamilyInstanceToRoomIndex = FamilyInstanceEntityTable?.GetIndexColumnValues("index:Vim.Room:ToRoom") ?? Array.Empty<int>().ToIArray();
            FamilyInstanceSuperComponentIndex = FamilyInstanceEntityTable?.GetIndexColumnValues("index:Vim.Element:SuperComponent") ?? Array.Empty<int>().ToIArray();
            FamilyInstanceElementIndex = FamilyInstanceEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            ViewCameraIndex = ViewEntityTable?.GetIndexColumnValues("index:Vim.Camera:Camera") ?? Array.Empty<int>().ToIArray();
            ViewFamilyTypeIndex = ViewEntityTable?.GetIndexColumnValues("index:Vim.FamilyType:FamilyType") ?? Array.Empty<int>().ToIArray();
            ViewElementIndex = ViewEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            ElementInViewViewIndex = ElementInViewEntityTable?.GetIndexColumnValues("index:Vim.View:View") ?? Array.Empty<int>().ToIArray();
            ElementInViewElementIndex = ElementInViewEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            ShapeInViewShapeIndex = ShapeInViewEntityTable?.GetIndexColumnValues("index:Vim.Shape:Shape") ?? Array.Empty<int>().ToIArray();
            ShapeInViewViewIndex = ShapeInViewEntityTable?.GetIndexColumnValues("index:Vim.View:View") ?? Array.Empty<int>().ToIArray();
            AssetInViewAssetIndex = AssetInViewEntityTable?.GetIndexColumnValues("index:Vim.Asset:Asset") ?? Array.Empty<int>().ToIArray();
            AssetInViewViewIndex = AssetInViewEntityTable?.GetIndexColumnValues("index:Vim.View:View") ?? Array.Empty<int>().ToIArray();
            AssetInViewSheetAssetIndex = AssetInViewSheetEntityTable?.GetIndexColumnValues("index:Vim.Asset:Asset") ?? Array.Empty<int>().ToIArray();
            AssetInViewSheetViewSheetIndex = AssetInViewSheetEntityTable?.GetIndexColumnValues("index:Vim.ViewSheet:ViewSheet") ?? Array.Empty<int>().ToIArray();
            LevelInViewLevelIndex = LevelInViewEntityTable?.GetIndexColumnValues("index:Vim.Level:Level") ?? Array.Empty<int>().ToIArray();
            LevelInViewViewIndex = LevelInViewEntityTable?.GetIndexColumnValues("index:Vim.View:View") ?? Array.Empty<int>().ToIArray();
            MaterialColorTextureFileIndex = MaterialEntityTable?.GetIndexColumnValues("index:Vim.Asset:ColorTextureFile") ?? Array.Empty<int>().ToIArray();
            MaterialNormalTextureFileIndex = MaterialEntityTable?.GetIndexColumnValues("index:Vim.Asset:NormalTextureFile") ?? Array.Empty<int>().ToIArray();
            MaterialElementIndex = MaterialEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            MaterialInElementMaterialIndex = MaterialInElementEntityTable?.GetIndexColumnValues("index:Vim.Material:Material") ?? Array.Empty<int>().ToIArray();
            MaterialInElementElementIndex = MaterialInElementEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            CompoundStructureLayerMaterialIndex = CompoundStructureLayerEntityTable?.GetIndexColumnValues("index:Vim.Material:Material") ?? Array.Empty<int>().ToIArray();
            CompoundStructureLayerCompoundStructureIndex = CompoundStructureLayerEntityTable?.GetIndexColumnValues("index:Vim.CompoundStructure:CompoundStructure") ?? Array.Empty<int>().ToIArray();
            CompoundStructureStructuralLayerIndex = CompoundStructureEntityTable?.GetIndexColumnValues("index:Vim.CompoundStructureLayer:StructuralLayer") ?? Array.Empty<int>().ToIArray();
            NodeElementIndex = NodeEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            ShapeElementIndex = ShapeEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            ShapeCollectionElementIndex = ShapeCollectionEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            ShapeInShapeCollectionShapeIndex = ShapeInShapeCollectionEntityTable?.GetIndexColumnValues("index:Vim.Shape:Shape") ?? Array.Empty<int>().ToIArray();
            ShapeInShapeCollectionShapeCollectionIndex = ShapeInShapeCollectionEntityTable?.GetIndexColumnValues("index:Vim.ShapeCollection:ShapeCollection") ?? Array.Empty<int>().ToIArray();
            SystemFamilyTypeIndex = SystemEntityTable?.GetIndexColumnValues("index:Vim.FamilyType:FamilyType") ?? Array.Empty<int>().ToIArray();
            SystemElementIndex = SystemEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            ElementInSystemSystemIndex = ElementInSystemEntityTable?.GetIndexColumnValues("index:Vim.System:System") ?? Array.Empty<int>().ToIArray();
            ElementInSystemElementIndex = ElementInSystemEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            WarningBimDocumentIndex = WarningEntityTable?.GetIndexColumnValues("index:Vim.BimDocument:BimDocument") ?? Array.Empty<int>().ToIArray();
            ElementInWarningWarningIndex = ElementInWarningEntityTable?.GetIndexColumnValues("index:Vim.Warning:Warning") ?? Array.Empty<int>().ToIArray();
            ElementInWarningElementIndex = ElementInWarningEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            BasePointElementIndex = BasePointEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            PhaseFilterElementIndex = PhaseFilterEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            GridFamilyTypeIndex = GridEntityTable?.GetIndexColumnValues("index:Vim.FamilyType:FamilyType") ?? Array.Empty<int>().ToIArray();
            GridElementIndex = GridEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            AreaAreaSchemeIndex = AreaEntityTable?.GetIndexColumnValues("index:Vim.AreaScheme:AreaScheme") ?? Array.Empty<int>().ToIArray();
            AreaElementIndex = AreaEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            AreaSchemeElementIndex = AreaSchemeEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            ScheduleElementIndex = ScheduleEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            ScheduleColumnScheduleIndex = ScheduleColumnEntityTable?.GetIndexColumnValues("index:Vim.Schedule:Schedule") ?? Array.Empty<int>().ToIArray();
            ScheduleCellScheduleColumnIndex = ScheduleCellEntityTable?.GetIndexColumnValues("index:Vim.ScheduleColumn:ScheduleColumn") ?? Array.Empty<int>().ToIArray();
            ViewSheetSetElementIndex = ViewSheetSetEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            ViewSheetFamilyTypeIndex = ViewSheetEntityTable?.GetIndexColumnValues("index:Vim.FamilyType:FamilyType") ?? Array.Empty<int>().ToIArray();
            ViewSheetElementIndex = ViewSheetEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            ViewSheetInViewSheetSetViewSheetIndex = ViewSheetInViewSheetSetEntityTable?.GetIndexColumnValues("index:Vim.ViewSheet:ViewSheet") ?? Array.Empty<int>().ToIArray();
            ViewSheetInViewSheetSetViewSheetSetIndex = ViewSheetInViewSheetSetEntityTable?.GetIndexColumnValues("index:Vim.ViewSheetSet:ViewSheetSet") ?? Array.Empty<int>().ToIArray();
            ViewInViewSheetSetViewIndex = ViewInViewSheetSetEntityTable?.GetIndexColumnValues("index:Vim.View:View") ?? Array.Empty<int>().ToIArray();
            ViewInViewSheetSetViewSheetSetIndex = ViewInViewSheetSetEntityTable?.GetIndexColumnValues("index:Vim.ViewSheetSet:ViewSheetSet") ?? Array.Empty<int>().ToIArray();
            ViewInViewSheetViewIndex = ViewInViewSheetEntityTable?.GetIndexColumnValues("index:Vim.View:View") ?? Array.Empty<int>().ToIArray();
            ViewInViewSheetViewSheetIndex = ViewInViewSheetEntityTable?.GetIndexColumnValues("index:Vim.ViewSheet:ViewSheet") ?? Array.Empty<int>().ToIArray();
            SiteElementIndex = SiteEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            BuildingSiteIndex = BuildingEntityTable?.GetIndexColumnValues("index:Vim.Site:Site") ?? Array.Empty<int>().ToIArray();
            BuildingElementIndex = BuildingEntityTable?.GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>().ToIArray();
            
            // Initialize entity collections
            AssetList = NumAsset.Select(i => GetAsset(i));
            DisplayUnitList = NumDisplayUnit.Select(i => GetDisplayUnit(i));
            ParameterDescriptorList = NumParameterDescriptor.Select(i => GetParameterDescriptor(i));
            ParameterList = NumParameter.Select(i => GetParameter(i));
            ElementList = NumElement.Select(i => GetElement(i));
            WorksetList = NumWorkset.Select(i => GetWorkset(i));
            AssemblyInstanceList = NumAssemblyInstance.Select(i => GetAssemblyInstance(i));
            GroupList = NumGroup.Select(i => GetGroup(i));
            DesignOptionList = NumDesignOption.Select(i => GetDesignOption(i));
            LevelList = NumLevel.Select(i => GetLevel(i));
            PhaseList = NumPhase.Select(i => GetPhase(i));
            RoomList = NumRoom.Select(i => GetRoom(i));
            BimDocumentList = NumBimDocument.Select(i => GetBimDocument(i));
            DisplayUnitInBimDocumentList = NumDisplayUnitInBimDocument.Select(i => GetDisplayUnitInBimDocument(i));
            PhaseOrderInBimDocumentList = NumPhaseOrderInBimDocument.Select(i => GetPhaseOrderInBimDocument(i));
            CategoryList = NumCategory.Select(i => GetCategory(i));
            FamilyList = NumFamily.Select(i => GetFamily(i));
            FamilyTypeList = NumFamilyType.Select(i => GetFamilyType(i));
            FamilyInstanceList = NumFamilyInstance.Select(i => GetFamilyInstance(i));
            ViewList = NumView.Select(i => GetView(i));
            ElementInViewList = NumElementInView.Select(i => GetElementInView(i));
            ShapeInViewList = NumShapeInView.Select(i => GetShapeInView(i));
            AssetInViewList = NumAssetInView.Select(i => GetAssetInView(i));
            AssetInViewSheetList = NumAssetInViewSheet.Select(i => GetAssetInViewSheet(i));
            LevelInViewList = NumLevelInView.Select(i => GetLevelInView(i));
            CameraList = NumCamera.Select(i => GetCamera(i));
            MaterialList = NumMaterial.Select(i => GetMaterial(i));
            MaterialInElementList = NumMaterialInElement.Select(i => GetMaterialInElement(i));
            CompoundStructureLayerList = NumCompoundStructureLayer.Select(i => GetCompoundStructureLayer(i));
            CompoundStructureList = NumCompoundStructure.Select(i => GetCompoundStructure(i));
            NodeList = NumNode.Select(i => GetNode(i));
            GeometryList = NumGeometry.Select(i => GetGeometry(i));
            ShapeList = NumShape.Select(i => GetShape(i));
            ShapeCollectionList = NumShapeCollection.Select(i => GetShapeCollection(i));
            ShapeInShapeCollectionList = NumShapeInShapeCollection.Select(i => GetShapeInShapeCollection(i));
            SystemList = NumSystem.Select(i => GetSystem(i));
            ElementInSystemList = NumElementInSystem.Select(i => GetElementInSystem(i));
            WarningList = NumWarning.Select(i => GetWarning(i));
            ElementInWarningList = NumElementInWarning.Select(i => GetElementInWarning(i));
            BasePointList = NumBasePoint.Select(i => GetBasePoint(i));
            PhaseFilterList = NumPhaseFilter.Select(i => GetPhaseFilter(i));
            GridList = NumGrid.Select(i => GetGrid(i));
            AreaList = NumArea.Select(i => GetArea(i));
            AreaSchemeList = NumAreaScheme.Select(i => GetAreaScheme(i));
            ScheduleList = NumSchedule.Select(i => GetSchedule(i));
            ScheduleColumnList = NumScheduleColumn.Select(i => GetScheduleColumn(i));
            ScheduleCellList = NumScheduleCell.Select(i => GetScheduleCell(i));
            ViewSheetSetList = NumViewSheetSet.Select(i => GetViewSheetSet(i));
            ViewSheetList = NumViewSheet.Select(i => GetViewSheet(i));
            ViewSheetInViewSheetSetList = NumViewSheetInViewSheetSet.Select(i => GetViewSheetInViewSheetSet(i));
            ViewInViewSheetSetList = NumViewInViewSheetSet.Select(i => GetViewInViewSheetSet(i));
            ViewInViewSheetList = NumViewInViewSheet.Select(i => GetViewInViewSheet(i));
            SiteList = NumSite.Select(i => GetSite(i));
            BuildingList = NumBuilding.Select(i => GetBuilding(i));
            
            // Initialize element index maps
            ElementIndexMaps = new ElementIndexMaps(this, inParallel);
        }
    } // Document class
    
    public partial class EntityTableSet
    {
        public Dictionary<string, SerializableEntityTable> RawTableMap { get; } = new Dictionary<string, SerializableEntityTable>();
        
        private SerializableEntityTable GetRawTableOrDefault(string tableName)
            => RawTableMap.TryGetValue(tableName, out var result) ? result : null;
        
        public EntityTableSet(SerializableEntityTable[] rawTables, string[] stringBuffer)
        {
            foreach (var rawTable in rawTables)
                RawTableMap[rawTable.Name] = rawTable;
            
            // Populate the entity tables.
            if (GetRawTableOrDefault("Vim.Asset") is SerializableEntityTable assetTable)
                AssetTable = new AssetTable(assetTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.DisplayUnit") is SerializableEntityTable displayunitTable)
                DisplayUnitTable = new DisplayUnitTable(displayunitTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ParameterDescriptor") is SerializableEntityTable parameterdescriptorTable)
                ParameterDescriptorTable = new ParameterDescriptorTable(parameterdescriptorTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Parameter") is SerializableEntityTable parameterTable)
                ParameterTable = new ParameterTable(parameterTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Element") is SerializableEntityTable elementTable)
                ElementTable = new ElementTable(elementTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Workset") is SerializableEntityTable worksetTable)
                WorksetTable = new WorksetTable(worksetTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.AssemblyInstance") is SerializableEntityTable assemblyinstanceTable)
                AssemblyInstanceTable = new AssemblyInstanceTable(assemblyinstanceTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Group") is SerializableEntityTable groupTable)
                GroupTable = new GroupTable(groupTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.DesignOption") is SerializableEntityTable designoptionTable)
                DesignOptionTable = new DesignOptionTable(designoptionTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Level") is SerializableEntityTable levelTable)
                LevelTable = new LevelTable(levelTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Phase") is SerializableEntityTable phaseTable)
                PhaseTable = new PhaseTable(phaseTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Room") is SerializableEntityTable roomTable)
                RoomTable = new RoomTable(roomTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.BimDocument") is SerializableEntityTable bimdocumentTable)
                BimDocumentTable = new BimDocumentTable(bimdocumentTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.DisplayUnitInBimDocument") is SerializableEntityTable displayunitinbimdocumentTable)
                DisplayUnitInBimDocumentTable = new DisplayUnitInBimDocumentTable(displayunitinbimdocumentTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.PhaseOrderInBimDocument") is SerializableEntityTable phaseorderinbimdocumentTable)
                PhaseOrderInBimDocumentTable = new PhaseOrderInBimDocumentTable(phaseorderinbimdocumentTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Category") is SerializableEntityTable categoryTable)
                CategoryTable = new CategoryTable(categoryTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Family") is SerializableEntityTable familyTable)
                FamilyTable = new FamilyTable(familyTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.FamilyType") is SerializableEntityTable familytypeTable)
                FamilyTypeTable = new FamilyTypeTable(familytypeTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.FamilyInstance") is SerializableEntityTable familyinstanceTable)
                FamilyInstanceTable = new FamilyInstanceTable(familyinstanceTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.View") is SerializableEntityTable viewTable)
                ViewTable = new ViewTable(viewTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ElementInView") is SerializableEntityTable elementinviewTable)
                ElementInViewTable = new ElementInViewTable(elementinviewTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ShapeInView") is SerializableEntityTable shapeinviewTable)
                ShapeInViewTable = new ShapeInViewTable(shapeinviewTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.AssetInView") is SerializableEntityTable assetinviewTable)
                AssetInViewTable = new AssetInViewTable(assetinviewTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.AssetInViewSheet") is SerializableEntityTable assetinviewsheetTable)
                AssetInViewSheetTable = new AssetInViewSheetTable(assetinviewsheetTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.LevelInView") is SerializableEntityTable levelinviewTable)
                LevelInViewTable = new LevelInViewTable(levelinviewTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Camera") is SerializableEntityTable cameraTable)
                CameraTable = new CameraTable(cameraTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Material") is SerializableEntityTable materialTable)
                MaterialTable = new MaterialTable(materialTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.MaterialInElement") is SerializableEntityTable materialinelementTable)
                MaterialInElementTable = new MaterialInElementTable(materialinelementTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.CompoundStructureLayer") is SerializableEntityTable compoundstructurelayerTable)
                CompoundStructureLayerTable = new CompoundStructureLayerTable(compoundstructurelayerTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.CompoundStructure") is SerializableEntityTable compoundstructureTable)
                CompoundStructureTable = new CompoundStructureTable(compoundstructureTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Node") is SerializableEntityTable nodeTable)
                NodeTable = new NodeTable(nodeTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Geometry") is SerializableEntityTable geometryTable)
                GeometryTable = new GeometryTable(geometryTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Shape") is SerializableEntityTable shapeTable)
                ShapeTable = new ShapeTable(shapeTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ShapeCollection") is SerializableEntityTable shapecollectionTable)
                ShapeCollectionTable = new ShapeCollectionTable(shapecollectionTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ShapeInShapeCollection") is SerializableEntityTable shapeinshapecollectionTable)
                ShapeInShapeCollectionTable = new ShapeInShapeCollectionTable(shapeinshapecollectionTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.System") is SerializableEntityTable systemTable)
                SystemTable = new SystemTable(systemTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ElementInSystem") is SerializableEntityTable elementinsystemTable)
                ElementInSystemTable = new ElementInSystemTable(elementinsystemTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Warning") is SerializableEntityTable warningTable)
                WarningTable = new WarningTable(warningTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ElementInWarning") is SerializableEntityTable elementinwarningTable)
                ElementInWarningTable = new ElementInWarningTable(elementinwarningTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.BasePoint") is SerializableEntityTable basepointTable)
                BasePointTable = new BasePointTable(basepointTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.PhaseFilter") is SerializableEntityTable phasefilterTable)
                PhaseFilterTable = new PhaseFilterTable(phasefilterTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Grid") is SerializableEntityTable gridTable)
                GridTable = new GridTable(gridTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Area") is SerializableEntityTable areaTable)
                AreaTable = new AreaTable(areaTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.AreaScheme") is SerializableEntityTable areaschemeTable)
                AreaSchemeTable = new AreaSchemeTable(areaschemeTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Schedule") is SerializableEntityTable scheduleTable)
                ScheduleTable = new ScheduleTable(scheduleTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ScheduleColumn") is SerializableEntityTable schedulecolumnTable)
                ScheduleColumnTable = new ScheduleColumnTable(schedulecolumnTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ScheduleCell") is SerializableEntityTable schedulecellTable)
                ScheduleCellTable = new ScheduleCellTable(schedulecellTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ViewSheetSet") is SerializableEntityTable viewsheetsetTable)
                ViewSheetSetTable = new ViewSheetSetTable(viewsheetsetTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ViewSheet") is SerializableEntityTable viewsheetTable)
                ViewSheetTable = new ViewSheetTable(viewsheetTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ViewSheetInViewSheetSet") is SerializableEntityTable viewsheetinviewsheetsetTable)
                ViewSheetInViewSheetSetTable = new ViewSheetInViewSheetSetTable(viewsheetinviewsheetsetTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ViewInViewSheetSet") is SerializableEntityTable viewinviewsheetsetTable)
                ViewInViewSheetSetTable = new ViewInViewSheetSetTable(viewinviewsheetsetTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.ViewInViewSheet") is SerializableEntityTable viewinviewsheetTable)
                ViewInViewSheetTable = new ViewInViewSheetTable(viewinviewsheetTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Site") is SerializableEntityTable siteTable)
                SiteTable = new SiteTable(siteTable, stringBuffer);
            
            if (GetRawTableOrDefault("Vim.Building") is SerializableEntityTable buildingTable)
                BuildingTable = new BuildingTable(buildingTable, stringBuffer);
            
        } // EntityTableSet constructor
        
        public AssetTable AssetTable { get; } // can be null
        public Asset GetAsset(int index) => AssetTable?.Get(index);
        public DisplayUnitTable DisplayUnitTable { get; } // can be null
        public DisplayUnit GetDisplayUnit(int index) => DisplayUnitTable?.Get(index);
        public ParameterDescriptorTable ParameterDescriptorTable { get; } // can be null
        public ParameterDescriptor GetParameterDescriptor(int index) => ParameterDescriptorTable?.Get(index);
        public ParameterTable ParameterTable { get; } // can be null
        public Parameter GetParameter(int index) => ParameterTable?.Get(index);
        public ElementTable ElementTable { get; } // can be null
        public Element GetElement(int index) => ElementTable?.Get(index);
        public WorksetTable WorksetTable { get; } // can be null
        public Workset GetWorkset(int index) => WorksetTable?.Get(index);
        public AssemblyInstanceTable AssemblyInstanceTable { get; } // can be null
        public AssemblyInstance GetAssemblyInstance(int index) => AssemblyInstanceTable?.Get(index);
        public GroupTable GroupTable { get; } // can be null
        public Group GetGroup(int index) => GroupTable?.Get(index);
        public DesignOptionTable DesignOptionTable { get; } // can be null
        public DesignOption GetDesignOption(int index) => DesignOptionTable?.Get(index);
        public LevelTable LevelTable { get; } // can be null
        public Level GetLevel(int index) => LevelTable?.Get(index);
        public PhaseTable PhaseTable { get; } // can be null
        public Phase GetPhase(int index) => PhaseTable?.Get(index);
        public RoomTable RoomTable { get; } // can be null
        public Room GetRoom(int index) => RoomTable?.Get(index);
        public BimDocumentTable BimDocumentTable { get; } // can be null
        public BimDocument GetBimDocument(int index) => BimDocumentTable?.Get(index);
        public DisplayUnitInBimDocumentTable DisplayUnitInBimDocumentTable { get; } // can be null
        public DisplayUnitInBimDocument GetDisplayUnitInBimDocument(int index) => DisplayUnitInBimDocumentTable?.Get(index);
        public PhaseOrderInBimDocumentTable PhaseOrderInBimDocumentTable { get; } // can be null
        public PhaseOrderInBimDocument GetPhaseOrderInBimDocument(int index) => PhaseOrderInBimDocumentTable?.Get(index);
        public CategoryTable CategoryTable { get; } // can be null
        public Category GetCategory(int index) => CategoryTable?.Get(index);
        public FamilyTable FamilyTable { get; } // can be null
        public Family GetFamily(int index) => FamilyTable?.Get(index);
        public FamilyTypeTable FamilyTypeTable { get; } // can be null
        public FamilyType GetFamilyType(int index) => FamilyTypeTable?.Get(index);
        public FamilyInstanceTable FamilyInstanceTable { get; } // can be null
        public FamilyInstance GetFamilyInstance(int index) => FamilyInstanceTable?.Get(index);
        public ViewTable ViewTable { get; } // can be null
        public View GetView(int index) => ViewTable?.Get(index);
        public ElementInViewTable ElementInViewTable { get; } // can be null
        public ElementInView GetElementInView(int index) => ElementInViewTable?.Get(index);
        public ShapeInViewTable ShapeInViewTable { get; } // can be null
        public ShapeInView GetShapeInView(int index) => ShapeInViewTable?.Get(index);
        public AssetInViewTable AssetInViewTable { get; } // can be null
        public AssetInView GetAssetInView(int index) => AssetInViewTable?.Get(index);
        public AssetInViewSheetTable AssetInViewSheetTable { get; } // can be null
        public AssetInViewSheet GetAssetInViewSheet(int index) => AssetInViewSheetTable?.Get(index);
        public LevelInViewTable LevelInViewTable { get; } // can be null
        public LevelInView GetLevelInView(int index) => LevelInViewTable?.Get(index);
        public CameraTable CameraTable { get; } // can be null
        public Camera GetCamera(int index) => CameraTable?.Get(index);
        public MaterialTable MaterialTable { get; } // can be null
        public Material GetMaterial(int index) => MaterialTable?.Get(index);
        public MaterialInElementTable MaterialInElementTable { get; } // can be null
        public MaterialInElement GetMaterialInElement(int index) => MaterialInElementTable?.Get(index);
        public CompoundStructureLayerTable CompoundStructureLayerTable { get; } // can be null
        public CompoundStructureLayer GetCompoundStructureLayer(int index) => CompoundStructureLayerTable?.Get(index);
        public CompoundStructureTable CompoundStructureTable { get; } // can be null
        public CompoundStructure GetCompoundStructure(int index) => CompoundStructureTable?.Get(index);
        public NodeTable NodeTable { get; } // can be null
        public Node GetNode(int index) => NodeTable?.Get(index);
        public GeometryTable GeometryTable { get; } // can be null
        public Geometry GetGeometry(int index) => GeometryTable?.Get(index);
        public ShapeTable ShapeTable { get; } // can be null
        public Shape GetShape(int index) => ShapeTable?.Get(index);
        public ShapeCollectionTable ShapeCollectionTable { get; } // can be null
        public ShapeCollection GetShapeCollection(int index) => ShapeCollectionTable?.Get(index);
        public ShapeInShapeCollectionTable ShapeInShapeCollectionTable { get; } // can be null
        public ShapeInShapeCollection GetShapeInShapeCollection(int index) => ShapeInShapeCollectionTable?.Get(index);
        public SystemTable SystemTable { get; } // can be null
        public System GetSystem(int index) => SystemTable?.Get(index);
        public ElementInSystemTable ElementInSystemTable { get; } // can be null
        public ElementInSystem GetElementInSystem(int index) => ElementInSystemTable?.Get(index);
        public WarningTable WarningTable { get; } // can be null
        public Warning GetWarning(int index) => WarningTable?.Get(index);
        public ElementInWarningTable ElementInWarningTable { get; } // can be null
        public ElementInWarning GetElementInWarning(int index) => ElementInWarningTable?.Get(index);
        public BasePointTable BasePointTable { get; } // can be null
        public BasePoint GetBasePoint(int index) => BasePointTable?.Get(index);
        public PhaseFilterTable PhaseFilterTable { get; } // can be null
        public PhaseFilter GetPhaseFilter(int index) => PhaseFilterTable?.Get(index);
        public GridTable GridTable { get; } // can be null
        public Grid GetGrid(int index) => GridTable?.Get(index);
        public AreaTable AreaTable { get; } // can be null
        public Area GetArea(int index) => AreaTable?.Get(index);
        public AreaSchemeTable AreaSchemeTable { get; } // can be null
        public AreaScheme GetAreaScheme(int index) => AreaSchemeTable?.Get(index);
        public ScheduleTable ScheduleTable { get; } // can be null
        public Schedule GetSchedule(int index) => ScheduleTable?.Get(index);
        public ScheduleColumnTable ScheduleColumnTable { get; } // can be null
        public ScheduleColumn GetScheduleColumn(int index) => ScheduleColumnTable?.Get(index);
        public ScheduleCellTable ScheduleCellTable { get; } // can be null
        public ScheduleCell GetScheduleCell(int index) => ScheduleCellTable?.Get(index);
        public ViewSheetSetTable ViewSheetSetTable { get; } // can be null
        public ViewSheetSet GetViewSheetSet(int index) => ViewSheetSetTable?.Get(index);
        public ViewSheetTable ViewSheetTable { get; } // can be null
        public ViewSheet GetViewSheet(int index) => ViewSheetTable?.Get(index);
        public ViewSheetInViewSheetSetTable ViewSheetInViewSheetSetTable { get; } // can be null
        public ViewSheetInViewSheetSet GetViewSheetInViewSheetSet(int index) => ViewSheetInViewSheetSetTable?.Get(index);
        public ViewInViewSheetSetTable ViewInViewSheetSetTable { get; } // can be null
        public ViewInViewSheetSet GetViewInViewSheetSet(int index) => ViewInViewSheetSetTable?.Get(index);
        public ViewInViewSheetTable ViewInViewSheetTable { get; } // can be null
        public ViewInViewSheet GetViewInViewSheet(int index) => ViewInViewSheetTable?.Get(index);
        public SiteTable SiteTable { get; } // can be null
        public Site GetSite(int index) => SiteTable?.Get(index);
        public BuildingTable BuildingTable { get; } // can be null
        public Building GetBuilding(int index) => BuildingTable?.Get(index);
    } // class EntityTableSet
    
    public partial class AssetTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public AssetTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnBufferName = GetStringColumnValues("string:BufferName") ?? Array.Empty<String>();
        } // AssetTable constructor
        
        public String[] ColumnBufferName { get; }
        public String GetBufferName(int index, String @default = "") => ColumnBufferName.ElementAtOrDefault(index, @default);
        
        
        // Object Getter
        public Asset Get(int index)
        {
            if (index < 0) return null;
            var r = new Asset();
            r.Index = index;
            r.BufferName = GetBufferName(index);
            return r;
        } // Asset Get
    } // class AssetTable 
    
    public partial class DisplayUnitTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public DisplayUnitTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnSpec = GetStringColumnValues("string:Spec") ?? Array.Empty<String>();
            ColumnType = GetStringColumnValues("string:Type") ?? Array.Empty<String>();
            ColumnLabel = GetStringColumnValues("string:Label") ?? Array.Empty<String>();
        } // DisplayUnitTable constructor
        
        public String[] ColumnSpec { get; }
        public String GetSpec(int index, String @default = "") => ColumnSpec.ElementAtOrDefault(index, @default);
        
        public String[] ColumnType { get; }
        public String GetType(int index, String @default = "") => ColumnType.ElementAtOrDefault(index, @default);
        
        public String[] ColumnLabel { get; }
        public String GetLabel(int index, String @default = "") => ColumnLabel.ElementAtOrDefault(index, @default);
        
        
        // Object Getter
        public DisplayUnit Get(int index)
        {
            if (index < 0) return null;
            var r = new DisplayUnit();
            r.Index = index;
            r.Spec = GetSpec(index);
            r.Type = GetType(index);
            r.Label = GetLabel(index);
            return r;
        } // DisplayUnit Get
    } // class DisplayUnitTable 
    
    public partial class ParameterDescriptorTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ParameterDescriptorTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnName = GetStringColumnValues("string:Name") ?? Array.Empty<String>();
            ColumnGroup = GetStringColumnValues("string:Group") ?? Array.Empty<String>();
            ColumnParameterType = GetStringColumnValues("string:ParameterType") ?? Array.Empty<String>();
            ColumnIsInstance = GetDataColumnValues<Boolean>("byte:IsInstance") ?? Array.Empty<Boolean>();
            ColumnIsShared = GetDataColumnValues<Boolean>("byte:IsShared") ?? Array.Empty<Boolean>();
            ColumnIsReadOnly = GetDataColumnValues<Boolean>("byte:IsReadOnly") ?? Array.Empty<Boolean>();
            ColumnFlags = GetDataColumnValues<Int32>("int:Flags") ?? Array.Empty<Int32>();
            ColumnGuid = GetStringColumnValues("string:Guid") ?? Array.Empty<String>();
            ColumnStorageType = GetDataColumnValues<Int32>("int:StorageType") ?? Array.Empty<Int32>();
            ColumnDisplayUnitIndex = GetIndexColumnValues("index:Vim.DisplayUnit:DisplayUnit") ?? Array.Empty<int>();
        } // ParameterDescriptorTable constructor
        
        public String[] ColumnName { get; }
        public String GetName(int index, String @default = "") => ColumnName.ElementAtOrDefault(index, @default);
        
        public String[] ColumnGroup { get; }
        public String GetGroup(int index, String @default = "") => ColumnGroup.ElementAtOrDefault(index, @default);
        
        public String[] ColumnParameterType { get; }
        public String GetParameterType(int index, String @default = "") => ColumnParameterType.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsInstance { get; }
        public Boolean GetIsInstance(int index, Boolean @default = default) => ColumnIsInstance.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsShared { get; }
        public Boolean GetIsShared(int index, Boolean @default = default) => ColumnIsShared.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsReadOnly { get; }
        public Boolean GetIsReadOnly(int index, Boolean @default = default) => ColumnIsReadOnly.ElementAtOrDefault(index, @default);
        
        public Int32[] ColumnFlags { get; }
        public Int32 GetFlags(int index, Int32 @default = default) => ColumnFlags.ElementAtOrDefault(index, @default);
        
        public String[] ColumnGuid { get; }
        public String GetGuid(int index, String @default = "") => ColumnGuid.ElementAtOrDefault(index, @default);
        
        public Int32[] ColumnStorageType { get; }
        public Int32 GetStorageType(int index, Int32 @default = default) => ColumnStorageType.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnDisplayUnitIndex { get; }
        public int GetDisplayUnitIndex(int index) => ColumnDisplayUnitIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetDisplayUnit(int index) => _parentTableSet.GetDisplayUnit(GetDisplayUnitIndex(index));
        
        // Object Getter
        public ParameterDescriptor Get(int index)
        {
            if (index < 0) return null;
            var r = new ParameterDescriptor();
            r.Index = index;
            r.Name = GetName(index);
            r.Group = GetGroup(index);
            r.ParameterType = GetParameterType(index);
            r.IsInstance = GetIsInstance(index);
            r.IsShared = GetIsShared(index);
            r.IsReadOnly = GetIsReadOnly(index);
            r.Flags = GetFlags(index);
            r.Guid = GetGuid(index);
            r.StorageType = GetStorageType(index);
            r._DisplayUnit = new Relation<Vim.Format.ObjectModel.DisplayUnit>(GetDisplayUnitIndex(index), _parentTableSet.GetDisplayUnit);
            return r;
        } // ParameterDescriptor Get
    } // class ParameterDescriptorTable 
    
    public partial class ParameterTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ParameterTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnValue = GetStringColumnValues("string:Value") ?? Array.Empty<String>();
            ColumnParameterDescriptorIndex = GetIndexColumnValues("index:Vim.ParameterDescriptor:ParameterDescriptor") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // ParameterTable constructor
        
        public String[] ColumnValue { get; }
        public String GetValue(int index, String @default = "") => ColumnValue.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnParameterDescriptorIndex { get; }
        public int GetParameterDescriptorIndex(int index) => ColumnParameterDescriptorIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetParameterDescriptor(int index) => _parentTableSet.GetParameterDescriptor(GetParameterDescriptorIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Parameter Get(int index)
        {
            if (index < 0) return null;
            var r = new Parameter();
            r.Index = index;
            r.Value = GetValue(index);
            r._ParameterDescriptor = new Relation<Vim.Format.ObjectModel.ParameterDescriptor>(GetParameterDescriptorIndex(index), _parentTableSet.GetParameterDescriptor);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Parameter Get
    } // class ParameterTable 
    
    public partial class ElementTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ElementTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnId = (GetDataColumnValues<Int64>("long:Id") ?? GetDataColumnValues<Int32>("int:Id")?.Select(v => (Int64) v)) ?? Array.Empty<Int64>();
            ColumnType = GetStringColumnValues("string:Type") ?? Array.Empty<String>();
            ColumnName = GetStringColumnValues("string:Name") ?? Array.Empty<String>();
            ColumnUniqueId = GetStringColumnValues("string:UniqueId") ?? Array.Empty<String>();
            ColumnLocation_X = GetDataColumnValues<Single>("float:Location.X") ?? Array.Empty<Single>();
            ColumnLocation_Y = GetDataColumnValues<Single>("float:Location.Y") ?? Array.Empty<Single>();
            ColumnLocation_Z = GetDataColumnValues<Single>("float:Location.Z") ?? Array.Empty<Single>();
            ColumnFamilyName = GetStringColumnValues("string:FamilyName") ?? Array.Empty<String>();
            ColumnIsPinned = GetDataColumnValues<Boolean>("byte:IsPinned") ?? Array.Empty<Boolean>();
            ColumnLevelIndex = GetIndexColumnValues("index:Vim.Level:Level") ?? Array.Empty<int>();
            ColumnPhaseCreatedIndex = GetIndexColumnValues("index:Vim.Phase:PhaseCreated") ?? Array.Empty<int>();
            ColumnPhaseDemolishedIndex = GetIndexColumnValues("index:Vim.Phase:PhaseDemolished") ?? Array.Empty<int>();
            ColumnCategoryIndex = GetIndexColumnValues("index:Vim.Category:Category") ?? Array.Empty<int>();
            ColumnWorksetIndex = GetIndexColumnValues("index:Vim.Workset:Workset") ?? Array.Empty<int>();
            ColumnDesignOptionIndex = GetIndexColumnValues("index:Vim.DesignOption:DesignOption") ?? Array.Empty<int>();
            ColumnOwnerViewIndex = GetIndexColumnValues("index:Vim.View:OwnerView") ?? Array.Empty<int>();
            ColumnGroupIndex = GetIndexColumnValues("index:Vim.Group:Group") ?? Array.Empty<int>();
            ColumnAssemblyInstanceIndex = GetIndexColumnValues("index:Vim.AssemblyInstance:AssemblyInstance") ?? Array.Empty<int>();
            ColumnBimDocumentIndex = GetIndexColumnValues("index:Vim.BimDocument:BimDocument") ?? Array.Empty<int>();
            ColumnRoomIndex = GetIndexColumnValues("index:Vim.Room:Room") ?? Array.Empty<int>();
        } // ElementTable constructor
        
        public Int64[] ColumnId { get; }
        public Int64 GetId(int index, Int64 @default = default) => ColumnId.ElementAtOrDefault(index, @default);
        
        public String[] ColumnType { get; }
        public String GetType(int index, String @default = "") => ColumnType.ElementAtOrDefault(index, @default);
        
        public String[] ColumnName { get; }
        public String GetName(int index, String @default = "") => ColumnName.ElementAtOrDefault(index, @default);
        
        public String[] ColumnUniqueId { get; }
        public String GetUniqueId(int index, String @default = "") => ColumnUniqueId.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnLocation_X { get; }
        public Single GetLocation_X(int index, Single @default = default) => ColumnLocation_X.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnLocation_Y { get; }
        public Single GetLocation_Y(int index, Single @default = default) => ColumnLocation_Y.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnLocation_Z { get; }
        public Single GetLocation_Z(int index, Single @default = default) => ColumnLocation_Z.ElementAtOrDefault(index, @default);
        
        public String[] ColumnFamilyName { get; }
        public String GetFamilyName(int index, String @default = "") => ColumnFamilyName.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsPinned { get; }
        public Boolean GetIsPinned(int index, Boolean @default = default) => ColumnIsPinned.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnLevelIndex { get; }
        public int GetLevelIndex(int index) => ColumnLevelIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetLevel(int index) => _parentTableSet.GetLevel(GetLevelIndex(index));
        
        public int[] ColumnPhaseCreatedIndex { get; }
        public int GetPhaseCreatedIndex(int index) => ColumnPhaseCreatedIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetPhaseCreated(int index) => _parentTableSet.GetPhase(GetPhaseCreatedIndex(index));
        
        public int[] ColumnPhaseDemolishedIndex { get; }
        public int GetPhaseDemolishedIndex(int index) => ColumnPhaseDemolishedIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetPhaseDemolished(int index) => _parentTableSet.GetPhase(GetPhaseDemolishedIndex(index));
        
        public int[] ColumnCategoryIndex { get; }
        public int GetCategoryIndex(int index) => ColumnCategoryIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetCategory(int index) => _parentTableSet.GetCategory(GetCategoryIndex(index));
        
        public int[] ColumnWorksetIndex { get; }
        public int GetWorksetIndex(int index) => ColumnWorksetIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetWorkset(int index) => _parentTableSet.GetWorkset(GetWorksetIndex(index));
        
        public int[] ColumnDesignOptionIndex { get; }
        public int GetDesignOptionIndex(int index) => ColumnDesignOptionIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetDesignOption(int index) => _parentTableSet.GetDesignOption(GetDesignOptionIndex(index));
        
        public int[] ColumnOwnerViewIndex { get; }
        public int GetOwnerViewIndex(int index) => ColumnOwnerViewIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetOwnerView(int index) => _parentTableSet.GetView(GetOwnerViewIndex(index));
        
        public int[] ColumnGroupIndex { get; }
        public int GetGroupIndex(int index) => ColumnGroupIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetGroup(int index) => _parentTableSet.GetGroup(GetGroupIndex(index));
        
        public int[] ColumnAssemblyInstanceIndex { get; }
        public int GetAssemblyInstanceIndex(int index) => ColumnAssemblyInstanceIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetAssemblyInstance(int index) => _parentTableSet.GetAssemblyInstance(GetAssemblyInstanceIndex(index));
        
        public int[] ColumnBimDocumentIndex { get; }
        public int GetBimDocumentIndex(int index) => ColumnBimDocumentIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetBimDocument(int index) => _parentTableSet.GetBimDocument(GetBimDocumentIndex(index));
        
        public int[] ColumnRoomIndex { get; }
        public int GetRoomIndex(int index) => ColumnRoomIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetRoom(int index) => _parentTableSet.GetRoom(GetRoomIndex(index));
        
        // Object Getter
        public Element Get(int index)
        {
            if (index < 0) return null;
            var r = new Element();
            r.Index = index;
            r.Id = GetId(index);
            r.Type = GetType(index);
            r.Name = GetName(index);
            r.UniqueId = GetUniqueId(index);
            r.Location_X = GetLocation_X(index);
            r.Location_Y = GetLocation_Y(index);
            r.Location_Z = GetLocation_Z(index);
            r.FamilyName = GetFamilyName(index);
            r.IsPinned = GetIsPinned(index);
            r._Level = new Relation<Vim.Format.ObjectModel.Level>(GetLevelIndex(index), _parentTableSet.GetLevel);
            r._PhaseCreated = new Relation<Vim.Format.ObjectModel.Phase>(GetPhaseCreatedIndex(index), _parentTableSet.GetPhase);
            r._PhaseDemolished = new Relation<Vim.Format.ObjectModel.Phase>(GetPhaseDemolishedIndex(index), _parentTableSet.GetPhase);
            r._Category = new Relation<Vim.Format.ObjectModel.Category>(GetCategoryIndex(index), _parentTableSet.GetCategory);
            r._Workset = new Relation<Vim.Format.ObjectModel.Workset>(GetWorksetIndex(index), _parentTableSet.GetWorkset);
            r._DesignOption = new Relation<Vim.Format.ObjectModel.DesignOption>(GetDesignOptionIndex(index), _parentTableSet.GetDesignOption);
            r._OwnerView = new Relation<Vim.Format.ObjectModel.View>(GetOwnerViewIndex(index), _parentTableSet.GetView);
            r._Group = new Relation<Vim.Format.ObjectModel.Group>(GetGroupIndex(index), _parentTableSet.GetGroup);
            r._AssemblyInstance = new Relation<Vim.Format.ObjectModel.AssemblyInstance>(GetAssemblyInstanceIndex(index), _parentTableSet.GetAssemblyInstance);
            r._BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>(GetBimDocumentIndex(index), _parentTableSet.GetBimDocument);
            r._Room = new Relation<Vim.Format.ObjectModel.Room>(GetRoomIndex(index), _parentTableSet.GetRoom);
            return r;
        } // Element Get
    } // class ElementTable 
    
    public partial class WorksetTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public WorksetTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnId = GetDataColumnValues<Int32>("int:Id") ?? Array.Empty<Int32>();
            ColumnName = GetStringColumnValues("string:Name") ?? Array.Empty<String>();
            ColumnKind = GetStringColumnValues("string:Kind") ?? Array.Empty<String>();
            ColumnIsOpen = GetDataColumnValues<Boolean>("byte:IsOpen") ?? Array.Empty<Boolean>();
            ColumnIsEditable = GetDataColumnValues<Boolean>("byte:IsEditable") ?? Array.Empty<Boolean>();
            ColumnOwner = GetStringColumnValues("string:Owner") ?? Array.Empty<String>();
            ColumnUniqueId = GetStringColumnValues("string:UniqueId") ?? Array.Empty<String>();
            ColumnBimDocumentIndex = GetIndexColumnValues("index:Vim.BimDocument:BimDocument") ?? Array.Empty<int>();
        } // WorksetTable constructor
        
        public Int32[] ColumnId { get; }
        public Int32 GetId(int index, Int32 @default = default) => ColumnId.ElementAtOrDefault(index, @default);
        
        public String[] ColumnName { get; }
        public String GetName(int index, String @default = "") => ColumnName.ElementAtOrDefault(index, @default);
        
        public String[] ColumnKind { get; }
        public String GetKind(int index, String @default = "") => ColumnKind.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsOpen { get; }
        public Boolean GetIsOpen(int index, Boolean @default = default) => ColumnIsOpen.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsEditable { get; }
        public Boolean GetIsEditable(int index, Boolean @default = default) => ColumnIsEditable.ElementAtOrDefault(index, @default);
        
        public String[] ColumnOwner { get; }
        public String GetOwner(int index, String @default = "") => ColumnOwner.ElementAtOrDefault(index, @default);
        
        public String[] ColumnUniqueId { get; }
        public String GetUniqueId(int index, String @default = "") => ColumnUniqueId.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnBimDocumentIndex { get; }
        public int GetBimDocumentIndex(int index) => ColumnBimDocumentIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetBimDocument(int index) => _parentTableSet.GetBimDocument(GetBimDocumentIndex(index));
        
        // Object Getter
        public Workset Get(int index)
        {
            if (index < 0) return null;
            var r = new Workset();
            r.Index = index;
            r.Id = GetId(index);
            r.Name = GetName(index);
            r.Kind = GetKind(index);
            r.IsOpen = GetIsOpen(index);
            r.IsEditable = GetIsEditable(index);
            r.Owner = GetOwner(index);
            r.UniqueId = GetUniqueId(index);
            r._BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>(GetBimDocumentIndex(index), _parentTableSet.GetBimDocument);
            return r;
        } // Workset Get
    } // class WorksetTable 
    
    public partial class AssemblyInstanceTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public AssemblyInstanceTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnAssemblyTypeName = GetStringColumnValues("string:AssemblyTypeName") ?? Array.Empty<String>();
            ColumnPosition_X = GetDataColumnValues<Single>("float:Position.X") ?? Array.Empty<Single>();
            ColumnPosition_Y = GetDataColumnValues<Single>("float:Position.Y") ?? Array.Empty<Single>();
            ColumnPosition_Z = GetDataColumnValues<Single>("float:Position.Z") ?? Array.Empty<Single>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // AssemblyInstanceTable constructor
        
        public String[] ColumnAssemblyTypeName { get; }
        public String GetAssemblyTypeName(int index, String @default = "") => ColumnAssemblyTypeName.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnPosition_X { get; }
        public Single GetPosition_X(int index, Single @default = default) => ColumnPosition_X.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnPosition_Y { get; }
        public Single GetPosition_Y(int index, Single @default = default) => ColumnPosition_Y.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnPosition_Z { get; }
        public Single GetPosition_Z(int index, Single @default = default) => ColumnPosition_Z.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public AssemblyInstance Get(int index)
        {
            if (index < 0) return null;
            var r = new AssemblyInstance();
            r.Index = index;
            r.AssemblyTypeName = GetAssemblyTypeName(index);
            r.Position_X = GetPosition_X(index);
            r.Position_Y = GetPosition_Y(index);
            r.Position_Z = GetPosition_Z(index);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // AssemblyInstance Get
    } // class AssemblyInstanceTable 
    
    public partial class GroupTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public GroupTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnGroupType = GetStringColumnValues("string:GroupType") ?? Array.Empty<String>();
            ColumnPosition_X = GetDataColumnValues<Single>("float:Position.X") ?? Array.Empty<Single>();
            ColumnPosition_Y = GetDataColumnValues<Single>("float:Position.Y") ?? Array.Empty<Single>();
            ColumnPosition_Z = GetDataColumnValues<Single>("float:Position.Z") ?? Array.Empty<Single>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // GroupTable constructor
        
        public String[] ColumnGroupType { get; }
        public String GetGroupType(int index, String @default = "") => ColumnGroupType.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnPosition_X { get; }
        public Single GetPosition_X(int index, Single @default = default) => ColumnPosition_X.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnPosition_Y { get; }
        public Single GetPosition_Y(int index, Single @default = default) => ColumnPosition_Y.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnPosition_Z { get; }
        public Single GetPosition_Z(int index, Single @default = default) => ColumnPosition_Z.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Group Get(int index)
        {
            if (index < 0) return null;
            var r = new Group();
            r.Index = index;
            r.GroupType = GetGroupType(index);
            r.Position_X = GetPosition_X(index);
            r.Position_Y = GetPosition_Y(index);
            r.Position_Z = GetPosition_Z(index);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Group Get
    } // class GroupTable 
    
    public partial class DesignOptionTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public DesignOptionTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnIsPrimary = GetDataColumnValues<Boolean>("byte:IsPrimary") ?? Array.Empty<Boolean>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // DesignOptionTable constructor
        
        public Boolean[] ColumnIsPrimary { get; }
        public Boolean GetIsPrimary(int index, Boolean @default = default) => ColumnIsPrimary.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public DesignOption Get(int index)
        {
            if (index < 0) return null;
            var r = new DesignOption();
            r.Index = index;
            r.IsPrimary = GetIsPrimary(index);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // DesignOption Get
    } // class DesignOptionTable 
    
    public partial class LevelTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public LevelTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnElevation = GetDataColumnValues<Double>("double:Elevation") ?? Array.Empty<Double>();
            ColumnFamilyTypeIndex = GetIndexColumnValues("index:Vim.FamilyType:FamilyType") ?? Array.Empty<int>();
            ColumnBuildingIndex = GetIndexColumnValues("index:Vim.Building:Building") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // LevelTable constructor
        
        public Double[] ColumnElevation { get; }
        public Double GetElevation(int index, Double @default = default) => ColumnElevation.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnFamilyTypeIndex { get; }
        public int GetFamilyTypeIndex(int index) => ColumnFamilyTypeIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetFamilyType(int index) => _parentTableSet.GetFamilyType(GetFamilyTypeIndex(index));
        
        public int[] ColumnBuildingIndex { get; }
        public int GetBuildingIndex(int index) => ColumnBuildingIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetBuilding(int index) => _parentTableSet.GetBuilding(GetBuildingIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Level Get(int index)
        {
            if (index < 0) return null;
            var r = new Level();
            r.Index = index;
            r.Elevation = GetElevation(index);
            r._FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>(GetFamilyTypeIndex(index), _parentTableSet.GetFamilyType);
            r._Building = new Relation<Vim.Format.ObjectModel.Building>(GetBuildingIndex(index), _parentTableSet.GetBuilding);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Level Get
    } // class LevelTable 
    
    public partial class PhaseTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public PhaseTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // PhaseTable constructor
        
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Phase Get(int index)
        {
            if (index < 0) return null;
            var r = new Phase();
            r.Index = index;
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Phase Get
    } // class PhaseTable 
    
    public partial class RoomTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public RoomTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnBaseOffset = GetDataColumnValues<Double>("double:BaseOffset") ?? Array.Empty<Double>();
            ColumnLimitOffset = GetDataColumnValues<Double>("double:LimitOffset") ?? Array.Empty<Double>();
            ColumnUnboundedHeight = GetDataColumnValues<Double>("double:UnboundedHeight") ?? Array.Empty<Double>();
            ColumnVolume = GetDataColumnValues<Double>("double:Volume") ?? Array.Empty<Double>();
            ColumnPerimeter = GetDataColumnValues<Double>("double:Perimeter") ?? Array.Empty<Double>();
            ColumnArea = GetDataColumnValues<Double>("double:Area") ?? Array.Empty<Double>();
            ColumnNumber = GetStringColumnValues("string:Number") ?? Array.Empty<String>();
            ColumnUpperLimitIndex = GetIndexColumnValues("index:Vim.Level:UpperLimit") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // RoomTable constructor
        
        public Double[] ColumnBaseOffset { get; }
        public Double GetBaseOffset(int index, Double @default = default) => ColumnBaseOffset.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnLimitOffset { get; }
        public Double GetLimitOffset(int index, Double @default = default) => ColumnLimitOffset.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnUnboundedHeight { get; }
        public Double GetUnboundedHeight(int index, Double @default = default) => ColumnUnboundedHeight.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnVolume { get; }
        public Double GetVolume(int index, Double @default = default) => ColumnVolume.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnPerimeter { get; }
        public Double GetPerimeter(int index, Double @default = default) => ColumnPerimeter.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnArea { get; }
        public Double GetArea(int index, Double @default = default) => ColumnArea.ElementAtOrDefault(index, @default);
        
        public String[] ColumnNumber { get; }
        public String GetNumber(int index, String @default = "") => ColumnNumber.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnUpperLimitIndex { get; }
        public int GetUpperLimitIndex(int index) => ColumnUpperLimitIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetUpperLimit(int index) => _parentTableSet.GetLevel(GetUpperLimitIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Room Get(int index)
        {
            if (index < 0) return null;
            var r = new Room();
            r.Index = index;
            r.BaseOffset = GetBaseOffset(index);
            r.LimitOffset = GetLimitOffset(index);
            r.UnboundedHeight = GetUnboundedHeight(index);
            r.Volume = GetVolume(index);
            r.Perimeter = GetPerimeter(index);
            r.Area = GetArea(index);
            r.Number = GetNumber(index);
            r._UpperLimit = new Relation<Vim.Format.ObjectModel.Level>(GetUpperLimitIndex(index), _parentTableSet.GetLevel);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Room Get
    } // class RoomTable 
    
    public partial class BimDocumentTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public BimDocumentTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnTitle = GetStringColumnValues("string:Title") ?? Array.Empty<String>();
            ColumnIsMetric = GetDataColumnValues<Boolean>("byte:IsMetric") ?? Array.Empty<Boolean>();
            ColumnGuid = GetStringColumnValues("string:Guid") ?? Array.Empty<String>();
            ColumnNumSaves = GetDataColumnValues<Int32>("int:NumSaves") ?? Array.Empty<Int32>();
            ColumnIsLinked = GetDataColumnValues<Boolean>("byte:IsLinked") ?? Array.Empty<Boolean>();
            ColumnIsDetached = GetDataColumnValues<Boolean>("byte:IsDetached") ?? Array.Empty<Boolean>();
            ColumnIsWorkshared = GetDataColumnValues<Boolean>("byte:IsWorkshared") ?? Array.Empty<Boolean>();
            ColumnPathName = GetStringColumnValues("string:PathName") ?? Array.Empty<String>();
            ColumnLatitude = GetDataColumnValues<Double>("double:Latitude") ?? Array.Empty<Double>();
            ColumnLongitude = GetDataColumnValues<Double>("double:Longitude") ?? Array.Empty<Double>();
            ColumnTimeZone = GetDataColumnValues<Double>("double:TimeZone") ?? Array.Empty<Double>();
            ColumnPlaceName = GetStringColumnValues("string:PlaceName") ?? Array.Empty<String>();
            ColumnWeatherStationName = GetStringColumnValues("string:WeatherStationName") ?? Array.Empty<String>();
            ColumnElevation = GetDataColumnValues<Double>("double:Elevation") ?? Array.Empty<Double>();
            ColumnProjectLocation = GetStringColumnValues("string:ProjectLocation") ?? Array.Empty<String>();
            ColumnIssueDate = GetStringColumnValues("string:IssueDate") ?? Array.Empty<String>();
            ColumnStatus = GetStringColumnValues("string:Status") ?? Array.Empty<String>();
            ColumnClientName = GetStringColumnValues("string:ClientName") ?? Array.Empty<String>();
            ColumnAddress = GetStringColumnValues("string:Address") ?? Array.Empty<String>();
            ColumnName = GetStringColumnValues("string:Name") ?? Array.Empty<String>();
            ColumnNumber = GetStringColumnValues("string:Number") ?? Array.Empty<String>();
            ColumnAuthor = GetStringColumnValues("string:Author") ?? Array.Empty<String>();
            ColumnBuildingName = GetStringColumnValues("string:BuildingName") ?? Array.Empty<String>();
            ColumnOrganizationName = GetStringColumnValues("string:OrganizationName") ?? Array.Empty<String>();
            ColumnOrganizationDescription = GetStringColumnValues("string:OrganizationDescription") ?? Array.Empty<String>();
            ColumnProduct = GetStringColumnValues("string:Product") ?? Array.Empty<String>();
            ColumnVersion = GetStringColumnValues("string:Version") ?? Array.Empty<String>();
            ColumnUser = GetStringColumnValues("string:User") ?? Array.Empty<String>();
            ColumnActiveViewIndex = GetIndexColumnValues("index:Vim.View:ActiveView") ?? Array.Empty<int>();
            ColumnOwnerFamilyIndex = GetIndexColumnValues("index:Vim.Family:OwnerFamily") ?? Array.Empty<int>();
            ColumnParentIndex = GetIndexColumnValues("index:Vim.BimDocument:Parent") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // BimDocumentTable constructor
        
        public String[] ColumnTitle { get; }
        public String GetTitle(int index, String @default = "") => ColumnTitle.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsMetric { get; }
        public Boolean GetIsMetric(int index, Boolean @default = default) => ColumnIsMetric.ElementAtOrDefault(index, @default);
        
        public String[] ColumnGuid { get; }
        public String GetGuid(int index, String @default = "") => ColumnGuid.ElementAtOrDefault(index, @default);
        
        public Int32[] ColumnNumSaves { get; }
        public Int32 GetNumSaves(int index, Int32 @default = default) => ColumnNumSaves.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsLinked { get; }
        public Boolean GetIsLinked(int index, Boolean @default = default) => ColumnIsLinked.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsDetached { get; }
        public Boolean GetIsDetached(int index, Boolean @default = default) => ColumnIsDetached.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsWorkshared { get; }
        public Boolean GetIsWorkshared(int index, Boolean @default = default) => ColumnIsWorkshared.ElementAtOrDefault(index, @default);
        
        public String[] ColumnPathName { get; }
        public String GetPathName(int index, String @default = "") => ColumnPathName.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnLatitude { get; }
        public Double GetLatitude(int index, Double @default = default) => ColumnLatitude.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnLongitude { get; }
        public Double GetLongitude(int index, Double @default = default) => ColumnLongitude.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnTimeZone { get; }
        public Double GetTimeZone(int index, Double @default = default) => ColumnTimeZone.ElementAtOrDefault(index, @default);
        
        public String[] ColumnPlaceName { get; }
        public String GetPlaceName(int index, String @default = "") => ColumnPlaceName.ElementAtOrDefault(index, @default);
        
        public String[] ColumnWeatherStationName { get; }
        public String GetWeatherStationName(int index, String @default = "") => ColumnWeatherStationName.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnElevation { get; }
        public Double GetElevation(int index, Double @default = default) => ColumnElevation.ElementAtOrDefault(index, @default);
        
        public String[] ColumnProjectLocation { get; }
        public String GetProjectLocation(int index, String @default = "") => ColumnProjectLocation.ElementAtOrDefault(index, @default);
        
        public String[] ColumnIssueDate { get; }
        public String GetIssueDate(int index, String @default = "") => ColumnIssueDate.ElementAtOrDefault(index, @default);
        
        public String[] ColumnStatus { get; }
        public String GetStatus(int index, String @default = "") => ColumnStatus.ElementAtOrDefault(index, @default);
        
        public String[] ColumnClientName { get; }
        public String GetClientName(int index, String @default = "") => ColumnClientName.ElementAtOrDefault(index, @default);
        
        public String[] ColumnAddress { get; }
        public String GetAddress(int index, String @default = "") => ColumnAddress.ElementAtOrDefault(index, @default);
        
        public String[] ColumnName { get; }
        public String GetName(int index, String @default = "") => ColumnName.ElementAtOrDefault(index, @default);
        
        public String[] ColumnNumber { get; }
        public String GetNumber(int index, String @default = "") => ColumnNumber.ElementAtOrDefault(index, @default);
        
        public String[] ColumnAuthor { get; }
        public String GetAuthor(int index, String @default = "") => ColumnAuthor.ElementAtOrDefault(index, @default);
        
        public String[] ColumnBuildingName { get; }
        public String GetBuildingName(int index, String @default = "") => ColumnBuildingName.ElementAtOrDefault(index, @default);
        
        public String[] ColumnOrganizationName { get; }
        public String GetOrganizationName(int index, String @default = "") => ColumnOrganizationName.ElementAtOrDefault(index, @default);
        
        public String[] ColumnOrganizationDescription { get; }
        public String GetOrganizationDescription(int index, String @default = "") => ColumnOrganizationDescription.ElementAtOrDefault(index, @default);
        
        public String[] ColumnProduct { get; }
        public String GetProduct(int index, String @default = "") => ColumnProduct.ElementAtOrDefault(index, @default);
        
        public String[] ColumnVersion { get; }
        public String GetVersion(int index, String @default = "") => ColumnVersion.ElementAtOrDefault(index, @default);
        
        public String[] ColumnUser { get; }
        public String GetUser(int index, String @default = "") => ColumnUser.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnActiveViewIndex { get; }
        public int GetActiveViewIndex(int index) => ColumnActiveViewIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetActiveView(int index) => _parentTableSet.GetView(GetActiveViewIndex(index));
        
        public int[] ColumnOwnerFamilyIndex { get; }
        public int GetOwnerFamilyIndex(int index) => ColumnOwnerFamilyIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetOwnerFamily(int index) => _parentTableSet.GetFamily(GetOwnerFamilyIndex(index));
        
        public int[] ColumnParentIndex { get; }
        public int GetParentIndex(int index) => ColumnParentIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetParent(int index) => _parentTableSet.GetBimDocument(GetParentIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public BimDocument Get(int index)
        {
            if (index < 0) return null;
            var r = new BimDocument();
            r.Index = index;
            r.Title = GetTitle(index);
            r.IsMetric = GetIsMetric(index);
            r.Guid = GetGuid(index);
            r.NumSaves = GetNumSaves(index);
            r.IsLinked = GetIsLinked(index);
            r.IsDetached = GetIsDetached(index);
            r.IsWorkshared = GetIsWorkshared(index);
            r.PathName = GetPathName(index);
            r.Latitude = GetLatitude(index);
            r.Longitude = GetLongitude(index);
            r.TimeZone = GetTimeZone(index);
            r.PlaceName = GetPlaceName(index);
            r.WeatherStationName = GetWeatherStationName(index);
            r.Elevation = GetElevation(index);
            r.ProjectLocation = GetProjectLocation(index);
            r.IssueDate = GetIssueDate(index);
            r.Status = GetStatus(index);
            r.ClientName = GetClientName(index);
            r.Address = GetAddress(index);
            r.Name = GetName(index);
            r.Number = GetNumber(index);
            r.Author = GetAuthor(index);
            r.BuildingName = GetBuildingName(index);
            r.OrganizationName = GetOrganizationName(index);
            r.OrganizationDescription = GetOrganizationDescription(index);
            r.Product = GetProduct(index);
            r.Version = GetVersion(index);
            r.User = GetUser(index);
            r._ActiveView = new Relation<Vim.Format.ObjectModel.View>(GetActiveViewIndex(index), _parentTableSet.GetView);
            r._OwnerFamily = new Relation<Vim.Format.ObjectModel.Family>(GetOwnerFamilyIndex(index), _parentTableSet.GetFamily);
            r._Parent = new Relation<Vim.Format.ObjectModel.BimDocument>(GetParentIndex(index), _parentTableSet.GetBimDocument);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // BimDocument Get
    } // class BimDocumentTable 
    
    public partial class DisplayUnitInBimDocumentTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public DisplayUnitInBimDocumentTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnDisplayUnitIndex = GetIndexColumnValues("index:Vim.DisplayUnit:DisplayUnit") ?? Array.Empty<int>();
            ColumnBimDocumentIndex = GetIndexColumnValues("index:Vim.BimDocument:BimDocument") ?? Array.Empty<int>();
        } // DisplayUnitInBimDocumentTable constructor
        
        
        public int[] ColumnDisplayUnitIndex { get; }
        public int GetDisplayUnitIndex(int index) => ColumnDisplayUnitIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetDisplayUnit(int index) => _parentTableSet.GetDisplayUnit(GetDisplayUnitIndex(index));
        
        public int[] ColumnBimDocumentIndex { get; }
        public int GetBimDocumentIndex(int index) => ColumnBimDocumentIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetBimDocument(int index) => _parentTableSet.GetBimDocument(GetBimDocumentIndex(index));
        
        // Object Getter
        public DisplayUnitInBimDocument Get(int index)
        {
            if (index < 0) return null;
            var r = new DisplayUnitInBimDocument();
            r.Index = index;
            r._DisplayUnit = new Relation<Vim.Format.ObjectModel.DisplayUnit>(GetDisplayUnitIndex(index), _parentTableSet.GetDisplayUnit);
            r._BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>(GetBimDocumentIndex(index), _parentTableSet.GetBimDocument);
            return r;
        } // DisplayUnitInBimDocument Get
    } // class DisplayUnitInBimDocumentTable 
    
    public partial class PhaseOrderInBimDocumentTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public PhaseOrderInBimDocumentTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnOrderIndex = GetDataColumnValues<Int32>("int:OrderIndex") ?? Array.Empty<Int32>();
            ColumnPhaseIndex = GetIndexColumnValues("index:Vim.Phase:Phase") ?? Array.Empty<int>();
            ColumnBimDocumentIndex = GetIndexColumnValues("index:Vim.BimDocument:BimDocument") ?? Array.Empty<int>();
        } // PhaseOrderInBimDocumentTable constructor
        
        public Int32[] ColumnOrderIndex { get; }
        public Int32 GetOrderIndex(int index, Int32 @default = default) => ColumnOrderIndex.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnPhaseIndex { get; }
        public int GetPhaseIndex(int index) => ColumnPhaseIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetPhase(int index) => _parentTableSet.GetPhase(GetPhaseIndex(index));
        
        public int[] ColumnBimDocumentIndex { get; }
        public int GetBimDocumentIndex(int index) => ColumnBimDocumentIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetBimDocument(int index) => _parentTableSet.GetBimDocument(GetBimDocumentIndex(index));
        
        // Object Getter
        public PhaseOrderInBimDocument Get(int index)
        {
            if (index < 0) return null;
            var r = new PhaseOrderInBimDocument();
            r.Index = index;
            r.OrderIndex = GetOrderIndex(index);
            r._Phase = new Relation<Vim.Format.ObjectModel.Phase>(GetPhaseIndex(index), _parentTableSet.GetPhase);
            r._BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>(GetBimDocumentIndex(index), _parentTableSet.GetBimDocument);
            return r;
        } // PhaseOrderInBimDocument Get
    } // class PhaseOrderInBimDocumentTable 
    
    public partial class CategoryTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public CategoryTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnName = GetStringColumnValues("string:Name") ?? Array.Empty<String>();
            ColumnId = (GetDataColumnValues<Int64>("long:Id") ?? GetDataColumnValues<Int32>("int:Id")?.Select(v => (Int64) v)) ?? Array.Empty<Int64>();
            ColumnCategoryType = GetStringColumnValues("string:CategoryType") ?? Array.Empty<String>();
            ColumnLineColor_X = GetDataColumnValues<Double>("double:LineColor.X") ?? Array.Empty<Double>();
            ColumnLineColor_Y = GetDataColumnValues<Double>("double:LineColor.Y") ?? Array.Empty<Double>();
            ColumnLineColor_Z = GetDataColumnValues<Double>("double:LineColor.Z") ?? Array.Empty<Double>();
            ColumnBuiltInCategory = GetStringColumnValues("string:BuiltInCategory") ?? Array.Empty<String>();
            ColumnParentIndex = GetIndexColumnValues("index:Vim.Category:Parent") ?? Array.Empty<int>();
            ColumnMaterialIndex = GetIndexColumnValues("index:Vim.Material:Material") ?? Array.Empty<int>();
        } // CategoryTable constructor
        
        public String[] ColumnName { get; }
        public String GetName(int index, String @default = "") => ColumnName.ElementAtOrDefault(index, @default);
        
        public Int64[] ColumnId { get; }
        public Int64 GetId(int index, Int64 @default = default) => ColumnId.ElementAtOrDefault(index, @default);
        
        public String[] ColumnCategoryType { get; }
        public String GetCategoryType(int index, String @default = "") => ColumnCategoryType.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnLineColor_X { get; }
        public Double GetLineColor_X(int index, Double @default = default) => ColumnLineColor_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnLineColor_Y { get; }
        public Double GetLineColor_Y(int index, Double @default = default) => ColumnLineColor_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnLineColor_Z { get; }
        public Double GetLineColor_Z(int index, Double @default = default) => ColumnLineColor_Z.ElementAtOrDefault(index, @default);
        
        public String[] ColumnBuiltInCategory { get; }
        public String GetBuiltInCategory(int index, String @default = "") => ColumnBuiltInCategory.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnParentIndex { get; }
        public int GetParentIndex(int index) => ColumnParentIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetParent(int index) => _parentTableSet.GetCategory(GetParentIndex(index));
        
        public int[] ColumnMaterialIndex { get; }
        public int GetMaterialIndex(int index) => ColumnMaterialIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetMaterial(int index) => _parentTableSet.GetMaterial(GetMaterialIndex(index));
        
        // Object Getter
        public Category Get(int index)
        {
            if (index < 0) return null;
            var r = new Category();
            r.Index = index;
            r.Name = GetName(index);
            r.Id = GetId(index);
            r.CategoryType = GetCategoryType(index);
            r.LineColor_X = GetLineColor_X(index);
            r.LineColor_Y = GetLineColor_Y(index);
            r.LineColor_Z = GetLineColor_Z(index);
            r.BuiltInCategory = GetBuiltInCategory(index);
            r._Parent = new Relation<Vim.Format.ObjectModel.Category>(GetParentIndex(index), _parentTableSet.GetCategory);
            r._Material = new Relation<Vim.Format.ObjectModel.Material>(GetMaterialIndex(index), _parentTableSet.GetMaterial);
            return r;
        } // Category Get
    } // class CategoryTable 
    
    public partial class FamilyTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public FamilyTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnStructuralMaterialType = GetStringColumnValues("string:StructuralMaterialType") ?? Array.Empty<String>();
            ColumnStructuralSectionShape = GetStringColumnValues("string:StructuralSectionShape") ?? Array.Empty<String>();
            ColumnIsSystemFamily = GetDataColumnValues<Boolean>("byte:IsSystemFamily") ?? Array.Empty<Boolean>();
            ColumnIsInPlace = GetDataColumnValues<Boolean>("byte:IsInPlace") ?? Array.Empty<Boolean>();
            ColumnFamilyCategoryIndex = GetIndexColumnValues("index:Vim.Category:FamilyCategory") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // FamilyTable constructor
        
        public String[] ColumnStructuralMaterialType { get; }
        public String GetStructuralMaterialType(int index, String @default = "") => ColumnStructuralMaterialType.ElementAtOrDefault(index, @default);
        
        public String[] ColumnStructuralSectionShape { get; }
        public String GetStructuralSectionShape(int index, String @default = "") => ColumnStructuralSectionShape.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsSystemFamily { get; }
        public Boolean GetIsSystemFamily(int index, Boolean @default = default) => ColumnIsSystemFamily.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsInPlace { get; }
        public Boolean GetIsInPlace(int index, Boolean @default = default) => ColumnIsInPlace.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnFamilyCategoryIndex { get; }
        public int GetFamilyCategoryIndex(int index) => ColumnFamilyCategoryIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetFamilyCategory(int index) => _parentTableSet.GetCategory(GetFamilyCategoryIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Family Get(int index)
        {
            if (index < 0) return null;
            var r = new Family();
            r.Index = index;
            r.StructuralMaterialType = GetStructuralMaterialType(index);
            r.StructuralSectionShape = GetStructuralSectionShape(index);
            r.IsSystemFamily = GetIsSystemFamily(index);
            r.IsInPlace = GetIsInPlace(index);
            r._FamilyCategory = new Relation<Vim.Format.ObjectModel.Category>(GetFamilyCategoryIndex(index), _parentTableSet.GetCategory);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Family Get
    } // class FamilyTable 
    
    public partial class FamilyTypeTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public FamilyTypeTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnIsSystemFamilyType = GetDataColumnValues<Boolean>("byte:IsSystemFamilyType") ?? Array.Empty<Boolean>();
            ColumnFamilyIndex = GetIndexColumnValues("index:Vim.Family:Family") ?? Array.Empty<int>();
            ColumnCompoundStructureIndex = GetIndexColumnValues("index:Vim.CompoundStructure:CompoundStructure") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // FamilyTypeTable constructor
        
        public Boolean[] ColumnIsSystemFamilyType { get; }
        public Boolean GetIsSystemFamilyType(int index, Boolean @default = default) => ColumnIsSystemFamilyType.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnFamilyIndex { get; }
        public int GetFamilyIndex(int index) => ColumnFamilyIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetFamily(int index) => _parentTableSet.GetFamily(GetFamilyIndex(index));
        
        public int[] ColumnCompoundStructureIndex { get; }
        public int GetCompoundStructureIndex(int index) => ColumnCompoundStructureIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetCompoundStructure(int index) => _parentTableSet.GetCompoundStructure(GetCompoundStructureIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public FamilyType Get(int index)
        {
            if (index < 0) return null;
            var r = new FamilyType();
            r.Index = index;
            r.IsSystemFamilyType = GetIsSystemFamilyType(index);
            r._Family = new Relation<Vim.Format.ObjectModel.Family>(GetFamilyIndex(index), _parentTableSet.GetFamily);
            r._CompoundStructure = new Relation<Vim.Format.ObjectModel.CompoundStructure>(GetCompoundStructureIndex(index), _parentTableSet.GetCompoundStructure);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // FamilyType Get
    } // class FamilyTypeTable 
    
    public partial class FamilyInstanceTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public FamilyInstanceTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnFacingFlipped = GetDataColumnValues<Boolean>("byte:FacingFlipped") ?? Array.Empty<Boolean>();
            ColumnFacingOrientation_X = GetDataColumnValues<Single>("float:FacingOrientation.X") ?? Array.Empty<Single>();
            ColumnFacingOrientation_Y = GetDataColumnValues<Single>("float:FacingOrientation.Y") ?? Array.Empty<Single>();
            ColumnFacingOrientation_Z = GetDataColumnValues<Single>("float:FacingOrientation.Z") ?? Array.Empty<Single>();
            ColumnHandFlipped = GetDataColumnValues<Boolean>("byte:HandFlipped") ?? Array.Empty<Boolean>();
            ColumnMirrored = GetDataColumnValues<Boolean>("byte:Mirrored") ?? Array.Empty<Boolean>();
            ColumnHasModifiedGeometry = GetDataColumnValues<Boolean>("byte:HasModifiedGeometry") ?? Array.Empty<Boolean>();
            ColumnScale = GetDataColumnValues<Single>("float:Scale") ?? Array.Empty<Single>();
            ColumnBasisX_X = GetDataColumnValues<Single>("float:BasisX.X") ?? Array.Empty<Single>();
            ColumnBasisX_Y = GetDataColumnValues<Single>("float:BasisX.Y") ?? Array.Empty<Single>();
            ColumnBasisX_Z = GetDataColumnValues<Single>("float:BasisX.Z") ?? Array.Empty<Single>();
            ColumnBasisY_X = GetDataColumnValues<Single>("float:BasisY.X") ?? Array.Empty<Single>();
            ColumnBasisY_Y = GetDataColumnValues<Single>("float:BasisY.Y") ?? Array.Empty<Single>();
            ColumnBasisY_Z = GetDataColumnValues<Single>("float:BasisY.Z") ?? Array.Empty<Single>();
            ColumnBasisZ_X = GetDataColumnValues<Single>("float:BasisZ.X") ?? Array.Empty<Single>();
            ColumnBasisZ_Y = GetDataColumnValues<Single>("float:BasisZ.Y") ?? Array.Empty<Single>();
            ColumnBasisZ_Z = GetDataColumnValues<Single>("float:BasisZ.Z") ?? Array.Empty<Single>();
            ColumnTranslation_X = GetDataColumnValues<Single>("float:Translation.X") ?? Array.Empty<Single>();
            ColumnTranslation_Y = GetDataColumnValues<Single>("float:Translation.Y") ?? Array.Empty<Single>();
            ColumnTranslation_Z = GetDataColumnValues<Single>("float:Translation.Z") ?? Array.Empty<Single>();
            ColumnHandOrientation_X = GetDataColumnValues<Single>("float:HandOrientation.X") ?? Array.Empty<Single>();
            ColumnHandOrientation_Y = GetDataColumnValues<Single>("float:HandOrientation.Y") ?? Array.Empty<Single>();
            ColumnHandOrientation_Z = GetDataColumnValues<Single>("float:HandOrientation.Z") ?? Array.Empty<Single>();
            ColumnFamilyTypeIndex = GetIndexColumnValues("index:Vim.FamilyType:FamilyType") ?? Array.Empty<int>();
            ColumnHostIndex = GetIndexColumnValues("index:Vim.Element:Host") ?? Array.Empty<int>();
            ColumnFromRoomIndex = GetIndexColumnValues("index:Vim.Room:FromRoom") ?? Array.Empty<int>();
            ColumnToRoomIndex = GetIndexColumnValues("index:Vim.Room:ToRoom") ?? Array.Empty<int>();
            ColumnSuperComponentIndex = GetIndexColumnValues("index:Vim.Element:SuperComponent") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // FamilyInstanceTable constructor
        
        public Boolean[] ColumnFacingFlipped { get; }
        public Boolean GetFacingFlipped(int index, Boolean @default = default) => ColumnFacingFlipped.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnFacingOrientation_X { get; }
        public Single GetFacingOrientation_X(int index, Single @default = default) => ColumnFacingOrientation_X.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnFacingOrientation_Y { get; }
        public Single GetFacingOrientation_Y(int index, Single @default = default) => ColumnFacingOrientation_Y.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnFacingOrientation_Z { get; }
        public Single GetFacingOrientation_Z(int index, Single @default = default) => ColumnFacingOrientation_Z.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnHandFlipped { get; }
        public Boolean GetHandFlipped(int index, Boolean @default = default) => ColumnHandFlipped.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnMirrored { get; }
        public Boolean GetMirrored(int index, Boolean @default = default) => ColumnMirrored.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnHasModifiedGeometry { get; }
        public Boolean GetHasModifiedGeometry(int index, Boolean @default = default) => ColumnHasModifiedGeometry.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnScale { get; }
        public Single GetScale(int index, Single @default = default) => ColumnScale.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBasisX_X { get; }
        public Single GetBasisX_X(int index, Single @default = default) => ColumnBasisX_X.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBasisX_Y { get; }
        public Single GetBasisX_Y(int index, Single @default = default) => ColumnBasisX_Y.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBasisX_Z { get; }
        public Single GetBasisX_Z(int index, Single @default = default) => ColumnBasisX_Z.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBasisY_X { get; }
        public Single GetBasisY_X(int index, Single @default = default) => ColumnBasisY_X.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBasisY_Y { get; }
        public Single GetBasisY_Y(int index, Single @default = default) => ColumnBasisY_Y.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBasisY_Z { get; }
        public Single GetBasisY_Z(int index, Single @default = default) => ColumnBasisY_Z.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBasisZ_X { get; }
        public Single GetBasisZ_X(int index, Single @default = default) => ColumnBasisZ_X.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBasisZ_Y { get; }
        public Single GetBasisZ_Y(int index, Single @default = default) => ColumnBasisZ_Y.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBasisZ_Z { get; }
        public Single GetBasisZ_Z(int index, Single @default = default) => ColumnBasisZ_Z.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnTranslation_X { get; }
        public Single GetTranslation_X(int index, Single @default = default) => ColumnTranslation_X.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnTranslation_Y { get; }
        public Single GetTranslation_Y(int index, Single @default = default) => ColumnTranslation_Y.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnTranslation_Z { get; }
        public Single GetTranslation_Z(int index, Single @default = default) => ColumnTranslation_Z.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnHandOrientation_X { get; }
        public Single GetHandOrientation_X(int index, Single @default = default) => ColumnHandOrientation_X.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnHandOrientation_Y { get; }
        public Single GetHandOrientation_Y(int index, Single @default = default) => ColumnHandOrientation_Y.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnHandOrientation_Z { get; }
        public Single GetHandOrientation_Z(int index, Single @default = default) => ColumnHandOrientation_Z.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnFamilyTypeIndex { get; }
        public int GetFamilyTypeIndex(int index) => ColumnFamilyTypeIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetFamilyType(int index) => _parentTableSet.GetFamilyType(GetFamilyTypeIndex(index));
        
        public int[] ColumnHostIndex { get; }
        public int GetHostIndex(int index) => ColumnHostIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetHost(int index) => _parentTableSet.GetElement(GetHostIndex(index));
        
        public int[] ColumnFromRoomIndex { get; }
        public int GetFromRoomIndex(int index) => ColumnFromRoomIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetFromRoom(int index) => _parentTableSet.GetRoom(GetFromRoomIndex(index));
        
        public int[] ColumnToRoomIndex { get; }
        public int GetToRoomIndex(int index) => ColumnToRoomIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetToRoom(int index) => _parentTableSet.GetRoom(GetToRoomIndex(index));
        
        public int[] ColumnSuperComponentIndex { get; }
        public int GetSuperComponentIndex(int index) => ColumnSuperComponentIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetSuperComponent(int index) => _parentTableSet.GetElement(GetSuperComponentIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public FamilyInstance Get(int index)
        {
            if (index < 0) return null;
            var r = new FamilyInstance();
            r.Index = index;
            r.FacingFlipped = GetFacingFlipped(index);
            r.FacingOrientation_X = GetFacingOrientation_X(index);
            r.FacingOrientation_Y = GetFacingOrientation_Y(index);
            r.FacingOrientation_Z = GetFacingOrientation_Z(index);
            r.HandFlipped = GetHandFlipped(index);
            r.Mirrored = GetMirrored(index);
            r.HasModifiedGeometry = GetHasModifiedGeometry(index);
            r.Scale = GetScale(index);
            r.BasisX_X = GetBasisX_X(index);
            r.BasisX_Y = GetBasisX_Y(index);
            r.BasisX_Z = GetBasisX_Z(index);
            r.BasisY_X = GetBasisY_X(index);
            r.BasisY_Y = GetBasisY_Y(index);
            r.BasisY_Z = GetBasisY_Z(index);
            r.BasisZ_X = GetBasisZ_X(index);
            r.BasisZ_Y = GetBasisZ_Y(index);
            r.BasisZ_Z = GetBasisZ_Z(index);
            r.Translation_X = GetTranslation_X(index);
            r.Translation_Y = GetTranslation_Y(index);
            r.Translation_Z = GetTranslation_Z(index);
            r.HandOrientation_X = GetHandOrientation_X(index);
            r.HandOrientation_Y = GetHandOrientation_Y(index);
            r.HandOrientation_Z = GetHandOrientation_Z(index);
            r._FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>(GetFamilyTypeIndex(index), _parentTableSet.GetFamilyType);
            r._Host = new Relation<Vim.Format.ObjectModel.Element>(GetHostIndex(index), _parentTableSet.GetElement);
            r._FromRoom = new Relation<Vim.Format.ObjectModel.Room>(GetFromRoomIndex(index), _parentTableSet.GetRoom);
            r._ToRoom = new Relation<Vim.Format.ObjectModel.Room>(GetToRoomIndex(index), _parentTableSet.GetRoom);
            r._SuperComponent = new Relation<Vim.Format.ObjectModel.Element>(GetSuperComponentIndex(index), _parentTableSet.GetElement);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // FamilyInstance Get
    } // class FamilyInstanceTable 
    
    public partial class ViewTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ViewTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnTitle = GetStringColumnValues("string:Title") ?? Array.Empty<String>();
            ColumnViewType = GetStringColumnValues("string:ViewType") ?? Array.Empty<String>();
            ColumnUp_X = GetDataColumnValues<Double>("double:Up.X") ?? Array.Empty<Double>();
            ColumnUp_Y = GetDataColumnValues<Double>("double:Up.Y") ?? Array.Empty<Double>();
            ColumnUp_Z = GetDataColumnValues<Double>("double:Up.Z") ?? Array.Empty<Double>();
            ColumnRight_X = GetDataColumnValues<Double>("double:Right.X") ?? Array.Empty<Double>();
            ColumnRight_Y = GetDataColumnValues<Double>("double:Right.Y") ?? Array.Empty<Double>();
            ColumnRight_Z = GetDataColumnValues<Double>("double:Right.Z") ?? Array.Empty<Double>();
            ColumnOrigin_X = GetDataColumnValues<Double>("double:Origin.X") ?? Array.Empty<Double>();
            ColumnOrigin_Y = GetDataColumnValues<Double>("double:Origin.Y") ?? Array.Empty<Double>();
            ColumnOrigin_Z = GetDataColumnValues<Double>("double:Origin.Z") ?? Array.Empty<Double>();
            ColumnViewDirection_X = GetDataColumnValues<Double>("double:ViewDirection.X") ?? Array.Empty<Double>();
            ColumnViewDirection_Y = GetDataColumnValues<Double>("double:ViewDirection.Y") ?? Array.Empty<Double>();
            ColumnViewDirection_Z = GetDataColumnValues<Double>("double:ViewDirection.Z") ?? Array.Empty<Double>();
            ColumnViewPosition_X = GetDataColumnValues<Double>("double:ViewPosition.X") ?? Array.Empty<Double>();
            ColumnViewPosition_Y = GetDataColumnValues<Double>("double:ViewPosition.Y") ?? Array.Empty<Double>();
            ColumnViewPosition_Z = GetDataColumnValues<Double>("double:ViewPosition.Z") ?? Array.Empty<Double>();
            ColumnScale = GetDataColumnValues<Double>("double:Scale") ?? Array.Empty<Double>();
            ColumnOutline_Min_X = GetDataColumnValues<Double>("double:Outline.Min.X") ?? Array.Empty<Double>();
            ColumnOutline_Min_Y = GetDataColumnValues<Double>("double:Outline.Min.Y") ?? Array.Empty<Double>();
            ColumnOutline_Max_X = GetDataColumnValues<Double>("double:Outline.Max.X") ?? Array.Empty<Double>();
            ColumnOutline_Max_Y = GetDataColumnValues<Double>("double:Outline.Max.Y") ?? Array.Empty<Double>();
            ColumnDetailLevel = GetDataColumnValues<Int32>("int:DetailLevel") ?? Array.Empty<Int32>();
            ColumnCameraIndex = GetIndexColumnValues("index:Vim.Camera:Camera") ?? Array.Empty<int>();
            ColumnFamilyTypeIndex = GetIndexColumnValues("index:Vim.FamilyType:FamilyType") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // ViewTable constructor
        
        public String[] ColumnTitle { get; }
        public String GetTitle(int index, String @default = "") => ColumnTitle.ElementAtOrDefault(index, @default);
        
        public String[] ColumnViewType { get; }
        public String GetViewType(int index, String @default = "") => ColumnViewType.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnUp_X { get; }
        public Double GetUp_X(int index, Double @default = default) => ColumnUp_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnUp_Y { get; }
        public Double GetUp_Y(int index, Double @default = default) => ColumnUp_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnUp_Z { get; }
        public Double GetUp_Z(int index, Double @default = default) => ColumnUp_Z.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnRight_X { get; }
        public Double GetRight_X(int index, Double @default = default) => ColumnRight_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnRight_Y { get; }
        public Double GetRight_Y(int index, Double @default = default) => ColumnRight_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnRight_Z { get; }
        public Double GetRight_Z(int index, Double @default = default) => ColumnRight_Z.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnOrigin_X { get; }
        public Double GetOrigin_X(int index, Double @default = default) => ColumnOrigin_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnOrigin_Y { get; }
        public Double GetOrigin_Y(int index, Double @default = default) => ColumnOrigin_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnOrigin_Z { get; }
        public Double GetOrigin_Z(int index, Double @default = default) => ColumnOrigin_Z.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnViewDirection_X { get; }
        public Double GetViewDirection_X(int index, Double @default = default) => ColumnViewDirection_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnViewDirection_Y { get; }
        public Double GetViewDirection_Y(int index, Double @default = default) => ColumnViewDirection_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnViewDirection_Z { get; }
        public Double GetViewDirection_Z(int index, Double @default = default) => ColumnViewDirection_Z.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnViewPosition_X { get; }
        public Double GetViewPosition_X(int index, Double @default = default) => ColumnViewPosition_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnViewPosition_Y { get; }
        public Double GetViewPosition_Y(int index, Double @default = default) => ColumnViewPosition_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnViewPosition_Z { get; }
        public Double GetViewPosition_Z(int index, Double @default = default) => ColumnViewPosition_Z.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnScale { get; }
        public Double GetScale(int index, Double @default = default) => ColumnScale.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnOutline_Min_X { get; }
        public Double GetOutline_Min_X(int index, Double @default = default) => ColumnOutline_Min_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnOutline_Min_Y { get; }
        public Double GetOutline_Min_Y(int index, Double @default = default) => ColumnOutline_Min_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnOutline_Max_X { get; }
        public Double GetOutline_Max_X(int index, Double @default = default) => ColumnOutline_Max_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnOutline_Max_Y { get; }
        public Double GetOutline_Max_Y(int index, Double @default = default) => ColumnOutline_Max_Y.ElementAtOrDefault(index, @default);
        
        public Int32[] ColumnDetailLevel { get; }
        public Int32 GetDetailLevel(int index, Int32 @default = default) => ColumnDetailLevel.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnCameraIndex { get; }
        public int GetCameraIndex(int index) => ColumnCameraIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetCamera(int index) => _parentTableSet.GetCamera(GetCameraIndex(index));
        
        public int[] ColumnFamilyTypeIndex { get; }
        public int GetFamilyTypeIndex(int index) => ColumnFamilyTypeIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetFamilyType(int index) => _parentTableSet.GetFamilyType(GetFamilyTypeIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public View Get(int index)
        {
            if (index < 0) return null;
            var r = new View();
            r.Index = index;
            r.Title = GetTitle(index);
            r.ViewType = GetViewType(index);
            r.Up_X = GetUp_X(index);
            r.Up_Y = GetUp_Y(index);
            r.Up_Z = GetUp_Z(index);
            r.Right_X = GetRight_X(index);
            r.Right_Y = GetRight_Y(index);
            r.Right_Z = GetRight_Z(index);
            r.Origin_X = GetOrigin_X(index);
            r.Origin_Y = GetOrigin_Y(index);
            r.Origin_Z = GetOrigin_Z(index);
            r.ViewDirection_X = GetViewDirection_X(index);
            r.ViewDirection_Y = GetViewDirection_Y(index);
            r.ViewDirection_Z = GetViewDirection_Z(index);
            r.ViewPosition_X = GetViewPosition_X(index);
            r.ViewPosition_Y = GetViewPosition_Y(index);
            r.ViewPosition_Z = GetViewPosition_Z(index);
            r.Scale = GetScale(index);
            r.Outline_Min_X = GetOutline_Min_X(index);
            r.Outline_Min_Y = GetOutline_Min_Y(index);
            r.Outline_Max_X = GetOutline_Max_X(index);
            r.Outline_Max_Y = GetOutline_Max_Y(index);
            r.DetailLevel = GetDetailLevel(index);
            r._Camera = new Relation<Vim.Format.ObjectModel.Camera>(GetCameraIndex(index), _parentTableSet.GetCamera);
            r._FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>(GetFamilyTypeIndex(index), _parentTableSet.GetFamilyType);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // View Get
    } // class ViewTable 
    
    public partial class ElementInViewTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ElementInViewTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnViewIndex = GetIndexColumnValues("index:Vim.View:View") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // ElementInViewTable constructor
        
        
        public int[] ColumnViewIndex { get; }
        public int GetViewIndex(int index) => ColumnViewIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetView(int index) => _parentTableSet.GetView(GetViewIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public ElementInView Get(int index)
        {
            if (index < 0) return null;
            var r = new ElementInView();
            r.Index = index;
            r._View = new Relation<Vim.Format.ObjectModel.View>(GetViewIndex(index), _parentTableSet.GetView);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // ElementInView Get
    } // class ElementInViewTable 
    
    public partial class ShapeInViewTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ShapeInViewTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnShapeIndex = GetIndexColumnValues("index:Vim.Shape:Shape") ?? Array.Empty<int>();
            ColumnViewIndex = GetIndexColumnValues("index:Vim.View:View") ?? Array.Empty<int>();
        } // ShapeInViewTable constructor
        
        
        public int[] ColumnShapeIndex { get; }
        public int GetShapeIndex(int index) => ColumnShapeIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetShape(int index) => _parentTableSet.GetShape(GetShapeIndex(index));
        
        public int[] ColumnViewIndex { get; }
        public int GetViewIndex(int index) => ColumnViewIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetView(int index) => _parentTableSet.GetView(GetViewIndex(index));
        
        // Object Getter
        public ShapeInView Get(int index)
        {
            if (index < 0) return null;
            var r = new ShapeInView();
            r.Index = index;
            r._Shape = new Relation<Vim.Format.ObjectModel.Shape>(GetShapeIndex(index), _parentTableSet.GetShape);
            r._View = new Relation<Vim.Format.ObjectModel.View>(GetViewIndex(index), _parentTableSet.GetView);
            return r;
        } // ShapeInView Get
    } // class ShapeInViewTable 
    
    public partial class AssetInViewTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public AssetInViewTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnAssetIndex = GetIndexColumnValues("index:Vim.Asset:Asset") ?? Array.Empty<int>();
            ColumnViewIndex = GetIndexColumnValues("index:Vim.View:View") ?? Array.Empty<int>();
        } // AssetInViewTable constructor
        
        
        public int[] ColumnAssetIndex { get; }
        public int GetAssetIndex(int index) => ColumnAssetIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetAsset(int index) => _parentTableSet.GetAsset(GetAssetIndex(index));
        
        public int[] ColumnViewIndex { get; }
        public int GetViewIndex(int index) => ColumnViewIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetView(int index) => _parentTableSet.GetView(GetViewIndex(index));
        
        // Object Getter
        public AssetInView Get(int index)
        {
            if (index < 0) return null;
            var r = new AssetInView();
            r.Index = index;
            r._Asset = new Relation<Vim.Format.ObjectModel.Asset>(GetAssetIndex(index), _parentTableSet.GetAsset);
            r._View = new Relation<Vim.Format.ObjectModel.View>(GetViewIndex(index), _parentTableSet.GetView);
            return r;
        } // AssetInView Get
    } // class AssetInViewTable 
    
    public partial class AssetInViewSheetTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public AssetInViewSheetTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnAssetIndex = GetIndexColumnValues("index:Vim.Asset:Asset") ?? Array.Empty<int>();
            ColumnViewSheetIndex = GetIndexColumnValues("index:Vim.ViewSheet:ViewSheet") ?? Array.Empty<int>();
        } // AssetInViewSheetTable constructor
        
        
        public int[] ColumnAssetIndex { get; }
        public int GetAssetIndex(int index) => ColumnAssetIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetAsset(int index) => _parentTableSet.GetAsset(GetAssetIndex(index));
        
        public int[] ColumnViewSheetIndex { get; }
        public int GetViewSheetIndex(int index) => ColumnViewSheetIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetViewSheet(int index) => _parentTableSet.GetViewSheet(GetViewSheetIndex(index));
        
        // Object Getter
        public AssetInViewSheet Get(int index)
        {
            if (index < 0) return null;
            var r = new AssetInViewSheet();
            r.Index = index;
            r._Asset = new Relation<Vim.Format.ObjectModel.Asset>(GetAssetIndex(index), _parentTableSet.GetAsset);
            r._ViewSheet = new Relation<Vim.Format.ObjectModel.ViewSheet>(GetViewSheetIndex(index), _parentTableSet.GetViewSheet);
            return r;
        } // AssetInViewSheet Get
    } // class AssetInViewSheetTable 
    
    public partial class LevelInViewTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public LevelInViewTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnExtents_Min_X = GetDataColumnValues<Double>("double:Extents.Min.X") ?? Array.Empty<Double>();
            ColumnExtents_Min_Y = GetDataColumnValues<Double>("double:Extents.Min.Y") ?? Array.Empty<Double>();
            ColumnExtents_Min_Z = GetDataColumnValues<Double>("double:Extents.Min.Z") ?? Array.Empty<Double>();
            ColumnExtents_Max_X = GetDataColumnValues<Double>("double:Extents.Max.X") ?? Array.Empty<Double>();
            ColumnExtents_Max_Y = GetDataColumnValues<Double>("double:Extents.Max.Y") ?? Array.Empty<Double>();
            ColumnExtents_Max_Z = GetDataColumnValues<Double>("double:Extents.Max.Z") ?? Array.Empty<Double>();
            ColumnLevelIndex = GetIndexColumnValues("index:Vim.Level:Level") ?? Array.Empty<int>();
            ColumnViewIndex = GetIndexColumnValues("index:Vim.View:View") ?? Array.Empty<int>();
        } // LevelInViewTable constructor
        
        public Double[] ColumnExtents_Min_X { get; }
        public Double GetExtents_Min_X(int index, Double @default = default) => ColumnExtents_Min_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnExtents_Min_Y { get; }
        public Double GetExtents_Min_Y(int index, Double @default = default) => ColumnExtents_Min_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnExtents_Min_Z { get; }
        public Double GetExtents_Min_Z(int index, Double @default = default) => ColumnExtents_Min_Z.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnExtents_Max_X { get; }
        public Double GetExtents_Max_X(int index, Double @default = default) => ColumnExtents_Max_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnExtents_Max_Y { get; }
        public Double GetExtents_Max_Y(int index, Double @default = default) => ColumnExtents_Max_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnExtents_Max_Z { get; }
        public Double GetExtents_Max_Z(int index, Double @default = default) => ColumnExtents_Max_Z.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnLevelIndex { get; }
        public int GetLevelIndex(int index) => ColumnLevelIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetLevel(int index) => _parentTableSet.GetLevel(GetLevelIndex(index));
        
        public int[] ColumnViewIndex { get; }
        public int GetViewIndex(int index) => ColumnViewIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetView(int index) => _parentTableSet.GetView(GetViewIndex(index));
        
        // Object Getter
        public LevelInView Get(int index)
        {
            if (index < 0) return null;
            var r = new LevelInView();
            r.Index = index;
            r.Extents_Min_X = GetExtents_Min_X(index);
            r.Extents_Min_Y = GetExtents_Min_Y(index);
            r.Extents_Min_Z = GetExtents_Min_Z(index);
            r.Extents_Max_X = GetExtents_Max_X(index);
            r.Extents_Max_Y = GetExtents_Max_Y(index);
            r.Extents_Max_Z = GetExtents_Max_Z(index);
            r._Level = new Relation<Vim.Format.ObjectModel.Level>(GetLevelIndex(index), _parentTableSet.GetLevel);
            r._View = new Relation<Vim.Format.ObjectModel.View>(GetViewIndex(index), _parentTableSet.GetView);
            return r;
        } // LevelInView Get
    } // class LevelInViewTable 
    
    public partial class CameraTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public CameraTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnId = GetDataColumnValues<Int32>("int:Id") ?? Array.Empty<Int32>();
            ColumnIsPerspective = GetDataColumnValues<Int32>("int:IsPerspective") ?? Array.Empty<Int32>();
            ColumnVerticalExtent = GetDataColumnValues<Double>("double:VerticalExtent") ?? Array.Empty<Double>();
            ColumnHorizontalExtent = GetDataColumnValues<Double>("double:HorizontalExtent") ?? Array.Empty<Double>();
            ColumnFarDistance = GetDataColumnValues<Double>("double:FarDistance") ?? Array.Empty<Double>();
            ColumnNearDistance = GetDataColumnValues<Double>("double:NearDistance") ?? Array.Empty<Double>();
            ColumnTargetDistance = GetDataColumnValues<Double>("double:TargetDistance") ?? Array.Empty<Double>();
            ColumnRightOffset = GetDataColumnValues<Double>("double:RightOffset") ?? Array.Empty<Double>();
            ColumnUpOffset = GetDataColumnValues<Double>("double:UpOffset") ?? Array.Empty<Double>();
        } // CameraTable constructor
        
        public Int32[] ColumnId { get; }
        public Int32 GetId(int index, Int32 @default = default) => ColumnId.ElementAtOrDefault(index, @default);
        
        public Int32[] ColumnIsPerspective { get; }
        public Int32 GetIsPerspective(int index, Int32 @default = default) => ColumnIsPerspective.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnVerticalExtent { get; }
        public Double GetVerticalExtent(int index, Double @default = default) => ColumnVerticalExtent.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnHorizontalExtent { get; }
        public Double GetHorizontalExtent(int index, Double @default = default) => ColumnHorizontalExtent.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnFarDistance { get; }
        public Double GetFarDistance(int index, Double @default = default) => ColumnFarDistance.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnNearDistance { get; }
        public Double GetNearDistance(int index, Double @default = default) => ColumnNearDistance.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnTargetDistance { get; }
        public Double GetTargetDistance(int index, Double @default = default) => ColumnTargetDistance.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnRightOffset { get; }
        public Double GetRightOffset(int index, Double @default = default) => ColumnRightOffset.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnUpOffset { get; }
        public Double GetUpOffset(int index, Double @default = default) => ColumnUpOffset.ElementAtOrDefault(index, @default);
        
        
        // Object Getter
        public Camera Get(int index)
        {
            if (index < 0) return null;
            var r = new Camera();
            r.Index = index;
            r.Id = GetId(index);
            r.IsPerspective = GetIsPerspective(index);
            r.VerticalExtent = GetVerticalExtent(index);
            r.HorizontalExtent = GetHorizontalExtent(index);
            r.FarDistance = GetFarDistance(index);
            r.NearDistance = GetNearDistance(index);
            r.TargetDistance = GetTargetDistance(index);
            r.RightOffset = GetRightOffset(index);
            r.UpOffset = GetUpOffset(index);
            return r;
        } // Camera Get
    } // class CameraTable 
    
    public partial class MaterialTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public MaterialTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnName = GetStringColumnValues("string:Name") ?? Array.Empty<String>();
            ColumnMaterialCategory = GetStringColumnValues("string:MaterialCategory") ?? Array.Empty<String>();
            ColumnColor_X = GetDataColumnValues<Double>("double:Color.X") ?? Array.Empty<Double>();
            ColumnColor_Y = GetDataColumnValues<Double>("double:Color.Y") ?? Array.Empty<Double>();
            ColumnColor_Z = GetDataColumnValues<Double>("double:Color.Z") ?? Array.Empty<Double>();
            ColumnColorUvScaling_X = GetDataColumnValues<Double>("double:ColorUvScaling.X") ?? Array.Empty<Double>();
            ColumnColorUvScaling_Y = GetDataColumnValues<Double>("double:ColorUvScaling.Y") ?? Array.Empty<Double>();
            ColumnColorUvOffset_X = GetDataColumnValues<Double>("double:ColorUvOffset.X") ?? Array.Empty<Double>();
            ColumnColorUvOffset_Y = GetDataColumnValues<Double>("double:ColorUvOffset.Y") ?? Array.Empty<Double>();
            ColumnNormalUvScaling_X = GetDataColumnValues<Double>("double:NormalUvScaling.X") ?? Array.Empty<Double>();
            ColumnNormalUvScaling_Y = GetDataColumnValues<Double>("double:NormalUvScaling.Y") ?? Array.Empty<Double>();
            ColumnNormalUvOffset_X = GetDataColumnValues<Double>("double:NormalUvOffset.X") ?? Array.Empty<Double>();
            ColumnNormalUvOffset_Y = GetDataColumnValues<Double>("double:NormalUvOffset.Y") ?? Array.Empty<Double>();
            ColumnNormalAmount = GetDataColumnValues<Double>("double:NormalAmount") ?? Array.Empty<Double>();
            ColumnGlossiness = GetDataColumnValues<Double>("double:Glossiness") ?? Array.Empty<Double>();
            ColumnSmoothness = GetDataColumnValues<Double>("double:Smoothness") ?? Array.Empty<Double>();
            ColumnTransparency = GetDataColumnValues<Double>("double:Transparency") ?? Array.Empty<Double>();
            ColumnColorTextureFileIndex = GetIndexColumnValues("index:Vim.Asset:ColorTextureFile") ?? Array.Empty<int>();
            ColumnNormalTextureFileIndex = GetIndexColumnValues("index:Vim.Asset:NormalTextureFile") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // MaterialTable constructor
        
        public String[] ColumnName { get; }
        public String GetName(int index, String @default = "") => ColumnName.ElementAtOrDefault(index, @default);
        
        public String[] ColumnMaterialCategory { get; }
        public String GetMaterialCategory(int index, String @default = "") => ColumnMaterialCategory.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnColor_X { get; }
        public Double GetColor_X(int index, Double @default = default) => ColumnColor_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnColor_Y { get; }
        public Double GetColor_Y(int index, Double @default = default) => ColumnColor_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnColor_Z { get; }
        public Double GetColor_Z(int index, Double @default = default) => ColumnColor_Z.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnColorUvScaling_X { get; }
        public Double GetColorUvScaling_X(int index, Double @default = default) => ColumnColorUvScaling_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnColorUvScaling_Y { get; }
        public Double GetColorUvScaling_Y(int index, Double @default = default) => ColumnColorUvScaling_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnColorUvOffset_X { get; }
        public Double GetColorUvOffset_X(int index, Double @default = default) => ColumnColorUvOffset_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnColorUvOffset_Y { get; }
        public Double GetColorUvOffset_Y(int index, Double @default = default) => ColumnColorUvOffset_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnNormalUvScaling_X { get; }
        public Double GetNormalUvScaling_X(int index, Double @default = default) => ColumnNormalUvScaling_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnNormalUvScaling_Y { get; }
        public Double GetNormalUvScaling_Y(int index, Double @default = default) => ColumnNormalUvScaling_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnNormalUvOffset_X { get; }
        public Double GetNormalUvOffset_X(int index, Double @default = default) => ColumnNormalUvOffset_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnNormalUvOffset_Y { get; }
        public Double GetNormalUvOffset_Y(int index, Double @default = default) => ColumnNormalUvOffset_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnNormalAmount { get; }
        public Double GetNormalAmount(int index, Double @default = default) => ColumnNormalAmount.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnGlossiness { get; }
        public Double GetGlossiness(int index, Double @default = default) => ColumnGlossiness.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnSmoothness { get; }
        public Double GetSmoothness(int index, Double @default = default) => ColumnSmoothness.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnTransparency { get; }
        public Double GetTransparency(int index, Double @default = default) => ColumnTransparency.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnColorTextureFileIndex { get; }
        public int GetColorTextureFileIndex(int index) => ColumnColorTextureFileIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetColorTextureFile(int index) => _parentTableSet.GetAsset(GetColorTextureFileIndex(index));
        
        public int[] ColumnNormalTextureFileIndex { get; }
        public int GetNormalTextureFileIndex(int index) => ColumnNormalTextureFileIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetNormalTextureFile(int index) => _parentTableSet.GetAsset(GetNormalTextureFileIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Material Get(int index)
        {
            if (index < 0) return null;
            var r = new Material();
            r.Index = index;
            r.Name = GetName(index);
            r.MaterialCategory = GetMaterialCategory(index);
            r.Color_X = GetColor_X(index);
            r.Color_Y = GetColor_Y(index);
            r.Color_Z = GetColor_Z(index);
            r.ColorUvScaling_X = GetColorUvScaling_X(index);
            r.ColorUvScaling_Y = GetColorUvScaling_Y(index);
            r.ColorUvOffset_X = GetColorUvOffset_X(index);
            r.ColorUvOffset_Y = GetColorUvOffset_Y(index);
            r.NormalUvScaling_X = GetNormalUvScaling_X(index);
            r.NormalUvScaling_Y = GetNormalUvScaling_Y(index);
            r.NormalUvOffset_X = GetNormalUvOffset_X(index);
            r.NormalUvOffset_Y = GetNormalUvOffset_Y(index);
            r.NormalAmount = GetNormalAmount(index);
            r.Glossiness = GetGlossiness(index);
            r.Smoothness = GetSmoothness(index);
            r.Transparency = GetTransparency(index);
            r._ColorTextureFile = new Relation<Vim.Format.ObjectModel.Asset>(GetColorTextureFileIndex(index), _parentTableSet.GetAsset);
            r._NormalTextureFile = new Relation<Vim.Format.ObjectModel.Asset>(GetNormalTextureFileIndex(index), _parentTableSet.GetAsset);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Material Get
    } // class MaterialTable 
    
    public partial class MaterialInElementTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public MaterialInElementTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnArea = GetDataColumnValues<Double>("double:Area") ?? Array.Empty<Double>();
            ColumnVolume = GetDataColumnValues<Double>("double:Volume") ?? Array.Empty<Double>();
            ColumnIsPaint = GetDataColumnValues<Boolean>("byte:IsPaint") ?? Array.Empty<Boolean>();
            ColumnMaterialIndex = GetIndexColumnValues("index:Vim.Material:Material") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // MaterialInElementTable constructor
        
        public Double[] ColumnArea { get; }
        public Double GetArea(int index, Double @default = default) => ColumnArea.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnVolume { get; }
        public Double GetVolume(int index, Double @default = default) => ColumnVolume.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsPaint { get; }
        public Boolean GetIsPaint(int index, Boolean @default = default) => ColumnIsPaint.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnMaterialIndex { get; }
        public int GetMaterialIndex(int index) => ColumnMaterialIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetMaterial(int index) => _parentTableSet.GetMaterial(GetMaterialIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public MaterialInElement Get(int index)
        {
            if (index < 0) return null;
            var r = new MaterialInElement();
            r.Index = index;
            r.Area = GetArea(index);
            r.Volume = GetVolume(index);
            r.IsPaint = GetIsPaint(index);
            r._Material = new Relation<Vim.Format.ObjectModel.Material>(GetMaterialIndex(index), _parentTableSet.GetMaterial);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // MaterialInElement Get
    } // class MaterialInElementTable 
    
    public partial class CompoundStructureLayerTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public CompoundStructureLayerTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnOrderIndex = GetDataColumnValues<Int32>("int:OrderIndex") ?? Array.Empty<Int32>();
            ColumnWidth = GetDataColumnValues<Double>("double:Width") ?? Array.Empty<Double>();
            ColumnMaterialFunctionAssignment = GetStringColumnValues("string:MaterialFunctionAssignment") ?? Array.Empty<String>();
            ColumnMaterialIndex = GetIndexColumnValues("index:Vim.Material:Material") ?? Array.Empty<int>();
            ColumnCompoundStructureIndex = GetIndexColumnValues("index:Vim.CompoundStructure:CompoundStructure") ?? Array.Empty<int>();
        } // CompoundStructureLayerTable constructor
        
        public Int32[] ColumnOrderIndex { get; }
        public Int32 GetOrderIndex(int index, Int32 @default = default) => ColumnOrderIndex.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnWidth { get; }
        public Double GetWidth(int index, Double @default = default) => ColumnWidth.ElementAtOrDefault(index, @default);
        
        public String[] ColumnMaterialFunctionAssignment { get; }
        public String GetMaterialFunctionAssignment(int index, String @default = "") => ColumnMaterialFunctionAssignment.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnMaterialIndex { get; }
        public int GetMaterialIndex(int index) => ColumnMaterialIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetMaterial(int index) => _parentTableSet.GetMaterial(GetMaterialIndex(index));
        
        public int[] ColumnCompoundStructureIndex { get; }
        public int GetCompoundStructureIndex(int index) => ColumnCompoundStructureIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetCompoundStructure(int index) => _parentTableSet.GetCompoundStructure(GetCompoundStructureIndex(index));
        
        // Object Getter
        public CompoundStructureLayer Get(int index)
        {
            if (index < 0) return null;
            var r = new CompoundStructureLayer();
            r.Index = index;
            r.OrderIndex = GetOrderIndex(index);
            r.Width = GetWidth(index);
            r.MaterialFunctionAssignment = GetMaterialFunctionAssignment(index);
            r._Material = new Relation<Vim.Format.ObjectModel.Material>(GetMaterialIndex(index), _parentTableSet.GetMaterial);
            r._CompoundStructure = new Relation<Vim.Format.ObjectModel.CompoundStructure>(GetCompoundStructureIndex(index), _parentTableSet.GetCompoundStructure);
            return r;
        } // CompoundStructureLayer Get
    } // class CompoundStructureLayerTable 
    
    public partial class CompoundStructureTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public CompoundStructureTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnWidth = GetDataColumnValues<Double>("double:Width") ?? Array.Empty<Double>();
            ColumnStructuralLayerIndex = GetIndexColumnValues("index:Vim.CompoundStructureLayer:StructuralLayer") ?? Array.Empty<int>();
        } // CompoundStructureTable constructor
        
        public Double[] ColumnWidth { get; }
        public Double GetWidth(int index, Double @default = default) => ColumnWidth.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnStructuralLayerIndex { get; }
        public int GetStructuralLayerIndex(int index) => ColumnStructuralLayerIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetStructuralLayer(int index) => _parentTableSet.GetCompoundStructureLayer(GetStructuralLayerIndex(index));
        
        // Object Getter
        public CompoundStructure Get(int index)
        {
            if (index < 0) return null;
            var r = new CompoundStructure();
            r.Index = index;
            r.Width = GetWidth(index);
            r._StructuralLayer = new Relation<Vim.Format.ObjectModel.CompoundStructureLayer>(GetStructuralLayerIndex(index), _parentTableSet.GetCompoundStructureLayer);
            return r;
        } // CompoundStructure Get
    } // class CompoundStructureTable 
    
    public partial class NodeTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public NodeTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // NodeTable constructor
        
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Node Get(int index)
        {
            if (index < 0) return null;
            var r = new Node();
            r.Index = index;
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Node Get
    } // class NodeTable 
    
    public partial class GeometryTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public GeometryTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnBox_Min_X = GetDataColumnValues<Single>("float:Box.Min.X") ?? Array.Empty<Single>();
            ColumnBox_Min_Y = GetDataColumnValues<Single>("float:Box.Min.Y") ?? Array.Empty<Single>();
            ColumnBox_Min_Z = GetDataColumnValues<Single>("float:Box.Min.Z") ?? Array.Empty<Single>();
            ColumnBox_Max_X = GetDataColumnValues<Single>("float:Box.Max.X") ?? Array.Empty<Single>();
            ColumnBox_Max_Y = GetDataColumnValues<Single>("float:Box.Max.Y") ?? Array.Empty<Single>();
            ColumnBox_Max_Z = GetDataColumnValues<Single>("float:Box.Max.Z") ?? Array.Empty<Single>();
            ColumnVertexCount = GetDataColumnValues<Int32>("int:VertexCount") ?? Array.Empty<Int32>();
            ColumnFaceCount = GetDataColumnValues<Int32>("int:FaceCount") ?? Array.Empty<Int32>();
        } // GeometryTable constructor
        
        public Single[] ColumnBox_Min_X { get; }
        public Single GetBox_Min_X(int index, Single @default = default) => ColumnBox_Min_X.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBox_Min_Y { get; }
        public Single GetBox_Min_Y(int index, Single @default = default) => ColumnBox_Min_Y.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBox_Min_Z { get; }
        public Single GetBox_Min_Z(int index, Single @default = default) => ColumnBox_Min_Z.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBox_Max_X { get; }
        public Single GetBox_Max_X(int index, Single @default = default) => ColumnBox_Max_X.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBox_Max_Y { get; }
        public Single GetBox_Max_Y(int index, Single @default = default) => ColumnBox_Max_Y.ElementAtOrDefault(index, @default);
        
        public Single[] ColumnBox_Max_Z { get; }
        public Single GetBox_Max_Z(int index, Single @default = default) => ColumnBox_Max_Z.ElementAtOrDefault(index, @default);
        
        public Int32[] ColumnVertexCount { get; }
        public Int32 GetVertexCount(int index, Int32 @default = default) => ColumnVertexCount.ElementAtOrDefault(index, @default);
        
        public Int32[] ColumnFaceCount { get; }
        public Int32 GetFaceCount(int index, Int32 @default = default) => ColumnFaceCount.ElementAtOrDefault(index, @default);
        
        
        // Object Getter
        public Geometry Get(int index)
        {
            if (index < 0) return null;
            var r = new Geometry();
            r.Index = index;
            r.Box_Min_X = GetBox_Min_X(index);
            r.Box_Min_Y = GetBox_Min_Y(index);
            r.Box_Min_Z = GetBox_Min_Z(index);
            r.Box_Max_X = GetBox_Max_X(index);
            r.Box_Max_Y = GetBox_Max_Y(index);
            r.Box_Max_Z = GetBox_Max_Z(index);
            r.VertexCount = GetVertexCount(index);
            r.FaceCount = GetFaceCount(index);
            return r;
        } // Geometry Get
    } // class GeometryTable 
    
    public partial class ShapeTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ShapeTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // ShapeTable constructor
        
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Shape Get(int index)
        {
            if (index < 0) return null;
            var r = new Shape();
            r.Index = index;
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Shape Get
    } // class ShapeTable 
    
    public partial class ShapeCollectionTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ShapeCollectionTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // ShapeCollectionTable constructor
        
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public ShapeCollection Get(int index)
        {
            if (index < 0) return null;
            var r = new ShapeCollection();
            r.Index = index;
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // ShapeCollection Get
    } // class ShapeCollectionTable 
    
    public partial class ShapeInShapeCollectionTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ShapeInShapeCollectionTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnShapeIndex = GetIndexColumnValues("index:Vim.Shape:Shape") ?? Array.Empty<int>();
            ColumnShapeCollectionIndex = GetIndexColumnValues("index:Vim.ShapeCollection:ShapeCollection") ?? Array.Empty<int>();
        } // ShapeInShapeCollectionTable constructor
        
        
        public int[] ColumnShapeIndex { get; }
        public int GetShapeIndex(int index) => ColumnShapeIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetShape(int index) => _parentTableSet.GetShape(GetShapeIndex(index));
        
        public int[] ColumnShapeCollectionIndex { get; }
        public int GetShapeCollectionIndex(int index) => ColumnShapeCollectionIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetShapeCollection(int index) => _parentTableSet.GetShapeCollection(GetShapeCollectionIndex(index));
        
        // Object Getter
        public ShapeInShapeCollection Get(int index)
        {
            if (index < 0) return null;
            var r = new ShapeInShapeCollection();
            r.Index = index;
            r._Shape = new Relation<Vim.Format.ObjectModel.Shape>(GetShapeIndex(index), _parentTableSet.GetShape);
            r._ShapeCollection = new Relation<Vim.Format.ObjectModel.ShapeCollection>(GetShapeCollectionIndex(index), _parentTableSet.GetShapeCollection);
            return r;
        } // ShapeInShapeCollection Get
    } // class ShapeInShapeCollectionTable 
    
    public partial class SystemTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public SystemTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnSystemType = GetDataColumnValues<Int32>("int:SystemType") ?? Array.Empty<Int32>();
            ColumnFamilyTypeIndex = GetIndexColumnValues("index:Vim.FamilyType:FamilyType") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // SystemTable constructor
        
        public Int32[] ColumnSystemType { get; }
        public Int32 GetSystemType(int index, Int32 @default = default) => ColumnSystemType.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnFamilyTypeIndex { get; }
        public int GetFamilyTypeIndex(int index) => ColumnFamilyTypeIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetFamilyType(int index) => _parentTableSet.GetFamilyType(GetFamilyTypeIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public System Get(int index)
        {
            if (index < 0) return null;
            var r = new System();
            r.Index = index;
            r.SystemType = GetSystemType(index);
            r._FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>(GetFamilyTypeIndex(index), _parentTableSet.GetFamilyType);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // System Get
    } // class SystemTable 
    
    public partial class ElementInSystemTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ElementInSystemTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnRoles = GetDataColumnValues<Int32>("int:Roles") ?? Array.Empty<Int32>();
            ColumnSystemIndex = GetIndexColumnValues("index:Vim.System:System") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // ElementInSystemTable constructor
        
        public Int32[] ColumnRoles { get; }
        public Int32 GetRoles(int index, Int32 @default = default) => ColumnRoles.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnSystemIndex { get; }
        public int GetSystemIndex(int index) => ColumnSystemIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetSystem(int index) => _parentTableSet.GetSystem(GetSystemIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public ElementInSystem Get(int index)
        {
            if (index < 0) return null;
            var r = new ElementInSystem();
            r.Index = index;
            r.Roles = GetRoles(index);
            r._System = new Relation<Vim.Format.ObjectModel.System>(GetSystemIndex(index), _parentTableSet.GetSystem);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // ElementInSystem Get
    } // class ElementInSystemTable 
    
    public partial class WarningTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public WarningTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnGuid = GetStringColumnValues("string:Guid") ?? Array.Empty<String>();
            ColumnSeverity = GetStringColumnValues("string:Severity") ?? Array.Empty<String>();
            ColumnDescription = GetStringColumnValues("string:Description") ?? Array.Empty<String>();
            ColumnBimDocumentIndex = GetIndexColumnValues("index:Vim.BimDocument:BimDocument") ?? Array.Empty<int>();
        } // WarningTable constructor
        
        public String[] ColumnGuid { get; }
        public String GetGuid(int index, String @default = "") => ColumnGuid.ElementAtOrDefault(index, @default);
        
        public String[] ColumnSeverity { get; }
        public String GetSeverity(int index, String @default = "") => ColumnSeverity.ElementAtOrDefault(index, @default);
        
        public String[] ColumnDescription { get; }
        public String GetDescription(int index, String @default = "") => ColumnDescription.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnBimDocumentIndex { get; }
        public int GetBimDocumentIndex(int index) => ColumnBimDocumentIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetBimDocument(int index) => _parentTableSet.GetBimDocument(GetBimDocumentIndex(index));
        
        // Object Getter
        public Warning Get(int index)
        {
            if (index < 0) return null;
            var r = new Warning();
            r.Index = index;
            r.Guid = GetGuid(index);
            r.Severity = GetSeverity(index);
            r.Description = GetDescription(index);
            r._BimDocument = new Relation<Vim.Format.ObjectModel.BimDocument>(GetBimDocumentIndex(index), _parentTableSet.GetBimDocument);
            return r;
        } // Warning Get
    } // class WarningTable 
    
    public partial class ElementInWarningTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ElementInWarningTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnWarningIndex = GetIndexColumnValues("index:Vim.Warning:Warning") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // ElementInWarningTable constructor
        
        
        public int[] ColumnWarningIndex { get; }
        public int GetWarningIndex(int index) => ColumnWarningIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetWarning(int index) => _parentTableSet.GetWarning(GetWarningIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public ElementInWarning Get(int index)
        {
            if (index < 0) return null;
            var r = new ElementInWarning();
            r.Index = index;
            r._Warning = new Relation<Vim.Format.ObjectModel.Warning>(GetWarningIndex(index), _parentTableSet.GetWarning);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // ElementInWarning Get
    } // class ElementInWarningTable 
    
    public partial class BasePointTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public BasePointTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnIsSurveyPoint = GetDataColumnValues<Boolean>("byte:IsSurveyPoint") ?? Array.Empty<Boolean>();
            ColumnPosition_X = GetDataColumnValues<Double>("double:Position.X") ?? Array.Empty<Double>();
            ColumnPosition_Y = GetDataColumnValues<Double>("double:Position.Y") ?? Array.Empty<Double>();
            ColumnPosition_Z = GetDataColumnValues<Double>("double:Position.Z") ?? Array.Empty<Double>();
            ColumnSharedPosition_X = GetDataColumnValues<Double>("double:SharedPosition.X") ?? Array.Empty<Double>();
            ColumnSharedPosition_Y = GetDataColumnValues<Double>("double:SharedPosition.Y") ?? Array.Empty<Double>();
            ColumnSharedPosition_Z = GetDataColumnValues<Double>("double:SharedPosition.Z") ?? Array.Empty<Double>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // BasePointTable constructor
        
        public Boolean[] ColumnIsSurveyPoint { get; }
        public Boolean GetIsSurveyPoint(int index, Boolean @default = default) => ColumnIsSurveyPoint.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnPosition_X { get; }
        public Double GetPosition_X(int index, Double @default = default) => ColumnPosition_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnPosition_Y { get; }
        public Double GetPosition_Y(int index, Double @default = default) => ColumnPosition_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnPosition_Z { get; }
        public Double GetPosition_Z(int index, Double @default = default) => ColumnPosition_Z.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnSharedPosition_X { get; }
        public Double GetSharedPosition_X(int index, Double @default = default) => ColumnSharedPosition_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnSharedPosition_Y { get; }
        public Double GetSharedPosition_Y(int index, Double @default = default) => ColumnSharedPosition_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnSharedPosition_Z { get; }
        public Double GetSharedPosition_Z(int index, Double @default = default) => ColumnSharedPosition_Z.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public BasePoint Get(int index)
        {
            if (index < 0) return null;
            var r = new BasePoint();
            r.Index = index;
            r.IsSurveyPoint = GetIsSurveyPoint(index);
            r.Position_X = GetPosition_X(index);
            r.Position_Y = GetPosition_Y(index);
            r.Position_Z = GetPosition_Z(index);
            r.SharedPosition_X = GetSharedPosition_X(index);
            r.SharedPosition_Y = GetSharedPosition_Y(index);
            r.SharedPosition_Z = GetSharedPosition_Z(index);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // BasePoint Get
    } // class BasePointTable 
    
    public partial class PhaseFilterTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public PhaseFilterTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnNew = GetDataColumnValues<Int32>("int:New") ?? Array.Empty<Int32>();
            ColumnExisting = GetDataColumnValues<Int32>("int:Existing") ?? Array.Empty<Int32>();
            ColumnDemolished = GetDataColumnValues<Int32>("int:Demolished") ?? Array.Empty<Int32>();
            ColumnTemporary = GetDataColumnValues<Int32>("int:Temporary") ?? Array.Empty<Int32>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // PhaseFilterTable constructor
        
        public Int32[] ColumnNew { get; }
        public Int32 GetNew(int index, Int32 @default = default) => ColumnNew.ElementAtOrDefault(index, @default);
        
        public Int32[] ColumnExisting { get; }
        public Int32 GetExisting(int index, Int32 @default = default) => ColumnExisting.ElementAtOrDefault(index, @default);
        
        public Int32[] ColumnDemolished { get; }
        public Int32 GetDemolished(int index, Int32 @default = default) => ColumnDemolished.ElementAtOrDefault(index, @default);
        
        public Int32[] ColumnTemporary { get; }
        public Int32 GetTemporary(int index, Int32 @default = default) => ColumnTemporary.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public PhaseFilter Get(int index)
        {
            if (index < 0) return null;
            var r = new PhaseFilter();
            r.Index = index;
            r.New = GetNew(index);
            r.Existing = GetExisting(index);
            r.Demolished = GetDemolished(index);
            r.Temporary = GetTemporary(index);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // PhaseFilter Get
    } // class PhaseFilterTable 
    
    public partial class GridTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public GridTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnStartPoint_X = GetDataColumnValues<Double>("double:StartPoint.X") ?? Array.Empty<Double>();
            ColumnStartPoint_Y = GetDataColumnValues<Double>("double:StartPoint.Y") ?? Array.Empty<Double>();
            ColumnStartPoint_Z = GetDataColumnValues<Double>("double:StartPoint.Z") ?? Array.Empty<Double>();
            ColumnEndPoint_X = GetDataColumnValues<Double>("double:EndPoint.X") ?? Array.Empty<Double>();
            ColumnEndPoint_Y = GetDataColumnValues<Double>("double:EndPoint.Y") ?? Array.Empty<Double>();
            ColumnEndPoint_Z = GetDataColumnValues<Double>("double:EndPoint.Z") ?? Array.Empty<Double>();
            ColumnIsCurved = GetDataColumnValues<Boolean>("byte:IsCurved") ?? Array.Empty<Boolean>();
            ColumnExtents_Min_X = GetDataColumnValues<Double>("double:Extents.Min.X") ?? Array.Empty<Double>();
            ColumnExtents_Min_Y = GetDataColumnValues<Double>("double:Extents.Min.Y") ?? Array.Empty<Double>();
            ColumnExtents_Min_Z = GetDataColumnValues<Double>("double:Extents.Min.Z") ?? Array.Empty<Double>();
            ColumnExtents_Max_X = GetDataColumnValues<Double>("double:Extents.Max.X") ?? Array.Empty<Double>();
            ColumnExtents_Max_Y = GetDataColumnValues<Double>("double:Extents.Max.Y") ?? Array.Empty<Double>();
            ColumnExtents_Max_Z = GetDataColumnValues<Double>("double:Extents.Max.Z") ?? Array.Empty<Double>();
            ColumnFamilyTypeIndex = GetIndexColumnValues("index:Vim.FamilyType:FamilyType") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // GridTable constructor
        
        public Double[] ColumnStartPoint_X { get; }
        public Double GetStartPoint_X(int index, Double @default = default) => ColumnStartPoint_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnStartPoint_Y { get; }
        public Double GetStartPoint_Y(int index, Double @default = default) => ColumnStartPoint_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnStartPoint_Z { get; }
        public Double GetStartPoint_Z(int index, Double @default = default) => ColumnStartPoint_Z.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnEndPoint_X { get; }
        public Double GetEndPoint_X(int index, Double @default = default) => ColumnEndPoint_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnEndPoint_Y { get; }
        public Double GetEndPoint_Y(int index, Double @default = default) => ColumnEndPoint_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnEndPoint_Z { get; }
        public Double GetEndPoint_Z(int index, Double @default = default) => ColumnEndPoint_Z.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsCurved { get; }
        public Boolean GetIsCurved(int index, Boolean @default = default) => ColumnIsCurved.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnExtents_Min_X { get; }
        public Double GetExtents_Min_X(int index, Double @default = default) => ColumnExtents_Min_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnExtents_Min_Y { get; }
        public Double GetExtents_Min_Y(int index, Double @default = default) => ColumnExtents_Min_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnExtents_Min_Z { get; }
        public Double GetExtents_Min_Z(int index, Double @default = default) => ColumnExtents_Min_Z.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnExtents_Max_X { get; }
        public Double GetExtents_Max_X(int index, Double @default = default) => ColumnExtents_Max_X.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnExtents_Max_Y { get; }
        public Double GetExtents_Max_Y(int index, Double @default = default) => ColumnExtents_Max_Y.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnExtents_Max_Z { get; }
        public Double GetExtents_Max_Z(int index, Double @default = default) => ColumnExtents_Max_Z.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnFamilyTypeIndex { get; }
        public int GetFamilyTypeIndex(int index) => ColumnFamilyTypeIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetFamilyType(int index) => _parentTableSet.GetFamilyType(GetFamilyTypeIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Grid Get(int index)
        {
            if (index < 0) return null;
            var r = new Grid();
            r.Index = index;
            r.StartPoint_X = GetStartPoint_X(index);
            r.StartPoint_Y = GetStartPoint_Y(index);
            r.StartPoint_Z = GetStartPoint_Z(index);
            r.EndPoint_X = GetEndPoint_X(index);
            r.EndPoint_Y = GetEndPoint_Y(index);
            r.EndPoint_Z = GetEndPoint_Z(index);
            r.IsCurved = GetIsCurved(index);
            r.Extents_Min_X = GetExtents_Min_X(index);
            r.Extents_Min_Y = GetExtents_Min_Y(index);
            r.Extents_Min_Z = GetExtents_Min_Z(index);
            r.Extents_Max_X = GetExtents_Max_X(index);
            r.Extents_Max_Y = GetExtents_Max_Y(index);
            r.Extents_Max_Z = GetExtents_Max_Z(index);
            r._FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>(GetFamilyTypeIndex(index), _parentTableSet.GetFamilyType);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Grid Get
    } // class GridTable 
    
    public partial class AreaTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public AreaTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnValue = GetDataColumnValues<Double>("double:Value") ?? Array.Empty<Double>();
            ColumnPerimeter = GetDataColumnValues<Double>("double:Perimeter") ?? Array.Empty<Double>();
            ColumnNumber = GetStringColumnValues("string:Number") ?? Array.Empty<String>();
            ColumnIsGrossInterior = GetDataColumnValues<Boolean>("byte:IsGrossInterior") ?? Array.Empty<Boolean>();
            ColumnAreaSchemeIndex = GetIndexColumnValues("index:Vim.AreaScheme:AreaScheme") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // AreaTable constructor
        
        public Double[] ColumnValue { get; }
        public Double GetValue(int index, Double @default = default) => ColumnValue.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnPerimeter { get; }
        public Double GetPerimeter(int index, Double @default = default) => ColumnPerimeter.ElementAtOrDefault(index, @default);
        
        public String[] ColumnNumber { get; }
        public String GetNumber(int index, String @default = "") => ColumnNumber.ElementAtOrDefault(index, @default);
        
        public Boolean[] ColumnIsGrossInterior { get; }
        public Boolean GetIsGrossInterior(int index, Boolean @default = default) => ColumnIsGrossInterior.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnAreaSchemeIndex { get; }
        public int GetAreaSchemeIndex(int index) => ColumnAreaSchemeIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetAreaScheme(int index) => _parentTableSet.GetAreaScheme(GetAreaSchemeIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Area Get(int index)
        {
            if (index < 0) return null;
            var r = new Area();
            r.Index = index;
            r.Value = GetValue(index);
            r.Perimeter = GetPerimeter(index);
            r.Number = GetNumber(index);
            r.IsGrossInterior = GetIsGrossInterior(index);
            r._AreaScheme = new Relation<Vim.Format.ObjectModel.AreaScheme>(GetAreaSchemeIndex(index), _parentTableSet.GetAreaScheme);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Area Get
    } // class AreaTable 
    
    public partial class AreaSchemeTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public AreaSchemeTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnIsGrossBuildingArea = GetDataColumnValues<Boolean>("byte:IsGrossBuildingArea") ?? Array.Empty<Boolean>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // AreaSchemeTable constructor
        
        public Boolean[] ColumnIsGrossBuildingArea { get; }
        public Boolean GetIsGrossBuildingArea(int index, Boolean @default = default) => ColumnIsGrossBuildingArea.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public AreaScheme Get(int index)
        {
            if (index < 0) return null;
            var r = new AreaScheme();
            r.Index = index;
            r.IsGrossBuildingArea = GetIsGrossBuildingArea(index);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // AreaScheme Get
    } // class AreaSchemeTable 
    
    public partial class ScheduleTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ScheduleTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // ScheduleTable constructor
        
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Schedule Get(int index)
        {
            if (index < 0) return null;
            var r = new Schedule();
            r.Index = index;
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Schedule Get
    } // class ScheduleTable 
    
    public partial class ScheduleColumnTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ScheduleColumnTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnName = GetStringColumnValues("string:Name") ?? Array.Empty<String>();
            ColumnColumnIndex = GetDataColumnValues<Int32>("int:ColumnIndex") ?? Array.Empty<Int32>();
            ColumnScheduleIndex = GetIndexColumnValues("index:Vim.Schedule:Schedule") ?? Array.Empty<int>();
        } // ScheduleColumnTable constructor
        
        public String[] ColumnName { get; }
        public String GetName(int index, String @default = "") => ColumnName.ElementAtOrDefault(index, @default);
        
        public Int32[] ColumnColumnIndex { get; }
        public Int32 GetColumnIndex(int index, Int32 @default = default) => ColumnColumnIndex.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnScheduleIndex { get; }
        public int GetScheduleIndex(int index) => ColumnScheduleIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetSchedule(int index) => _parentTableSet.GetSchedule(GetScheduleIndex(index));
        
        // Object Getter
        public ScheduleColumn Get(int index)
        {
            if (index < 0) return null;
            var r = new ScheduleColumn();
            r.Index = index;
            r.Name = GetName(index);
            r.ColumnIndex = GetColumnIndex(index);
            r._Schedule = new Relation<Vim.Format.ObjectModel.Schedule>(GetScheduleIndex(index), _parentTableSet.GetSchedule);
            return r;
        } // ScheduleColumn Get
    } // class ScheduleColumnTable 
    
    public partial class ScheduleCellTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ScheduleCellTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnValue = GetStringColumnValues("string:Value") ?? Array.Empty<String>();
            ColumnRowIndex = GetDataColumnValues<Int32>("int:RowIndex") ?? Array.Empty<Int32>();
            ColumnScheduleColumnIndex = GetIndexColumnValues("index:Vim.ScheduleColumn:ScheduleColumn") ?? Array.Empty<int>();
        } // ScheduleCellTable constructor
        
        public String[] ColumnValue { get; }
        public String GetValue(int index, String @default = "") => ColumnValue.ElementAtOrDefault(index, @default);
        
        public Int32[] ColumnRowIndex { get; }
        public Int32 GetRowIndex(int index, Int32 @default = default) => ColumnRowIndex.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnScheduleColumnIndex { get; }
        public int GetScheduleColumnIndex(int index) => ColumnScheduleColumnIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetScheduleColumn(int index) => _parentTableSet.GetScheduleColumn(GetScheduleColumnIndex(index));
        
        // Object Getter
        public ScheduleCell Get(int index)
        {
            if (index < 0) return null;
            var r = new ScheduleCell();
            r.Index = index;
            r.Value = GetValue(index);
            r.RowIndex = GetRowIndex(index);
            r._ScheduleColumn = new Relation<Vim.Format.ObjectModel.ScheduleColumn>(GetScheduleColumnIndex(index), _parentTableSet.GetScheduleColumn);
            return r;
        } // ScheduleCell Get
    } // class ScheduleCellTable 
    
    public partial class ViewSheetSetTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ViewSheetSetTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // ViewSheetSetTable constructor
        
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public ViewSheetSet Get(int index)
        {
            if (index < 0) return null;
            var r = new ViewSheetSet();
            r.Index = index;
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // ViewSheetSet Get
    } // class ViewSheetSetTable 
    
    public partial class ViewSheetTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ViewSheetTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnFamilyTypeIndex = GetIndexColumnValues("index:Vim.FamilyType:FamilyType") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // ViewSheetTable constructor
        
        
        public int[] ColumnFamilyTypeIndex { get; }
        public int GetFamilyTypeIndex(int index) => ColumnFamilyTypeIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetFamilyType(int index) => _parentTableSet.GetFamilyType(GetFamilyTypeIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public ViewSheet Get(int index)
        {
            if (index < 0) return null;
            var r = new ViewSheet();
            r.Index = index;
            r._FamilyType = new Relation<Vim.Format.ObjectModel.FamilyType>(GetFamilyTypeIndex(index), _parentTableSet.GetFamilyType);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // ViewSheet Get
    } // class ViewSheetTable 
    
    public partial class ViewSheetInViewSheetSetTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ViewSheetInViewSheetSetTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnViewSheetIndex = GetIndexColumnValues("index:Vim.ViewSheet:ViewSheet") ?? Array.Empty<int>();
            ColumnViewSheetSetIndex = GetIndexColumnValues("index:Vim.ViewSheetSet:ViewSheetSet") ?? Array.Empty<int>();
        } // ViewSheetInViewSheetSetTable constructor
        
        
        public int[] ColumnViewSheetIndex { get; }
        public int GetViewSheetIndex(int index) => ColumnViewSheetIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetViewSheet(int index) => _parentTableSet.GetViewSheet(GetViewSheetIndex(index));
        
        public int[] ColumnViewSheetSetIndex { get; }
        public int GetViewSheetSetIndex(int index) => ColumnViewSheetSetIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetViewSheetSet(int index) => _parentTableSet.GetViewSheetSet(GetViewSheetSetIndex(index));
        
        // Object Getter
        public ViewSheetInViewSheetSet Get(int index)
        {
            if (index < 0) return null;
            var r = new ViewSheetInViewSheetSet();
            r.Index = index;
            r._ViewSheet = new Relation<Vim.Format.ObjectModel.ViewSheet>(GetViewSheetIndex(index), _parentTableSet.GetViewSheet);
            r._ViewSheetSet = new Relation<Vim.Format.ObjectModel.ViewSheetSet>(GetViewSheetSetIndex(index), _parentTableSet.GetViewSheetSet);
            return r;
        } // ViewSheetInViewSheetSet Get
    } // class ViewSheetInViewSheetSetTable 
    
    public partial class ViewInViewSheetSetTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ViewInViewSheetSetTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnViewIndex = GetIndexColumnValues("index:Vim.View:View") ?? Array.Empty<int>();
            ColumnViewSheetSetIndex = GetIndexColumnValues("index:Vim.ViewSheetSet:ViewSheetSet") ?? Array.Empty<int>();
        } // ViewInViewSheetSetTable constructor
        
        
        public int[] ColumnViewIndex { get; }
        public int GetViewIndex(int index) => ColumnViewIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetView(int index) => _parentTableSet.GetView(GetViewIndex(index));
        
        public int[] ColumnViewSheetSetIndex { get; }
        public int GetViewSheetSetIndex(int index) => ColumnViewSheetSetIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetViewSheetSet(int index) => _parentTableSet.GetViewSheetSet(GetViewSheetSetIndex(index));
        
        // Object Getter
        public ViewInViewSheetSet Get(int index)
        {
            if (index < 0) return null;
            var r = new ViewInViewSheetSet();
            r.Index = index;
            r._View = new Relation<Vim.Format.ObjectModel.View>(GetViewIndex(index), _parentTableSet.GetView);
            r._ViewSheetSet = new Relation<Vim.Format.ObjectModel.ViewSheetSet>(GetViewSheetSetIndex(index), _parentTableSet.GetViewSheetSet);
            return r;
        } // ViewInViewSheetSet Get
    } // class ViewInViewSheetSetTable 
    
    public partial class ViewInViewSheetTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public ViewInViewSheetTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnViewIndex = GetIndexColumnValues("index:Vim.View:View") ?? Array.Empty<int>();
            ColumnViewSheetIndex = GetIndexColumnValues("index:Vim.ViewSheet:ViewSheet") ?? Array.Empty<int>();
        } // ViewInViewSheetTable constructor
        
        
        public int[] ColumnViewIndex { get; }
        public int GetViewIndex(int index) => ColumnViewIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetView(int index) => _parentTableSet.GetView(GetViewIndex(index));
        
        public int[] ColumnViewSheetIndex { get; }
        public int GetViewSheetIndex(int index) => ColumnViewSheetIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetViewSheet(int index) => _parentTableSet.GetViewSheet(GetViewSheetIndex(index));
        
        // Object Getter
        public ViewInViewSheet Get(int index)
        {
            if (index < 0) return null;
            var r = new ViewInViewSheet();
            r.Index = index;
            r._View = new Relation<Vim.Format.ObjectModel.View>(GetViewIndex(index), _parentTableSet.GetView);
            r._ViewSheet = new Relation<Vim.Format.ObjectModel.ViewSheet>(GetViewSheetIndex(index), _parentTableSet.GetViewSheet);
            return r;
        } // ViewInViewSheet Get
    } // class ViewInViewSheetTable 
    
    public partial class SiteTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public SiteTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnLatitude = GetDataColumnValues<Double>("double:Latitude") ?? Array.Empty<Double>();
            ColumnLongitude = GetDataColumnValues<Double>("double:Longitude") ?? Array.Empty<Double>();
            ColumnAddress = GetStringColumnValues("string:Address") ?? Array.Empty<String>();
            ColumnElevation = GetDataColumnValues<Double>("double:Elevation") ?? Array.Empty<Double>();
            ColumnNumber = GetStringColumnValues("string:Number") ?? Array.Empty<String>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // SiteTable constructor
        
        public Double[] ColumnLatitude { get; }
        public Double GetLatitude(int index, Double @default = default) => ColumnLatitude.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnLongitude { get; }
        public Double GetLongitude(int index, Double @default = default) => ColumnLongitude.ElementAtOrDefault(index, @default);
        
        public String[] ColumnAddress { get; }
        public String GetAddress(int index, String @default = "") => ColumnAddress.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnElevation { get; }
        public Double GetElevation(int index, Double @default = default) => ColumnElevation.ElementAtOrDefault(index, @default);
        
        public String[] ColumnNumber { get; }
        public String GetNumber(int index, String @default = "") => ColumnNumber.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Site Get(int index)
        {
            if (index < 0) return null;
            var r = new Site();
            r.Index = index;
            r.Latitude = GetLatitude(index);
            r.Longitude = GetLongitude(index);
            r.Address = GetAddress(index);
            r.Elevation = GetElevation(index);
            r.Number = GetNumber(index);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Site Get
    } // class SiteTable 
    
    public partial class BuildingTable : EntityTable_v2
    {
        private readonly EntityTableSet _parentTableSet; // can be null
        
        public BuildingTable(SerializableEntityTable rawTable, string[] stringBuffer, EntityTableSet parentTableSet = null) : base(rawTable, stringBuffer)
        {
            _parentTableSet = parentTableSet;
            ColumnElevation = GetDataColumnValues<Double>("double:Elevation") ?? Array.Empty<Double>();
            ColumnTerrainElevation = GetDataColumnValues<Double>("double:TerrainElevation") ?? Array.Empty<Double>();
            ColumnAddress = GetStringColumnValues("string:Address") ?? Array.Empty<String>();
            ColumnSiteIndex = GetIndexColumnValues("index:Vim.Site:Site") ?? Array.Empty<int>();
            ColumnElementIndex = GetIndexColumnValues("index:Vim.Element:Element") ?? Array.Empty<int>();
        } // BuildingTable constructor
        
        public Double[] ColumnElevation { get; }
        public Double GetElevation(int index, Double @default = default) => ColumnElevation.ElementAtOrDefault(index, @default);
        
        public Double[] ColumnTerrainElevation { get; }
        public Double GetTerrainElevation(int index, Double @default = default) => ColumnTerrainElevation.ElementAtOrDefault(index, @default);
        
        public String[] ColumnAddress { get; }
        public String GetAddress(int index, String @default = "") => ColumnAddress.ElementAtOrDefault(index, @default);
        
        
        public int[] ColumnSiteIndex { get; }
        public int GetSiteIndex(int index) => ColumnSiteIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetSite(int index) => _parentTableSet.GetSite(GetSiteIndex(index));
        
        public int[] ColumnElementIndex { get; }
        public int GetElementIndex(int index) => ColumnElementIndex.ElementAtOrDefault(index, EntityRelation.None);
        public GetElement(int index) => _parentTableSet.GetElement(GetElementIndex(index));
        
        // Object Getter
        public Building Get(int index)
        {
            if (index < 0) return null;
            var r = new Building();
            r.Index = index;
            r.Elevation = GetElevation(index);
            r.TerrainElevation = GetTerrainElevation(index);
            r.Address = GetAddress(index);
            r._Site = new Relation<Vim.Format.ObjectModel.Site>(GetSiteIndex(index), _parentTableSet.GetSite);
            r._Element = new Relation<Vim.Format.ObjectModel.Element>(GetElementIndex(index), _parentTableSet.GetElement);
            return r;
        } // Building Get
    } // class BuildingTable 
    
    public static class DocumentBuilderExtensions
    {
        public static Func<IEnumerable<Entity>, EntityTableBuilder> GetTableBuilderFunc(this Type type)
        {
            if (type == typeof(Asset)) return ToAssetTableBuilder;
            if (type == typeof(DisplayUnit)) return ToDisplayUnitTableBuilder;
            if (type == typeof(ParameterDescriptor)) return ToParameterDescriptorTableBuilder;
            if (type == typeof(Parameter)) return ToParameterTableBuilder;
            if (type == typeof(Element)) return ToElementTableBuilder;
            if (type == typeof(Workset)) return ToWorksetTableBuilder;
            if (type == typeof(AssemblyInstance)) return ToAssemblyInstanceTableBuilder;
            if (type == typeof(Group)) return ToGroupTableBuilder;
            if (type == typeof(DesignOption)) return ToDesignOptionTableBuilder;
            if (type == typeof(Level)) return ToLevelTableBuilder;
            if (type == typeof(Phase)) return ToPhaseTableBuilder;
            if (type == typeof(Room)) return ToRoomTableBuilder;
            if (type == typeof(BimDocument)) return ToBimDocumentTableBuilder;
            if (type == typeof(DisplayUnitInBimDocument)) return ToDisplayUnitInBimDocumentTableBuilder;
            if (type == typeof(PhaseOrderInBimDocument)) return ToPhaseOrderInBimDocumentTableBuilder;
            if (type == typeof(Category)) return ToCategoryTableBuilder;
            if (type == typeof(Family)) return ToFamilyTableBuilder;
            if (type == typeof(FamilyType)) return ToFamilyTypeTableBuilder;
            if (type == typeof(FamilyInstance)) return ToFamilyInstanceTableBuilder;
            if (type == typeof(View)) return ToViewTableBuilder;
            if (type == typeof(ElementInView)) return ToElementInViewTableBuilder;
            if (type == typeof(ShapeInView)) return ToShapeInViewTableBuilder;
            if (type == typeof(AssetInView)) return ToAssetInViewTableBuilder;
            if (type == typeof(AssetInViewSheet)) return ToAssetInViewSheetTableBuilder;
            if (type == typeof(LevelInView)) return ToLevelInViewTableBuilder;
            if (type == typeof(Camera)) return ToCameraTableBuilder;
            if (type == typeof(Material)) return ToMaterialTableBuilder;
            if (type == typeof(MaterialInElement)) return ToMaterialInElementTableBuilder;
            if (type == typeof(CompoundStructureLayer)) return ToCompoundStructureLayerTableBuilder;
            if (type == typeof(CompoundStructure)) return ToCompoundStructureTableBuilder;
            if (type == typeof(Node)) return ToNodeTableBuilder;
            if (type == typeof(Geometry)) return ToGeometryTableBuilder;
            if (type == typeof(Shape)) return ToShapeTableBuilder;
            if (type == typeof(ShapeCollection)) return ToShapeCollectionTableBuilder;
            if (type == typeof(ShapeInShapeCollection)) return ToShapeInShapeCollectionTableBuilder;
            if (type == typeof(System)) return ToSystemTableBuilder;
            if (type == typeof(ElementInSystem)) return ToElementInSystemTableBuilder;
            if (type == typeof(Warning)) return ToWarningTableBuilder;
            if (type == typeof(ElementInWarning)) return ToElementInWarningTableBuilder;
            if (type == typeof(BasePoint)) return ToBasePointTableBuilder;
            if (type == typeof(PhaseFilter)) return ToPhaseFilterTableBuilder;
            if (type == typeof(Grid)) return ToGridTableBuilder;
            if (type == typeof(Area)) return ToAreaTableBuilder;
            if (type == typeof(AreaScheme)) return ToAreaSchemeTableBuilder;
            if (type == typeof(Schedule)) return ToScheduleTableBuilder;
            if (type == typeof(ScheduleColumn)) return ToScheduleColumnTableBuilder;
            if (type == typeof(ScheduleCell)) return ToScheduleCellTableBuilder;
            if (type == typeof(ViewSheetSet)) return ToViewSheetSetTableBuilder;
            if (type == typeof(ViewSheet)) return ToViewSheetTableBuilder;
            if (type == typeof(ViewSheetInViewSheetSet)) return ToViewSheetInViewSheetSetTableBuilder;
            if (type == typeof(ViewInViewSheetSet)) return ToViewInViewSheetSetTableBuilder;
            if (type == typeof(ViewInViewSheet)) return ToViewInViewSheetTableBuilder;
            if (type == typeof(Site)) return ToSiteTableBuilder;
            if (type == typeof(Building)) return ToBuildingTableBuilder;
            throw new ArgumentException(nameof(type));
        }
        public static EntityTableBuilder ToAssetTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Asset>() ?? Enumerable.Empty<Asset>();
            var tb = new EntityTableBuilder("Vim.Asset");
            tb.AddStringColumn("string:BufferName", typedEntities.Select(x => x.BufferName));
            return tb;
        }
        public static EntityTableBuilder ToDisplayUnitTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<DisplayUnit>() ?? Enumerable.Empty<DisplayUnit>();
            var tb = new EntityTableBuilder("Vim.DisplayUnit");
            tb.AddStringColumn("string:Spec", typedEntities.Select(x => x.Spec));
            tb.AddStringColumn("string:Type", typedEntities.Select(x => x.Type));
            tb.AddStringColumn("string:Label", typedEntities.Select(x => x.Label));
            return tb;
        }
        public static EntityTableBuilder ToParameterDescriptorTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ParameterDescriptor>() ?? Enumerable.Empty<ParameterDescriptor>();
            var tb = new EntityTableBuilder("Vim.ParameterDescriptor");
            tb.AddStringColumn("string:Name", typedEntities.Select(x => x.Name));
            tb.AddStringColumn("string:Group", typedEntities.Select(x => x.Group));
            tb.AddStringColumn("string:ParameterType", typedEntities.Select(x => x.ParameterType));
            tb.AddDataColumn("byte:IsInstance", typedEntities.Select(x => x.IsInstance));
            tb.AddDataColumn("byte:IsShared", typedEntities.Select(x => x.IsShared));
            tb.AddDataColumn("byte:IsReadOnly", typedEntities.Select(x => x.IsReadOnly));
            tb.AddDataColumn("int:Flags", typedEntities.Select(x => x.Flags));
            tb.AddStringColumn("string:Guid", typedEntities.Select(x => x.Guid));
            tb.AddDataColumn("int:StorageType", typedEntities.Select(x => x.StorageType));
            tb.AddIndexColumn("index:Vim.DisplayUnit:DisplayUnit", typedEntities.Select(x => x._DisplayUnit?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToParameterTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Parameter>() ?? Enumerable.Empty<Parameter>();
            var tb = new EntityTableBuilder("Vim.Parameter");
            tb.AddStringColumn("string:Value", typedEntities.Select(x => x.Value));
            tb.AddIndexColumn("index:Vim.ParameterDescriptor:ParameterDescriptor", typedEntities.Select(x => x._ParameterDescriptor?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToElementTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Element>() ?? Enumerable.Empty<Element>();
            var tb = new EntityTableBuilder("Vim.Element");
            tb.AddDataColumn("long:Id", typedEntities.Select(x => x.Id));
            tb.AddStringColumn("string:Type", typedEntities.Select(x => x.Type));
            tb.AddStringColumn("string:Name", typedEntities.Select(x => x.Name));
            tb.AddStringColumn("string:UniqueId", typedEntities.Select(x => x.UniqueId));
            tb.AddDataColumn("float:Location.X", typedEntities.Select(x => x.Location_X));
            tb.AddDataColumn("float:Location.Y", typedEntities.Select(x => x.Location_Y));
            tb.AddDataColumn("float:Location.Z", typedEntities.Select(x => x.Location_Z));
            tb.AddStringColumn("string:FamilyName", typedEntities.Select(x => x.FamilyName));
            tb.AddDataColumn("byte:IsPinned", typedEntities.Select(x => x.IsPinned));
            tb.AddIndexColumn("index:Vim.Level:Level", typedEntities.Select(x => x._Level?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Phase:PhaseCreated", typedEntities.Select(x => x._PhaseCreated?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Phase:PhaseDemolished", typedEntities.Select(x => x._PhaseDemolished?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Category:Category", typedEntities.Select(x => x._Category?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Workset:Workset", typedEntities.Select(x => x._Workset?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.DesignOption:DesignOption", typedEntities.Select(x => x._DesignOption?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.View:OwnerView", typedEntities.Select(x => x._OwnerView?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Group:Group", typedEntities.Select(x => x._Group?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.AssemblyInstance:AssemblyInstance", typedEntities.Select(x => x._AssemblyInstance?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.BimDocument:BimDocument", typedEntities.Select(x => x._BimDocument?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Room:Room", typedEntities.Select(x => x._Room?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToWorksetTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Workset>() ?? Enumerable.Empty<Workset>();
            var tb = new EntityTableBuilder("Vim.Workset");
            tb.AddDataColumn("int:Id", typedEntities.Select(x => x.Id));
            tb.AddStringColumn("string:Name", typedEntities.Select(x => x.Name));
            tb.AddStringColumn("string:Kind", typedEntities.Select(x => x.Kind));
            tb.AddDataColumn("byte:IsOpen", typedEntities.Select(x => x.IsOpen));
            tb.AddDataColumn("byte:IsEditable", typedEntities.Select(x => x.IsEditable));
            tb.AddStringColumn("string:Owner", typedEntities.Select(x => x.Owner));
            tb.AddStringColumn("string:UniqueId", typedEntities.Select(x => x.UniqueId));
            tb.AddIndexColumn("index:Vim.BimDocument:BimDocument", typedEntities.Select(x => x._BimDocument?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToAssemblyInstanceTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<AssemblyInstance>() ?? Enumerable.Empty<AssemblyInstance>();
            var tb = new EntityTableBuilder("Vim.AssemblyInstance");
            tb.AddStringColumn("string:AssemblyTypeName", typedEntities.Select(x => x.AssemblyTypeName));
            tb.AddDataColumn("float:Position.X", typedEntities.Select(x => x.Position_X));
            tb.AddDataColumn("float:Position.Y", typedEntities.Select(x => x.Position_Y));
            tb.AddDataColumn("float:Position.Z", typedEntities.Select(x => x.Position_Z));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToGroupTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Group>() ?? Enumerable.Empty<Group>();
            var tb = new EntityTableBuilder("Vim.Group");
            tb.AddStringColumn("string:GroupType", typedEntities.Select(x => x.GroupType));
            tb.AddDataColumn("float:Position.X", typedEntities.Select(x => x.Position_X));
            tb.AddDataColumn("float:Position.Y", typedEntities.Select(x => x.Position_Y));
            tb.AddDataColumn("float:Position.Z", typedEntities.Select(x => x.Position_Z));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToDesignOptionTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<DesignOption>() ?? Enumerable.Empty<DesignOption>();
            var tb = new EntityTableBuilder("Vim.DesignOption");
            tb.AddDataColumn("byte:IsPrimary", typedEntities.Select(x => x.IsPrimary));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToLevelTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Level>() ?? Enumerable.Empty<Level>();
            var tb = new EntityTableBuilder("Vim.Level");
            tb.AddDataColumn("double:Elevation", typedEntities.Select(x => x.Elevation));
            tb.AddIndexColumn("index:Vim.FamilyType:FamilyType", typedEntities.Select(x => x._FamilyType?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Building:Building", typedEntities.Select(x => x._Building?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToPhaseTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Phase>() ?? Enumerable.Empty<Phase>();
            var tb = new EntityTableBuilder("Vim.Phase");
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToRoomTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Room>() ?? Enumerable.Empty<Room>();
            var tb = new EntityTableBuilder("Vim.Room");
            tb.AddDataColumn("double:BaseOffset", typedEntities.Select(x => x.BaseOffset));
            tb.AddDataColumn("double:LimitOffset", typedEntities.Select(x => x.LimitOffset));
            tb.AddDataColumn("double:UnboundedHeight", typedEntities.Select(x => x.UnboundedHeight));
            tb.AddDataColumn("double:Volume", typedEntities.Select(x => x.Volume));
            tb.AddDataColumn("double:Perimeter", typedEntities.Select(x => x.Perimeter));
            tb.AddDataColumn("double:Area", typedEntities.Select(x => x.Area));
            tb.AddStringColumn("string:Number", typedEntities.Select(x => x.Number));
            tb.AddIndexColumn("index:Vim.Level:UpperLimit", typedEntities.Select(x => x._UpperLimit?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToBimDocumentTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<BimDocument>() ?? Enumerable.Empty<BimDocument>();
            var tb = new EntityTableBuilder("Vim.BimDocument");
            tb.AddStringColumn("string:Title", typedEntities.Select(x => x.Title));
            tb.AddDataColumn("byte:IsMetric", typedEntities.Select(x => x.IsMetric));
            tb.AddStringColumn("string:Guid", typedEntities.Select(x => x.Guid));
            tb.AddDataColumn("int:NumSaves", typedEntities.Select(x => x.NumSaves));
            tb.AddDataColumn("byte:IsLinked", typedEntities.Select(x => x.IsLinked));
            tb.AddDataColumn("byte:IsDetached", typedEntities.Select(x => x.IsDetached));
            tb.AddDataColumn("byte:IsWorkshared", typedEntities.Select(x => x.IsWorkshared));
            tb.AddStringColumn("string:PathName", typedEntities.Select(x => x.PathName));
            tb.AddDataColumn("double:Latitude", typedEntities.Select(x => x.Latitude));
            tb.AddDataColumn("double:Longitude", typedEntities.Select(x => x.Longitude));
            tb.AddDataColumn("double:TimeZone", typedEntities.Select(x => x.TimeZone));
            tb.AddStringColumn("string:PlaceName", typedEntities.Select(x => x.PlaceName));
            tb.AddStringColumn("string:WeatherStationName", typedEntities.Select(x => x.WeatherStationName));
            tb.AddDataColumn("double:Elevation", typedEntities.Select(x => x.Elevation));
            tb.AddStringColumn("string:ProjectLocation", typedEntities.Select(x => x.ProjectLocation));
            tb.AddStringColumn("string:IssueDate", typedEntities.Select(x => x.IssueDate));
            tb.AddStringColumn("string:Status", typedEntities.Select(x => x.Status));
            tb.AddStringColumn("string:ClientName", typedEntities.Select(x => x.ClientName));
            tb.AddStringColumn("string:Address", typedEntities.Select(x => x.Address));
            tb.AddStringColumn("string:Name", typedEntities.Select(x => x.Name));
            tb.AddStringColumn("string:Number", typedEntities.Select(x => x.Number));
            tb.AddStringColumn("string:Author", typedEntities.Select(x => x.Author));
            tb.AddStringColumn("string:BuildingName", typedEntities.Select(x => x.BuildingName));
            tb.AddStringColumn("string:OrganizationName", typedEntities.Select(x => x.OrganizationName));
            tb.AddStringColumn("string:OrganizationDescription", typedEntities.Select(x => x.OrganizationDescription));
            tb.AddStringColumn("string:Product", typedEntities.Select(x => x.Product));
            tb.AddStringColumn("string:Version", typedEntities.Select(x => x.Version));
            tb.AddStringColumn("string:User", typedEntities.Select(x => x.User));
            tb.AddIndexColumn("index:Vim.View:ActiveView", typedEntities.Select(x => x._ActiveView?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Family:OwnerFamily", typedEntities.Select(x => x._OwnerFamily?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.BimDocument:Parent", typedEntities.Select(x => x._Parent?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToDisplayUnitInBimDocumentTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<DisplayUnitInBimDocument>() ?? Enumerable.Empty<DisplayUnitInBimDocument>();
            var tb = new EntityTableBuilder("Vim.DisplayUnitInBimDocument");
            tb.AddIndexColumn("index:Vim.DisplayUnit:DisplayUnit", typedEntities.Select(x => x._DisplayUnit?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.BimDocument:BimDocument", typedEntities.Select(x => x._BimDocument?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToPhaseOrderInBimDocumentTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<PhaseOrderInBimDocument>() ?? Enumerable.Empty<PhaseOrderInBimDocument>();
            var tb = new EntityTableBuilder("Vim.PhaseOrderInBimDocument");
            tb.AddDataColumn("int:OrderIndex", typedEntities.Select(x => x.OrderIndex));
            tb.AddIndexColumn("index:Vim.Phase:Phase", typedEntities.Select(x => x._Phase?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.BimDocument:BimDocument", typedEntities.Select(x => x._BimDocument?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToCategoryTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Category>() ?? Enumerable.Empty<Category>();
            var tb = new EntityTableBuilder("Vim.Category");
            tb.AddStringColumn("string:Name", typedEntities.Select(x => x.Name));
            tb.AddDataColumn("long:Id", typedEntities.Select(x => x.Id));
            tb.AddStringColumn("string:CategoryType", typedEntities.Select(x => x.CategoryType));
            tb.AddDataColumn("double:LineColor.X", typedEntities.Select(x => x.LineColor_X));
            tb.AddDataColumn("double:LineColor.Y", typedEntities.Select(x => x.LineColor_Y));
            tb.AddDataColumn("double:LineColor.Z", typedEntities.Select(x => x.LineColor_Z));
            tb.AddStringColumn("string:BuiltInCategory", typedEntities.Select(x => x.BuiltInCategory));
            tb.AddIndexColumn("index:Vim.Category:Parent", typedEntities.Select(x => x._Parent?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Material:Material", typedEntities.Select(x => x._Material?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToFamilyTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Family>() ?? Enumerable.Empty<Family>();
            var tb = new EntityTableBuilder("Vim.Family");
            tb.AddStringColumn("string:StructuralMaterialType", typedEntities.Select(x => x.StructuralMaterialType));
            tb.AddStringColumn("string:StructuralSectionShape", typedEntities.Select(x => x.StructuralSectionShape));
            tb.AddDataColumn("byte:IsSystemFamily", typedEntities.Select(x => x.IsSystemFamily));
            tb.AddDataColumn("byte:IsInPlace", typedEntities.Select(x => x.IsInPlace));
            tb.AddIndexColumn("index:Vim.Category:FamilyCategory", typedEntities.Select(x => x._FamilyCategory?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToFamilyTypeTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<FamilyType>() ?? Enumerable.Empty<FamilyType>();
            var tb = new EntityTableBuilder("Vim.FamilyType");
            tb.AddDataColumn("byte:IsSystemFamilyType", typedEntities.Select(x => x.IsSystemFamilyType));
            tb.AddIndexColumn("index:Vim.Family:Family", typedEntities.Select(x => x._Family?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.CompoundStructure:CompoundStructure", typedEntities.Select(x => x._CompoundStructure?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToFamilyInstanceTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<FamilyInstance>() ?? Enumerable.Empty<FamilyInstance>();
            var tb = new EntityTableBuilder("Vim.FamilyInstance");
            tb.AddDataColumn("byte:FacingFlipped", typedEntities.Select(x => x.FacingFlipped));
            tb.AddDataColumn("float:FacingOrientation.X", typedEntities.Select(x => x.FacingOrientation_X));
            tb.AddDataColumn("float:FacingOrientation.Y", typedEntities.Select(x => x.FacingOrientation_Y));
            tb.AddDataColumn("float:FacingOrientation.Z", typedEntities.Select(x => x.FacingOrientation_Z));
            tb.AddDataColumn("byte:HandFlipped", typedEntities.Select(x => x.HandFlipped));
            tb.AddDataColumn("byte:Mirrored", typedEntities.Select(x => x.Mirrored));
            tb.AddDataColumn("byte:HasModifiedGeometry", typedEntities.Select(x => x.HasModifiedGeometry));
            tb.AddDataColumn("float:Scale", typedEntities.Select(x => x.Scale));
            tb.AddDataColumn("float:BasisX.X", typedEntities.Select(x => x.BasisX_X));
            tb.AddDataColumn("float:BasisX.Y", typedEntities.Select(x => x.BasisX_Y));
            tb.AddDataColumn("float:BasisX.Z", typedEntities.Select(x => x.BasisX_Z));
            tb.AddDataColumn("float:BasisY.X", typedEntities.Select(x => x.BasisY_X));
            tb.AddDataColumn("float:BasisY.Y", typedEntities.Select(x => x.BasisY_Y));
            tb.AddDataColumn("float:BasisY.Z", typedEntities.Select(x => x.BasisY_Z));
            tb.AddDataColumn("float:BasisZ.X", typedEntities.Select(x => x.BasisZ_X));
            tb.AddDataColumn("float:BasisZ.Y", typedEntities.Select(x => x.BasisZ_Y));
            tb.AddDataColumn("float:BasisZ.Z", typedEntities.Select(x => x.BasisZ_Z));
            tb.AddDataColumn("float:Translation.X", typedEntities.Select(x => x.Translation_X));
            tb.AddDataColumn("float:Translation.Y", typedEntities.Select(x => x.Translation_Y));
            tb.AddDataColumn("float:Translation.Z", typedEntities.Select(x => x.Translation_Z));
            tb.AddDataColumn("float:HandOrientation.X", typedEntities.Select(x => x.HandOrientation_X));
            tb.AddDataColumn("float:HandOrientation.Y", typedEntities.Select(x => x.HandOrientation_Y));
            tb.AddDataColumn("float:HandOrientation.Z", typedEntities.Select(x => x.HandOrientation_Z));
            tb.AddIndexColumn("index:Vim.FamilyType:FamilyType", typedEntities.Select(x => x._FamilyType?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Host", typedEntities.Select(x => x._Host?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Room:FromRoom", typedEntities.Select(x => x._FromRoom?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Room:ToRoom", typedEntities.Select(x => x._ToRoom?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:SuperComponent", typedEntities.Select(x => x._SuperComponent?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToViewTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<View>() ?? Enumerable.Empty<View>();
            var tb = new EntityTableBuilder("Vim.View");
            tb.AddStringColumn("string:Title", typedEntities.Select(x => x.Title));
            tb.AddStringColumn("string:ViewType", typedEntities.Select(x => x.ViewType));
            tb.AddDataColumn("double:Up.X", typedEntities.Select(x => x.Up_X));
            tb.AddDataColumn("double:Up.Y", typedEntities.Select(x => x.Up_Y));
            tb.AddDataColumn("double:Up.Z", typedEntities.Select(x => x.Up_Z));
            tb.AddDataColumn("double:Right.X", typedEntities.Select(x => x.Right_X));
            tb.AddDataColumn("double:Right.Y", typedEntities.Select(x => x.Right_Y));
            tb.AddDataColumn("double:Right.Z", typedEntities.Select(x => x.Right_Z));
            tb.AddDataColumn("double:Origin.X", typedEntities.Select(x => x.Origin_X));
            tb.AddDataColumn("double:Origin.Y", typedEntities.Select(x => x.Origin_Y));
            tb.AddDataColumn("double:Origin.Z", typedEntities.Select(x => x.Origin_Z));
            tb.AddDataColumn("double:ViewDirection.X", typedEntities.Select(x => x.ViewDirection_X));
            tb.AddDataColumn("double:ViewDirection.Y", typedEntities.Select(x => x.ViewDirection_Y));
            tb.AddDataColumn("double:ViewDirection.Z", typedEntities.Select(x => x.ViewDirection_Z));
            tb.AddDataColumn("double:ViewPosition.X", typedEntities.Select(x => x.ViewPosition_X));
            tb.AddDataColumn("double:ViewPosition.Y", typedEntities.Select(x => x.ViewPosition_Y));
            tb.AddDataColumn("double:ViewPosition.Z", typedEntities.Select(x => x.ViewPosition_Z));
            tb.AddDataColumn("double:Scale", typedEntities.Select(x => x.Scale));
            tb.AddDataColumn("double:Outline.Min.X", typedEntities.Select(x => x.Outline_Min_X));
            tb.AddDataColumn("double:Outline.Min.Y", typedEntities.Select(x => x.Outline_Min_Y));
            tb.AddDataColumn("double:Outline.Max.X", typedEntities.Select(x => x.Outline_Max_X));
            tb.AddDataColumn("double:Outline.Max.Y", typedEntities.Select(x => x.Outline_Max_Y));
            tb.AddDataColumn("int:DetailLevel", typedEntities.Select(x => x.DetailLevel));
            tb.AddIndexColumn("index:Vim.Camera:Camera", typedEntities.Select(x => x._Camera?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.FamilyType:FamilyType", typedEntities.Select(x => x._FamilyType?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToElementInViewTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ElementInView>() ?? Enumerable.Empty<ElementInView>();
            var tb = new EntityTableBuilder("Vim.ElementInView");
            tb.AddIndexColumn("index:Vim.View:View", typedEntities.Select(x => x._View?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToShapeInViewTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ShapeInView>() ?? Enumerable.Empty<ShapeInView>();
            var tb = new EntityTableBuilder("Vim.ShapeInView");
            tb.AddIndexColumn("index:Vim.Shape:Shape", typedEntities.Select(x => x._Shape?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.View:View", typedEntities.Select(x => x._View?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToAssetInViewTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<AssetInView>() ?? Enumerable.Empty<AssetInView>();
            var tb = new EntityTableBuilder("Vim.AssetInView");
            tb.AddIndexColumn("index:Vim.Asset:Asset", typedEntities.Select(x => x._Asset?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.View:View", typedEntities.Select(x => x._View?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToAssetInViewSheetTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<AssetInViewSheet>() ?? Enumerable.Empty<AssetInViewSheet>();
            var tb = new EntityTableBuilder("Vim.AssetInViewSheet");
            tb.AddIndexColumn("index:Vim.Asset:Asset", typedEntities.Select(x => x._Asset?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.ViewSheet:ViewSheet", typedEntities.Select(x => x._ViewSheet?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToLevelInViewTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<LevelInView>() ?? Enumerable.Empty<LevelInView>();
            var tb = new EntityTableBuilder("Vim.LevelInView");
            tb.AddDataColumn("double:Extents.Min.X", typedEntities.Select(x => x.Extents_Min_X));
            tb.AddDataColumn("double:Extents.Min.Y", typedEntities.Select(x => x.Extents_Min_Y));
            tb.AddDataColumn("double:Extents.Min.Z", typedEntities.Select(x => x.Extents_Min_Z));
            tb.AddDataColumn("double:Extents.Max.X", typedEntities.Select(x => x.Extents_Max_X));
            tb.AddDataColumn("double:Extents.Max.Y", typedEntities.Select(x => x.Extents_Max_Y));
            tb.AddDataColumn("double:Extents.Max.Z", typedEntities.Select(x => x.Extents_Max_Z));
            tb.AddIndexColumn("index:Vim.Level:Level", typedEntities.Select(x => x._Level?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.View:View", typedEntities.Select(x => x._View?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToCameraTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Camera>() ?? Enumerable.Empty<Camera>();
            var tb = new EntityTableBuilder("Vim.Camera");
            tb.AddDataColumn("int:Id", typedEntities.Select(x => x.Id));
            tb.AddDataColumn("int:IsPerspective", typedEntities.Select(x => x.IsPerspective));
            tb.AddDataColumn("double:VerticalExtent", typedEntities.Select(x => x.VerticalExtent));
            tb.AddDataColumn("double:HorizontalExtent", typedEntities.Select(x => x.HorizontalExtent));
            tb.AddDataColumn("double:FarDistance", typedEntities.Select(x => x.FarDistance));
            tb.AddDataColumn("double:NearDistance", typedEntities.Select(x => x.NearDistance));
            tb.AddDataColumn("double:TargetDistance", typedEntities.Select(x => x.TargetDistance));
            tb.AddDataColumn("double:RightOffset", typedEntities.Select(x => x.RightOffset));
            tb.AddDataColumn("double:UpOffset", typedEntities.Select(x => x.UpOffset));
            return tb;
        }
        public static EntityTableBuilder ToMaterialTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Material>() ?? Enumerable.Empty<Material>();
            var tb = new EntityTableBuilder("Vim.Material");
            tb.AddStringColumn("string:Name", typedEntities.Select(x => x.Name));
            tb.AddStringColumn("string:MaterialCategory", typedEntities.Select(x => x.MaterialCategory));
            tb.AddDataColumn("double:Color.X", typedEntities.Select(x => x.Color_X));
            tb.AddDataColumn("double:Color.Y", typedEntities.Select(x => x.Color_Y));
            tb.AddDataColumn("double:Color.Z", typedEntities.Select(x => x.Color_Z));
            tb.AddDataColumn("double:ColorUvScaling.X", typedEntities.Select(x => x.ColorUvScaling_X));
            tb.AddDataColumn("double:ColorUvScaling.Y", typedEntities.Select(x => x.ColorUvScaling_Y));
            tb.AddDataColumn("double:ColorUvOffset.X", typedEntities.Select(x => x.ColorUvOffset_X));
            tb.AddDataColumn("double:ColorUvOffset.Y", typedEntities.Select(x => x.ColorUvOffset_Y));
            tb.AddDataColumn("double:NormalUvScaling.X", typedEntities.Select(x => x.NormalUvScaling_X));
            tb.AddDataColumn("double:NormalUvScaling.Y", typedEntities.Select(x => x.NormalUvScaling_Y));
            tb.AddDataColumn("double:NormalUvOffset.X", typedEntities.Select(x => x.NormalUvOffset_X));
            tb.AddDataColumn("double:NormalUvOffset.Y", typedEntities.Select(x => x.NormalUvOffset_Y));
            tb.AddDataColumn("double:NormalAmount", typedEntities.Select(x => x.NormalAmount));
            tb.AddDataColumn("double:Glossiness", typedEntities.Select(x => x.Glossiness));
            tb.AddDataColumn("double:Smoothness", typedEntities.Select(x => x.Smoothness));
            tb.AddDataColumn("double:Transparency", typedEntities.Select(x => x.Transparency));
            tb.AddIndexColumn("index:Vim.Asset:ColorTextureFile", typedEntities.Select(x => x._ColorTextureFile?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Asset:NormalTextureFile", typedEntities.Select(x => x._NormalTextureFile?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToMaterialInElementTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<MaterialInElement>() ?? Enumerable.Empty<MaterialInElement>();
            var tb = new EntityTableBuilder("Vim.MaterialInElement");
            tb.AddDataColumn("double:Area", typedEntities.Select(x => x.Area));
            tb.AddDataColumn("double:Volume", typedEntities.Select(x => x.Volume));
            tb.AddDataColumn("byte:IsPaint", typedEntities.Select(x => x.IsPaint));
            tb.AddIndexColumn("index:Vim.Material:Material", typedEntities.Select(x => x._Material?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToCompoundStructureLayerTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<CompoundStructureLayer>() ?? Enumerable.Empty<CompoundStructureLayer>();
            var tb = new EntityTableBuilder("Vim.CompoundStructureLayer");
            tb.AddDataColumn("int:OrderIndex", typedEntities.Select(x => x.OrderIndex));
            tb.AddDataColumn("double:Width", typedEntities.Select(x => x.Width));
            tb.AddStringColumn("string:MaterialFunctionAssignment", typedEntities.Select(x => x.MaterialFunctionAssignment));
            tb.AddIndexColumn("index:Vim.Material:Material", typedEntities.Select(x => x._Material?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.CompoundStructure:CompoundStructure", typedEntities.Select(x => x._CompoundStructure?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToCompoundStructureTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<CompoundStructure>() ?? Enumerable.Empty<CompoundStructure>();
            var tb = new EntityTableBuilder("Vim.CompoundStructure");
            tb.AddDataColumn("double:Width", typedEntities.Select(x => x.Width));
            tb.AddIndexColumn("index:Vim.CompoundStructureLayer:StructuralLayer", typedEntities.Select(x => x._StructuralLayer?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToNodeTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Node>() ?? Enumerable.Empty<Node>();
            var tb = new EntityTableBuilder("Vim.Node");
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToGeometryTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Geometry>() ?? Enumerable.Empty<Geometry>();
            var tb = new EntityTableBuilder("Vim.Geometry");
            tb.AddDataColumn("float:Box.Min.X", typedEntities.Select(x => x.Box_Min_X));
            tb.AddDataColumn("float:Box.Min.Y", typedEntities.Select(x => x.Box_Min_Y));
            tb.AddDataColumn("float:Box.Min.Z", typedEntities.Select(x => x.Box_Min_Z));
            tb.AddDataColumn("float:Box.Max.X", typedEntities.Select(x => x.Box_Max_X));
            tb.AddDataColumn("float:Box.Max.Y", typedEntities.Select(x => x.Box_Max_Y));
            tb.AddDataColumn("float:Box.Max.Z", typedEntities.Select(x => x.Box_Max_Z));
            tb.AddDataColumn("int:VertexCount", typedEntities.Select(x => x.VertexCount));
            tb.AddDataColumn("int:FaceCount", typedEntities.Select(x => x.FaceCount));
            return tb;
        }
        public static EntityTableBuilder ToShapeTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Shape>() ?? Enumerable.Empty<Shape>();
            var tb = new EntityTableBuilder("Vim.Shape");
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToShapeCollectionTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ShapeCollection>() ?? Enumerable.Empty<ShapeCollection>();
            var tb = new EntityTableBuilder("Vim.ShapeCollection");
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToShapeInShapeCollectionTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ShapeInShapeCollection>() ?? Enumerable.Empty<ShapeInShapeCollection>();
            var tb = new EntityTableBuilder("Vim.ShapeInShapeCollection");
            tb.AddIndexColumn("index:Vim.Shape:Shape", typedEntities.Select(x => x._Shape?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.ShapeCollection:ShapeCollection", typedEntities.Select(x => x._ShapeCollection?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToSystemTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<System>() ?? Enumerable.Empty<System>();
            var tb = new EntityTableBuilder("Vim.System");
            tb.AddDataColumn("int:SystemType", typedEntities.Select(x => x.SystemType));
            tb.AddIndexColumn("index:Vim.FamilyType:FamilyType", typedEntities.Select(x => x._FamilyType?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToElementInSystemTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ElementInSystem>() ?? Enumerable.Empty<ElementInSystem>();
            var tb = new EntityTableBuilder("Vim.ElementInSystem");
            tb.AddDataColumn("int:Roles", typedEntities.Select(x => x.Roles));
            tb.AddIndexColumn("index:Vim.System:System", typedEntities.Select(x => x._System?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToWarningTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Warning>() ?? Enumerable.Empty<Warning>();
            var tb = new EntityTableBuilder("Vim.Warning");
            tb.AddStringColumn("string:Guid", typedEntities.Select(x => x.Guid));
            tb.AddStringColumn("string:Severity", typedEntities.Select(x => x.Severity));
            tb.AddStringColumn("string:Description", typedEntities.Select(x => x.Description));
            tb.AddIndexColumn("index:Vim.BimDocument:BimDocument", typedEntities.Select(x => x._BimDocument?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToElementInWarningTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ElementInWarning>() ?? Enumerable.Empty<ElementInWarning>();
            var tb = new EntityTableBuilder("Vim.ElementInWarning");
            tb.AddIndexColumn("index:Vim.Warning:Warning", typedEntities.Select(x => x._Warning?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToBasePointTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<BasePoint>() ?? Enumerable.Empty<BasePoint>();
            var tb = new EntityTableBuilder("Vim.BasePoint");
            tb.AddDataColumn("byte:IsSurveyPoint", typedEntities.Select(x => x.IsSurveyPoint));
            tb.AddDataColumn("double:Position.X", typedEntities.Select(x => x.Position_X));
            tb.AddDataColumn("double:Position.Y", typedEntities.Select(x => x.Position_Y));
            tb.AddDataColumn("double:Position.Z", typedEntities.Select(x => x.Position_Z));
            tb.AddDataColumn("double:SharedPosition.X", typedEntities.Select(x => x.SharedPosition_X));
            tb.AddDataColumn("double:SharedPosition.Y", typedEntities.Select(x => x.SharedPosition_Y));
            tb.AddDataColumn("double:SharedPosition.Z", typedEntities.Select(x => x.SharedPosition_Z));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToPhaseFilterTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<PhaseFilter>() ?? Enumerable.Empty<PhaseFilter>();
            var tb = new EntityTableBuilder("Vim.PhaseFilter");
            tb.AddDataColumn("int:New", typedEntities.Select(x => x.New));
            tb.AddDataColumn("int:Existing", typedEntities.Select(x => x.Existing));
            tb.AddDataColumn("int:Demolished", typedEntities.Select(x => x.Demolished));
            tb.AddDataColumn("int:Temporary", typedEntities.Select(x => x.Temporary));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToGridTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Grid>() ?? Enumerable.Empty<Grid>();
            var tb = new EntityTableBuilder("Vim.Grid");
            tb.AddDataColumn("double:StartPoint.X", typedEntities.Select(x => x.StartPoint_X));
            tb.AddDataColumn("double:StartPoint.Y", typedEntities.Select(x => x.StartPoint_Y));
            tb.AddDataColumn("double:StartPoint.Z", typedEntities.Select(x => x.StartPoint_Z));
            tb.AddDataColumn("double:EndPoint.X", typedEntities.Select(x => x.EndPoint_X));
            tb.AddDataColumn("double:EndPoint.Y", typedEntities.Select(x => x.EndPoint_Y));
            tb.AddDataColumn("double:EndPoint.Z", typedEntities.Select(x => x.EndPoint_Z));
            tb.AddDataColumn("byte:IsCurved", typedEntities.Select(x => x.IsCurved));
            tb.AddDataColumn("double:Extents.Min.X", typedEntities.Select(x => x.Extents_Min_X));
            tb.AddDataColumn("double:Extents.Min.Y", typedEntities.Select(x => x.Extents_Min_Y));
            tb.AddDataColumn("double:Extents.Min.Z", typedEntities.Select(x => x.Extents_Min_Z));
            tb.AddDataColumn("double:Extents.Max.X", typedEntities.Select(x => x.Extents_Max_X));
            tb.AddDataColumn("double:Extents.Max.Y", typedEntities.Select(x => x.Extents_Max_Y));
            tb.AddDataColumn("double:Extents.Max.Z", typedEntities.Select(x => x.Extents_Max_Z));
            tb.AddIndexColumn("index:Vim.FamilyType:FamilyType", typedEntities.Select(x => x._FamilyType?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToAreaTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Area>() ?? Enumerable.Empty<Area>();
            var tb = new EntityTableBuilder("Vim.Area");
            tb.AddDataColumn("double:Value", typedEntities.Select(x => x.Value));
            tb.AddDataColumn("double:Perimeter", typedEntities.Select(x => x.Perimeter));
            tb.AddStringColumn("string:Number", typedEntities.Select(x => x.Number));
            tb.AddDataColumn("byte:IsGrossInterior", typedEntities.Select(x => x.IsGrossInterior));
            tb.AddIndexColumn("index:Vim.AreaScheme:AreaScheme", typedEntities.Select(x => x._AreaScheme?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToAreaSchemeTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<AreaScheme>() ?? Enumerable.Empty<AreaScheme>();
            var tb = new EntityTableBuilder("Vim.AreaScheme");
            tb.AddDataColumn("byte:IsGrossBuildingArea", typedEntities.Select(x => x.IsGrossBuildingArea));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToScheduleTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Schedule>() ?? Enumerable.Empty<Schedule>();
            var tb = new EntityTableBuilder("Vim.Schedule");
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToScheduleColumnTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ScheduleColumn>() ?? Enumerable.Empty<ScheduleColumn>();
            var tb = new EntityTableBuilder("Vim.ScheduleColumn");
            tb.AddStringColumn("string:Name", typedEntities.Select(x => x.Name));
            tb.AddDataColumn("int:ColumnIndex", typedEntities.Select(x => x.ColumnIndex));
            tb.AddIndexColumn("index:Vim.Schedule:Schedule", typedEntities.Select(x => x._Schedule?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToScheduleCellTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ScheduleCell>() ?? Enumerable.Empty<ScheduleCell>();
            var tb = new EntityTableBuilder("Vim.ScheduleCell");
            tb.AddStringColumn("string:Value", typedEntities.Select(x => x.Value));
            tb.AddDataColumn("int:RowIndex", typedEntities.Select(x => x.RowIndex));
            tb.AddIndexColumn("index:Vim.ScheduleColumn:ScheduleColumn", typedEntities.Select(x => x._ScheduleColumn?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToViewSheetSetTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ViewSheetSet>() ?? Enumerable.Empty<ViewSheetSet>();
            var tb = new EntityTableBuilder("Vim.ViewSheetSet");
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToViewSheetTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ViewSheet>() ?? Enumerable.Empty<ViewSheet>();
            var tb = new EntityTableBuilder("Vim.ViewSheet");
            tb.AddIndexColumn("index:Vim.FamilyType:FamilyType", typedEntities.Select(x => x._FamilyType?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToViewSheetInViewSheetSetTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ViewSheetInViewSheetSet>() ?? Enumerable.Empty<ViewSheetInViewSheetSet>();
            var tb = new EntityTableBuilder("Vim.ViewSheetInViewSheetSet");
            tb.AddIndexColumn("index:Vim.ViewSheet:ViewSheet", typedEntities.Select(x => x._ViewSheet?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.ViewSheetSet:ViewSheetSet", typedEntities.Select(x => x._ViewSheetSet?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToViewInViewSheetSetTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ViewInViewSheetSet>() ?? Enumerable.Empty<ViewInViewSheetSet>();
            var tb = new EntityTableBuilder("Vim.ViewInViewSheetSet");
            tb.AddIndexColumn("index:Vim.View:View", typedEntities.Select(x => x._View?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.ViewSheetSet:ViewSheetSet", typedEntities.Select(x => x._ViewSheetSet?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToViewInViewSheetTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<ViewInViewSheet>() ?? Enumerable.Empty<ViewInViewSheet>();
            var tb = new EntityTableBuilder("Vim.ViewInViewSheet");
            tb.AddIndexColumn("index:Vim.View:View", typedEntities.Select(x => x._View?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.ViewSheet:ViewSheet", typedEntities.Select(x => x._ViewSheet?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToSiteTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Site>() ?? Enumerable.Empty<Site>();
            var tb = new EntityTableBuilder("Vim.Site");
            tb.AddDataColumn("double:Latitude", typedEntities.Select(x => x.Latitude));
            tb.AddDataColumn("double:Longitude", typedEntities.Select(x => x.Longitude));
            tb.AddStringColumn("string:Address", typedEntities.Select(x => x.Address));
            tb.AddDataColumn("double:Elevation", typedEntities.Select(x => x.Elevation));
            tb.AddStringColumn("string:Number", typedEntities.Select(x => x.Number));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
        public static EntityTableBuilder ToBuildingTableBuilder(this IEnumerable<Entity> entities)
        {
            var typedEntities = entities?.Cast<Building>() ?? Enumerable.Empty<Building>();
            var tb = new EntityTableBuilder("Vim.Building");
            tb.AddDataColumn("double:Elevation", typedEntities.Select(x => x.Elevation));
            tb.AddDataColumn("double:TerrainElevation", typedEntities.Select(x => x.TerrainElevation));
            tb.AddStringColumn("string:Address", typedEntities.Select(x => x.Address));
            tb.AddIndexColumn("index:Vim.Site:Site", typedEntities.Select(x => x._Site?.Index ?? EntityRelation.None));
            tb.AddIndexColumn("index:Vim.Element:Element", typedEntities.Select(x => x._Element?.Index ?? EntityRelation.None));
            return tb;
        }
    } // DocumentBuilderExtensions
    
    public partial class ObjectModelBuilder
    {
        public readonly Dictionary<Type, EntityTableBuilder> EntityTableBuilders = new Dictionary<Type, EntityTableBuilder>()
        {
            {typeof(Asset), new EntityTableBuilder()},
            {typeof(DisplayUnit), new EntityTableBuilder()},
            {typeof(ParameterDescriptor), new EntityTableBuilder()},
            {typeof(Parameter), new EntityTableBuilder()},
            {typeof(Element), new EntityTableBuilder()},
            {typeof(Workset), new EntityTableBuilder()},
            {typeof(AssemblyInstance), new EntityTableBuilder()},
            {typeof(Group), new EntityTableBuilder()},
            {typeof(DesignOption), new EntityTableBuilder()},
            {typeof(Level), new EntityTableBuilder()},
            {typeof(Phase), new EntityTableBuilder()},
            {typeof(Room), new EntityTableBuilder()},
            {typeof(BimDocument), new EntityTableBuilder()},
            {typeof(DisplayUnitInBimDocument), new EntityTableBuilder()},
            {typeof(PhaseOrderInBimDocument), new EntityTableBuilder()},
            {typeof(Category), new EntityTableBuilder()},
            {typeof(Family), new EntityTableBuilder()},
            {typeof(FamilyType), new EntityTableBuilder()},
            {typeof(FamilyInstance), new EntityTableBuilder()},
            {typeof(View), new EntityTableBuilder()},
            {typeof(ElementInView), new EntityTableBuilder()},
            {typeof(ShapeInView), new EntityTableBuilder()},
            {typeof(AssetInView), new EntityTableBuilder()},
            {typeof(AssetInViewSheet), new EntityTableBuilder()},
            {typeof(LevelInView), new EntityTableBuilder()},
            {typeof(Camera), new EntityTableBuilder()},
            {typeof(Material), new EntityTableBuilder()},
            {typeof(MaterialInElement), new EntityTableBuilder()},
            {typeof(CompoundStructureLayer), new EntityTableBuilder()},
            {typeof(CompoundStructure), new EntityTableBuilder()},
            {typeof(Node), new EntityTableBuilder()},
            {typeof(Geometry), new EntityTableBuilder()},
            {typeof(Shape), new EntityTableBuilder()},
            {typeof(ShapeCollection), new EntityTableBuilder()},
            {typeof(ShapeInShapeCollection), new EntityTableBuilder()},
            {typeof(System), new EntityTableBuilder()},
            {typeof(ElementInSystem), new EntityTableBuilder()},
            {typeof(Warning), new EntityTableBuilder()},
            {typeof(ElementInWarning), new EntityTableBuilder()},
            {typeof(BasePoint), new EntityTableBuilder()},
            {typeof(PhaseFilter), new EntityTableBuilder()},
            {typeof(Grid), new EntityTableBuilder()},
            {typeof(Area), new EntityTableBuilder()},
            {typeof(AreaScheme), new EntityTableBuilder()},
            {typeof(Schedule), new EntityTableBuilder()},
            {typeof(ScheduleColumn), new EntityTableBuilder()},
            {typeof(ScheduleCell), new EntityTableBuilder()},
            {typeof(ViewSheetSet), new EntityTableBuilder()},
            {typeof(ViewSheet), new EntityTableBuilder()},
            {typeof(ViewSheetInViewSheetSet), new EntityTableBuilder()},
            {typeof(ViewInViewSheetSet), new EntityTableBuilder()},
            {typeof(ViewInViewSheet), new EntityTableBuilder()},
            {typeof(Site), new EntityTableBuilder()},
            {typeof(Building), new EntityTableBuilder()},
        };
    } // ObjectModelBuilder
} // namespace
