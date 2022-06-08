using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    /// <summary>AWS EC2 Container Registry.</summary>
    [JsiiInterface(nativeType: typeof(IEcrRepositoryConfig), fullyQualifiedName: "aws.ecr.EcrRepositoryConfig")]
    public interface IEcrRepositoryConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#name EcrRepository#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>image_scanning_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#image_scanning_configuration EcrRepository#image_scanning_configuration}
        /// </remarks>
        [JsiiProperty(name: "imageScanningConfiguration", typeJson: "{\"fqn\":\"aws.ecr.EcrRepositoryImageScanningConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ecr.IEcrRepositoryImageScanningConfiguration? ImageScanningConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#image_tag_mutability EcrRepository#image_tag_mutability}.</summary>
        [JsiiProperty(name: "imageTagMutability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageTagMutability
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#tags EcrRepository#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#timeouts EcrRepository#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ecr.EcrRepositoryTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ecr.IEcrRepositoryTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2 Container Registry.</summary>
        [JsiiTypeProxy(nativeType: typeof(IEcrRepositoryConfig), fullyQualifiedName: "aws.ecr.EcrRepositoryConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ecr.IEcrRepositoryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#name EcrRepository#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>image_scanning_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#image_scanning_configuration EcrRepository#image_scanning_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "imageScanningConfiguration", typeJson: "{\"fqn\":\"aws.ecr.EcrRepositoryImageScanningConfiguration\"}", isOptional: true)]
            public aws.Ecr.IEcrRepositoryImageScanningConfiguration? ImageScanningConfiguration
            {
                get => GetInstanceProperty<aws.Ecr.IEcrRepositoryImageScanningConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#image_tag_mutability EcrRepository#image_tag_mutability}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageTagMutability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageTagMutability
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#tags EcrRepository#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ecr_repository#timeouts EcrRepository#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ecr.EcrRepositoryTimeouts\"}", isOptional: true)]
            public aws.Ecr.IEcrRepositoryTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Ecr.IEcrRepositoryTimeouts?>();
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
