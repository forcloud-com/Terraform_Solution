using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllQueryArguments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments\"}}]")]
        public virtual void PutAllQueryArguments(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBody", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody\"}}]")]
        public virtual void PutBody(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMethod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod\"}}]")]
        public virtual void PutMethod(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryString", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString\"}}]")]
        public virtual void PutQueryString(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSingleHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader\"}}]")]
        public virtual void PutSingleHeader(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSingleQueryArgument", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument\"}}]")]
        public virtual void PutSingleQueryArgument(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUriPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath\"}}]")]
        public virtual void PutUriPath(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath)}, new object[]{@value});
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

        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArgumentsOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArgumentsOutputReference AllQueryArguments
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArgumentsOutputReference>()!;
        }

        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBodyOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBodyOutputReference Body
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBodyOutputReference>()!;
        }

        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethodOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethodOutputReference Method
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethodOutputReference>()!;
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryStringOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryStringOutputReference QueryString
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryStringOutputReference>()!;
        }

        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeaderOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeaderOutputReference SingleHeader
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeaderOutputReference>()!;
        }

        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgumentOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgumentOutputReference SingleQueryArgument
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgumentOutputReference>()!;
        }

        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPathOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPathOutputReference UriPath
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPathOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allQueryArgumentsInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments? AllQueryArgumentsInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bodyInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody? BodyInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchBody?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "methodInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod? MethodInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchMethod?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString? QueryStringInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchQueryString?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singleHeaderInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader? SingleHeaderInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleHeader?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgumentInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument? SingleQueryArgumentInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uriPathInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath? UriPathInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatchUriPath?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatch\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatch? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementAndStatementStatementSizeConstraintStatementFieldToMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
