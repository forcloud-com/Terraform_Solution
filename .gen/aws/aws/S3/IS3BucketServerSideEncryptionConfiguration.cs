using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketServerSideEncryptionConfiguration), fullyQualifiedName: "aws.s3.S3BucketServerSideEncryptionConfiguration")]
    public interface IS3BucketServerSideEncryptionConfiguration
    {
        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#rule S3Bucket#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfigurationRule\"}")]
        aws.S3.IS3BucketServerSideEncryptionConfigurationRule Rule
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketServerSideEncryptionConfiguration), fullyQualifiedName: "aws.s3.S3BucketServerSideEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketServerSideEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#rule S3Bucket#rule}
            /// </remarks>
            [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3.S3BucketServerSideEncryptionConfigurationRule\"}")]
            public aws.S3.IS3BucketServerSideEncryptionConfigurationRule Rule
            {
                get => GetInstanceProperty<aws.S3.IS3BucketServerSideEncryptionConfigurationRule>()!;
            }
        }
    }
}
