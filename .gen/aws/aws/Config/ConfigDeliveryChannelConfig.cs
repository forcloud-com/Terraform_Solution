using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    #pragma warning disable CS8618

    /// <summary>AWS Config.</summary>
    [JsiiByValue(fqn: "aws.config.ConfigDeliveryChannelConfig")]
    public class ConfigDeliveryChannelConfig : aws.Config.IConfigDeliveryChannelConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#s3_bucket_name ConfigDeliveryChannel#s3_bucket_name}.</summary>
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string S3BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#name ConfigDeliveryChannel#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#s3_key_prefix ConfigDeliveryChannel#s3_key_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3KeyPrefix
        {
            get;
            set;
        }

        /// <summary>snapshot_delivery_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#snapshot_delivery_properties ConfigDeliveryChannel#snapshot_delivery_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotDeliveryProperties", typeJson: "{\"fqn\":\"aws.config.ConfigDeliveryChannelSnapshotDeliveryProperties\"}", isOptional: true)]
        public aws.Config.IConfigDeliveryChannelSnapshotDeliveryProperties? SnapshotDeliveryProperties
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#sns_topic_arn ConfigDeliveryChannel#sns_topic_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnsTopicArn
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
