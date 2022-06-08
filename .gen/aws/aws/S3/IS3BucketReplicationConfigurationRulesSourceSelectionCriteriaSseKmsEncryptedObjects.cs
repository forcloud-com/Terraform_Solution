using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects")]
    public interface IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#enabled S3Bucket#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#enabled S3Bucket#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
