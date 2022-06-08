using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    #pragma warning disable CS8618

    /// <summary>AWS Systems Manager.</summary>
    [JsiiByValue(fqn: "aws.ssm.SsmPatchBaselineConfig")]
    public class SsmPatchBaselineConfig : aws.Ssm.ISsmPatchBaselineConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#name SsmPatchBaseline#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>approval_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#approval_rule SsmPatchBaseline#approval_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "approvalRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmPatchBaselineApprovalRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ApprovalRule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#approved_patches SsmPatchBaseline#approved_patches}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "approvedPatches", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ApprovedPatches
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#approved_patches_compliance_level SsmPatchBaseline#approved_patches_compliance_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "approvedPatchesComplianceLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApprovedPatchesComplianceLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#description SsmPatchBaseline#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>global_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#global_filter SsmPatchBaseline#global_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "globalFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmPatchBaselineGlobalFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GlobalFilter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#operating_system SsmPatchBaseline#operating_system}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OperatingSystem
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#rejected_patches SsmPatchBaseline#rejected_patches}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rejectedPatches", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RejectedPatches
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#tags SsmPatchBaseline#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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
