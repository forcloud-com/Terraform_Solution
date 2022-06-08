using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    /// <summary>API Gateway.</summary>
    [JsiiInterface(nativeType: typeof(IApiGatewayMethodSettingsConfig), fullyQualifiedName: "aws.apigateway.ApiGatewayMethodSettingsConfig")]
    public interface IApiGatewayMethodSettingsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#method_path ApiGatewayMethodSettings#method_path}.</summary>
        [JsiiProperty(name: "methodPath", typeJson: "{\"primitive\":\"string\"}")]
        string MethodPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#rest_api_id ApiGatewayMethodSettings#rest_api_id}.</summary>
        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        string RestApiId
        {
            get;
        }

        /// <summary>settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#settings ApiGatewayMethodSettings#settings}
        /// </remarks>
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayMethodSettingsSettings\"}")]
        aws.Apigateway.IApiGatewayMethodSettingsSettings Settings
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#stage_name ApiGatewayMethodSettings#stage_name}.</summary>
        [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}")]
        string StageName
        {
            get;
        }

        /// <summary>API Gateway.</summary>
        [JsiiTypeProxy(nativeType: typeof(IApiGatewayMethodSettingsConfig), fullyQualifiedName: "aws.apigateway.ApiGatewayMethodSettingsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayMethodSettingsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#method_path ApiGatewayMethodSettings#method_path}.</summary>
            [JsiiProperty(name: "methodPath", typeJson: "{\"primitive\":\"string\"}")]
            public string MethodPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#rest_api_id ApiGatewayMethodSettings#rest_api_id}.</summary>
            [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
            public string RestApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#settings ApiGatewayMethodSettings#settings}
            /// </remarks>
            [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayMethodSettingsSettings\"}")]
            public aws.Apigateway.IApiGatewayMethodSettingsSettings Settings
            {
                get => GetInstanceProperty<aws.Apigateway.IApiGatewayMethodSettingsSettings>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#stage_name ApiGatewayMethodSettings#stage_name}.</summary>
            [JsiiProperty(name: "stageName", typeJson: "{\"primitive\":\"string\"}")]
            public string StageName
            {
                get => GetInstanceProperty<string>()!;
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
