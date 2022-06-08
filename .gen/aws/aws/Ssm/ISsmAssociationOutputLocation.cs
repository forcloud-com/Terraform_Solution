using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiInterface(nativeType: typeof(ISsmAssociationOutputLocation), fullyQualifiedName: "aws.ssm.SsmAssociationOutputLocation")]
    public interface ISsmAssociationOutputLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#s3_bucket_name SsmAssociation#s3_bucket_name}.</summary>
        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        string S3BucketName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#s3_key_prefix SsmAssociation#s3_key_prefix}.</summary>
        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3KeyPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmAssociationOutputLocation), fullyQualifiedName: "aws.ssm.SsmAssociationOutputLocation")]
        internal sealed class _Proxy : DeputyBase, aws.Ssm.ISsmAssociationOutputLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#s3_bucket_name SsmAssociation#s3_bucket_name}.</summary>
            [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string S3BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#s3_key_prefix SsmAssociation#s3_key_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3KeyPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
