using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    #pragma warning disable CS8618

    /// <summary>AWS DataSync.</summary>
    [JsiiByValue(fqn: "aws.datasync.DatasyncLocationS3Config")]
    public class DatasyncLocationS3Config : aws.Datasync.IDatasyncLocationS3Config
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_s3#s3_bucket_arn DatasyncLocationS3#s3_bucket_arn}.</summary>
        [JsiiProperty(name: "s3BucketArn", typeJson: "{\"primitive\":\"string\"}")]
        public string S3BucketArn
        {
            get;
            set;
        }

        /// <summary>s3_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_s3#s3_config DatasyncLocationS3#s3_config}
        /// </remarks>
        [JsiiProperty(name: "s3Config", typeJson: "{\"fqn\":\"aws.datasync.DatasyncLocationS3S3Config\"}")]
        public aws.Datasync.IDatasyncLocationS3S3Config S3Config
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_s3#subdirectory DatasyncLocationS3#subdirectory}.</summary>
        [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}")]
        public string Subdirectory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_s3#tags DatasyncLocationS3#tags}.</summary>
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
