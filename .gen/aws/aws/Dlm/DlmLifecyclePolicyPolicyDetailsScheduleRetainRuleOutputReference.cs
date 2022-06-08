using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dlm
{
    [JsiiClass(nativeType: typeof(aws.Dlm.DlmLifecyclePolicyPolicyDetailsScheduleRetainRuleOutputReference), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleRetainRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DlmLifecyclePolicyPolicyDetailsScheduleRetainRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DlmLifecyclePolicyPolicyDetailsScheduleRetainRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DlmLifecyclePolicyPolicyDetailsScheduleRetainRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DlmLifecyclePolicyPolicyDetailsScheduleRetainRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "countInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Count
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleRetainRule\"}", isOptional: true)]
        public virtual aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule? InternalValue
        {
            get => GetInstanceProperty<aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleRetainRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
