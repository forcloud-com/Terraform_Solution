using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethodOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethodOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethodOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethodOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethodOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethodOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethod\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethod? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatementXssMatchStatementFieldToMatchMethod?>();
            set => SetInstanceProperty(value);
        }
    }
}
