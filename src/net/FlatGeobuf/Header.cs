// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatGeobuf
{

using global::System;
using global::FlatBuffers;

public struct Header : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Header GetRootAsHeader(ByteBuffer _bb) { return GetRootAsHeader(_bb, new Header()); }
  public static Header GetRootAsHeader(ByteBuffer _bb, Header obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Header __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public double Envelope(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.GetDouble(__p.__vector(o) + j * 8) : (double)0; }
  public int EnvelopeLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEnvelopeBytes() { return __p.__vector_as_span(4); }
#else
  public ArraySegment<byte>? GetEnvelopeBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public double[] GetEnvelopeArray() { return __p.__vector_as_array<double>(4); }
  public GeometryType GeometryType { get { int o = __p.__offset(6); return o != 0 ? (GeometryType)__p.bb.Get(o + __p.bb_pos) : GeometryType.Point; } }
  public byte Dimensions { get { int o = __p.__offset(8); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)2; } }
  public Column? Columns(int j) { int o = __p.__offset(10); return o != 0 ? (Column?)(new Column()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ColumnsLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public uint IndexNodeSize { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)640; } }
  public uint IndexNodesCount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)1; } }
  public ulong FeaturesSize { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUlong(o + __p.bb_pos) : (ulong)0; } }
  public ulong FeaturesCount { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetUlong(o + __p.bb_pos) : (ulong)1; } }

  public static Offset<Header> CreateHeader(FlatBufferBuilder builder,
      VectorOffset envelopeOffset = default(VectorOffset),
      GeometryType geometry_type = GeometryType.Point,
      byte dimensions = 2,
      VectorOffset columnsOffset = default(VectorOffset),
      uint index_node_size = 640,
      uint index_nodes_count = 1,
      ulong features_size = 0,
      ulong features_count = 1) {
    builder.StartObject(8);
    Header.AddFeaturesCount(builder, features_count);
    Header.AddFeaturesSize(builder, features_size);
    Header.AddIndexNodesCount(builder, index_nodes_count);
    Header.AddIndexNodeSize(builder, index_node_size);
    Header.AddColumns(builder, columnsOffset);
    Header.AddEnvelope(builder, envelopeOffset);
    Header.AddDimensions(builder, dimensions);
    Header.AddGeometryType(builder, geometry_type);
    return Header.EndHeader(builder);
  }

  public static void StartHeader(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddEnvelope(FlatBufferBuilder builder, VectorOffset envelopeOffset) { builder.AddOffset(0, envelopeOffset.Value, 0); }
  public static VectorOffset CreateEnvelopeVector(FlatBufferBuilder builder, double[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddDouble(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEnvelopeVectorBlock(FlatBufferBuilder builder, double[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static void StartEnvelopeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddGeometryType(FlatBufferBuilder builder, GeometryType geometryType) { builder.AddByte(1, (byte)geometryType, 0); }
  public static void AddDimensions(FlatBufferBuilder builder, byte dimensions) { builder.AddByte(2, dimensions, 2); }
  public static void AddColumns(FlatBufferBuilder builder, VectorOffset columnsOffset) { builder.AddOffset(3, columnsOffset.Value, 0); }
  public static VectorOffset CreateColumnsVector(FlatBufferBuilder builder, Offset<Column>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateColumnsVectorBlock(FlatBufferBuilder builder, Offset<Column>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartColumnsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIndexNodeSize(FlatBufferBuilder builder, uint indexNodeSize) { builder.AddUint(4, indexNodeSize, 640); }
  public static void AddIndexNodesCount(FlatBufferBuilder builder, uint indexNodesCount) { builder.AddUint(5, indexNodesCount, 1); }
  public static void AddFeaturesSize(FlatBufferBuilder builder, ulong featuresSize) { builder.AddUlong(6, featuresSize, 0); }
  public static void AddFeaturesCount(FlatBufferBuilder builder, ulong featuresCount) { builder.AddUlong(7, featuresCount, 1); }
  public static Offset<Header> EndHeader(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Header>(o);
  }
  public static void FinishHeaderBuffer(FlatBufferBuilder builder, Offset<Header> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedHeaderBuffer(FlatBufferBuilder builder, Offset<Header> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}