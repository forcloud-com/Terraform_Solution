using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation")]
    public class S3BucketReplicationConfigurationRulesDestinationAccessControlTranslation : aws.S3.IS3BucketReplicationConfigurationRulesDestinationAccessControlTranslation
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#owner S3Bucket#owner}.</summary>
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public string Owner
        {
            get;
            set;
        }
    }
}
