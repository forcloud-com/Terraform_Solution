using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketServerSideEncryptionConfiguration")]
    public class S3BucketServerSideEncryptionConfiguration : aws.S3.IS3BucketServerSideEncryptionConfiguration
    {
        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#rule S3Bucket#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfigurationRule\"}")]
        public aws.S3.IS3BucketServerSideEncryptionConfigurationRule Rule
        {
            get;
            set;
        }
    }
}
