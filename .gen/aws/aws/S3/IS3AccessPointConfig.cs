using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    /// <summary>AWS Simple Storage Service.</summary>
    [JsiiInterface(nativeType: typeof(IS3AccessPointConfig), fullyQualifiedName: "aws.s3.S3AccessPointConfig")]
    public interface IS3AccessPointConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#bucket S3AccessPoint#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#name S3AccessPoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#account_id S3AccessPoint#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#policy S3AccessPoint#policy}.</summary>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Policy
        {
            get
            {
                return null;
            }
        }

        /// <summary>public_access_block_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#public_access_block_configuration S3AccessPoint#public_access_block_configuration}
        /// </remarks>
        [JsiiProperty(name: "publicAccessBlockConfiguration", typeJson: "{\"fqn\":\"aws.s3.S3AccessPointPublicAccessBlockConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3AccessPointPublicAccessBlockConfiguration? PublicAccessBlockConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#vpc_configuration S3AccessPoint#vpc_configuration}
        /// </remarks>
        [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"fqn\":\"aws.s3.S3AccessPointVpcConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3AccessPointVpcConfiguration? VpcConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Simple Storage Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IS3AccessPointConfig), fullyQualifiedName: "aws.s3.S3AccessPointConfig")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3AccessPointConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#bucket S3AccessPoint#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#name S3AccessPoint#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#account_id S3AccessPoint#account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#policy S3AccessPoint#policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Policy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>public_access_block_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#public_access_block_configuration S3AccessPoint#public_access_block_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicAccessBlockConfiguration", typeJson: "{\"fqn\":\"aws.s3.S3AccessPointPublicAccessBlockConfiguration\"}", isOptional: true)]
            public aws.S3.IS3AccessPointPublicAccessBlockConfiguration? PublicAccessBlockConfiguration
            {
                get => GetInstanceProperty<aws.S3.IS3AccessPointPublicAccessBlockConfiguration?>();
            }

            /// <summary>vpc_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_access_point#vpc_configuration S3AccessPoint#vpc_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"fqn\":\"aws.s3.S3AccessPointVpcConfiguration\"}", isOptional: true)]
            public aws.S3.IS3AccessPointVpcConfiguration? VpcConfiguration
            {
                get => GetInstanceProperty<aws.S3.IS3AccessPointVpcConfiguration?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
