using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssm.SsmPatchBaselineGlobalFilter")]
    public class SsmPatchBaselineGlobalFilter : aws.Ssm.ISsmPatchBaselineGlobalFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#key SsmPatchBaseline#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_baseline#values SsmPatchBaseline#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
