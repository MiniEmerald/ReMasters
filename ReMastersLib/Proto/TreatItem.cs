// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/TreatItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/TreatItem.proto</summary>
  public static partial class TreatItemReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/TreatItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TreatItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90by9UcmVhdEl0ZW0ucHJvdG8SDFJlTWFzdGVyc0xpYiJYCglUcmVh",
            "dEl0ZW0SDwoHaXRlbV9pZBgBIAEoAxIQCghhZmZpbml0eRgCIAEoBRIQCghp",
            "bWFnZV9pZBgDIAEoCRIKCgJ1NBgEIAEoBRIKCgJ1NRgFIAEoBSI6Cg5UcmVh",
            "dEl0ZW1UYWJsZRIoCgdlbnRyaWVzGAEgAygLMhcuUmVNYXN0ZXJzTGliLlRy",
            "ZWF0SXRlbWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.TreatItem), global::ReMastersLib.TreatItem.Parser, new[]{ "ItemId", "Affinity", "ImageId", "U4", "U5" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.TreatItemTable), global::ReMastersLib.TreatItemTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TreatItem : pb::IMessage<TreatItem> {
    private static readonly pb::MessageParser<TreatItem> _parser = new pb::MessageParser<TreatItem>(() => new TreatItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TreatItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.TreatItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TreatItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TreatItem(TreatItem other) : this() {
      itemId_ = other.itemId_;
      affinity_ = other.affinity_;
      imageId_ = other.imageId_;
      u4_ = other.u4_;
      u5_ = other.u5_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TreatItem Clone() {
      return new TreatItem(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private long itemId_;
    /// <summary>
    /// Item.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "affinity" field.</summary>
    public const int AffinityFieldNumber = 2;
    private int affinity_;
    /// <summary>
    /// EggUnitHappinessConfig.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Affinity {
      get { return affinity_; }
      set {
        affinity_ = value;
      }
    }

    /// <summary>Field number for the "image_id" field.</summary>
    public const int ImageIdFieldNumber = 3;
    private string imageId_ = "";
    /// <summary>
    /// ui/image/Item
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ImageId {
      get { return imageId_; }
      set {
        imageId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "u4" field.</summary>
    public const int U4FieldNumber = 4;
    private int u4_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U4 {
      get { return u4_; }
      set {
        u4_ = value;
      }
    }

    /// <summary>Field number for the "u5" field.</summary>
    public const int U5FieldNumber = 5;
    private int u5_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U5 {
      get { return u5_; }
      set {
        u5_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TreatItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TreatItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (Affinity != other.Affinity) return false;
      if (ImageId != other.ImageId) return false;
      if (U4 != other.U4) return false;
      if (U5 != other.U5) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0L) hash ^= ItemId.GetHashCode();
      if (Affinity != 0) hash ^= Affinity.GetHashCode();
      if (ImageId.Length != 0) hash ^= ImageId.GetHashCode();
      if (U4 != 0) hash ^= U4.GetHashCode();
      if (U5 != 0) hash ^= U5.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ItemId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ItemId);
      }
      if (Affinity != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Affinity);
      }
      if (ImageId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ImageId);
      }
      if (U4 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(U4);
      }
      if (U5 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(U5);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ItemId);
      }
      if (Affinity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Affinity);
      }
      if (ImageId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageId);
      }
      if (U4 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U4);
      }
      if (U5 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U5);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TreatItem other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0L) {
        ItemId = other.ItemId;
      }
      if (other.Affinity != 0) {
        Affinity = other.Affinity;
      }
      if (other.ImageId.Length != 0) {
        ImageId = other.ImageId;
      }
      if (other.U4 != 0) {
        U4 = other.U4;
      }
      if (other.U5 != 0) {
        U5 = other.U5;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ItemId = input.ReadInt64();
            break;
          }
          case 16: {
            Affinity = input.ReadInt32();
            break;
          }
          case 26: {
            ImageId = input.ReadString();
            break;
          }
          case 32: {
            U4 = input.ReadInt32();
            break;
          }
          case 40: {
            U5 = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TreatItemTable : pb::IMessage<TreatItemTable> {
    private static readonly pb::MessageParser<TreatItemTable> _parser = new pb::MessageParser<TreatItemTable>(() => new TreatItemTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TreatItemTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.TreatItemReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TreatItemTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TreatItemTable(TreatItemTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TreatItemTable Clone() {
      return new TreatItemTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.TreatItem> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.TreatItem.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.TreatItem> entries_ = new pbc::RepeatedField<global::ReMastersLib.TreatItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.TreatItem> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TreatItemTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TreatItemTable other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entries_.Equals(other.entries_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entries_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      entries_.WriteTo(output, _repeated_entries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += entries_.CalculateSize(_repeated_entries_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TreatItemTable other) {
      if (other == null) {
        return;
      }
      entries_.Add(other.entries_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            entries_.AddEntriesFrom(input, _repeated_entries_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
