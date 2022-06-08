using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    /// <summary>Amazon API Gateway Websocket and HTTP APIs.</summary>
    [JsiiInterface(nativeType: typeof(IApigatewayv2RouteConfig), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2RouteConfig")]
    public interface IApigatewayv2RouteConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#api_id Apigatewayv2Route#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#route_key Apigatewayv2Route#route_key}.</summary>
        [JsiiProperty(name: "routeKey", typeJson: "{\"primitive\":\"string\"}")]
        string RouteKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#api_key_required Apigatewayv2Route#api_key_required}.</summary>
        [JsiiProperty(name: "apiKeyRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApiKeyRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#authorization_scopes Apigatewayv2Route#authorization_scopes}.</summary>
        [JsiiProperty(name: "authorizationScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AuthorizationScopes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#authorization_type Apigatewayv2Route#authorization_type}.</summary>
        [JsiiProperty(name: "authorizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorizationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#authorizer_id Apigatewayv2Route#authorizer_id}.</summary>
        [JsiiProperty(name: "authorizerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorizerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#model_selection_expression Apigatewayv2Route#model_selection_expression}.</summary>
        [JsiiProperty(name: "modelSelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModelSelectionExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#operation_name Apigatewayv2Route#operation_name}.</summary>
        [JsiiProperty(name: "operationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperationName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#request_models Apigatewayv2Route#request_models}.</summary>
        [JsiiProperty(name: "requestModels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? RequestModels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#route_response_selection_expression Apigatewayv2Route#route_response_selection_expression}.</summary>
        [JsiiProperty(name: "routeResponseSelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RouteResponseSelectionExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#target Apigatewayv2Route#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>Amazon API Gateway Websocket and HTTP APIs.</summary>
        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2RouteConfig), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2RouteConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2.IApigatewayv2RouteConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#api_id Apigatewayv2Route#api_id}.</summary>
            [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#route_key Apigatewayv2Route#route_key}.</summary>
            [JsiiProperty(name: "routeKey", typeJson: "{\"primitive\":\"string\"}")]
            public string RouteKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#api_key_required Apigatewayv2Route#api_key_required}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "apiKeyRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ApiKeyRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#authorization_scopes Apigatewayv2Route#authorization_scopes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizationScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AuthorizationScopes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#authorization_type Apigatewayv2Route#authorization_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorizationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#authorizer_id Apigatewayv2Route#authorizer_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorizerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#model_selection_expression Apigatewayv2Route#model_selection_expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelSelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelSelectionExpression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#operation_name Apigatewayv2Route#operation_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperationName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#request_models Apigatewayv2Route#request_models}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requestModels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? RequestModels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#route_response_selection_expression Apigatewayv2Route#route_response_selection_expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routeResponseSelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RouteResponseSelectionExpression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_route#target Apigatewayv2Route#target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
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
