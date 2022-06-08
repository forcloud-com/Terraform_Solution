using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllQueryArguments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchAllQueryArguments\"}}]")]
        public virtual void PutAllQueryArguments(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchAllQueryArguments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchAllQueryArguments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBody", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchBody\"}}]")]
        public virtual void PutBody(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchBody @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchBody)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchMethod\"}}]")]
        public virtual void PutMethod(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryString", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchQueryString\"}}]")]
        public virtual void PutQueryString(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchQueryString @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchQueryString)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSingleHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleHeader\"}}]")]
        public virtual void PutSingleHeader(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleHeader)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSingleQueryArgument", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgument\"}}]")]
        public virtual void PutSingleQueryArgument(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgument @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgument)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUriPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchUriPath\"}}]")]
        public virtual void PutUriPath(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchUriPath @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchUriPath)}, new object[]{@value});
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

        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchAllQueryArgumentsOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchAllQueryArgumentsOutputReference AllQueryArguments
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchAllQueryArgumentsOutputReference>()!;
        }

        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchBodyOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchBodyOutputReference Body
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchBodyOutputReference>()!;
        }

        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchMethodOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchMethodOutputReference Method
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchMethodOutputReference>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchQueryStringOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchQueryStringOutputReference QueryString
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchQueryStringOutputReference>()!;
        }

        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleHeaderOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleHeaderOutputReference SingleHeader
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleHeaderOutputReference>()!;
        }

        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgumentOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgumentOutputReference SingleQueryArgument
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgumentOutputReference>()!;
        }

        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchUriPathOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchUriPathOutputReference UriPath
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchUriPathOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allQueryArgumentsInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchAllQueryArguments? AllQueryArgumentsInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchAllQueryArguments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bodyInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchBody\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchBody? BodyInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchBody?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "methodInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchMethod\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchMethod? MethodInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchMethod?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchQueryString\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchQueryString? QueryStringInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchQueryString?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singleHeaderInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleHeader\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleHeader? SingleHeaderInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleHeader?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgumentInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgument? SingleQueryArgumentInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchSingleQueryArgument?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uriPathInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchUriPath\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchUriPath? UriPathInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatchUriPath?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatch\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatch? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSqliMatchStatementFieldToMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
