using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation")]
    public interface IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#owner S3Bucket#owner}.</summary>
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        string Owner
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#owner S3Bucket#owner}.</summary>
            [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
            public string Owner
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
