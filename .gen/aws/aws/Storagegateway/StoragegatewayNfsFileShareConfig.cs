using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    #pragma warning disable CS8618

    /// <summary>AWS Storage Gateway.</summary>
    [JsiiByValue(fqn: "aws.storagegateway.StoragegatewayNfsFileShareConfig")]
    public class StoragegatewayNfsFileShareConfig : aws.Storagegateway.IStoragegatewayNfsFileShareConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#client_list StoragegatewayNfsFileShare#client_list}.</summary>
        [JsiiProperty(name: "clientList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ClientList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#gateway_arn StoragegatewayNfsFileShare#gateway_arn}.</summary>
        [JsiiProperty(name: "gatewayArn", typeJson: "{\"primitive\":\"string\"}")]
        public string GatewayArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#location_arn StoragegatewayNfsFileShare#location_arn}.</summary>
        [JsiiProperty(name: "locationArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LocationArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#role_arn StoragegatewayNfsFileShare#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#default_storage_class StoragegatewayNfsFileShare#default_storage_class}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultStorageClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultStorageClass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#guess_mime_type_enabled StoragegatewayNfsFileShare#guess_mime_type_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "guessMimeTypeEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? GuessMimeTypeEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#kms_encrypted StoragegatewayNfsFileShare#kms_encrypted}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsEncrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? KmsEncrypted
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#kms_key_arn StoragegatewayNfsFileShare#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        /// <summary>nfs_file_share_defaults block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#nfs_file_share_defaults StoragegatewayNfsFileShare#nfs_file_share_defaults}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nfsFileShareDefaults", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayNfsFileShareNfsFileShareDefaults\"}", isOptional: true)]
        public aws.Storagegateway.IStoragegatewayNfsFileShareNfsFileShareDefaults? NfsFileShareDefaults
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#object_acl StoragegatewayNfsFileShare#object_acl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectAcl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectAcl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#read_only StoragegatewayNfsFileShare#read_only}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ReadOnly
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#requester_pays StoragegatewayNfsFileShare#requester_pays}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requesterPays", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequesterPays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#squash StoragegatewayNfsFileShare#squash}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "squash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Squash
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#tags StoragegatewayNfsFileShare#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_nfs_file_share#timeouts StoragegatewayNfsFileShare#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayNfsFileShareTimeouts\"}", isOptional: true)]
        public aws.Storagegateway.IStoragegatewayNfsFileShareTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
