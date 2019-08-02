// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/LotteryUnitRate.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/LotteryUnitRate.proto</summary>
  public static partial class LotteryUnitRateReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/LotteryUnitRate.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LotteryUnitRateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQcm90by9Mb3R0ZXJ5VW5pdFJhdGUucHJvdG8SDFJlTWFzdGVyc0xpYiJQ",
            "Cg9Mb3R0ZXJ5VW5pdFJhdGUSFAoMbG90dGVyeV9uYW1lGAEgASgJEhQKDGNo",
            "YXJhY3Rlcl9pZBgCIAEoBBIRCglkcm9wX3JhdGUYAyABKA0iRgoUTG90dGVy",
            "eVVuaXRSYXRlVGFibGUSLgoHZW50cmllcxgBIAMoCzIdLlJlTWFzdGVyc0xp",
            "Yi5Mb3R0ZXJ5VW5pdFJhdGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.LotteryUnitRate), global::ReMastersLib.LotteryUnitRate.Parser, new[]{ "LotteryName", "CharacterId", "DropRate" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.LotteryUnitRateTable), global::ReMastersLib.LotteryUnitRateTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LotteryUnitRate : pb::IMessage<LotteryUnitRate> {
    private static readonly pb::MessageParser<LotteryUnitRate> _parser = new pb::MessageParser<LotteryUnitRate>(() => new LotteryUnitRate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LotteryUnitRate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.LotteryUnitRateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LotteryUnitRate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LotteryUnitRate(LotteryUnitRate other) : this() {
      lotteryName_ = other.lotteryName_;
      characterId_ = other.characterId_;
      dropRate_ = other.dropRate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LotteryUnitRate Clone() {
      return new LotteryUnitRate(this);
    }

    /// <summary>Field number for the "lottery_name" field.</summary>
    public const int LotteryNameFieldNumber = 1;
    private string lotteryName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LotteryName {
      get { return lotteryName_; }
      set {
        lotteryName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "character_id" field.</summary>
    public const int CharacterIdFieldNumber = 2;
    private ulong characterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong CharacterId {
      get { return characterId_; }
      set {
        characterId_ = value;
      }
    }

    /// <summary>Field number for the "drop_rate" field.</summary>
    public const int DropRateFieldNumber = 3;
    private uint dropRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint DropRate {
      get { return dropRate_; }
      set {
        dropRate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LotteryUnitRate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LotteryUnitRate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LotteryName != other.LotteryName) return false;
      if (CharacterId != other.CharacterId) return false;
      if (DropRate != other.DropRate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LotteryName.Length != 0) hash ^= LotteryName.GetHashCode();
      if (CharacterId != 0UL) hash ^= CharacterId.GetHashCode();
      if (DropRate != 0) hash ^= DropRate.GetHashCode();
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
      if (LotteryName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LotteryName);
      }
      if (CharacterId != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(CharacterId);
      }
      if (DropRate != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DropRate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LotteryName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LotteryName);
      }
      if (CharacterId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CharacterId);
      }
      if (DropRate != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DropRate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LotteryUnitRate other) {
      if (other == null) {
        return;
      }
      if (other.LotteryName.Length != 0) {
        LotteryName = other.LotteryName;
      }
      if (other.CharacterId != 0UL) {
        CharacterId = other.CharacterId;
      }
      if (other.DropRate != 0) {
        DropRate = other.DropRate;
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
          case 10: {
            LotteryName = input.ReadString();
            break;
          }
          case 16: {
            CharacterId = input.ReadUInt64();
            break;
          }
          case 24: {
            DropRate = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class LotteryUnitRateTable : pb::IMessage<LotteryUnitRateTable> {
    private static readonly pb::MessageParser<LotteryUnitRateTable> _parser = new pb::MessageParser<LotteryUnitRateTable>(() => new LotteryUnitRateTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LotteryUnitRateTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.LotteryUnitRateReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LotteryUnitRateTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LotteryUnitRateTable(LotteryUnitRateTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LotteryUnitRateTable Clone() {
      return new LotteryUnitRateTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.LotteryUnitRate> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.LotteryUnitRate.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.LotteryUnitRate> entries_ = new pbc::RepeatedField<global::ReMastersLib.LotteryUnitRate>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.LotteryUnitRate> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LotteryUnitRateTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LotteryUnitRateTable other) {
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
    public void MergeFrom(LotteryUnitRateTable other) {
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
