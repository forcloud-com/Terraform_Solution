using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    /// <summary>AWS AppSync.</summary>
    [JsiiInterface(nativeType: typeof(IAppsyncFunctionConfig), fullyQualifiedName: "aws.appsync.AppsyncFunctionConfig")]
    public interface IAppsyncFunctionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#api_id AppsyncFunction#api_id}.</summary>
        [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#data_source AppsyncFunction#data_source}.</summary>
        [JsiiProperty(name: "dataSource", typeJson: "{\"primitive\":\"string\"}")]
        string DataSource
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#name AppsyncFunction#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#request_mapping_template AppsyncFunction#request_mapping_template}.</summary>
        [JsiiProperty(name: "requestMappingTemplate", typeJson: "{\"primitive\":\"string\"}")]
        string RequestMappingTemplate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#response_mapping_template AppsyncFunction#response_mapping_template}.</summary>
        [JsiiProperty(name: "responseMappingTemplate", typeJson: "{\"primitive\":\"string\"}")]
        string ResponseMappingTemplate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#description AppsyncFunction#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#function_version AppsyncFunction#function_version}.</summary>
        [JsiiProperty(name: "functionVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FunctionVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS AppSync.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAppsyncFunctionConfig), fullyQualifiedName: "aws.appsync.AppsyncFunctionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Appsync.IAppsyncFunctionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#api_id AppsyncFunction#api_id}.</summary>
            [JsiiProperty(name: "apiId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#data_source AppsyncFunction#data_source}.</summary>
            [JsiiProperty(name: "dataSource", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSource
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#name AppsyncFunction#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#request_mapping_template AppsyncFunction#request_mapping_template}.</summary>
            [JsiiProperty(name: "requestMappingTemplate", typeJson: "{\"primitive\":\"string\"}")]
            public string RequestMappingTemplate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#response_mapping_template AppsyncFunction#response_mapping_template}.</summary>
            [JsiiProperty(name: "responseMappingTemplate", typeJson: "{\"primitive\":\"string\"}")]
            public string ResponseMappingTemplate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#description AppsyncFunction#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_function#function_version AppsyncFunction#function_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "functionVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FunctionVersion
            {
                get => GetInstanceProperty<string?>();
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
