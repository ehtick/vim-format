/*
    G3D Data Format
    Copyright 2019, VIMaec LLC
    Copyright 2018, Ara 3D, Inc.
    Usage licensed under terms of MIT Licenese.
*/

#ifndef __G3D_H__
#define __G3D_H__

#include <vector>
#include <sstream>
#include <map>

#include "bfast.h"

namespace g3d
{
    #define G3D_VERSION = { 2, 2, 0, "2022.05.02" };

    using namespace std;

    /// The different types of data types that can be used as elements. 
    enum class DataType 
    {
        dt_uint8,
        dt_int8,
        dt_uint16,
        dt_int16,
        dt_uint32,
        dt_int32,
        dt_uint64,
        dt_int64,
        dt_uint128,
        dt_int128,
        dt_float16,
        dt_float32,
        dt_float64,
        dt_float128,
        dt_Undefined = 0xff,
    };

    /// What geometric element each attribute is associated with 
    enum class Association 
    {
        assoc_vertex,
        assoc_face,
        assoc_corner,
        assoc_edge,
        assoc_subgeometry,
        assoc_instance,
        assoc_shapevertex,
        assoc_shape,
        assoc_material,
        assoc_mesh,
        assoc_submesh,
        assoc_all,
        assoc_none,
    };

    enum class InstanceFlags
    {
        None = 0,
        Hidden = 1,
    };

    // Contains all the information necessary to parse an attribute data channel and associate it with some part of the geometry 
    struct AttributeDescriptor
    {
        /// The type of individual data values. There are n of these per element where n is the arity.
        DataType data_type = DataType::dt_Undefined;

        /// The number of primitive values associated with each element 
        int data_arity = 0;

        /// The index of the attribute.
        int index = 0;
        
        /// What part of the geometry each tuple of data values is associated with 
        Association association = Association::assoc_none;
        
        /// The semantic of the attribute (e.g. normals, uv)
        string semantic;

        /// The size of each data element in bytes (not counting the arity).
        int32_t data_type_size() const {
            return data_type_size(data_type);
        }

        /// Retrieves the size of individual data types
        static int32_t data_type_size(DataType dt) {
            switch (dt) {
                case DataType::dt_uint8:
                case DataType::dt_int8:
                    return 1;
                case DataType::dt_uint16:
                case DataType::dt_int16:
                    return 2;
                case DataType::dt_uint32:
                case DataType::dt_int32:
                    return 4;
                case DataType::dt_uint64:
                case DataType::dt_int64:
                    return 8;
                case DataType::dt_uint128:
                case DataType::dt_int128:
                    return 16;
                case DataType::dt_float16:
                    return 2;
                case DataType::dt_float32:
                    return 4;
                case DataType::dt_float64:
                    return 8;
                case DataType::dt_float128:
                    return 16;
                default:
                    throw runtime_error("invalid data type");
            }
        }

        /// Given a map from keys to values, creates a new map from values to keys 
        template<typename K, typename V>
        static map<V, K> reverse_map(const map<K, V>& m) {
            map<V, K> r;
            for (const auto& kv : m)
                r[kv.second] = kv.first;
            return r;
        }

        /// Returns a lookup table of data-type enumerations to strings 
        static const map<DataType, string>& data_types_to_strings() {
            static map<DataType, string> names = {
                { DataType::dt_uint8,     "uint8" },
                { DataType::dt_int8,      "int8" },
                { DataType::dt_uint16,    "uint16" },
                { DataType::dt_int16,     "int16" },
                { DataType::dt_uint32,    "uint32" },
                { DataType::dt_int32,     "int32" },
                { DataType::dt_uint64,    "uint64" },
                { DataType::dt_int64,     "int64" },
                { DataType::dt_uint128,   "uint128" },
                { DataType::dt_int128,    "int128" },
                { DataType::dt_float16,   "float16" },
                { DataType::dt_float32,   "float32" },
                { DataType::dt_float64,   "float64" },
                { DataType::dt_float128,  "float128" },
            };
            return names;
        }

        static const map<string, DataType>& data_types_from_strings() {
            static auto r = reverse_map(data_types_to_strings());
            return r;
        }

        static const map<Association, string>& associations_to_strings() {
            static map<Association, string> names = {
                { Association::assoc_vertex,     "vertex" },
                { Association::assoc_face,       "face" },
                { Association::assoc_corner,     "corner" },
                { Association::assoc_edge,       "edge" },
                { Association::assoc_subgeometry,"subgeometry" },
                { Association::assoc_instance,   "instance" },
                { Association::assoc_shapevertex,"shapevertex" },
                { Association::assoc_shape,      "shape" },
                { Association::assoc_material,   "material" },
                { Association::assoc_mesh,       "mesh" },
                { Association::assoc_submesh,    "submesh" },
                { Association::assoc_all,        "all" },
                { Association::assoc_none,       "none" },
            };
            return names;
        }

