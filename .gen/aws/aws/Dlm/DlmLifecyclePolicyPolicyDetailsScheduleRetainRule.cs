using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dlm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleRetainRule")]
    public class DlmLifecyclePolicyPolicyDetailsScheduleRetainRule : aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#count DlmLifecyclePolicy#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public double Count
        {
            get;
            set;
        }
    }
}
