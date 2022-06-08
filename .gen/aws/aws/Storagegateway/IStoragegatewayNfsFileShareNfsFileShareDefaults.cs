using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    [JsiiInterface(nativeType: typeof(IStoragegatewayNfsFileShareNfsFileShareDefaults), fullyQualifiedName: "aws.storagegateway.StoragegatewayNfsFileShareNfsFileShareDefaults")]
    public interface IStoragegatewayNfsFileShareNfsFileShareDefaults
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#directory_mode StoragegatewayNfsFileShare#directory_mode}.</summary>
        [JsiiProperty(name: "directoryMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DirectoryMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#file_mode StoragegatewayNfsFileShare#file_mode}.</summary>
        [JsiiProperty(name: "fileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#group_id StoragegatewayNfsFileShare#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#owner_id StoragegatewayNfsFileShare#owner_id}.</summary>
        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OwnerId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStoragegatewayNfsFileShareNfsFileShareDefaults), fullyQualifiedName: "aws.storagegateway.StoragegatewayNfsFileShareNfsFileShareDefaults")]
        internal sealed class _Proxy : DeputyBase, aws.Storagegateway.IStoragegatewayNfsFileShareNfsFileShareDefaults
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#directory_mode StoragegatewayNfsFileShare#directory_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "directoryMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DirectoryMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#file_mode StoragegatewayNfsFileShare#file_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#group_id StoragegatewayNfsFileShare#group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GroupId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#owner_id StoragegatewayNfsFileShare#owner_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OwnerId
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