        static const map<string, Association>& associations_from_strings() {
            static auto r = reverse_map(associations_to_strings());
            return r;
        }
        
        string to_string() const {
            ostringstream oss;
            oss << "g3d"
                << ":" << associations_to_strings().at(association)
                << ":" << semantic
                << ":" << index
                << ":" << data_types_to_strings().at(data_type)
                << ":" << data_arity;
            return oss.str();
        };

        template<typename Out>
        static void split(const string &s, char delim, Out result) {
            stringstream ss(s);
            string item;
            while (getline(ss, item, delim)) 
                *(result++) = item;
        }

        static vector<string> split(const string &s, char delim) {
            vector<string> elems;
            split(s, delim, back_inserter(elems));
            return elems;
        }

        static Association association_from_string(const string& s) {
            auto d = associations_from_strings();
            if (d.find(s) == d.end()) throw runtime_error("unknown association");
            return d.at(s);
        }

        static DataType data_type_from_string(const string& s) {
            auto d = data_types_from_strings();
            if (d.find(s) == d.end()) throw runtime_error("unknown data-type");
            return d.at(s);
        }

        static AttributeDescriptor from_string(const string& s) {
            AttributeDescriptor desc;
            auto tokens = split(s, ':');
            auto token = tokens.begin();
            auto end = tokens.end();
            if (token == end) throw runtime_error("Insufficient tokens");
            if (*token++ != "g3d") throw runtime_error("Expected g3d"); if (token == end) throw runtime_error("Insufficient tokens");
            desc.association = association_from_string(*token++); if (token == end) throw runtime_error("Insufficient tokens");
            desc.semantic = *token++; if (token == end) throw runtime_error("Insufficient tokens");
            desc.index = stoi(*token++);
            desc.data_type = data_type_from_string(*token++); if (token == end) throw runtime_error("Insufficient tokens");
            desc.data_arity = stoi(*token++);
            if (token != end) throw runtime_error("Too many tokens");
            return desc;
        }
    };

    /// Manage the data buffer and meta-information of an attribute 
    struct Attribute {
        Attribute(const string& desc, const void* begin, const void* end)
            : descriptor(AttributeDescriptor::from_string(desc))
            , _begin((uint8_t*)begin)
            , _end((uint8_t*)end)
        { 
            if (!begin || !end) throw runtime_error("Null parameters");
            if (byte_size() % data_element_size() != 0) throw runtime_error("Data buffer byte size does not divide evenly by size of elements");        
        }
        size_t byte_size() const {
            return _end - _begin;
        }
        size_t data_element_size() const {
            return descriptor.data_type_size() * descriptor.data_arity;
        }
        size_t num_elements() const {
            return byte_size() / data_element_size();
        }
        bfast::Buffer to_buffer() {
            return bfast::Buffer{ descriptor.to_string(), bfast::ByteRange { _begin, _end } };
        }
        static Attribute from_buffer(bfast::Buffer buffer) {
            return Attribute(buffer.name, buffer.data.begin(), buffer.data.end());
        }
        AttributeDescriptor descriptor;
        uint8_t* _begin;
        uint8_t* _end;
    };

    // A G3d data structure, is a set of attributes. It is stored internally as a BFast 
    struct G3d    
    {
        string meta;
        bfast::Bfast bfast;
        std::vector<Attribute> attributes;

        G3d()
            : meta(default_meta())
        { }

        G3d(bfast::Bfast& inputBfast)
        {
            attributes.clear();
            bfast = inputBfast;
            for (auto i = 0; i < bfast.buffers.size(); ++i)
            {
                auto b = bfast.buffers[i];
                if (i == 0)
                    meta = b.data.to_string();
                else
                {
                    add_attribute(b.name, b.data.begin(), b.data.end());
                }
            }
        }
            
        static string default_meta() {
            return "{ \"G3D\": \"1.0.0\" }";
        }

        void recompute_bfast() {
            for (auto attr : attributes)
                bfast.buffers.push_back(attr.to_buffer());
        }

        void write_file(string path) {
            bfast::Bfast b;
            b.add("meta", meta.c_str());
            for (auto attr : attributes)
                b.buffers.push_back(attr.to_buffer());
            b.write_file(path);
        }

        void read_file(string path)
        {
            attributes.clear();
            bfast = bfast::Bfast::read_file(path);
            for (auto i = 0; i < bfast.buffers.size(); ++i)
            {
                auto b = bfast.buffers[i];
                if (i == 0)
                    meta = b.data.to_string();
                else
                    add_attribute(b.name, b.data.begin(), b.data.end());
            }
        }

