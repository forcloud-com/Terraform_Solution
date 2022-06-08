using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleStatementOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclRuleStatementOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclRuleStatementOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAndStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatement\"}}]")]
        public virtual void PutAndStatement(aws.Wafv2.IWafv2WebAclRuleStatementAndStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putByteMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementByteMatchStatement\"}}]")]
        public virtual void PutByteMatchStatement(aws.Wafv2.IWafv2WebAclRuleStatementByteMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementByteMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeoMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementGeoMatchStatement\"}}]")]
        public virtual void PutGeoMatchStatement(aws.Wafv2.IWafv2WebAclRuleStatementGeoMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementGeoMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpSetReferenceStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementIpSetReferenceStatement\"}}]")]
        public virtual void PutIpSetReferenceStatement(aws.Wafv2.IWafv2WebAclRuleStatementIpSetReferenceStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementIpSetReferenceStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManagedRuleGroupStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatement\"}}]")]
        public virtual void PutManagedRuleGroupStatement(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatement\"}}]")]
        public virtual void PutNotStatement(aws.Wafv2.IWafv2WebAclRuleStatementNotStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementNotStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOrStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatement\"}}]")]
        public virtual void PutOrStatement(aws.Wafv2.IWafv2WebAclRuleStatementOrStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementOrStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRateBasedStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatement\"}}]")]
        public virtual void PutRateBasedStatement(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegexPatternSetReferenceStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatement\"}}]")]
        public virtual void PutRegexPatternSetReferenceStatement(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRuleGroupReferenceStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRuleGroupReferenceStatement\"}}]")]
        public virtual void PutRuleGroupReferenceStatement(aws.Wafv2.IWafv2WebAclRuleStatementRuleGroupReferenceStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRuleGroupReferenceStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSizeConstraintStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementSizeConstraintStatement\"}}]")]
        public virtual void PutSizeConstraintStatement(aws.Wafv2.IWafv2WebAclRuleStatementSizeConstraintStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementSizeConstraintStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqliMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementSqliMatchStatement\"}}]")]
        public virtual void PutSqliMatchStatement(aws.Wafv2.IWafv2WebAclRuleStatementSqliMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementSqliMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXssMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementXssMatchStatement\"}}]")]
        public virtual void PutXssMatchStatement(aws.Wafv2.IWafv2WebAclRuleStatementXssMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementXssMatchStatement)}, new object[]{@value});
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

        [JsiiMethod(name: "resetManagedRuleGroupStatement")]
        public virtual void ResetManagedRuleGroupStatement()
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

        [JsiiMethod(name: "resetRateBasedStatement")]
        public virtual void ResetRateBasedStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegexPatternSetReferenceStatement")]
        public virtual void ResetRegexPatternSetReferenceStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuleGroupReferenceStatement")]
        public virtual void ResetRuleGroupReferenceStatement()
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

        [JsiiProperty(name: "andStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementOutputReference AndStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementOutputReference>()!;
        }

        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementByteMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementByteMatchStatementOutputReference ByteMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementByteMatchStatementOutputReference>()!;
        }

        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementGeoMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementGeoMatchStatementOutputReference GeoMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementGeoMatchStatementOutputReference>()!;
        }

        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementIpSetReferenceStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementIpSetReferenceStatementOutputReference IpSetReferenceStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementIpSetReferenceStatementOutputReference>()!;
        }

        [JsiiProperty(name: "managedRuleGroupStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementOutputReference ManagedRuleGroupStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementOutputReference>()!;
        }

        [JsiiProperty(name: "notStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementNotStatementOutputReference NotStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementNotStatementOutputReference>()!;
        }

        [JsiiProperty(name: "orStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementOrStatementOutputReference OrStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementOrStatementOutputReference>()!;
        }

        [JsiiProperty(name: "rateBasedStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementOutputReference RateBasedStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementOutputReference>()!;
        }

        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementOutputReference RegexPatternSetReferenceStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementOutputReference>()!;
        }

        [JsiiProperty(name: "ruleGroupReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRuleGroupReferenceStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRuleGroupReferenceStatementOutputReference RuleGroupReferenceStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRuleGroupReferenceStatementOutputReference>()!;
        }

        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementSizeConstraintStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementSizeConstraintStatementOutputReference SizeConstraintStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementSizeConstraintStatementOutputReference>()!;
        }

        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementSqliMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementSqliMatchStatementOutputReference SqliMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementSqliMatchStatementOutputReference>()!;
        }

        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementXssMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementXssMatchStatementOutputReference XssMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementXssMatchStatementOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "andStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatement? AndStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "byteMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementByteMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementByteMatchStatement? ByteMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementByteMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementGeoMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementGeoMatchStatement? GeoMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementGeoMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipSetReferenceStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementIpSetReferenceStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementIpSetReferenceStatement? IpSetReferenceStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementIpSetReferenceStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedRuleGroupStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatement? ManagedRuleGroupStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementNotStatement? NotStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementNotStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatement? OrStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rateBasedStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatement? RateBasedStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regexPatternSetReferenceStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleGroupReferenceStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRuleGroupReferenceStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRuleGroupReferenceStatement? RuleGroupReferenceStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRuleGroupReferenceStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeConstraintStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementSizeConstraintStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementSizeConstraintStatement? SizeConstraintStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementSizeConstraintStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqliMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementSqliMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementSqliMatchStatement? SqliMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementSqliMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xssMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementXssMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementXssMatchStatement? XssMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementXssMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatement? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatement?>();
            set => SetInstanceProperty(value);
        }
    }
}
