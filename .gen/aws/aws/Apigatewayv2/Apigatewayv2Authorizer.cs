using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer aws_apigatewayv2_authorizer}.</summary>
    [JsiiClass(nativeType: typeof(aws.Apigatewayv2.Apigatewayv2Authorizer), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2Authorizer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2AuthorizerConfig\"}}]")]
    public class Apigatewayv2Authorizer : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer aws_apigatewayv2_authorizer} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Apigatewayv2Authorizer(Constructs.Construct scope, string id, aws.Apigatewayv2.IApigatewayv2AuthorizerConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2Authorizer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2Authorizer(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putJwtConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2AuthorizerJwtConfiguration\"}}]")]
        public virtual void PutJwtConfiguration(aws.Apigatewayv2.IApigatewayv2AuthorizerJwtConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Apigatewayv2.IApigatewayv2AuthorizerJwtConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthorizerCredentialsArn")]
        public virtual void ResetAuthorizerCredentialsArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorizerUri")]
        public virtual void ResetAuthorizerUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJwtConfiguration")]
        public virtual void ResetJwtConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.Apigatewayv2.Apigatewayv2Authorizer))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jwtConfiguration", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2AuthorizerJwtConfigurationOutputReference\"}")]
        public virtual aws.Apigatewayv2.Apigatewayv2AuthorizerJwtConfigurationOutputReference JwtConfiguration
        {
            get => GetInstanceProperty<aws.Apigatewayv2.Apigatewayv2AuthorizerJwtConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizerCredentialsArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizerCredentialsArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizerTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizerTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizerUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizerUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identitySourcesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IdentitySourcesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jwtConfigurationInput", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2AuthorizerJwtConfiguration\"}", isOptional: true)]
        public virtual aws.Apigatewayv2.IApigatewayv2AuthorizerJwtConfiguration? JwtConfigurationInput
        {
            get => GetInstanceProperty<aws.Apigatewayv2.IApigatewayv2AuthorizerJwtConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorizerCredentialsArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizerCredentialsArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorizerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizerType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorizerUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizerUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "identitySources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdentitySources
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
