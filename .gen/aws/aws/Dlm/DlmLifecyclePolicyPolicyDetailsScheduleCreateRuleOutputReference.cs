using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dlm
{
    [JsiiClass(nativeType: typeof(aws.Dlm.DlmLifecyclePolicyPolicyDetailsScheduleCreateRuleOutputReference), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleCreateRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DlmLifecyclePolicyPolicyDetailsScheduleCreateRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DlmLifecyclePolicyPolicyDetailsScheduleCreateRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DlmLifecyclePolicyPolicyDetailsScheduleCreateRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DlmLifecyclePolicyPolicyDetailsScheduleCreateRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetIntervalUnit")]
        public virtual void ResetIntervalUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimes")]
        public virtual void ResetTimes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IntervalUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TimesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Interval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "intervalUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IntervalUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "times", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Times
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule\"}", isOptional: true)]
        public virtual aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule? InternalValue
        {
            get => GetInstanceProperty<aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
