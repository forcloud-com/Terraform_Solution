using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketObjectLockConfiguration), fullyQualifiedName: "aws.s3.S3BucketObjectLockConfiguration")]
    public interface IS3BucketObjectLockConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#object_lock_enabled S3Bucket#object_lock_enabled}.</summary>
        [JsiiProperty(name: "objectLockEnabled", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectLockEnabled
        {
            get;
        }

        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#rule S3Bucket#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3.S3BucketObjectLockConfigurationRule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketObjectLockConfigurationRule? Rule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketObjectLockConfiguration), fullyQualifiedName: "aws.s3.S3BucketObjectLockConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketObjectLockConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#object_lock_enabled S3Bucket#object_lock_enabled}.</summary>
            [JsiiProperty(name: "objectLockEnabled", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectLockEnabled
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#rule S3Bucket#rule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"aws.s3.S3BucketObjectLockConfigurationRule\"}", isOptional: true)]
            public aws.S3.IS3BucketObjectLockConfigurationRule? Rule
            {
                get => GetInstanceProperty<aws.S3.IS3BucketObjectLockConfigurationRule?>();
            }
        }
    }
}
