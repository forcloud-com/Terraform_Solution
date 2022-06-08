using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    #pragma warning disable CS8618

    /// <summary>API Gateway.</summary>
    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayIntegrationResponseConfig")]
    public class ApiGatewayIntegrationResponseConfig : aws.Apigateway.IApiGatewayIntegrationResponseConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration_response#http_method ApiGatewayIntegrationResponse#http_method}.</summary>
        [JsiiProperty(name: "httpMethod", typeJson: "{\"primitive\":\"string\"}")]
        public string HttpMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration_response#resource_id ApiGatewayIntegrationResponse#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration_response#rest_api_id ApiGatewayIntegrationResponse#rest_api_id}.</summary>
        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        public string RestApiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration_response#status_code ApiGatewayIntegrationResponse#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}")]
        public string StatusCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration_response#content_handling ApiGatewayIntegrationResponse#content_handling}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentHandling", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentHandling
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration_response#response_parameters ApiGatewayIntegrationResponse#response_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? ResponseParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration_response#response_parameters_in_json ApiGatewayIntegrationResponse#response_parameters_in_json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseParametersInJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseParametersInJson
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration_response#response_templates ApiGatewayIntegrationResponse#response_templates}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseTemplates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? ResponseTemplates
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_integration_response#selection_pattern ApiGatewayIntegrationResponse#selection_pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selectionPattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SelectionPattern
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
