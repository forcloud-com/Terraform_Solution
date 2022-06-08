using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketLifecycleRuleNoncurrentVersionExpiration), fullyQualifiedName: "aws.s3.S3BucketLifecycleRuleNoncurrentVersionExpiration")]
    public interface IS3BucketLifecycleRuleNoncurrentVersionExpiration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#days S3Bucket#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Days
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketLifecycleRuleNoncurrentVersionExpiration), fullyQualifiedName: "aws.s3.S3BucketLifecycleRuleNoncurrentVersionExpiration")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketLifecycleRuleNoncurrentVersionExpiration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#days S3Bucket#days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Days
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
