using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllQueryArguments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArguments\"}}]")]
        public virtual void PutAllQueryArguments(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArguments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArguments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBody", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBody\"}}]")]
        public virtual void PutBody(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBody @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBody)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethod\"}}]")]
        public virtual void PutMethod(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryString", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryString\"}}]")]
        public virtual void PutQueryString(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryString @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryString)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSingleHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader\"}}]")]
        public virtual void PutSingleHeader(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSingleQueryArgument", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgument\"}}]")]
        public virtual void PutSingleQueryArgument(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgument @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgument)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUriPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPath\"}}]")]
        public virtual void PutUriPath(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPath @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPath)}, new object[]{@value});
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

        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArgumentsOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArgumentsOutputReference AllQueryArguments
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArgumentsOutputReference>()!;
        }

        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBodyOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBodyOutputReference Body
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBodyOutputReference>()!;
        }

        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethodOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethodOutputReference Method
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethodOutputReference>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryStringOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryStringOutputReference QueryString
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryStringOutputReference>()!;
        }

        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeaderOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeaderOutputReference SingleHeader
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeaderOutputReference>()!;
        }

        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgumentOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgumentOutputReference SingleQueryArgument
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgumentOutputReference>()!;
        }

        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPathOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPathOutputReference UriPath
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPathOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allQueryArgumentsInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArguments? AllQueryArgumentsInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchAllQueryArguments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bodyInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBody\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBody? BodyInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchBody?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "methodInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethod\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethod? MethodInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchMethod?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryString\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryString? QueryStringInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchQueryString?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singleHeaderInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader? SingleHeaderInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleHeader?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgumentInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgument? SingleQueryArgumentInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchSingleQueryArgument?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uriPathInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPath\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPath? UriPathInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatchUriPath?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRegexPatternSetReferenceStatementFieldToMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
