using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2RuleGroupRuleStatementOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2RuleGroupRuleStatementOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2RuleGroupRuleStatementOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleStatementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleStatementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAndStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatement\"}}]")]
        public virtual void PutAndStatement(aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putByteMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatement\"}}]")]
        public virtual void PutByteMatchStatement(aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeoMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementGeoMatchStatement\"}}]")]
        public virtual void PutGeoMatchStatement(aws.Wafv2.IWafv2RuleGroupRuleStatementGeoMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementGeoMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpSetReferenceStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementIpSetReferenceStatement\"}}]")]
        public virtual void PutIpSetReferenceStatement(aws.Wafv2.IWafv2RuleGroupRuleStatementIpSetReferenceStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementIpSetReferenceStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatement\"}}]")]
        public virtual void PutNotStatement(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOrStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatement\"}}]")]
        public virtual void PutOrStatement(aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegexPatternSetReferenceStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementRegexPatternSetReferenceStatement\"}}]")]
        public virtual void PutRegexPatternSetReferenceStatement(aws.Wafv2.IWafv2RuleGroupRuleStatementRegexPatternSetReferenceStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementRegexPatternSetReferenceStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSizeConstraintStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatement\"}}]")]
        public virtual void PutSizeConstraintStatement(aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqliMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSqliMatchStatement\"}}]")]
        public virtual void PutSqliMatchStatement(aws.Wafv2.IWafv2RuleGroupRuleStatementSqliMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementSqliMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXssMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementXssMatchStatement\"}}]")]
        public virtual void PutXssMatchStatement(aws.Wafv2.IWafv2RuleGroupRuleStatementXssMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementXssMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAndStatement")]
        public virtual void ResetAndStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetByteMatchStatement")]
        public virtual void ResetByteMatchStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeoMatchStatement")]
        public virtual void ResetGeoMatchStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpSetReferenceStatement")]
        public virtual void ResetIpSetReferenceStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotStatement")]
        public virtual void ResetNotStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrStatement")]
        public virtual void ResetOrStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegexPatternSetReferenceStatement")]
        public virtual void ResetRegexPatternSetReferenceStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSizeConstraintStatement")]
        public virtual void ResetSizeConstraintStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqliMatchStatement")]
        public virtual void ResetSqliMatchStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXssMatchStatement")]
        public virtual void ResetXssMatchStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "andStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementAndStatementOutputReference AndStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementAndStatementOutputReference>()!;
        }

        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementOutputReference ByteMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementByteMatchStatementOutputReference>()!;
        }

        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementGeoMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementGeoMatchStatementOutputReference GeoMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementGeoMatchStatementOutputReference>()!;
        }

        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementIpSetReferenceStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementIpSetReferenceStatementOutputReference IpSetReferenceStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementIpSetReferenceStatementOutputReference>()!;
        }

        [JsiiProperty(name: "notStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementOutputReference NotStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementOutputReference>()!;
        }

        [JsiiProperty(name: "orStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementOrStatementOutputReference OrStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementOrStatementOutputReference>()!;
        }

        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementRegexPatternSetReferenceStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementRegexPatternSetReferenceStatementOutputReference RegexPatternSetReferenceStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementRegexPatternSetReferenceStatementOutputReference>()!;
        }

        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementOutputReference SizeConstraintStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatementOutputReference>()!;
        }

        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSqliMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementSqliMatchStatementOutputReference SqliMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementSqliMatchStatementOutputReference>()!;
        }

        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementXssMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementXssMatchStatementOutputReference XssMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementXssMatchStatementOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "andStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementAndStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatement? AndStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementAndStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "byteMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementByteMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatement? ByteMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementByteMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementGeoMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementGeoMatchStatement? GeoMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementGeoMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipSetReferenceStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementIpSetReferenceStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementIpSetReferenceStatement? IpSetReferenceStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementIpSetReferenceStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatement? NotStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementOrStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatement? OrStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementOrStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regexPatternSetReferenceStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementRegexPatternSetReferenceStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeConstraintStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSizeConstraintStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatement? SizeConstraintStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementSizeConstraintStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqliMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementSqliMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementSqliMatchStatement? SqliMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementSqliMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xssMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementXssMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementXssMatchStatement? XssMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementXssMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatement? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatement?>();
            set => SetInstanceProperty(value);
        }
    }
}
