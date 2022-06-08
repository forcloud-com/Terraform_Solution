using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dlm
{
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyPolicyDetails), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyPolicyDetails")]
    public interface IDlmLifecyclePolicyPolicyDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#resource_types DlmLifecyclePolicy#resource_types}.</summary>
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ResourceTypes
        {
            get;
        }

        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#schedule DlmLifecyclePolicy#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetailsSchedule\"},\"kind\":\"array\"}}]}}")]
        object Schedule
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#target_tags DlmLifecyclePolicy#target_tags}.</summary>
        [JsiiProperty(name: "targetTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> TargetTags
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyPolicyDetails), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyPolicyDetails")]
        internal sealed class _Proxy : DeputyBase, aws.Dlm.IDlmLifecyclePolicyPolicyDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#resource_types DlmLifecyclePolicy#resource_types}.</summary>
            [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ResourceTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#schedule DlmLifecyclePolicy#schedule}
            /// </remarks>
            [JsiiProperty(name: "schedule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetailsSchedule\"},\"kind\":\"array\"}}]}}")]
            public object Schedule
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#target_tags DlmLifecyclePolicy#target_tags}.</summary>
            [JsiiProperty(name: "targetTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> TargetTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }
        }
    }
}
