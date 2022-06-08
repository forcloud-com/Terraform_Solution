using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    #pragma warning disable CS8618

    /// <summary>AWS OpsWorks.</summary>
    [JsiiByValue(fqn: "aws.opsworks.OpsworksJavaAppLayerConfig")]
    public class OpsworksJavaAppLayerConfig : aws.Opsworks.IOpsworksJavaAppLayerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#stack_id OpsworksJavaAppLayer#stack_id}.</summary>
        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        public string StackId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#app_server OpsworksJavaAppLayer#app_server}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appServer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppServer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#app_server_version OpsworksJavaAppLayer#app_server_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "appServerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AppServerVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#auto_assign_elastic_ips OpsworksJavaAppLayer#auto_assign_elastic_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoAssignElasticIps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoAssignElasticIps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#auto_assign_public_ips OpsworksJavaAppLayer#auto_assign_public_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoAssignPublicIps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoAssignPublicIps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#auto_healing OpsworksJavaAppLayer#auto_healing}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoHealing", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoHealing
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#custom_configure_recipes OpsworksJavaAppLayer#custom_configure_recipes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customConfigureRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CustomConfigureRecipes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#custom_deploy_recipes OpsworksJavaAppLayer#custom_deploy_recipes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customDeployRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CustomDeployRecipes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#custom_instance_profile_arn OpsworksJavaAppLayer#custom_instance_profile_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customInstanceProfileArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomInstanceProfileArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#custom_json OpsworksJavaAppLayer#custom_json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomJson
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#custom_security_group_ids OpsworksJavaAppLayer#custom_security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CustomSecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#custom_setup_recipes OpsworksJavaAppLayer#custom_setup_recipes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customSetupRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CustomSetupRecipes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#custom_shutdown_recipes OpsworksJavaAppLayer#custom_shutdown_recipes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customShutdownRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CustomShutdownRecipes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#custom_undeploy_recipes OpsworksJavaAppLayer#custom_undeploy_recipes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customUndeployRecipes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CustomUndeployRecipes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#drain_elb_on_shutdown OpsworksJavaAppLayer#drain_elb_on_shutdown}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "drainElbOnShutdown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DrainElbOnShutdown
        {
            get;
            set;
        }

        /// <summary>ebs_volume block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#ebs_volume OpsworksJavaAppLayer#ebs_volume}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebsVolume", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksJavaAppLayerEbsVolume\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EbsVolume
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#elastic_load_balancer OpsworksJavaAppLayer#elastic_load_balancer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticLoadBalancer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ElasticLoadBalancer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#install_updates_on_boot OpsworksJavaAppLayer#install_updates_on_boot}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "installUpdatesOnBoot", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? InstallUpdatesOnBoot
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#instance_shutdown_timeout OpsworksJavaAppLayer#instance_shutdown_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceShutdownTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InstanceShutdownTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#jvm_options OpsworksJavaAppLayer#jvm_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jvmOptions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JvmOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#jvm_type OpsworksJavaAppLayer#jvm_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jvmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JvmType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#jvm_version OpsworksJavaAppLayer#jvm_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jvmVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JvmVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#name OpsworksJavaAppLayer#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#system_packages OpsworksJavaAppLayer#system_packages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemPackages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SystemPackages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#tags OpsworksJavaAppLayer#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_java_app_layer#use_ebs_optimized_instances OpsworksJavaAppLayer#use_ebs_optimized_instances}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useEbsOptimizedInstances", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseEbsOptimizedInstances
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
