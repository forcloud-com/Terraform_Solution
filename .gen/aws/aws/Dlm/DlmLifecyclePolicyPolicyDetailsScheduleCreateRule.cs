using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dlm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule")]
    public class DlmLifecyclePolicyPolicyDetailsScheduleCreateRule : aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#interval DlmLifecyclePolicy#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        public double Interval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#interval_unit DlmLifecyclePolicy#interval_unit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "intervalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IntervalUnit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#times DlmLifecyclePolicy#times}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "times", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Times
        {
            get;
            set;
        }
    }
}
