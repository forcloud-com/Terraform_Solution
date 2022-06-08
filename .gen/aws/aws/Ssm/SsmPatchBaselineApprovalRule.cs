using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssm.SsmPatchBaselineApprovalRule")]
    public class SsmPatchBaselineApprovalRule : aws.Ssm.ISsmPatchBaselineApprovalRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#approve_after_days SsmPatchBaseline#approve_after_days}.</summary>
        [JsiiProperty(name: "approveAfterDays", typeJson: "{\"primitive\":\"number\"}")]
        public double ApproveAfterDays
        {
            get;
            set;
        }

        /// <summary>patch_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#patch_filter SsmPatchBaseline#patch_filter}
        /// </remarks>
        [JsiiProperty(name: "patchFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmPatchBaselineApprovalRulePatchFilter\"},\"kind\":\"array\"}}]}}")]
        public object PatchFilter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#compliance_level SsmPatchBaseline#compliance_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "complianceLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComplianceLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#enable_non_security SsmPatchBaseline#enable_non_security}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableNonSecurity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableNonSecurity
        {
            get;
            set;
        }
    }
}
