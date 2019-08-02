// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/Monster.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/Monster.proto</summary>
  public static partial class MonsterReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/Monster.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonsterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm90by9Nb25zdGVyLnByb3RvEgxSZU1hc3RlcnNMaWIivgEKB01vbnN0",
            "ZXISEgoKdHJhaW5lcl9pZBgBIAEoBBISCgptb25zdGVyX2lkGAIgASgNEhQK",
            "DHN5bmNfbW92ZV9pZBgDIAEoDRIRCglocF92YWx1ZXMYBCADKA0SEgoKYXRr",
            "X3ZhbHVlcxgFIAMoDRISCgpkZWZfdmFsdWVzGAYgAygNEhIKCnNwYV92YWx1",
            "ZXMYByADKA0SEgoKc3BkX3ZhbHVlcxgIIAMoDRISCgpzcGVfdmFsdWVzGAkg",
            "AygNIjYKDE1vbnN0ZXJUYWJsZRImCgdlbnRyaWVzGAEgAygLMhUuUmVNYXN0",
            "ZXJzTGliLk1vbnN0ZXJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.Monster), global::ReMastersLib.Monster.Parser, new[]{ "TrainerId", "MonsterId", "SyncMoveId", "HpValues", "AtkValues", "DefValues", "SpaValues", "SpdValues", "SpeValues" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.MonsterTable), global::ReMastersLib.MonsterTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Monster : pb::IMessage<Monster> {
    private static readonly pb::MessageParser<Monster> _parser = new pb::MessageParser<Monster>(() => new Monster());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Monster> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.MonsterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Monster() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Monster(Monster other) : this() {
      trainerId_ = other.trainerId_;
      monsterId_ = other.monsterId_;
      syncMoveId_ = other.syncMoveId_;
      hpValues_ = other.hpValues_.Clone();
      atkValues_ = other.atkValues_.Clone();
      defValues_ = other.defValues_.Clone();
      spaValues_ = other.spaValues_.Clone();
      spdValues_ = other.spdValues_.Clone();
      speValues_ = other.speValues_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Monster Clone() {
      return new Monster(this);
    }

    /// <summary>Field number for the "trainer_id" field.</summary>
    public const int TrainerIdFieldNumber = 1;
    private ulong trainerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong TrainerId {
      get { return trainerId_; }
      set {
        trainerId_ = value;
      }
    }

    /// <summary>Field number for the "monster_id" field.</summary>
    public const int MonsterIdFieldNumber = 2;
    private uint monsterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint MonsterId {
      get { return monsterId_; }
      set {
        monsterId_ = value;
      }
    }

    /// <summary>Field number for the "sync_move_id" field.</summary>
    public const int SyncMoveIdFieldNumber = 3;
    private uint syncMoveId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint SyncMoveId {
      get { return syncMoveId_; }
      set {
        syncMoveId_ = value;
      }
    }

    /// <summary>Field number for the "hp_values" field.</summary>
    public const int HpValuesFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_hpValues_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> hpValues_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> HpValues {
      get { return hpValues_; }
    }

    /// <summary>Field number for the "atk_values" field.</summary>
    public const int AtkValuesFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_atkValues_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> atkValues_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> AtkValues {
      get { return atkValues_; }
    }

    /// <summary>Field number for the "def_values" field.</summary>
    public const int DefValuesFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_defValues_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> defValues_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> DefValues {
      get { return defValues_; }
    }

    /// <summary>Field number for the "spa_values" field.</summary>
    public const int SpaValuesFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_spaValues_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> spaValues_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> SpaValues {
      get { return spaValues_; }
    }

    /// <summary>Field number for the "spd_values" field.</summary>
    public const int SpdValuesFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_spdValues_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> spdValues_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> SpdValues {
      get { return spdValues_; }
    }

    /// <summary>Field number for the "spe_values" field.</summary>
    public const int SpeValuesFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_speValues_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> speValues_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> SpeValues {
      get { return speValues_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Monster);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Monster other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TrainerId != other.TrainerId) return false;
      if (MonsterId != other.MonsterId) return false;
      if (SyncMoveId != other.SyncMoveId) return false;
      if(!hpValues_.Equals(other.hpValues_)) return false;
      if(!atkValues_.Equals(other.atkValues_)) return false;
      if(!defValues_.Equals(other.defValues_)) return false;
      if(!spaValues_.Equals(other.spaValues_)) return false;
      if(!spdValues_.Equals(other.spdValues_)) return false;
      if(!speValues_.Equals(other.speValues_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TrainerId != 0UL) hash ^= TrainerId.GetHashCode();
      if (MonsterId != 0) hash ^= MonsterId.GetHashCode();
      if (SyncMoveId != 0) hash ^= SyncMoveId.GetHashCode();
      hash ^= hpValues_.GetHashCode();
      hash ^= atkValues_.GetHashCode();
      hash ^= defValues_.GetHashCode();
      hash ^= spaValues_.GetHashCode();
      hash ^= spdValues_.GetHashCode();
      hash ^= speValues_.GetHashCode();
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
      if (TrainerId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(TrainerId);
      }
      if (MonsterId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MonsterId);
      }
      if (SyncMoveId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SyncMoveId);
      }
      hpValues_.WriteTo(output, _repeated_hpValues_codec);
      atkValues_.WriteTo(output, _repeated_atkValues_codec);
      defValues_.WriteTo(output, _repeated_defValues_codec);
      spaValues_.WriteTo(output, _repeated_spaValues_codec);
      spdValues_.WriteTo(output, _repeated_spdValues_codec);
      speValues_.WriteTo(output, _repeated_speValues_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TrainerId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TrainerId);
      }
      if (MonsterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterId);
      }
      if (SyncMoveId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SyncMoveId);
      }
      size += hpValues_.CalculateSize(_repeated_hpValues_codec);
      size += atkValues_.CalculateSize(_repeated_atkValues_codec);
      size += defValues_.CalculateSize(_repeated_defValues_codec);
      size += spaValues_.CalculateSize(_repeated_spaValues_codec);
      size += spdValues_.CalculateSize(_repeated_spdValues_codec);
      size += speValues_.CalculateSize(_repeated_speValues_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Monster other) {
      if (other == null) {
        return;
      }
      if (other.TrainerId != 0UL) {
        TrainerId = other.TrainerId;
      }
      if (other.MonsterId != 0) {
        MonsterId = other.MonsterId;
      }
      if (other.SyncMoveId != 0) {
        SyncMoveId = other.SyncMoveId;
      }
      hpValues_.Add(other.hpValues_);
      atkValues_.Add(other.atkValues_);
      defValues_.Add(other.defValues_);
      spaValues_.Add(other.spaValues_);
      spdValues_.Add(other.spdValues_);
      speValues_.Add(other.speValues_);
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
            TrainerId = input.ReadUInt64();
            break;
          }
          case 16: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 24: {
            SyncMoveId = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            hpValues_.AddEntriesFrom(input, _repeated_hpValues_codec);
            break;
          }
          case 42:
          case 40: {
            atkValues_.AddEntriesFrom(input, _repeated_atkValues_codec);
            break;
          }
          case 50:
          case 48: {
            defValues_.AddEntriesFrom(input, _repeated_defValues_codec);
            break;
          }
          case 58:
          case 56: {
            spaValues_.AddEntriesFrom(input, _repeated_spaValues_codec);
            break;
          }
          case 66:
          case 64: {
            spdValues_.AddEntriesFrom(input, _repeated_spdValues_codec);
            break;
          }
          case 74:
          case 72: {
            speValues_.AddEntriesFrom(input, _repeated_speValues_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class MonsterTable : pb::IMessage<MonsterTable> {
    private static readonly pb::MessageParser<MonsterTable> _parser = new pb::MessageParser<MonsterTable>(() => new MonsterTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MonsterTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.MonsterReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterTable(MonsterTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterTable Clone() {
      return new MonsterTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.Monster> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.Monster.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.Monster> entries_ = new pbc::RepeatedField<global::ReMastersLib.Monster>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.Monster> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MonsterTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MonsterTable other) {
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
    public void MergeFrom(MonsterTable other) {
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
