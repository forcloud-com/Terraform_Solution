using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFieldToMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch\"}}]")]
        public virtual void PutFieldToMatch(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFieldToMatch")]
        public virtual void ResetFieldToMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchOutputReference FieldToMatch
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "comparisonOperatorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComparisonOperatorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatchInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch? FieldToMatchInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementFieldToMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "textTransformationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TextTransformationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComparisonOperator
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "textTransformation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatementTextTransformation\"},\"kind\":\"array\"}}]}}")]
        public virtual object TextTransformation
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatement? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementNotStatementStatementSizeConstraintStatement?>();
            set => SetInstanceProperty(value);
        }
    }
}
