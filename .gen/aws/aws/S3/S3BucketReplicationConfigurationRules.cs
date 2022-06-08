using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRules")]
    public class S3BucketReplicationConfigurationRules : aws.S3.IS3BucketReplicationConfigurationRules
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#destination S3Bucket#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesDestination\"}")]
        public aws.S3.IS3BucketReplicationConfigurationRulesDestination Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#status S3Bucket#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#filter S3Bucket#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesFilter\"}", isOptional: true)]
        public aws.S3.IS3BucketReplicationConfigurationRulesFilter? Filter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#id S3Bucket#id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#prefix S3Bucket#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#priority S3Bucket#priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>source_selection_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#source_selection_criteria S3Bucket#source_selection_criteria}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceSelectionCriteria", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteria\"}", isOptional: true)]
        public aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria? SourceSelectionCriteria
        {
            get;
            set;
        }
    }
}
