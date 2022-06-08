using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    #pragma warning disable CS8618

    /// <summary>API Gateway.</summary>
    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayMethodSettingsConfig")]
    public class ApiGatewayMethodSettingsConfig : aws.Apigateway.IApiGatewayMethodSettingsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#method_path ApiGatewayMethodSettings#method_path}.</summary>
        [JsiiProperty(name: "methodPath", typeJson: "{\"primitive\":\"string\"}")]
        public string MethodPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#rest_api_id ApiGatewayMethodSettings#rest_api_id}.</summary>
        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        public string RestApiId
        {
            get;
            set;
        }

        /// <summary>settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#settings ApiGatewayMethodSettings#settings}
        /// </remarks>
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayMethodSettingsSettings\"}")]
        public aws.Apigateway.IApiGatewayMethodSettingsSettings Settings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#stage_name ApiGatewayMethodSettings#stage_name}.</summary>
        [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}")]
        public string StageName
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
