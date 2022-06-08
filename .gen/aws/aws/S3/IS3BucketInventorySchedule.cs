using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketInventorySchedule), fullyQualifiedName: "aws.s3.S3BucketInventorySchedule")]
    public interface IS3BucketInventorySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#frequency S3BucketInventory#frequency}.</summary>
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
        string Frequency
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketInventorySchedule), fullyQualifiedName: "aws.s3.S3BucketInventorySchedule")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketInventorySchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_inventory#frequency S3BucketInventory#frequency}.</summary>
            [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"string\"}")]
            public string Frequency
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
