// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/BoxSearchItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/BoxSearchItem.proto</summary>
  public static partial class BoxSearchItemReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/BoxSearchItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BoxSearchItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlQcm90by9Cb3hTZWFyY2hJdGVtLnByb3RvEgxSZU1hc3RlcnNMaWIiggEK",
            "DUJveFNlYXJjaEl0ZW0SFQoNYm94X3NlYXJjaF9pZBgBIAEoBRIMCgRzdGVw",
            "GAIgASgFEg0KBW9yZGVyGAMgASgDEhYKDmlzX2dyYW5kX3ByaXplGAQgASgI",
            "EhMKC2l0ZW1fc2V0X2lkGAUgASgDEhAKCHF1YW50aXR5GAYgASgFIkIKEkJv",
            "eFNlYXJjaEl0ZW1UYWJsZRIsCgdlbnRyaWVzGAEgAygLMhsuUmVNYXN0ZXJz",
            "TGliLkJveFNlYXJjaEl0ZW1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.BoxSearchItem), global::ReMastersLib.BoxSearchItem.Parser, new[]{ "BoxSearchId", "Step", "Order", "IsGrandPrize", "ItemSetId", "Quantity" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.BoxSearchItemTable), global::ReMastersLib.BoxSearchItemTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BoxSearchItem : pb::IMessage<BoxSearchItem> {
    private static readonly pb::MessageParser<BoxSearchItem> _parser = new pb::MessageParser<BoxSearchItem>(() => new BoxSearchItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BoxSearchItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.BoxSearchItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoxSearchItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoxSearchItem(BoxSearchItem other) : this() {
      boxSearchId_ = other.boxSearchId_;
      step_ = other.step_;
      order_ = other.order_;
      isGrandPrize_ = other.isGrandPrize_;
      itemSetId_ = other.itemSetId_;
      quantity_ = other.quantity_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoxSearchItem Clone() {
      return new BoxSearchItem(this);
    }

    /// <summary>Field number for the "box_search_id" field.</summary>
    public const int BoxSearchIdFieldNumber = 1;
    private int boxSearchId_;
    /// <summary>
    /// BoxSearch.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BoxSearchId {
      get { return boxSearchId_; }
      set {
        boxSearchId_ = value;
      }
    }

    /// <summary>Field number for the "step" field.</summary>
    public const int StepFieldNumber = 2;
    private int step_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Step {
      get { return step_; }
      set {
        step_ = value;
      }
    }

    /// <summary>Field number for the "order" field.</summary>
    public const int OrderFieldNumber = 3;
    private long order_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Order {
      get { return order_; }
      set {
        order_ = value;
      }
    }

    /// <summary>Field number for the "is_grand_prize" field.</summary>
    public const int IsGrandPrizeFieldNumber = 4;
    private bool isGrandPrize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsGrandPrize {
      get { return isGrandPrize_; }
      set {
        isGrandPrize_ = value;
      }
    }

    /// <summary>Field number for the "item_set_id" field.</summary>
    public const int ItemSetIdFieldNumber = 5;
    private long itemSetId_;
    /// <summary>
    /// ItemSet.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ItemSetId {
      get { return itemSetId_; }
      set {
        itemSetId_ = value;
      }
    }

    /// <summary>Field number for the "quantity" field.</summary>
    public const int QuantityFieldNumber = 6;
    private int quantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BoxSearchItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BoxSearchItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BoxSearchId != other.BoxSearchId) return false;
      if (Step != other.Step) return false;
      if (Order != other.Order) return false;
      if (IsGrandPrize != other.IsGrandPrize) return false;
      if (ItemSetId != other.ItemSetId) return false;
      if (Quantity != other.Quantity) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BoxSearchId != 0) hash ^= BoxSearchId.GetHashCode();
      if (Step != 0) hash ^= Step.GetHashCode();
      if (Order != 0L) hash ^= Order.GetHashCode();
      if (IsGrandPrize != false) hash ^= IsGrandPrize.GetHashCode();
      if (ItemSetId != 0L) hash ^= ItemSetId.GetHashCode();
      if (Quantity != 0) hash ^= Quantity.GetHashCode();
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
      if (BoxSearchId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(BoxSearchId);
      }
      if (Step != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Step);
      }
      if (Order != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Order);
      }
      if (IsGrandPrize != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsGrandPrize);
      }
      if (ItemSetId != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(ItemSetId);
      }
      if (Quantity != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Quantity);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BoxSearchId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BoxSearchId);
      }
      if (Step != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Step);
      }
      if (Order != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Order);
      }
      if (IsGrandPrize != false) {
        size += 1 + 1;
      }
      if (ItemSetId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ItemSetId);
      }
      if (Quantity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Quantity);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BoxSearchItem other) {
      if (other == null) {
        return;
      }
      if (other.BoxSearchId != 0) {
        BoxSearchId = other.BoxSearchId;
      }
      if (other.Step != 0) {
        Step = other.Step;
      }
      if (other.Order != 0L) {
        Order = other.Order;
      }
      if (other.IsGrandPrize != false) {
        IsGrandPrize = other.IsGrandPrize;
      }
      if (other.ItemSetId != 0L) {
        ItemSetId = other.ItemSetId;
      }
      if (other.Quantity != 0) {
        Quantity = other.Quantity;
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
            BoxSearchId = input.ReadInt32();
            break;
          }
          case 16: {
            Step = input.ReadInt32();
            break;
          }
          case 24: {
            Order = input.ReadInt64();
            break;
          }
          case 32: {
            IsGrandPrize = input.ReadBool();
            break;
          }
          case 40: {
            ItemSetId = input.ReadInt64();
            break;
          }
          case 48: {
            Quantity = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class BoxSearchItemTable : pb::IMessage<BoxSearchItemTable> {
    private static readonly pb::MessageParser<BoxSearchItemTable> _parser = new pb::MessageParser<BoxSearchItemTable>(() => new BoxSearchItemTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BoxSearchItemTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.BoxSearchItemReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoxSearchItemTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoxSearchItemTable(BoxSearchItemTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoxSearchItemTable Clone() {
      return new BoxSearchItemTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.BoxSearchItem> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.BoxSearchItem.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.BoxSearchItem> entries_ = new pbc::RepeatedField<global::ReMastersLib.BoxSearchItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.BoxSearchItem> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BoxSearchItemTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BoxSearchItemTable other) {
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
    public void MergeFrom(BoxSearchItemTable other) {
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
