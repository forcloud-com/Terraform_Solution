using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    #pragma warning disable CS8618

    /// <summary>API Gateway.</summary>
    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayStageConfig")]
    public class ApiGatewayStageConfig : aws.Apigateway.IApiGatewayStageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#deployment_id ApiGatewayStage#deployment_id}.</summary>
        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}")]
        public string DeploymentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#rest_api_id ApiGatewayStage#rest_api_id}.</summary>
        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        public string RestApiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#stage_name ApiGatewayStage#stage_name}.</summary>
        [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}")]
        public string StageName
        {
            get;
            set;
        }

        /// <summary>access_log_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#access_log_settings ApiGatewayStage#access_log_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessLogSettings", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayStageAccessLogSettings\"}", isOptional: true)]
        public aws.Apigateway.IApiGatewayStageAccessLogSettings? AccessLogSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#cache_cluster_enabled ApiGatewayStage#cache_cluster_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheClusterEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CacheClusterEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#cache_cluster_size ApiGatewayStage#cache_cluster_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheClusterSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CacheClusterSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#client_certificate_id ApiGatewayStage#client_certificate_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificateId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCertificateId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#description ApiGatewayStage#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#documentation_version ApiGatewayStage#documentation_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "documentationVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DocumentationVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#tags ApiGatewayStage#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#variables ApiGatewayStage#variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "variables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Variables
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_stage#xray_tracing_enabled ApiGatewayStage#xray_tracing_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "xrayTracingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? XrayTracingEnabled
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
