using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAndStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatement\"}}]")]
        public virtual void PutAndStatement(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putByteMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement\"}}]")]
        public virtual void PutByteMatchStatement(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeoMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatement\"}}]")]
        public virtual void PutGeoMatchStatement(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpSetReferenceStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement\"}}]")]
        public virtual void PutIpSetReferenceStatement(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatement\"}}]")]
        public virtual void PutNotStatement(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOrStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement\"}}]")]
        public virtual void PutOrStatement(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegexPatternSetReferenceStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatement\"}}]")]
        public virtual void PutRegexPatternSetReferenceStatement(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSizeConstraintStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatement\"}}]")]
        public virtual void PutSizeConstraintStatement(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqliMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatement\"}}]")]
        public virtual void PutSqliMatchStatement(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXssMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatement\"}}]")]
        public virtual void PutXssMatchStatement(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatement)}, new object[]{@value});
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

        [JsiiProperty(name: "andStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementOutputReference AndStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatementOutputReference>()!;
        }

        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatementOutputReference ByteMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatementOutputReference>()!;
        }

        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatementOutputReference GeoMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatementOutputReference>()!;
        }

        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatementOutputReference IpSetReferenceStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatementOutputReference>()!;
        }

        [JsiiProperty(name: "notStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementOutputReference NotStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementOutputReference>()!;
        }

        [JsiiProperty(name: "orStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementOutputReference OrStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementOutputReference>()!;
        }

        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatementOutputReference RegexPatternSetReferenceStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatementOutputReference>()!;
        }

        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatementOutputReference SizeConstraintStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatementOutputReference>()!;
        }

        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatementOutputReference SqliMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatementOutputReference>()!;
        }

        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatementOutputReference XssMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatementOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "andStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatement? AndStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementAndStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "byteMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement? ByteMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementByteMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatement? GeoMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementGeoMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipSetReferenceStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement? IpSetReferenceStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementIpSetReferenceStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatement? NotStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement? OrStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regexPatternSetReferenceStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementRegexPatternSetReferenceStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeConstraintStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatement? SizeConstraintStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSizeConstraintStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqliMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatement? SqliMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementSqliMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xssMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatement? XssMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementXssMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatement?>();
            set => SetInstanceProperty(value);
        }
    }
}
