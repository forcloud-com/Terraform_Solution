using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects")]
    public class S3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects : aws.S3.IS3BucketReplicationConfigurationRulesSourceSelectionCriteriaSseKmsEncryptedObjects
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#enabled S3Bucket#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get;
            set;
        }
    }
}
