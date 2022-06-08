using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    /// <summary>AWS Simple Storage Service.</summary>
    [JsiiByValue(fqn: "aws.s3.S3BucketAnalyticsConfigurationConfig")]
    public class S3BucketAnalyticsConfigurationConfig : aws.S3.IS3BucketAnalyticsConfigurationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#bucket S3BucketAnalyticsConfiguration#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#name S3BucketAnalyticsConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#filter S3BucketAnalyticsConfiguration#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationFilter\"}", isOptional: true)]
        public aws.S3.IS3BucketAnalyticsConfigurationFilter? Filter
        {
            get;
            set;
        }

        /// <summary>storage_class_analysis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_analytics_configuration#storage_class_analysis S3BucketAnalyticsConfiguration#storage_class_analysis}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageClassAnalysis", typeJson: "{\"fqn\":\"aws.s3.S3BucketAnalyticsConfigurationStorageClassAnalysis\"}", isOptional: true)]
        public aws.S3.IS3BucketAnalyticsConfigurationStorageClassAnalysis? StorageClassAnalysis
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
