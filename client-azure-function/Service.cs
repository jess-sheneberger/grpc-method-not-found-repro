// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Service {

  /// <summary>Holder for reflection information generated from service.proto</summary>
  public static partial class ServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1zZXJ2aWNlLnByb3RvEgdzZXJ2aWNlIjgKA1JvdxIOCgZqb2JVUkwYASAB",
            "KAkSEwoLY29udGVudFR5cGUYAiABKAkSDAoEZGF0YRgDIAEoDCItCg1JbXBv",
            "cnRSZXF1ZXN0EhwKBnNvdXJjZRgBIAEoCzIMLnNlcnZpY2UuUm93Il0KDklt",
            "cG9ydFJlc3BvbnNlEh0KBWVycm9yGAEgASgLMg4uc2VydmljZS5FcnJvchIc",
            "CgZzb3VyY2UYAiABKAsyDC5zZXJ2aWNlLlJvdxIOCgZyZXN1bHQYAyABKAki",
            "JgoFRXJyb3ISDwoHbWVzc2FnZRgBIAEoCRIMCgRjb2RlGAIgASgDMkcKBklt",
            "cG9ydBI9CgZJbXBvcnQSFi5zZXJ2aWNlLkltcG9ydFJlcXVlc3QaFy5zZXJ2",
            "aWNlLkltcG9ydFJlc3BvbnNlKAEwAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Service.Row), global::Service.Row.Parser, new[]{ "JobURL", "ContentType", "Data" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Service.ImportRequest), global::Service.ImportRequest.Parser, new[]{ "Source" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Service.ImportResponse), global::Service.ImportResponse.Parser, new[]{ "Error", "Source", "Result" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Service.Error), global::Service.Error.Parser, new[]{ "Message", "Code" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Row : pb::IMessage<Row> {
    private static readonly pb::MessageParser<Row> _parser = new pb::MessageParser<Row>(() => new Row());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Row> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Service.ServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Row() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Row(Row other) : this() {
      jobURL_ = other.jobURL_;
      contentType_ = other.contentType_;
      data_ = other.data_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Row Clone() {
      return new Row(this);
    }

    /// <summary>Field number for the "jobURL" field.</summary>
    public const int JobURLFieldNumber = 1;
    private string jobURL_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JobURL {
      get { return jobURL_; }
      set {
        jobURL_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "contentType" field.</summary>
    public const int ContentTypeFieldNumber = 2;
    private string contentType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ContentType {
      get { return contentType_; }
      set {
        contentType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 3;
    private pb::ByteString data_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Row);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Row other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (JobURL != other.JobURL) return false;
      if (ContentType != other.ContentType) return false;
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (JobURL.Length != 0) hash ^= JobURL.GetHashCode();
      if (ContentType.Length != 0) hash ^= ContentType.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
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
      if (JobURL.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(JobURL);
      }
      if (ContentType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ContentType);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (JobURL.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JobURL);
      }
      if (ContentType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ContentType);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Row other) {
      if (other == null) {
        return;
      }
      if (other.JobURL.Length != 0) {
        JobURL = other.JobURL;
      }
      if (other.ContentType.Length != 0) {
        ContentType = other.ContentType;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
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
            JobURL = input.ReadString();
            break;
          }
          case 18: {
            ContentType = input.ReadString();
            break;
          }
          case 26: {
            Data = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ImportRequest : pb::IMessage<ImportRequest> {
    private static readonly pb::MessageParser<ImportRequest> _parser = new pb::MessageParser<ImportRequest>(() => new ImportRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ImportRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Service.ServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImportRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImportRequest(ImportRequest other) : this() {
      source_ = other.source_ != null ? other.source_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImportRequest Clone() {
      return new ImportRequest(this);
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 1;
    private global::Service.Row source_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Service.Row Source {
      get { return source_; }
      set {
        source_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ImportRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ImportRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Source, other.Source)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (source_ != null) hash ^= Source.GetHashCode();
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
      if (source_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Source);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (source_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Source);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ImportRequest other) {
      if (other == null) {
        return;
      }
      if (other.source_ != null) {
        if (source_ == null) {
          Source = new global::Service.Row();
        }
        Source.MergeFrom(other.Source);
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
            if (source_ == null) {
              Source = new global::Service.Row();
            }
            input.ReadMessage(Source);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ImportResponse : pb::IMessage<ImportResponse> {
    private static readonly pb::MessageParser<ImportResponse> _parser = new pb::MessageParser<ImportResponse>(() => new ImportResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ImportResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Service.ServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImportResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImportResponse(ImportResponse other) : this() {
      error_ = other.error_ != null ? other.error_.Clone() : null;
      source_ = other.source_ != null ? other.source_.Clone() : null;
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImportResponse Clone() {
      return new ImportResponse(this);
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 1;
    private global::Service.Error error_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Service.Error Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 2;
    private global::Service.Row source_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Service.Row Source {
      get { return source_; }
      set {
        source_ = value;
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 3;
    private string result_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Result {
      get { return result_; }
      set {
        result_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ImportResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ImportResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Error, other.Error)) return false;
      if (!object.Equals(Source, other.Source)) return false;
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (error_ != null) hash ^= Error.GetHashCode();
      if (source_ != null) hash ^= Source.GetHashCode();
      if (Result.Length != 0) hash ^= Result.GetHashCode();
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
      if (error_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Error);
      }
      if (source_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Source);
      }
      if (Result.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Result);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (error_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Error);
      }
      if (source_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Source);
      }
      if (Result.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Result);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ImportResponse other) {
      if (other == null) {
        return;
      }
      if (other.error_ != null) {
        if (error_ == null) {
          Error = new global::Service.Error();
        }
        Error.MergeFrom(other.Error);
      }
      if (other.source_ != null) {
        if (source_ == null) {
          Source = new global::Service.Row();
        }
        Source.MergeFrom(other.Source);
      }
      if (other.Result.Length != 0) {
        Result = other.Result;
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
            if (error_ == null) {
              Error = new global::Service.Error();
            }
            input.ReadMessage(Error);
            break;
          }
          case 18: {
            if (source_ == null) {
              Source = new global::Service.Row();
            }
            input.ReadMessage(Source);
            break;
          }
          case 26: {
            Result = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Error : pb::IMessage<Error> {
    private static readonly pb::MessageParser<Error> _parser = new pb::MessageParser<Error>(() => new Error());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Error> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Service.ServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Error() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Error(Error other) : this() {
      message_ = other.message_;
      code_ = other.code_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Error Clone() {
      return new Error(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 2;
    private long code_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Error);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Error other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if (Code != other.Code) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (Code != 0L) hash ^= Code.GetHashCode();
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
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (Code != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Code);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Code != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Code);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Error other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.Code != 0L) {
        Code = other.Code;
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
            Message = input.ReadString();
            break;
          }
          case 16: {
            Code = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