        void add_attribute(const string& name, const void* begin, const void* end) {
            try
            {
                attributes.push_back(Attribute(name, begin, end));
            } catch (std::exception& e) {
                e;
                // do nothing; the attribute was not recognized.
            }
        }

        void add_attribute(const string& name, void* begin, size_t size) {
            add_attribute(name, begin, (uint8_t*)begin + size);
        }
    };

    struct descriptors
    {
        static constexpr const char* Position = "g3d:vertex:position:0:float32:3";
        static constexpr const char* Index = "g3d:corner:index:0:int32:1";
        static constexpr const char* ObjectFaceSize = "g3d:all:facesize:0:int32:1";

        static constexpr const char* VertexUv = "g3d:vertex:uv:0:float32:2";
        static constexpr const char* VertexUvw = "g3d:vertex:uv:0:float32:3";
        static constexpr const char* VertexNormal = "g3d:vertex:normal:0:float32:3";
        static constexpr const char* VertexColor = "g3d:vertex:color:0:float32:3";
        static constexpr const char* VertexColorWithAlpha = "g3d:vertex:color:0:float32:4";
        static constexpr const char* VertexBitangent = "g3d:vertex:bitangent:0:float32:3";
        static constexpr const char* VertexTangent = "g3d:vertex:tangent:0:float32:3";
        static constexpr const char* VertexTangent4 = "g3d:vertex:tangent:0:float32:4";
        static constexpr const char* VertexSelectionWeight = "g3d:vertex:weight:0:float32:1";

        static constexpr const char* FaceMaterial = "g3d:face:material:0:int32:1";
        static constexpr const char* FaceNormal = "g3d:face:normal:0:float32:3";
        static constexpr const char* FaceSize = "g3d:face:facesize:0:int32:1";
        static constexpr const char* FaceIndexOffset = "g3d:face:indexoffset:0:int32:1";
        static constexpr const char* FaceSelectionWeight = "g3d:face:weight:0:float32:1";

        //VIM 1.0
        
        // Meshes
        static constexpr const char* MeshSubmeshOffset = "g3d:mesh:submeshoffset:0:int32:1";

        // Instances
        static constexpr const char* InstanceTransform = "g3d:instance:transform:0:float32:16";
        static constexpr const char* InstanceParent = "g3d:instance:parent:0:int32:1";
        static constexpr const char* InstanceMesh = "g3d:instance:mesh:0:int32:1";
        static constexpr const char* InstanceFlags = "g3d:instance:flags:0:uint16:1";

        // Shapes
        static constexpr const char* ShapeVertex = "g3d:shapevertex:position:0:float32:3";
        static constexpr const char* ShapeVertexOffset = "g3d:shape:vertexoffset:0:int32:1";
        static constexpr const char* ShapeColor = "g3d:shape:color:0:float32:4";
        static constexpr const char* ShapeWidth = "g3d:shape:width:0:float32:1";

        // Materials
        static constexpr const char* MaterialColor = "g3d:material:color:0:float32:4";
        static constexpr const char* MaterialGlossiness = "g3d:material:glossiness:0:float32:1";
        static constexpr const char* MaterialSmoothness = "g3d:material:smoothness:0:float32:1";

        // Submeshes
        static constexpr const char* SubmeshIndexOffset = "g3d:submesh:indexoffset:0:int32:1";
        static constexpr const char* SubmeshMaterial = "g3d:submesh:material:0:int32:1";

        // https://docs.thinkboxsoftware.com/products/krakatoa/2.6/1_Documentation/manual/formats/particle_channels.html
        static constexpr const char* PointVelocity = "g3d:vertex:velocity:0:float32:3";
        static constexpr const char* PointNormal = "g3d:vertex:normal:0:float32:3";
        static constexpr const char* PointAcceleration = "g3d:vertex:acceleration:0:float32:3";
        static constexpr const char* PointDensity = "g3d:vertex:density:0:float32:1";
        static constexpr const char* PointEmissionColor = "g3d:vertex:emission:0:float32:3";
        static constexpr const char* PointAbsorptionColor = "g3d:vertex:absorption:0:float32:3";
        static constexpr const char* PointSpin = "g3d:vertex:spin:0:float32:4";
        static constexpr const char* PointOrientation = "g3d:vertex:orientation:0:float32:4";
        static constexpr const char* PointParticleId = "g3d:vertex:particleid:0:int32:1";
        static constexpr const char* PointAge = "g3d:vertex:age:0:int32:1";

        // Line specific attributes 
        static constexpr const char* LineTangentIn = "g3d:vertex:tangent:0:float32:3";
        static constexpr const char* LineTangentOut = "g3d:vertex:tangent:1:float32:3";
    };
}

#endif