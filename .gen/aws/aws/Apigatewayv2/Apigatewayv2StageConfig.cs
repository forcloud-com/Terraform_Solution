using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    #pragma warning disable CS8618

    /// <summary>Amazon API Gateway Websocket and HTTP APIs.</summary>
    [JsiiByValue(fqn: "aws.apigatewayv2.Apigatewayv2StageConfig")]
    public class Apigatewayv2StageConfig : aws.Apigatewayv2.IApigatewayv2StageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#api_id Apigatewayv2Stage#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#name Apigatewayv2Stage#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>access_log_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#access_log_settings Apigatewayv2Stage#access_log_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessLogSettings", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2StageAccessLogSettings\"}", isOptional: true)]
        public aws.Apigatewayv2.IApigatewayv2StageAccessLogSettings? AccessLogSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#auto_deploy Apigatewayv2Stage#auto_deploy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoDeploy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoDeploy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#client_certificate_id Apigatewayv2Stage#client_certificate_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCertificateId
        {
            get;
            set;
        }

        /// <summary>default_route_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#default_route_settings Apigatewayv2Stage#default_route_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultRouteSettings", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2StageDefaultRouteSettings\"}", isOptional: true)]
        public aws.Apigatewayv2.IApigatewayv2StageDefaultRouteSettings? DefaultRouteSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#deployment_id Apigatewayv2Stage#deployment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeploymentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#description Apigatewayv2Stage#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>route_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#route_settings Apigatewayv2Stage#route_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routeSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigatewayv2.Apigatewayv2StageRouteSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RouteSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#stage_variables Apigatewayv2Stage#stage_variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stageVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? StageVariables
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apigatewayv2_stage#tags Apigatewayv2Stage#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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
