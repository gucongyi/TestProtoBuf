// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StoreRequest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protobuf {

  /// <summary>Holder for reflection information generated from StoreRequest.proto</summary>
  public static partial class StoreRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for StoreRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StoreRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJTdG9yZVJlcXVlc3QucHJvdG8SCHByb3RvYnVmIkkKDFN0b3JlUmVxdWVz",
            "dBIMCgRuYW1lGAEgASgJEgsKA251bRgCIAEoBRIOCgZyZXN1bHQYAyABKAUS",
            "DgoGbXlMaXN0GAQgAygJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protobuf.StoreRequest), global::Protobuf.StoreRequest.Parser, new[]{ "Name", "Num", "Result", "MyList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StoreRequest : pb::IMessage<StoreRequest> {
    private static readonly pb::MessageParser<StoreRequest> _parser = new pb::MessageParser<StoreRequest>(() => new StoreRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StoreRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protobuf.StoreRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoreRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoreRequest(StoreRequest other) : this() {
      name_ = other.name_;
      num_ = other.num_;
      result_ = other.result_;
      myList_ = other.myList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StoreRequest Clone() {
      return new StoreRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "num" field.</summary>
    public const int NumFieldNumber = 2;
    private int num_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Num {
      get { return num_; }
      set {
        num_ = value;
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 3;
    private int result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "myList" field.</summary>
    public const int MyListFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_myList_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> myList_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> MyList {
      get { return myList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StoreRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StoreRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Num != other.Num) return false;
      if (Result != other.Result) return false;
      if(!myList_.Equals(other.myList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Num != 0) hash ^= Num.GetHashCode();
      if (Result != 0) hash ^= Result.GetHashCode();
      hash ^= myList_.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Num != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Num);
      }
      if (Result != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Result);
      }
      myList_.WriteTo(output, _repeated_myList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Num != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Num);
      }
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Result);
      }
      size += myList_.CalculateSize(_repeated_myList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StoreRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Num != 0) {
        Num = other.Num;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      myList_.Add(other.myList_);
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            Num = input.ReadInt32();
            break;
          }
          case 24: {
            Result = input.ReadInt32();
            break;
          }
          case 34: {
            myList_.AddEntriesFrom(input, _repeated_myList_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
