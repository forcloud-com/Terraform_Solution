using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfigurationRulesSourceSelectionCriteria), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteria")]
    public interface IS3BucketReplicationConfigurationRulesSourceSelectionCriteria
    {
        /// <summary>sse_kms_encrypted_objects block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#sse_kms_encrypted_objects S3Bucket#sse_kms_encrypted_objects}
        /// </remarks>
        [JsiiProperty(name: "sseKmsEncryptedObjects", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjects
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfigurationRulesSourceSelectionCriteria), fullyQualifiedName: "aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>sse_kms_encrypted_objects block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#sse_kms_encrypted_objects S3Bucket#sse_kms_encrypted_objects}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sseKmsEncryptedObjects", typeJson: "{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects\"}", isOptional: true)]
            public aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects? SseKmsEncryptedObjects
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects?>();
            }
        }
    }
}
