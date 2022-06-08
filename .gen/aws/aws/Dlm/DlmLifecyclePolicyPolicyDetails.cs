using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dlm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dlm.DlmLifecyclePolicyPolicyDetails")]
    public class DlmLifecyclePolicyPolicyDetails : aws.Dlm.IDlmLifecyclePolicyPolicyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#resource_types DlmLifecyclePolicy#resource_types}.</summary>
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ResourceTypes
        {
            get;
            set;
        }

        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#schedule DlmLifecyclePolicy#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetailsSchedule\"},\"kind\":\"array\"}}]}}")]
        public object Schedule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#target_tags DlmLifecyclePolicy#target_tags}.</summary>
        [JsiiProperty(name: "targetTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> TargetTags
        {
            get;
            set;
        }
    }
}
