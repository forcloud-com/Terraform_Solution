using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    #pragma warning disable CS8618

    /// <summary>AWS CodeDeploy.</summary>
    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentConfigConfig")]
    public class CodedeployDeploymentConfigConfig : aws.Codedeploy.ICodedeployDeploymentConfigConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#deployment_config_name CodedeployDeploymentConfig#deployment_config_name}.</summary>
        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}")]
        public string DeploymentConfigName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#compute_platform CodedeployDeploymentConfig#compute_platform}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computePlatform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComputePlatform
        {
            get;
            set;
        }

        /// <summary>minimum_healthy_hosts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#minimum_healthy_hosts CodedeployDeploymentConfig#minimum_healthy_hosts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimumHealthyHosts", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigMinimumHealthyHosts\"}", isOptional: true)]
        public aws.Codedeploy.ICodedeployDeploymentConfigMinimumHealthyHosts? MinimumHealthyHosts
        {
            get;
            set;
        }

        /// <summary>traffic_routing_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#traffic_routing_config CodedeployDeploymentConfig#traffic_routing_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trafficRoutingConfig", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfig\"}", isOptional: true)]
        public aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfig? TrafficRoutingConfig
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
