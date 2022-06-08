using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketServerSideEncryptionConfigurationRule")]
    public class S3BucketServerSideEncryptionConfigurationRule : aws.S3.IS3BucketServerSideEncryptionConfigurationRule
    {
        /// <summary>apply_server_side_encryption_by_default block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#apply_server_side_encryption_by_default S3Bucket#apply_server_side_encryption_by_default}
        /// </remarks>
        [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"}")]
        public aws.S3.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault ApplyServerSideEncryptionByDefault
        {
            get;
            set;
        }
    }
}
