// Generated by the protocol buffer compiler.  DO NOT EDIT!
// NO CHECKED-IN PROTOBUF GENCODE
// source: PasswordManagerService.proto
// Protobuf Java Version: 4.28.2

package grpc;

public interface UserNameAndPswdOrBuilder extends
    // @@protoc_insertion_point(interface_extends:grpc.UserNameAndPswd)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <code>string username = 1;</code>
   * @return The username.
   */
  java.lang.String getUsername();
  /**
   * <code>string username = 1;</code>
   * @return The bytes for username.
   */
  com.google.protobuf.ByteString
      getUsernameBytes();

  /**
   * <code>string encryptedPassword = 2;</code>
   * @return The encryptedPassword.
   */
  java.lang.String getEncryptedPassword();
  /**
   * <code>string encryptedPassword = 2;</code>
   * @return The bytes for encryptedPassword.
   */
  com.google.protobuf.ByteString
      getEncryptedPasswordBytes();
}
