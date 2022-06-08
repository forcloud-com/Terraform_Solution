using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketObjectLockConfiguration")]
    public class S3BucketObjectLockConfiguration : aws.S3.IS3BucketObjectLockConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#object_lock_enabled S3Bucket#object_lock_enabled}.</summary>
        [JsiiProperty(name: "objectLockEnabled", typeJson: "{\"primitive\":\"string\"}")]
        public string ObjectLockEnabled
        {
            get;
            set;
        }

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#rule S3Bucket#rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3.S3BucketObjectLockConfigurationRule\"}", isOptional: true)]
        public aws.S3.IS3BucketObjectLockConfigurationRule? Rule
        {
            get;
            set;
        }
    }
}
