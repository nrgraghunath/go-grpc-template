// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: music.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Server {

  /// <summary>Holder for reflection information generated from music.proto</summary>
  public static partial class MusicReflection {

    #region Descriptor
    /// <summary>File descriptor for music.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MusicReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgttdXNpYy5wcm90bxIFbXVzaWMiHgoMQWxidW1SZXF1ZXN0Eg4KBmFydGlz",
            "dBgBIAEoCSI/CgxBbGJ1bURldGFpbHMSEgoKYWxidW1fbmFtZRgBIAEoCRIN",
            "CgVsYWJlbBgCIAEoCRIMCgR5ZWFyGAMgASgJMksKDE11c2ljU2VydmljZRI7",
            "Cg9HZXRBbGJ1bURldGFpbHMSEy5tdXNpYy5BbGJ1bVJlcXVlc3QaEy5tdXNp",
            "Yy5BbGJ1bURldGFpbHNCCaoCBlNlcnZlcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Server.AlbumRequest), global::Server.AlbumRequest.Parser, new[]{ "Artist" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Server.AlbumDetails), global::Server.AlbumDetails.Parser, new[]{ "AlbumName", "Label", "Year" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message containing the user's name.
  /// </summary>
  public sealed partial class AlbumRequest : pb::IMessage<AlbumRequest> {
    private static readonly pb::MessageParser<AlbumRequest> _parser = new pb::MessageParser<AlbumRequest>(() => new AlbumRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AlbumRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Server.MusicReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlbumRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlbumRequest(AlbumRequest other) : this() {
      artist_ = other.artist_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlbumRequest Clone() {
      return new AlbumRequest(this);
    }

    /// <summary>Field number for the "artist" field.</summary>
    public const int ArtistFieldNumber = 1;
    private string artist_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Artist {
      get { return artist_; }
      set {
        artist_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AlbumRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AlbumRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Artist != other.Artist) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Artist.Length != 0) hash ^= Artist.GetHashCode();
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
      if (Artist.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Artist);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Artist.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Artist);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AlbumRequest other) {
      if (other == null) {
        return;
      }
      if (other.Artist.Length != 0) {
        Artist = other.Artist;
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
            Artist = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The response message containing the albums.
  /// </summary>
  public sealed partial class AlbumDetails : pb::IMessage<AlbumDetails> {
    private static readonly pb::MessageParser<AlbumDetails> _parser = new pb::MessageParser<AlbumDetails>(() => new AlbumDetails());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AlbumDetails> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Server.MusicReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlbumDetails() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlbumDetails(AlbumDetails other) : this() {
      albumName_ = other.albumName_;
      label_ = other.label_;
      year_ = other.year_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AlbumDetails Clone() {
      return new AlbumDetails(this);
    }

    /// <summary>Field number for the "album_name" field.</summary>
    public const int AlbumNameFieldNumber = 1;
    private string albumName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AlbumName {
      get { return albumName_; }
      set {
        albumName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 2;
    private string label_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "year" field.</summary>
    public const int YearFieldNumber = 3;
    private string year_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Year {
      get { return year_; }
      set {
        year_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AlbumDetails);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AlbumDetails other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AlbumName != other.AlbumName) return false;
      if (Label != other.Label) return false;
      if (Year != other.Year) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AlbumName.Length != 0) hash ^= AlbumName.GetHashCode();
      if (Label.Length != 0) hash ^= Label.GetHashCode();
      if (Year.Length != 0) hash ^= Year.GetHashCode();
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
      if (AlbumName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AlbumName);
      }
      if (Label.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Label);
      }
      if (Year.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Year);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AlbumName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AlbumName);
      }
      if (Label.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (Year.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Year);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AlbumDetails other) {
      if (other == null) {
        return;
      }
      if (other.AlbumName.Length != 0) {
        AlbumName = other.AlbumName;
      }
      if (other.Label.Length != 0) {
        Label = other.Label;
      }
      if (other.Year.Length != 0) {
        Year = other.Year;
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
            AlbumName = input.ReadString();
            break;
          }
          case 18: {
            Label = input.ReadString();
            break;
          }
          case 26: {
            Year = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
