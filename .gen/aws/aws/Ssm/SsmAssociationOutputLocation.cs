using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssm.SsmAssociationOutputLocation")]
    public class SsmAssociationOutputLocation : aws.Ssm.ISsmAssociationOutputLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#s3_bucket_name SsmAssociation#s3_bucket_name}.</summary>
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string S3BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#s3_key_prefix SsmAssociation#s3_key_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3KeyPrefix
        {
            get;
            set;
        }
    }
}
