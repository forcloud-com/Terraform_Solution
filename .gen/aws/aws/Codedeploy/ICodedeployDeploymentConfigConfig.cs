using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    /// <summary>AWS CodeDeploy.</summary>
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentConfigConfig), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentConfigConfig")]
    public interface ICodedeployDeploymentConfigConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#deployment_config_name CodedeployDeploymentConfig#deployment_config_name}.</summary>
        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}")]
        string DeploymentConfigName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#compute_platform CodedeployDeploymentConfig#compute_platform}.</summary>
        [JsiiProperty(name: "computePlatform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ComputePlatform
        {
            get
            {
                return null;
            }
        }

        /// <summary>minimum_healthy_hosts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#minimum_healthy_hosts CodedeployDeploymentConfig#minimum_healthy_hosts}
        /// </remarks>
        [JsiiProperty(name: "minimumHealthyHosts", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigMinimumHealthyHosts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentConfigMinimumHealthyHosts? MinimumHealthyHosts
        {
            get
            {
                return null;
            }
        }

        /// <summary>traffic_routing_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#traffic_routing_config CodedeployDeploymentConfig#traffic_routing_config}
        /// </remarks>
        [JsiiProperty(name: "trafficRoutingConfig", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfig? TrafficRoutingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS CodeDeploy.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentConfigConfig), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentConfigConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentConfigConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#deployment_config_name CodedeployDeploymentConfig#deployment_config_name}.</summary>
            [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}")]
            public string DeploymentConfigName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#compute_platform CodedeployDeploymentConfig#compute_platform}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computePlatform", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ComputePlatform
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>minimum_healthy_hosts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#minimum_healthy_hosts CodedeployDeploymentConfig#minimum_healthy_hosts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minimumHealthyHosts", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigMinimumHealthyHosts\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentConfigMinimumHealthyHosts? MinimumHealthyHosts
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentConfigMinimumHealthyHosts?>();
            }

            /// <summary>traffic_routing_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#traffic_routing_config CodedeployDeploymentConfig#traffic_routing_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trafficRoutingConfig", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfig\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfig? TrafficRoutingConfig
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfig?>();
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
