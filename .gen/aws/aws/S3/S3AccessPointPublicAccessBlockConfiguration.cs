using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiByValue(fqn: "aws.s3.S3AccessPointPublicAccessBlockConfiguration")]
    public class S3AccessPointPublicAccessBlockConfiguration : aws.S3.IS3AccessPointPublicAccessBlockConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#block_public_acls S3AccessPoint#block_public_acls}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockPublicAcls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? BlockPublicAcls
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#block_public_policy S3AccessPoint#block_public_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockPublicPolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? BlockPublicPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#ignore_public_acls S3AccessPoint#ignore_public_acls}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ignorePublicAcls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IgnorePublicAcls
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#restrict_public_buckets S3AccessPoint#restrict_public_buckets}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "restrictPublicBuckets", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RestrictPublicBuckets
        {
            get;
            set;
        }
    }
}
