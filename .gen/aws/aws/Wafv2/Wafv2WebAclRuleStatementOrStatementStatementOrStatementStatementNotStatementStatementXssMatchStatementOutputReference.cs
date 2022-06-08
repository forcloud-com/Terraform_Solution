using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFieldToMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch\"}}]")]
        public virtual void PutFieldToMatch(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFieldToMatch")]
        public virtual void ResetFieldToMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchOutputReference FieldToMatch
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatchInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch? FieldToMatchInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementFieldToMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "textTransformationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TextTransformationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "textTransformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatementTextTransformation\"},\"kind\":\"array\"}}]}}")]
        public virtual object TextTransformation
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatement? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementOrStatementStatementNotStatementStatementXssMatchStatement?>();
            set => SetInstanceProperty(value);
        }
    }
}
