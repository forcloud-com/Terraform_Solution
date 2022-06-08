using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    /// <summary>AWS Config.</summary>
    [JsiiInterface(nativeType: typeof(IConfigDeliveryChannelConfig), fullyQualifiedName: "aws.config.ConfigDeliveryChannelConfig")]
    public interface IConfigDeliveryChannelConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#s3_bucket_name ConfigDeliveryChannel#s3_bucket_name}.</summary>
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        string S3BucketName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#name ConfigDeliveryChannel#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#s3_key_prefix ConfigDeliveryChannel#s3_key_prefix}.</summary>
        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3KeyPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>snapshot_delivery_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#snapshot_delivery_properties ConfigDeliveryChannel#snapshot_delivery_properties}
        /// </remarks>
        [JsiiProperty(name: "snapshotDeliveryProperties", typeJson: "{\"fqn\":\"aws.config.ConfigDeliveryChannelSnapshotDeliveryProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Config.IConfigDeliveryChannelSnapshotDeliveryProperties? SnapshotDeliveryProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#sns_topic_arn ConfigDeliveryChannel#sns_topic_arn}.</summary>
        [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SnsTopicArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Config.</summary>
        [JsiiTypeProxy(nativeType: typeof(IConfigDeliveryChannelConfig), fullyQualifiedName: "aws.config.ConfigDeliveryChannelConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Config.IConfigDeliveryChannelConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#s3_bucket_name ConfigDeliveryChannel#s3_bucket_name}.</summary>
            [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string S3BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#name ConfigDeliveryChannel#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#s3_key_prefix ConfigDeliveryChannel#s3_key_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3KeyPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>snapshot_delivery_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#snapshot_delivery_properties ConfigDeliveryChannel#snapshot_delivery_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snapshotDeliveryProperties", typeJson: "{\"fqn\":\"aws.config.ConfigDeliveryChannelSnapshotDeliveryProperties\"}", isOptional: true)]
            public aws.Config.IConfigDeliveryChannelSnapshotDeliveryProperties? SnapshotDeliveryProperties
            {
                get => GetInstanceProperty<aws.Config.IConfigDeliveryChannelSnapshotDeliveryProperties?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel#sns_topic_arn ConfigDeliveryChannel#sns_topic_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SnsTopicArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
