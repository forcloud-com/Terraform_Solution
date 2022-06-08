using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketObjectLockConfigurationRule), fullyQualifiedName: "aws.s3.S3BucketObjectLockConfigurationRule")]
    public interface IS3BucketObjectLockConfigurationRule
    {
        /// <summary>default_retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#default_retention S3Bucket#default_retention}
        /// </remarks>
        [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.s3.S3BucketObjectLockConfigurationRuleDefaultRetention\"}")]
        aws.S3.IS3BucketObjectLockConfigurationRuleDefaultRetention DefaultRetention
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketObjectLockConfigurationRule), fullyQualifiedName: "aws.s3.S3BucketObjectLockConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketObjectLockConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_retention block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#default_retention S3Bucket#default_retention}
            /// </remarks>
            [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"aws.s3.S3BucketObjectLockConfigurationRuleDefaultRetention\"}")]
            public aws.S3.IS3BucketObjectLockConfigurationRuleDefaultRetention DefaultRetention
            {
                get => GetInstanceProperty<aws.S3.IS3BucketObjectLockConfigurationRuleDefaultRetention>()!;
            }
        }
    }
}
