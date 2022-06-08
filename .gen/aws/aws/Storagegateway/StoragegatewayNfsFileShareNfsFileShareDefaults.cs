using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    [JsiiByValue(fqn: "aws.storagegateway.StoragegatewayNfsFileShareNfsFileShareDefaults")]
    public class StoragegatewayNfsFileShareNfsFileShareDefaults : aws.Storagegateway.IStoragegatewayNfsFileShareNfsFileShareDefaults
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#directory_mode StoragegatewayNfsFileShare#directory_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "directoryMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DirectoryMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#file_mode StoragegatewayNfsFileShare#file_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#group_id StoragegatewayNfsFileShare#group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#owner_id StoragegatewayNfsFileShare#owner_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OwnerId
        {
            get;
            set;
        }
    }
}
