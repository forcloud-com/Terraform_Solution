using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dlm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dlm.DlmLifecyclePolicyPolicyDetailsSchedule")]
    public class DlmLifecyclePolicyPolicyDetailsSchedule : aws.Dlm.IDlmLifecyclePolicyPolicyDetailsSchedule
    {
        /// <summary>create_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#create_rule DlmLifecyclePolicy#create_rule}
        /// </remarks>
        [JsiiProperty(name: "createRule", typeJson: "{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule\"}")]
        public aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule CreateRule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#name DlmLifecyclePolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>retain_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#retain_rule DlmLifecyclePolicy#retain_rule}
        /// </remarks>
        [JsiiProperty(name: "retainRule", typeJson: "{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleRetainRule\"}")]
        public aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule RetainRule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#copy_tags DlmLifecyclePolicy#copy_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CopyTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#tags_to_add DlmLifecyclePolicy#tags_to_add}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsToAdd", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TagsToAdd
        {
            get;
            set;
        }
    }
}
