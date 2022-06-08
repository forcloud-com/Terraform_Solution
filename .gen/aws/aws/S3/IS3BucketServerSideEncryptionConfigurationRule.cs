using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketServerSideEncryptionConfigurationRule), fullyQualifiedName: "aws.s3.S3BucketServerSideEncryptionConfigurationRule")]
    public interface IS3BucketServerSideEncryptionConfigurationRule
    {
        /// <summary>apply_server_side_encryption_by_default block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#apply_server_side_encryption_by_default S3Bucket#apply_server_side_encryption_by_default}
        /// </remarks>
        [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"}")]
        aws.S3.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault ApplyServerSideEncryptionByDefault
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketServerSideEncryptionConfigurationRule), fullyQualifiedName: "aws.s3.S3BucketServerSideEncryptionConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketServerSideEncryptionConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>apply_server_side_encryption_by_default block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#apply_server_side_encryption_by_default S3Bucket#apply_server_side_encryption_by_default}
            /// </remarks>
            [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"}")]
            public aws.S3.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault ApplyServerSideEncryptionByDefault
            {
                get => GetInstanceProperty<aws.S3.IS3BucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault>()!;
            }
        }
    }
}
