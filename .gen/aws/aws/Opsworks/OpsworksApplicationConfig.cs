using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    #pragma warning disable CS8618

    /// <summary>AWS OpsWorks.</summary>
    [JsiiByValue(fqn: "aws.opsworks.OpsworksApplicationConfig")]
    public class OpsworksApplicationConfig : aws.Opsworks.IOpsworksApplicationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#name OpsworksApplication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#stack_id OpsworksApplication#stack_id}.</summary>
        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        public string StackId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#type OpsworksApplication#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>app_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#app_source OpsworksApplication#app_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appSource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksApplicationAppSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AppSource
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#auto_bundle_on_deploy OpsworksApplication#auto_bundle_on_deploy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoBundleOnDeploy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutoBundleOnDeploy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#aws_flow_ruby_settings OpsworksApplication#aws_flow_ruby_settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsFlowRubySettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AwsFlowRubySettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#data_source_arn OpsworksApplication#data_source_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataSourceArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataSourceArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#data_source_database_name OpsworksApplication#data_source_database_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataSourceDatabaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataSourceDatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#data_source_type OpsworksApplication#data_source_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataSourceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataSourceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#description OpsworksApplication#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#document_root OpsworksApplication#document_root}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "documentRoot", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DocumentRoot
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#domains OpsworksApplication#domains}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Domains
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#enable_ssl OpsworksApplication#enable_ssl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableSsl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableSsl
        {
            get;
            set;
        }

        /// <summary>environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#environment OpsworksApplication#environment}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksApplicationEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Environment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#rails_env OpsworksApplication#rails_env}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "railsEnv", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RailsEnv
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#short_name OpsworksApplication#short_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shortName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShortName
        {
            get;
            set;
        }

        /// <summary>ssl_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_application#ssl_configuration OpsworksApplication#ssl_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksApplicationSslConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SslConfiguration
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
