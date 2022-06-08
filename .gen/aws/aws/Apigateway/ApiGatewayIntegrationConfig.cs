using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    #pragma warning disable CS8618

    /// <summary>API Gateway.</summary>
    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayIntegrationConfig")]
    public class ApiGatewayIntegrationConfig : aws.Apigateway.IApiGatewayIntegrationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#http_method ApiGatewayIntegration#http_method}.</summary>
        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
        public string HttpMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#resource_id ApiGatewayIntegration#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#rest_api_id ApiGatewayIntegration#rest_api_id}.</summary>
        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        public string RestApiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#type ApiGatewayIntegration#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#cache_key_parameters ApiGatewayIntegration#cache_key_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheKeyParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CacheKeyParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#cache_namespace ApiGatewayIntegration#cache_namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CacheNamespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#connection_id ApiGatewayIntegration#connection_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#connection_type ApiGatewayIntegration#connection_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#content_handling ApiGatewayIntegration#content_handling}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentHandling
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#credentials ApiGatewayIntegration#credentials}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "credentials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Credentials
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#integration_http_method ApiGatewayIntegration#integration_http_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "integrationHttpMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IntegrationHttpMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#passthrough_behavior ApiGatewayIntegration#passthrough_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passthroughBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PassthroughBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#request_parameters ApiGatewayIntegration#request_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? RequestParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#request_parameters_in_json ApiGatewayIntegration#request_parameters_in_json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestParametersInJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestParametersInJson
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#request_templates ApiGatewayIntegration#request_templates}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestTemplates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? RequestTemplates
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#timeout_milliseconds ApiGatewayIntegration#timeout_milliseconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutMilliseconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration#uri ApiGatewayIntegration#uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uri
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
