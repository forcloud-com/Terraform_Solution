using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dlm
{
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleRetainRule")]
    public interface IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#count DlmLifecyclePolicy#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        double Count
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleRetainRule")]
        internal sealed class _Proxy : DeputyBase, aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#count DlmLifecyclePolicy#count}.</summary>
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
            public double Count
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
