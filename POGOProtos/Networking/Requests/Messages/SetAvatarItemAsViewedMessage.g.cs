// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Requests/Messages/SetAvatarItemAsViewedMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/SetAvatarItemAsViewedMessage.proto</summary>
  public static partial class SetAvatarItemAsViewedMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/SetAvatarItemAsViewedMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetAvatarItemAsViewedMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkpQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvU2V0",
            "QXZhdGFySXRlbUFzVmlld2VkTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5O",
            "ZXR3b3JraW5nLlJlcXVlc3RzLk1lc3NhZ2VzIjoKHFNldEF2YXRhckl0ZW1B",
            "c1ZpZXdlZE1lc3NhZ2USGgoSYXZhdGFyX3RlbXBsYXRlX2lkGAEgAygJYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.SetAvatarItemAsViewedMessage), global::POGOProtos.Networking.Requests.Messages.SetAvatarItemAsViewedMessage.Parser, new[]{ "AvatarTemplateId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SetAvatarItemAsViewedMessage : pb::IMessage<SetAvatarItemAsViewedMessage> {
    private static readonly pb::MessageParser<SetAvatarItemAsViewedMessage> _parser = new pb::MessageParser<SetAvatarItemAsViewedMessage>(() => new SetAvatarItemAsViewedMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetAvatarItemAsViewedMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.SetAvatarItemAsViewedMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetAvatarItemAsViewedMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetAvatarItemAsViewedMessage(SetAvatarItemAsViewedMessage other) : this() {
      avatarTemplateId_ = other.avatarTemplateId_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetAvatarItemAsViewedMessage Clone() {
      return new SetAvatarItemAsViewedMessage(this);
    }

    /// <summary>Field number for the "avatar_template_id" field.</summary>
    public const int AvatarTemplateIdFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_avatarTemplateId_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> avatarTemplateId_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> AvatarTemplateId {
      get { return avatarTemplateId_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetAvatarItemAsViewedMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetAvatarItemAsViewedMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!avatarTemplateId_.Equals(other.avatarTemplateId_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= avatarTemplateId_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      avatarTemplateId_.WriteTo(output, _repeated_avatarTemplateId_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += avatarTemplateId_.CalculateSize(_repeated_avatarTemplateId_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetAvatarItemAsViewedMessage other) {
      if (other == null) {
        return;
      }
      avatarTemplateId_.Add(other.avatarTemplateId_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            avatarTemplateId_.AddEntriesFrom(input, _repeated_avatarTemplateId_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code