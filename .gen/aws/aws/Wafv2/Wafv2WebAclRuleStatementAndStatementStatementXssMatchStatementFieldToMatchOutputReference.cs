using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllQueryArguments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchAllQueryArguments\"}}]")]
        public virtual void PutAllQueryArguments(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchAllQueryArguments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchAllQueryArguments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBody", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchBody\"}}]")]
        public virtual void PutBody(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchBody @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchBody)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchMethod\"}}]")]
        public virtual void PutMethod(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryString", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchQueryString\"}}]")]
        public virtual void PutQueryString(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchQueryString @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchQueryString)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSingleHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleHeader\"}}]")]
        public virtual void PutSingleHeader(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleHeader)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSingleQueryArgument", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument\"}}]")]
        public virtual void PutSingleQueryArgument(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUriPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchUriPath\"}}]")]
        public virtual void PutUriPath(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchUriPath @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchUriPath)}, new object[]{@value});
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

        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchAllQueryArgumentsOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchAllQueryArgumentsOutputReference AllQueryArguments
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchAllQueryArgumentsOutputReference>()!;
        }

        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchBodyOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchBodyOutputReference Body
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchBodyOutputReference>()!;
        }

        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchMethodOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchMethodOutputReference Method
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchMethodOutputReference>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchQueryStringOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchQueryStringOutputReference QueryString
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchQueryStringOutputReference>()!;
        }

        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleHeaderOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleHeaderOutputReference SingleHeader
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleHeaderOutputReference>()!;
        }

        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleQueryArgumentOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleQueryArgumentOutputReference SingleQueryArgument
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleQueryArgumentOutputReference>()!;
        }

        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchUriPathOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchUriPathOutputReference UriPath
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchUriPathOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allQueryArgumentsInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchAllQueryArguments? AllQueryArgumentsInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchAllQueryArguments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bodyInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchBody\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchBody? BodyInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchBody?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "methodInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchMethod\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchMethod? MethodInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchMethod?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchQueryString\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchQueryString? QueryStringInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchQueryString?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singleHeaderInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleHeader\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleHeader? SingleHeaderInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleHeader?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgumentInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgumentInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchSingleQueryArgument?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uriPathInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchUriPath\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchUriPath? UriPathInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatchUriPath?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatch\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatch? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementXssMatchStatementFieldToMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
