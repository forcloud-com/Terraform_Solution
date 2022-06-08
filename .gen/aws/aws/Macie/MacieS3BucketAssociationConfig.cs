using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie
{
    #pragma warning disable CS8618

    /// <summary>AWS Macie.</summary>
    [JsiiByValue(fqn: "aws.macie.MacieS3BucketAssociationConfig")]
    public class MacieS3BucketAssociationConfig : aws.Macie.IMacieS3BucketAssociationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie_s3_bucket_association#bucket_name MacieS3BucketAssociation#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketName
        {
            get;
            set;
        }

        /// <summary>classification_type block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie_s3_bucket_association#classification_type MacieS3BucketAssociation#classification_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "classificationType", typeJson: "{\"fqn\":\"aws.macie.MacieS3BucketAssociationClassificationType\"}", isOptional: true)]
        public aws.Macie.IMacieS3BucketAssociationClassificationType? ClassificationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie_s3_bucket_association#member_account_id MacieS3BucketAssociation#member_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memberAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MemberAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie_s3_bucket_association#prefix MacieS3BucketAssociation#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
