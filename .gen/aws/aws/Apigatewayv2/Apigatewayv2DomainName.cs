using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name aws_apigatewayv2_domain_name}.</summary>
    [JsiiClass(nativeType: typeof(aws.Apigatewayv2.Apigatewayv2DomainName), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2DomainName", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2DomainNameConfig\"}}]")]
    public class Apigatewayv2DomainName : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_domain_name aws_apigatewayv2_domain_name} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Apigatewayv2DomainName(Constructs.Construct scope, string id, aws.Apigatewayv2.IApigatewayv2DomainNameConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2DomainName(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2DomainName(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDomainNameConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2DomainNameDomainNameConfiguration\"}}]")]
        public virtual void PutDomainNameConfiguration(aws.Apigatewayv2.IApigatewayv2DomainNameDomainNameConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigatewayv2.IApigatewayv2DomainNameDomainNameConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2DomainNameTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Apigatewayv2.IApigatewayv2DomainNameTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigatewayv2.IApigatewayv2DomainNameTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Apigatewayv2.Apigatewayv2DomainName))!;

        [JsiiProperty(name: "apiMappingSelectionExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiMappingSelectionExpression
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainNameConfiguration", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2DomainNameDomainNameConfigurationOutputReference\"}")]
        public virtual aws.Apigatewayv2.Apigatewayv2DomainNameDomainNameConfigurationOutputReference DomainNameConfiguration
        {
            get => GetInstanceProperty<aws.Apigatewayv2.Apigatewayv2DomainNameDomainNameConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2DomainNameTimeoutsOutputReference\"}")]
        public virtual aws.Apigatewayv2.Apigatewayv2DomainNameTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Apigatewayv2.Apigatewayv2DomainNameTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameConfigurationInput", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2DomainNameDomainNameConfiguration\"}", isOptional: true)]
        public virtual aws.Apigatewayv2.IApigatewayv2DomainNameDomainNameConfiguration? DomainNameConfigurationInput
        {
            get => GetInstanceProperty<aws.Apigatewayv2.IApigatewayv2DomainNameDomainNameConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2DomainNameTimeouts\"}", isOptional: true)]
        public virtual aws.Apigatewayv2.IApigatewayv2DomainNameTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Apigatewayv2.IApigatewayv2DomainNameTimeouts?>();
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
