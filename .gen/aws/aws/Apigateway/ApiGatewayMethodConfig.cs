using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    #pragma warning disable CS8618

    /// <summary>API Gateway.</summary>
    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayMethodConfig")]
    public class ApiGatewayMethodConfig : aws.Apigateway.IApiGatewayMethodConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method#authorization ApiGatewayMethod#authorization}.</summary>
        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public string Authorization
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method#http_method ApiGatewayMethod#http_method}.</summary>
        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
        public string HttpMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method#resource_id ApiGatewayMethod#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method#rest_api_id ApiGatewayMethod#rest_api_id}.</summary>
        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        public string RestApiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method#api_key_required ApiGatewayMethod#api_key_required}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "apiKeyRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ApiKeyRequired
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method#authorization_scopes ApiGatewayMethod#authorization_scopes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizationScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AuthorizationScopes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method#authorizer_id ApiGatewayMethod#authorizer_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthorizerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method#request_models ApiGatewayMethod#request_models}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestModels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? RequestModels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method#request_parameters ApiGatewayMethod#request_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestParameters", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, object>? RequestParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method#request_parameters_in_json ApiGatewayMethod#request_parameters_in_json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestParametersInJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestParametersInJson
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method#request_validator_id ApiGatewayMethod#request_validator_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestValidatorId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestValidatorId
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
