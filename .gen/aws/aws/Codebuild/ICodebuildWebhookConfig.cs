using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    /// <summary>AWS CodeBuild.</summary>
    [JsiiInterface(nativeType: typeof(ICodebuildWebhookConfig), fullyQualifiedName: "aws.codebuild.CodebuildWebhookConfig")]
    public interface ICodebuildWebhookConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#project_name CodebuildWebhook#project_name}.</summary>
        [JsiiProperty(name: "projectName", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#branch_filter CodebuildWebhook#branch_filter}.</summary>
        [JsiiProperty(name: "branchFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BranchFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#filter_group CodebuildWebhook#filter_group}
        /// </remarks>
        [JsiiProperty(name: "filterGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildWebhookFilterGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FilterGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS CodeBuild.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICodebuildWebhookConfig), fullyQualifiedName: "aws.codebuild.CodebuildWebhookConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Codebuild.ICodebuildWebhookConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#project_name CodebuildWebhook#project_name}.</summary>
            [JsiiProperty(name: "projectName", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#branch_filter CodebuildWebhook#branch_filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "branchFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BranchFilter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>filter_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#filter_group CodebuildWebhook#filter_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filterGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildWebhookFilterGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FilterGroup
            {
                get => GetInstanceProperty<object?>();
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
