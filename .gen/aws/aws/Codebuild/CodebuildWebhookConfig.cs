using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codebuild
{
    #pragma warning disable CS8618

    /// <summary>AWS CodeBuild.</summary>
    [JsiiByValue(fqn: "aws.codebuild.CodebuildWebhookConfig")]
    public class CodebuildWebhookConfig : aws.Codebuild.ICodebuildWebhookConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#project_name CodebuildWebhook#project_name}.</summary>
        [JsiiProperty(name: "projectName", typeJson: "{\"primitive\":\"string\"}")]
        public string ProjectName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#branch_filter CodebuildWebhook#branch_filter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "branchFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BranchFilter
        {
            get;
            set;
        }

        /// <summary>filter_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codebuild_webhook#filter_group CodebuildWebhook#filter_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codebuild.CodebuildWebhookFilterGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FilterGroup
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
