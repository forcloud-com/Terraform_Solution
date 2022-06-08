using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    /// <summary>API Gateway.</summary>
    [JsiiInterface(nativeType: typeof(IApiGatewayRequestValidatorConfig), fullyQualifiedName: "aws.apigateway.ApiGatewayRequestValidatorConfig")]
    public interface IApiGatewayRequestValidatorConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_request_validator#name ApiGatewayRequestValidator#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_request_validator#rest_api_id ApiGatewayRequestValidator#rest_api_id}.</summary>
        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        string RestApiId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_request_validator#validate_request_body ApiGatewayRequestValidator#validate_request_body}.</summary>
        [JsiiProperty(name: "validateRequestBody", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ValidateRequestBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_request_validator#validate_request_parameters ApiGatewayRequestValidator#validate_request_parameters}.</summary>
        [JsiiProperty(name: "validateRequestParameters", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ValidateRequestParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>API Gateway.</summary>
        [JsiiTypeProxy(nativeType: typeof(IApiGatewayRequestValidatorConfig), fullyQualifiedName: "aws.apigateway.ApiGatewayRequestValidatorConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayRequestValidatorConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_request_validator#name ApiGatewayRequestValidator#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_request_validator#rest_api_id ApiGatewayRequestValidator#rest_api_id}.</summary>
            [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
            public string RestApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_request_validator#validate_request_body ApiGatewayRequestValidator#validate_request_body}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validateRequestBody", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ValidateRequestBody
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_request_validator#validate_request_parameters ApiGatewayRequestValidator#validate_request_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validateRequestParameters", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ValidateRequestParameters
            {
                get => GetInstanceProperty<object?>();
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
