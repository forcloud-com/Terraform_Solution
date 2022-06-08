using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    /// <summary>API Gateway.</summary>
    [JsiiInterface(nativeType: typeof(IApiGatewayDocumentationPartConfig), fullyQualifiedName: "aws.apigateway.ApiGatewayDocumentationPartConfig")]
    public interface IApiGatewayDocumentationPartConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_documentation_part#location ApiGatewayDocumentationPart#location}
        /// </remarks>
        [JsiiProperty(name: "location", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayDocumentationPartLocation\"}")]
        aws.Apigateway.IApiGatewayDocumentationPartLocation Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_documentation_part#properties ApiGatewayDocumentationPart#properties}.</summary>
        [JsiiProperty(name: "properties", typeJson: "{\"primitive\":\"string\"}")]
        string Properties
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_documentation_part#rest_api_id ApiGatewayDocumentationPart#rest_api_id}.</summary>
        [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
        string RestApiId
        {
            get;
        }

        /// <summary>API Gateway.</summary>
        [JsiiTypeProxy(nativeType: typeof(IApiGatewayDocumentationPartConfig), fullyQualifiedName: "aws.apigateway.ApiGatewayDocumentationPartConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Apigateway.IApiGatewayDocumentationPartConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_documentation_part#location ApiGatewayDocumentationPart#location}
            /// </remarks>
            [JsiiProperty(name: "location", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayDocumentationPartLocation\"}")]
            public aws.Apigateway.IApiGatewayDocumentationPartLocation Location
            {
                get => GetInstanceProperty<aws.Apigateway.IApiGatewayDocumentationPartLocation>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_documentation_part#properties ApiGatewayDocumentationPart#properties}.</summary>
            [JsiiProperty(name: "properties", typeJson: "{\"primitive\":\"string\"}")]
            public string Properties
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_documentation_part#rest_api_id ApiGatewayDocumentationPart#rest_api_id}.</summary>
            [JsiiProperty(name: "restApiId", typeJson: "{\"primitive\":\"string\"}")]
            public string RestApiId
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
