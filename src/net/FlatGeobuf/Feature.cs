// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatGeobuf
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct Feature : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_22_10_26(); }
  public static Feature GetRootAsFeature(ByteBuffer _bb) { return GetRootAsFeature(_bb, new Feature()); }
  public static Feature GetRootAsFeature(ByteBuffer _bb, Feature obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Feature __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatGeobuf.Geometry? Geometry { get { int o = __p.__offset(4); return o != 0 ? (FlatGeobuf.Geometry?)(new FlatGeobuf.Geometry()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public byte Properties(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int PropertiesLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPropertiesBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetPropertiesBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetPropertiesArray() { return __p.__vector_as_array<byte>(6); }
  public FlatGeobuf.Column? Columns(int j) { int o = __p.__offset(8); return o != 0 ? (FlatGeobuf.Column?)(new FlatGeobuf.Column()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int ColumnsLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatGeobuf.Feature> CreateFeature(FlatBufferBuilder builder,
      Offset<FlatGeobuf.Geometry> geometryOffset = default(Offset<FlatGeobuf.Geometry>),
      VectorOffset propertiesOffset = default(VectorOffset),
      VectorOffset columnsOffset = default(VectorOffset)) {
    builder.StartTable(3);
    Feature.AddColumns(builder, columnsOffset);
    Feature.AddProperties(builder, propertiesOffset);
    Feature.AddGeometry(builder, geometryOffset);
    return Feature.EndFeature(builder);
  }

  public static void StartFeature(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddGeometry(FlatBufferBuilder builder, Offset<FlatGeobuf.Geometry> geometryOffset) { builder.AddOffset(0, geometryOffset.Value, 0); }
  public static void AddProperties(FlatBufferBuilder builder, VectorOffset propertiesOffset) { builder.AddOffset(1, propertiesOffset.Value, 0); }
  public static VectorOffset CreatePropertiesVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePropertiesVectorBlock(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePropertiesVectorBlock(FlatBufferBuilder builder, ArraySegment<byte> data) { builder.StartVector(1, data.Count, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePropertiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<byte>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPropertiesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddColumns(FlatBufferBuilder builder, VectorOffset columnsOffset) { builder.AddOffset(2, columnsOffset.Value, 0); }
  public static VectorOffset CreateColumnsVector(FlatBufferBuilder builder, Offset<FlatGeobuf.Column>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateColumnsVectorBlock(FlatBufferBuilder builder, Offset<FlatGeobuf.Column>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateColumnsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatGeobuf.Column>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateColumnsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatGeobuf.Column>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartColumnsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatGeobuf.Feature> EndFeature(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatGeobuf.Feature>(o);
  }
  public static void FinishFeatureBuffer(FlatBufferBuilder builder, Offset<FlatGeobuf.Feature> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedFeatureBuffer(FlatBufferBuilder builder, Offset<FlatGeobuf.Feature> offset) { builder.FinishSizePrefixed(offset.Value); }
  public FeatureT UnPack() {
    var _o = new FeatureT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FeatureT _o) {
    _o.Geometry = this.Geometry.HasValue ? this.Geometry.Value.UnPack() : null;
    _o.Properties = new List<byte>();
    for (var _j = 0; _j < this.PropertiesLength; ++_j) {_o.Properties.Add(this.Properties(_j));}
    _o.Columns = new List<FlatGeobuf.ColumnT>();
    for (var _j = 0; _j < this.ColumnsLength; ++_j) {_o.Columns.Add(this.Columns(_j).HasValue ? this.Columns(_j).Value.UnPack() : null);}
  }
  public static Offset<FlatGeobuf.Feature> Pack(FlatBufferBuilder builder, FeatureT _o) {
    if (_o == null) return default(Offset<FlatGeobuf.Feature>);
    var _geometry = _o.Geometry == null ? default(Offset<FlatGeobuf.Geometry>) : FlatGeobuf.Geometry.Pack(builder, _o.Geometry);
    var _properties = default(VectorOffset);
    if (_o.Properties != null) {
      var __properties = _o.Properties.ToArray();
      _properties = CreatePropertiesVector(builder, __properties);
    }
    var _columns = default(VectorOffset);
    if (_o.Columns != null) {
      var __columns = new Offset<FlatGeobuf.Column>[_o.Columns.Count];
      for (var _j = 0; _j < __columns.Length; ++_j) { __columns[_j] = FlatGeobuf.Column.Pack(builder, _o.Columns[_j]); }
      _columns = CreateColumnsVector(builder, __columns);
    }
    return CreateFeature(
      builder,
      _geometry,
      _properties,
      _columns);
  }
}

public class FeatureT
{
  public FlatGeobuf.GeometryT Geometry { get; set; }
  public List<byte> Properties { get; set; }
  public List<FlatGeobuf.ColumnT> Columns { get; set; }

  public FeatureT() {
    this.Geometry = null;
    this.Properties = null;
    this.Columns = null;
  }
  public static FeatureT DeserializeFromBinary(byte[] fbBuffer) {
    return Feature.GetRootAsFeature(new ByteBuffer(fbBuffer)).UnPack();
  }
  public byte[] SerializeToBinary() {
    var fbb = new FlatBufferBuilder(0x10000);
    Feature.FinishFeatureBuffer(fbb, Feature.Pack(fbb, this));
    return fbb.DataBuffer.ToSizedArray();
  }
}


}
