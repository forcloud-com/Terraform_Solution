using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    /// <summary>AWS OpsWorks.</summary>
    [JsiiInterface(nativeType: typeof(IOpsworksApplicationConfig), fullyQualifiedName: "aws.opsworks.OpsworksApplicationConfig")]
    public interface IOpsworksApplicationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#name OpsworksApplication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#stack_id OpsworksApplication#stack_id}.</summary>
        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        string StackId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#type OpsworksApplication#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>app_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#app_source OpsworksApplication#app_source}
        /// </remarks>
        [JsiiProperty(name: "appSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksApplicationAppSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AppSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#auto_bundle_on_deploy OpsworksApplication#auto_bundle_on_deploy}.</summary>
        [JsiiProperty(name: "autoBundleOnDeploy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AutoBundleOnDeploy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#aws_flow_ruby_settings OpsworksApplication#aws_flow_ruby_settings}.</summary>
        [JsiiProperty(name: "awsFlowRubySettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsFlowRubySettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#data_source_arn OpsworksApplication#data_source_arn}.</summary>
        [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataSourceArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#data_source_database_name OpsworksApplication#data_source_database_name}.</summary>
        [JsiiProperty(name: "dataSourceDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataSourceDatabaseName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#data_source_type OpsworksApplication#data_source_type}.</summary>
        [JsiiProperty(name: "dataSourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataSourceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#description OpsworksApplication#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#document_root OpsworksApplication#document_root}.</summary>
        [JsiiProperty(name: "documentRoot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DocumentRoot
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#domains OpsworksApplication#domains}.</summary>
        [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Domains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#enable_ssl OpsworksApplication#enable_ssl}.</summary>
        [JsiiProperty(name: "enableSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableSsl
        {
            get
            {
                return null;
            }
        }

        /// <summary>environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#environment OpsworksApplication#environment}
        /// </remarks>
        [JsiiProperty(name: "environment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksApplicationEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Environment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#rails_env OpsworksApplication#rails_env}.</summary>
        [JsiiProperty(name: "railsEnv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RailsEnv
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#short_name OpsworksApplication#short_name}.</summary>
        [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShortName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssl_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#ssl_configuration OpsworksApplication#ssl_configuration}
        /// </remarks>
        [JsiiProperty(name: "sslConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksApplicationSslConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SslConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS OpsWorks.</summary>
        [JsiiTypeProxy(nativeType: typeof(IOpsworksApplicationConfig), fullyQualifiedName: "aws.opsworks.OpsworksApplicationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Opsworks.IOpsworksApplicationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#name OpsworksApplication#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#stack_id OpsworksApplication#stack_id}.</summary>
            [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
            public string StackId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#type OpsworksApplication#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>app_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#app_source OpsworksApplication#app_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksApplicationAppSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AppSource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#auto_bundle_on_deploy OpsworksApplication#auto_bundle_on_deploy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoBundleOnDeploy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AutoBundleOnDeploy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#aws_flow_ruby_settings OpsworksApplication#aws_flow_ruby_settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "awsFlowRubySettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsFlowRubySettings
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#data_source_arn OpsworksApplication#data_source_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataSourceArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#data_source_database_name OpsworksApplication#data_source_database_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataSourceDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataSourceDatabaseName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#data_source_type OpsworksApplication#data_source_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataSourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataSourceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#description OpsworksApplication#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#document_root OpsworksApplication#document_root}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "documentRoot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DocumentRoot
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#domains OpsworksApplication#domains}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Domains
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#enable_ssl OpsworksApplication#enable_ssl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableSsl
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>environment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#environment OpsworksApplication#environment}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksApplicationEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Environment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#rails_env OpsworksApplication#rails_env}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "railsEnv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RailsEnv
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#short_name OpsworksApplication#short_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShortName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ssl_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#ssl_configuration OpsworksApplication#ssl_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksApplicationSslConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SslConfiguration
            {
                get => GetInstanceProperty<object?>();
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
