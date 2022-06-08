using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    /// <summary>API Gateway.</summary>
    [JsiiInterface(nativeType: typeof(IApiGatewayUsagePlanConfig), fullyQualifiedName: "aws.apigateway.ApiGatewayUsagePlanConfig")]
    public interface IApiGatewayUsagePlanConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#name ApiGatewayUsagePlan#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>api_stages block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#api_stages ApiGatewayUsagePlan#api_stages}
        /// </remarks>
        [JsiiProperty(name: "apiStages", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanApiStages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApiStages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#description ApiGatewayUsagePlan#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#product_code ApiGatewayUsagePlan#product_code}.</summary>
        [JsiiProperty(name: "productCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProductCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>quota_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#quota_settings ApiGatewayUsagePlan#quota_settings}
        /// </remarks>
        [JsiiProperty(name: "quotaSettings", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanQuotaSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Apigateway.IApiGatewayUsagePlanQuotaSettings? QuotaSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#tags ApiGatewayUsagePlan#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>throttle_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#throttle_settings ApiGatewayUsagePlan#throttle_settings}
        /// </remarks>
        [JsiiProperty(name: "throttleSettings", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanThrottleSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Apigateway.IApiGatewayUsagePlanThrottleSettings? ThrottleSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>API Gateway.</summary>
        [JsiiTypeProxy(nativeType: typeof(IApiGatewayUsagePlanConfig), fullyQualifiedName: "aws.apigateway.ApiGatewayUsagePlanConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayUsagePlanConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#name ApiGatewayUsagePlan#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>api_stages block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#api_stages ApiGatewayUsagePlan#api_stages}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiStages", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanApiStages\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApiStages
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#description ApiGatewayUsagePlan#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#product_code ApiGatewayUsagePlan#product_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "productCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProductCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>quota_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#quota_settings ApiGatewayUsagePlan#quota_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "quotaSettings", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanQuotaSettings\"}", isOptional: true)]
            public aws.Apigateway.IApiGatewayUsagePlanQuotaSettings? QuotaSettings
            {
                get => GetInstanceProperty<aws.Apigateway.IApiGatewayUsagePlanQuotaSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#tags ApiGatewayUsagePlan#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>throttle_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_usage_plan#throttle_settings ApiGatewayUsagePlan#throttle_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "throttleSettings", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanThrottleSettings\"}", isOptional: true)]
            public aws.Apigateway.IApiGatewayUsagePlanThrottleSettings? ThrottleSettings
            {
                get => GetInstanceProperty<aws.Apigateway.IApiGatewayUsagePlanThrottleSettings?>();
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
