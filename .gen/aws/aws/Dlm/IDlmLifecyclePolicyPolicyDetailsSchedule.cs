using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dlm
{
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsSchedule), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyPolicyDetailsSchedule")]
    public interface IDlmLifecyclePolicyPolicyDetailsSchedule
    {
        /// <summary>create_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#create_rule DlmLifecyclePolicy#create_rule}
        /// </remarks>
        [JsiiProperty(name: "createRule", typeJson: "{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule\"}")]
        aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule CreateRule
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#name DlmLifecyclePolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>retain_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#retain_rule DlmLifecyclePolicy#retain_rule}
        /// </remarks>
        [JsiiProperty(name: "retainRule", typeJson: "{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleRetainRule\"}")]
        aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule RetainRule
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#copy_tags DlmLifecyclePolicy#copy_tags}.</summary>
        [JsiiProperty(name: "copyTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CopyTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#tags_to_add DlmLifecyclePolicy#tags_to_add}.</summary>
        [JsiiProperty(name: "tagsToAdd", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsToAdd
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsSchedule), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyPolicyDetailsSchedule")]
        internal sealed class _Proxy : DeputyBase, aws.Dlm.IDlmLifecyclePolicyPolicyDetailsSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>create_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#create_rule DlmLifecyclePolicy#create_rule}
            /// </remarks>
            [JsiiProperty(name: "createRule", typeJson: "{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule\"}")]
            public aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule CreateRule
            {
                get => GetInstanceProperty<aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#name DlmLifecyclePolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>retain_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#retain_rule DlmLifecyclePolicy#retain_rule}
            /// </remarks>
            [JsiiProperty(name: "retainRule", typeJson: "{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleRetainRule\"}")]
            public aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule RetainRule
            {
                get => GetInstanceProperty<aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#copy_tags DlmLifecyclePolicy#copy_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "copyTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CopyTags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#tags_to_add DlmLifecyclePolicy#tags_to_add}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsToAdd", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsToAdd
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
