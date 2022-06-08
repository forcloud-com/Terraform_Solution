using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_integration_response aws_apigatewayv2_integration_response}.</summary>
    [JsiiClass(nativeType: typeof(aws.Apigatewayv2.Apigatewayv2IntegrationResponse), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2IntegrationResponse", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2IntegrationResponseConfig\"}}]")]
    public class Apigatewayv2IntegrationResponse : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_integration_response aws_apigatewayv2_integration_response} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Apigatewayv2IntegrationResponse(Constructs.Construct scope, string id, aws.Apigatewayv2.IApigatewayv2IntegrationResponseConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2IntegrationResponse(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2IntegrationResponse(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetContentHandlingStrategy")]
        public virtual void ResetContentHandlingStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseTemplates")]
        public virtual void ResetResponseTemplates()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTemplateSelectionExpression")]
        public virtual void ResetTemplateSelectionExpression()
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
        = GetStaticProperty<string>(typeof(aws.Apigatewayv2.Apigatewayv2IntegrationResponse))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentHandlingStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContentHandlingStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "integrationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IntegrationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "integrationResponseKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IntegrationResponseKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseTemplatesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ResponseTemplatesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "templateSelectionExpressionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TemplateSelectionExpressionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contentHandlingStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentHandlingStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "integrationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IntegrationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "integrationResponseKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IntegrationResponseKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseTemplates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> ResponseTemplates
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "templateSelectionExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TemplateSelectionExpression
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
