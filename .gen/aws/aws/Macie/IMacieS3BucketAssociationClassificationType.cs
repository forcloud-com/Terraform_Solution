using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie
{
    [JsiiInterface(nativeType: typeof(IMacieS3BucketAssociationClassificationType), fullyQualifiedName: "aws.macie.MacieS3BucketAssociationClassificationType")]
    public interface IMacieS3BucketAssociationClassificationType
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie_s3_bucket_association#continuous MacieS3BucketAssociation#continuous}.</summary>
        [JsiiProperty(name: "continuous", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Continuous
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie_s3_bucket_association#one_time MacieS3BucketAssociation#one_time}.</summary>
        [JsiiProperty(name: "oneTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OneTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacieS3BucketAssociationClassificationType), fullyQualifiedName: "aws.macie.MacieS3BucketAssociationClassificationType")]
        internal sealed class _Proxy : DeputyBase, aws.Macie.IMacieS3BucketAssociationClassificationType
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie_s3_bucket_association#continuous MacieS3BucketAssociation#continuous}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "continuous", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Continuous
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie_s3_bucket_association#one_time MacieS3BucketAssociation#one_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oneTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OneTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
