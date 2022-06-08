using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    #pragma warning disable CS8618

    /// <summary>AWS Storage Gateway.</summary>
    [JsiiByValue(fqn: "aws.storagegateway.StoragegatewayCachedIscsiVolumeConfig")]
    public class StoragegatewayCachedIscsiVolumeConfig : aws.Storagegateway.IStoragegatewayCachedIscsiVolumeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_cached_iscsi_volume#gateway_arn StoragegatewayCachedIscsiVolume#gateway_arn}.</summary>
        [JsiiProperty(name: "gatewayArn", typeJson: "{\"primitive\":\"string\"}")]
        public string GatewayArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_cached_iscsi_volume#network_interface_id StoragegatewayCachedIscsiVolume#network_interface_id}.</summary>
        [JsiiProperty(name: "networkInterfaceId", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkInterfaceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_cached_iscsi_volume#target_name StoragegatewayCachedIscsiVolume#target_name}.</summary>
        [JsiiProperty(name: "targetName", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_cached_iscsi_volume#volume_size_in_bytes StoragegatewayCachedIscsiVolume#volume_size_in_bytes}.</summary>
        [JsiiProperty(name: "volumeSizeInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public double VolumeSizeInBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_cached_iscsi_volume#snapshot_id StoragegatewayCachedIscsiVolume#snapshot_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnapshotId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_cached_iscsi_volume#source_volume_arn StoragegatewayCachedIscsiVolume#source_volume_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceVolumeArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceVolumeArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_cached_iscsi_volume#tags StoragegatewayCachedIscsiVolume#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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
