using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleActionOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclRuleActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclRuleActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionAllow\"}}]")]
        public virtual void PutAllow(aws.Wafv2.IWafv2WebAclRuleActionAllow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleActionAllow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionBlock\"}}]")]
        public virtual void PutBlock(aws.Wafv2.IWafv2WebAclRuleActionBlock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleActionBlock)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionCount\"}}]")]
        public virtual void PutCount(aws.Wafv2.IWafv2WebAclRuleActionCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleActionCount)}, new object[]{@value});
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

        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionAllowOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleActionAllowOutputReference Allow
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleActionAllowOutputReference>()!;
        }

        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionBlockOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleActionBlockOutputReference Block
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleActionBlockOutputReference>()!;
        }

        [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionCountOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleActionCountOutputReference Count
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleActionCountOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionAllow\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleActionAllow? AllowInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleActionAllow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionBlock\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleActionBlock? BlockInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleActionBlock?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "countInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionCount\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleActionCount? CountInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleActionCount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleAction\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleAction? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
