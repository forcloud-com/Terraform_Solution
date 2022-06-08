using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    #pragma warning disable CS8618

    /// <summary>Amazon API Gateway Websocket and HTTP APIs.</summary>
    [JsiiByValue(fqn: "aws.apigatewayv2.Apigatewayv2IntegrationResponseConfig")]
    public class Apigatewayv2IntegrationResponseConfig : aws.Apigatewayv2.IApigatewayv2IntegrationResponseConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_integration_response#api_id Apigatewayv2IntegrationResponse#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_integration_response#integration_id Apigatewayv2IntegrationResponse#integration_id}.</summary>
        [JsiiProperty(name: "integrationId", typeJson: "{\"primitive\":\"string\"}")]
        public string IntegrationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_integration_response#integration_response_key Apigatewayv2IntegrationResponse#integration_response_key}.</summary>
        [JsiiProperty(name: "integrationResponseKey", typeJson: "{\"primitive\":\"string\"}")]
        public string IntegrationResponseKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_integration_response#content_handling_strategy Apigatewayv2IntegrationResponse#content_handling_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentHandlingStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentHandlingStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_integration_response#response_templates Apigatewayv2IntegrationResponse#response_templates}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseTemplates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? ResponseTemplates
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_integration_response#template_selection_expression Apigatewayv2IntegrationResponse#template_selection_expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "templateSelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TemplateSelectionExpression
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
