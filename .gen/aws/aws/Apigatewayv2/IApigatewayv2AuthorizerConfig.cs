using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    /// <summary>Amazon API Gateway Websocket and HTTP APIs.</summary>
    [JsiiInterface(nativeType: typeof(IApigatewayv2AuthorizerConfig), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2AuthorizerConfig")]
    public interface IApigatewayv2AuthorizerConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#api_id Apigatewayv2Authorizer#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#authorizer_type Apigatewayv2Authorizer#authorizer_type}.</summary>
        [JsiiProperty(name: "authorizerType", typeJson: "{\"primitive\":\"string\"}")]
        string AuthorizerType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#identity_sources Apigatewayv2Authorizer#identity_sources}.</summary>
        [JsiiProperty(name: "identitySources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] IdentitySources
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#name Apigatewayv2Authorizer#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#authorizer_credentials_arn Apigatewayv2Authorizer#authorizer_credentials_arn}.</summary>
        [JsiiProperty(name: "authorizerCredentialsArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorizerCredentialsArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#authorizer_uri Apigatewayv2Authorizer#authorizer_uri}.</summary>
        [JsiiProperty(name: "authorizerUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorizerUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>jwt_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#jwt_configuration Apigatewayv2Authorizer#jwt_configuration}
        /// </remarks>
        [JsiiProperty(name: "jwtConfiguration", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2AuthorizerJwtConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Apigatewayv2.IApigatewayv2AuthorizerJwtConfiguration? JwtConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Amazon API Gateway Websocket and HTTP APIs.</summary>
        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2AuthorizerConfig), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2AuthorizerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2.IApigatewayv2AuthorizerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#api_id Apigatewayv2Authorizer#api_id}.</summary>
            [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#authorizer_type Apigatewayv2Authorizer#authorizer_type}.</summary>
            [JsiiProperty(name: "authorizerType", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthorizerType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#identity_sources Apigatewayv2Authorizer#identity_sources}.</summary>
            [JsiiProperty(name: "identitySources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] IdentitySources
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#name Apigatewayv2Authorizer#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#authorizer_credentials_arn Apigatewayv2Authorizer#authorizer_credentials_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizerCredentialsArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorizerCredentialsArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#authorizer_uri Apigatewayv2Authorizer#authorizer_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizerUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorizerUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>jwt_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_authorizer#jwt_configuration Apigatewayv2Authorizer#jwt_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jwtConfiguration", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2AuthorizerJwtConfiguration\"}", isOptional: true)]
            public aws.Apigatewayv2.IApigatewayv2AuthorizerJwtConfiguration? JwtConfiguration
            {
                get => GetInstanceProperty<aws.Apigatewayv2.IApigatewayv2AuthorizerJwtConfiguration?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
