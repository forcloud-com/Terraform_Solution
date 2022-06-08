using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    /// <summary>AWS Simple Storage Service.</summary>
    [JsiiByValue(fqn: "aws.s3.DataAwsS3BucketObjectsConfig")]
    public class DataAwsS3BucketObjectsConfig : aws.S3.IDataAwsS3BucketObjectsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#bucket DataAwsS3BucketObjects#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#delimiter DataAwsS3BucketObjects#delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#encoding_type DataAwsS3BucketObjects#encoding_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encodingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncodingType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#fetch_owner DataAwsS3BucketObjects#fetch_owner}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fetchOwner", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? FetchOwner
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#max_keys DataAwsS3BucketObjects#max_keys}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxKeys", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxKeys
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#prefix DataAwsS3BucketObjects#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/s3_bucket_objects#start_after DataAwsS3BucketObjects#start_after}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartAfter
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
