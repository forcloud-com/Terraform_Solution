using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketInventoryDestination), fullyQualifiedName: "aws.s3.S3BucketInventoryDestination")]
    public interface IS3BucketInventoryDestination
    {
        /// <summary>bucket block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#bucket S3BucketInventory#bucket}
        /// </remarks>
        [JsiiProperty(name: "bucket", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucket\"}")]
        aws.S3.IS3BucketInventoryDestinationBucket Bucket
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventoryDestination), fullyQualifiedName: "aws.s3.S3BucketInventoryDestination")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketInventoryDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bucket block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#bucket S3BucketInventory#bucket}
            /// </remarks>
            [JsiiProperty(name: "bucket", typeJson: "{\"fqn\":\"aws.s3.S3BucketInventoryDestinationBucket\"}")]
            public aws.S3.IS3BucketInventoryDestinationBucket Bucket
            {
                get => GetInstanceProperty<aws.S3.IS3BucketInventoryDestinationBucket>()!;
            }
        }
    }
}
