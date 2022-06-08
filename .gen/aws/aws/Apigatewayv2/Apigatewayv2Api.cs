using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_api aws_apigatewayv2_api}.</summary>
    [JsiiClass(nativeType: typeof(aws.Apigatewayv2.Apigatewayv2Api), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2Api", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2ApiConfig\"}}]")]
    public class Apigatewayv2Api : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_api aws_apigatewayv2_api} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Apigatewayv2Api(Constructs.Construct scope, string id, aws.Apigatewayv2.IApigatewayv2ApiConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2Api(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2Api(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCorsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2ApiCorsConfiguration\"}}]")]
        public virtual void PutCorsConfiguration(aws.Apigatewayv2.IApigatewayv2ApiCorsConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigatewayv2.IApigatewayv2ApiCorsConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiKeySelectionExpression")]
        public virtual void ResetApiKeySelectionExpression()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCorsConfiguration")]
        public virtual void ResetCorsConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentialsArn")]
        public virtual void ResetCredentialsArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRouteKey")]
        public virtual void ResetRouteKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRouteSelectionExpression")]
        public virtual void ResetRouteSelectionExpression()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTarget")]
        public virtual void ResetTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
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
        = GetStaticProperty<string>(typeof(aws.Apigatewayv2.Apigatewayv2Api))!;

        [JsiiProperty(name: "apiEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "corsConfiguration", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2ApiCorsConfigurationOutputReference\"}")]
        public virtual aws.Apigatewayv2.Apigatewayv2ApiCorsConfigurationOutputReference CorsConfiguration
        {
            get => GetInstanceProperty<aws.Apigatewayv2.Apigatewayv2ApiCorsConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "executionArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiKeySelectionExpressionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiKeySelectionExpressionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsConfigurationInput", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2ApiCorsConfiguration\"}", isOptional: true)]
        public virtual aws.Apigatewayv2.IApigatewayv2ApiCorsConfiguration? CorsConfigurationInput
        {
            get => GetInstanceProperty<aws.Apigatewayv2.IApigatewayv2ApiCorsConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CredentialsArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RouteKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeSelectionExpressionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RouteSelectionExpressionInput
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
        [JsiiProperty(name: "targetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apiKeySelectionExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiKeySelectionExpression
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "credentialsArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CredentialsArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtocolType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RouteKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routeSelectionExpression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RouteSelectionExpression
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

        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Target
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
