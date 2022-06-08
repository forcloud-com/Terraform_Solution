using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2RuleGroupRuleActionOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2RuleGroupRuleActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2RuleGroupRuleActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionAllow\"}}]")]
        public virtual void PutAllow(aws.Wafv2.IWafv2RuleGroupRuleActionAllow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleActionAllow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlock\"}}]")]
        public virtual void PutBlock(aws.Wafv2.IWafv2RuleGroupRuleActionBlock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleActionBlock)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionCount\"}}]")]
        public virtual void PutCount(aws.Wafv2.IWafv2RuleGroupRuleActionCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleActionCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllow")]
        public virtual void ResetAllow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlock")]
        public virtual void ResetBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCount")]
        public virtual void ResetCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionAllowOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleActionAllowOutputReference Allow
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleActionAllowOutputReference>()!;
        }

        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlockOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleActionBlockOutputReference Block
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleActionBlockOutputReference>()!;
        }

        [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionCountOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleActionCountOutputReference Count
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleActionCountOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionAllow\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleActionAllow? AllowInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionAllow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlock\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleActionBlock? BlockInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionBlock?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "countInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionCount\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleActionCount? CountInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionCount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleAction\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleAction? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
