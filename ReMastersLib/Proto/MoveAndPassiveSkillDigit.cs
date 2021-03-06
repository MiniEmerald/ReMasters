// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/MoveAndPassiveSkillDigit.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/MoveAndPassiveSkillDigit.proto</summary>
  public static partial class MoveAndPassiveSkillDigitReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/MoveAndPassiveSkillDigit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MoveAndPassiveSkillDigitReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRQcm90by9Nb3ZlQW5kUGFzc2l2ZVNraWxsRGlnaXQucHJvdG8SDFJlTWFz",
            "dGVyc0xpYiLHAQoYTW92ZUFuZFBhc3NpdmVTa2lsbERpZ2l0EgoKAmlkGAEg",
            "ASgDEg4KBnBhcmFtMRgCIAEoAxIOCgZwYXJhbTIYAyABKAMSDgoGcGFyYW0z",
            "GAQgASgDEg4KBnBhcmFtNBgFIAEoAxIOCgZwYXJhbTUYBiABKAMSDgoGcGFy",
            "YW02GAcgASgDEg4KBnBhcmFtNxgIIAEoAxIOCgZwYXJhbTgYCSABKAMSDgoG",
            "cGFyYW05GAogASgDEg8KB3BhcmFtMTAYCyABKAMiWAodTW92ZUFuZFBhc3Np",
            "dmVTa2lsbERpZ2l0VGFibGUSNwoHZW50cmllcxgBIAMoCzImLlJlTWFzdGVy",
            "c0xpYi5Nb3ZlQW5kUGFzc2l2ZVNraWxsRGlnaXRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.MoveAndPassiveSkillDigit), global::ReMastersLib.MoveAndPassiveSkillDigit.Parser, new[]{ "Id", "Param1", "Param2", "Param3", "Param4", "Param5", "Param6", "Param7", "Param8", "Param9", "Param10" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.MoveAndPassiveSkillDigitTable), global::ReMastersLib.MoveAndPassiveSkillDigitTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MoveAndPassiveSkillDigit : pb::IMessage<MoveAndPassiveSkillDigit> {
    private static readonly pb::MessageParser<MoveAndPassiveSkillDigit> _parser = new pb::MessageParser<MoveAndPassiveSkillDigit>(() => new MoveAndPassiveSkillDigit());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MoveAndPassiveSkillDigit> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.MoveAndPassiveSkillDigitReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MoveAndPassiveSkillDigit() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MoveAndPassiveSkillDigit(MoveAndPassiveSkillDigit other) : this() {
      id_ = other.id_;
      param1_ = other.param1_;
      param2_ = other.param2_;
      param3_ = other.param3_;
      param4_ = other.param4_;
      param5_ = other.param5_;
      param6_ = other.param6_;
      param7_ = other.param7_;
      param8_ = other.param8_;
      param9_ = other.param9_;
      param10_ = other.param10_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MoveAndPassiveSkillDigit Clone() {
      return new MoveAndPassiveSkillDigit(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private long id_;
    /// <summary>
    /// Move id or Passive id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "param1" field.</summary>
    public const int Param1FieldNumber = 2;
    private long param1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Param1 {
      get { return param1_; }
      set {
        param1_ = value;
      }
    }

    /// <summary>Field number for the "param2" field.</summary>
    public const int Param2FieldNumber = 3;
    private long param2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Param2 {
      get { return param2_; }
      set {
        param2_ = value;
      }
    }

    /// <summary>Field number for the "param3" field.</summary>
    public const int Param3FieldNumber = 4;
    private long param3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Param3 {
      get { return param3_; }
      set {
        param3_ = value;
      }
    }

    /// <summary>Field number for the "param4" field.</summary>
    public const int Param4FieldNumber = 5;
    private long param4_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Param4 {
      get { return param4_; }
      set {
        param4_ = value;
      }
    }

    /// <summary>Field number for the "param5" field.</summary>
    public const int Param5FieldNumber = 6;
    private long param5_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Param5 {
      get { return param5_; }
      set {
        param5_ = value;
      }
    }

    /// <summary>Field number for the "param6" field.</summary>
    public const int Param6FieldNumber = 7;
    private long param6_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Param6 {
      get { return param6_; }
      set {
        param6_ = value;
      }
    }

    /// <summary>Field number for the "param7" field.</summary>
    public const int Param7FieldNumber = 8;
    private long param7_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Param7 {
      get { return param7_; }
      set {
        param7_ = value;
      }
    }

    /// <summary>Field number for the "param8" field.</summary>
    public const int Param8FieldNumber = 9;
    private long param8_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Param8 {
      get { return param8_; }
      set {
        param8_ = value;
      }
    }

    /// <summary>Field number for the "param9" field.</summary>
    public const int Param9FieldNumber = 10;
    private long param9_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Param9 {
      get { return param9_; }
      set {
        param9_ = value;
      }
    }

    /// <summary>Field number for the "param10" field.</summary>
    public const int Param10FieldNumber = 11;
    private long param10_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Param10 {
      get { return param10_; }
      set {
        param10_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MoveAndPassiveSkillDigit);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MoveAndPassiveSkillDigit other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Param1 != other.Param1) return false;
      if (Param2 != other.Param2) return false;
      if (Param3 != other.Param3) return false;
      if (Param4 != other.Param4) return false;
      if (Param5 != other.Param5) return false;
      if (Param6 != other.Param6) return false;
      if (Param7 != other.Param7) return false;
      if (Param8 != other.Param8) return false;
      if (Param9 != other.Param9) return false;
      if (Param10 != other.Param10) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (Param1 != 0L) hash ^= Param1.GetHashCode();
      if (Param2 != 0L) hash ^= Param2.GetHashCode();
      if (Param3 != 0L) hash ^= Param3.GetHashCode();
      if (Param4 != 0L) hash ^= Param4.GetHashCode();
      if (Param5 != 0L) hash ^= Param5.GetHashCode();
      if (Param6 != 0L) hash ^= Param6.GetHashCode();
      if (Param7 != 0L) hash ^= Param7.GetHashCode();
      if (Param8 != 0L) hash ^= Param8.GetHashCode();
      if (Param9 != 0L) hash ^= Param9.GetHashCode();
      if (Param10 != 0L) hash ^= Param10.GetHashCode();
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
      if (Id != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Id);
      }
      if (Param1 != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Param1);
      }
      if (Param2 != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Param2);
      }
      if (Param3 != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Param3);
      }
      if (Param4 != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(Param4);
      }
      if (Param5 != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(Param5);
      }
      if (Param6 != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(Param6);
      }
      if (Param7 != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(Param7);
      }
      if (Param8 != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(Param8);
      }
      if (Param9 != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(Param9);
      }
      if (Param10 != 0L) {
        output.WriteRawTag(88);
        output.WriteInt64(Param10);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (Param1 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Param1);
      }
      if (Param2 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Param2);
      }
      if (Param3 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Param3);
      }
      if (Param4 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Param4);
      }
      if (Param5 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Param5);
      }
      if (Param6 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Param6);
      }
      if (Param7 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Param7);
      }
      if (Param8 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Param8);
      }
      if (Param9 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Param9);
      }
      if (Param10 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Param10);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MoveAndPassiveSkillDigit other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.Param1 != 0L) {
        Param1 = other.Param1;
      }
      if (other.Param2 != 0L) {
        Param2 = other.Param2;
      }
      if (other.Param3 != 0L) {
        Param3 = other.Param3;
      }
      if (other.Param4 != 0L) {
        Param4 = other.Param4;
      }
      if (other.Param5 != 0L) {
        Param5 = other.Param5;
      }
      if (other.Param6 != 0L) {
        Param6 = other.Param6;
      }
      if (other.Param7 != 0L) {
        Param7 = other.Param7;
      }
      if (other.Param8 != 0L) {
        Param8 = other.Param8;
      }
      if (other.Param9 != 0L) {
        Param9 = other.Param9;
      }
      if (other.Param10 != 0L) {
        Param10 = other.Param10;
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
            Id = input.ReadInt64();
            break;
          }
          case 16: {
            Param1 = input.ReadInt64();
            break;
          }
          case 24: {
            Param2 = input.ReadInt64();
            break;
          }
          case 32: {
            Param3 = input.ReadInt64();
            break;
          }
          case 40: {
            Param4 = input.ReadInt64();
            break;
          }
          case 48: {
            Param5 = input.ReadInt64();
            break;
          }
          case 56: {
            Param6 = input.ReadInt64();
            break;
          }
          case 64: {
            Param7 = input.ReadInt64();
            break;
          }
          case 72: {
            Param8 = input.ReadInt64();
            break;
          }
          case 80: {
            Param9 = input.ReadInt64();
            break;
          }
          case 88: {
            Param10 = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class MoveAndPassiveSkillDigitTable : pb::IMessage<MoveAndPassiveSkillDigitTable> {
    private static readonly pb::MessageParser<MoveAndPassiveSkillDigitTable> _parser = new pb::MessageParser<MoveAndPassiveSkillDigitTable>(() => new MoveAndPassiveSkillDigitTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MoveAndPassiveSkillDigitTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.MoveAndPassiveSkillDigitReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MoveAndPassiveSkillDigitTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MoveAndPassiveSkillDigitTable(MoveAndPassiveSkillDigitTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MoveAndPassiveSkillDigitTable Clone() {
      return new MoveAndPassiveSkillDigitTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.MoveAndPassiveSkillDigit> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.MoveAndPassiveSkillDigit.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.MoveAndPassiveSkillDigit> entries_ = new pbc::RepeatedField<global::ReMastersLib.MoveAndPassiveSkillDigit>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.MoveAndPassiveSkillDigit> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MoveAndPassiveSkillDigitTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MoveAndPassiveSkillDigitTable other) {
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
    public void MergeFrom(MoveAndPassiveSkillDigitTable other) {
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
