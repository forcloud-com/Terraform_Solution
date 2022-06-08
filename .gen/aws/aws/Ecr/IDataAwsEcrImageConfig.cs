using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    /// <summary>AWS EC2 Container Registry.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsEcrImageConfig), fullyQualifiedName: "aws.ecr.DataAwsEcrImageConfig")]
    public interface IDataAwsEcrImageConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_image#repository_name DataAwsEcrImage#repository_name}.</summary>
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_image#image_digest DataAwsEcrImage#image_digest}.</summary>
        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageDigest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_image#image_tag DataAwsEcrImage#image_tag}.</summary>
        [JsiiProperty(name: "imageTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_image#registry_id DataAwsEcrImage#registry_id}.</summary>
        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegistryId
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2 Container Registry.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsEcrImageConfig), fullyQualifiedName: "aws.ecr.DataAwsEcrImageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ecr.IDataAwsEcrImageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_image#repository_name DataAwsEcrImage#repository_name}.</summary>
            [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_image#image_digest DataAwsEcrImage#image_digest}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageDigest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_image#image_tag DataAwsEcrImage#image_tag}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageTag", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageTag
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_image#registry_id DataAwsEcrImage#registry_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegistryId
            {
                get => GetInstanceProperty<string?>();
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
