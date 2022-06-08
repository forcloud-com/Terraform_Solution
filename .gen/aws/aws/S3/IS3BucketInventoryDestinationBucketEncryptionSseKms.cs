using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketInventoryDestinationBucketEncryptionSseKms), fullyQualifiedName: "aws.s3.S3BucketInventoryDestinationBucketEncryptionSseKms")]
    public interface IS3BucketInventoryDestinationBucketEncryptionSseKms
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#key_id S3BucketInventory#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        string KeyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventoryDestinationBucketEncryptionSseKms), fullyQualifiedName: "aws.s3.S3BucketInventoryDestinationBucketEncryptionSseKms")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketInventoryDestinationBucketEncryptionSseKms
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#key_id S3BucketInventory#key_id}.</summary>
            [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
