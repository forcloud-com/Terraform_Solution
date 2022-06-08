using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie
{
    [JsiiByValue(fqn: "aws.macie.MacieS3BucketAssociationClassificationType")]
    public class MacieS3BucketAssociationClassificationType : aws.Macie.IMacieS3BucketAssociationClassificationType
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie_s3_bucket_association#continuous MacieS3BucketAssociation#continuous}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "continuous", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Continuous
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie_s3_bucket_association#one_time MacieS3BucketAssociation#one_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oneTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OneTime
        {
            get;
            set;
        }
    }
}
