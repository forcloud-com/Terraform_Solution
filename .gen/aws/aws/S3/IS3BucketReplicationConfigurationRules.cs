using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRules), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRules")]
    public interface IS3BucketReplicationConfigurationRules
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#destination S3Bucket#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesDestination\"}")]
        aws.S3.IS3BucketReplicationConfigurationRulesDestination Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#status S3Bucket#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#filter S3Bucket#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketReplicationConfigurationRulesFilter? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#id S3Bucket#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#prefix S3Bucket#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#priority S3Bucket#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Priority
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_selection_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#source_selection_criteria S3Bucket#source_selection_criteria}
        /// </remarks>
        [JsiiProperty(name: "sourceSelectionCriteria", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteria\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria? SourceSelectionCriteria
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRules), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRules")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketReplicationConfigurationRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#destination S3Bucket#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesDestination\"}")]
            public aws.S3.IS3BucketReplicationConfigurationRulesDestination Destination
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRulesDestination>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#status S3Bucket#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#filter S3Bucket#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesFilter\"}", isOptional: true)]
            public aws.S3.IS3BucketReplicationConfigurationRulesFilter? Filter
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRulesFilter?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#id S3Bucket#id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#prefix S3Bucket#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#priority S3Bucket#priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Priority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>source_selection_criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#source_selection_criteria S3Bucket#source_selection_criteria}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceSelectionCriteria", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteria\"}", isOptional: true)]
            public aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria? SourceSelectionCriteria
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria?>();
            }
        }
    }
}
