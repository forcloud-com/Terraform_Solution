using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllQueryArguments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchAllQueryArguments\"}}]")]
        public virtual void PutAllQueryArguments(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchAllQueryArguments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchAllQueryArguments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBody", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchBody\"}}]")]
        public virtual void PutBody(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchBody @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchBody)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchMethod\"}}]")]
        public virtual void PutMethod(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryString", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchQueryString\"}}]")]
        public virtual void PutQueryString(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchQueryString @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchQueryString)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSingleHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleHeader\"}}]")]
        public virtual void PutSingleHeader(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleHeader)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSingleQueryArgument", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument\"}}]")]
        public virtual void PutSingleQueryArgument(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUriPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchUriPath\"}}]")]
        public virtual void PutUriPath(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchUriPath @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchUriPath)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllQueryArguments")]
        public virtual void ResetAllQueryArguments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBody")]
        public virtual void ResetBody()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMethod")]
        public virtual void ResetMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryString")]
        public virtual void ResetQueryString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSingleHeader")]
        public virtual void ResetSingleHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSingleQueryArgument")]
        public virtual void ResetSingleQueryArgument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUriPath")]
        public virtual void ResetUriPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchAllQueryArgumentsOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchAllQueryArgumentsOutputReference AllQueryArguments
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchAllQueryArgumentsOutputReference>()!;
        }

        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchBodyOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchBodyOutputReference Body
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchBodyOutputReference>()!;
        }

        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchMethodOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchMethodOutputReference Method
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchMethodOutputReference>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchQueryStringOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchQueryStringOutputReference QueryString
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchQueryStringOutputReference>()!;
        }

        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleHeaderOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleHeaderOutputReference SingleHeader
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleHeaderOutputReference>()!;
        }

        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleQueryArgumentOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleQueryArgumentOutputReference SingleQueryArgument
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleQueryArgumentOutputReference>()!;
        }

        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchUriPathOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchUriPathOutputReference UriPath
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchUriPathOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allQueryArgumentsInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchAllQueryArguments? AllQueryArgumentsInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchAllQueryArguments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bodyInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchBody\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchBody? BodyInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchBody?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "methodInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchMethod\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchMethod? MethodInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchMethod?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchQueryString\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchQueryString? QueryStringInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchQueryString?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singleHeaderInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleHeader\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleHeader? SingleHeaderInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleHeader?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgumentInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgumentInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchSingleQueryArgument?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uriPathInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchUriPath\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchUriPath? UriPathInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatchUriPath?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatch\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatch? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleStatementNotStatementStatementByteMatchStatementFieldToMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
