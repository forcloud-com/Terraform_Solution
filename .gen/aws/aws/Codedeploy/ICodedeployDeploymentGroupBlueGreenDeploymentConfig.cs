using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfig), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfig")]
    public interface ICodedeployDeploymentGroupBlueGreenDeploymentConfig
    {
        /// <summary>deployment_ready_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#deployment_ready_option CodedeployDeploymentGroup#deployment_ready_option}
        /// </remarks>
        [JsiiProperty(name: "deploymentReadyOption", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption? DeploymentReadyOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>green_fleet_provisioning_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#green_fleet_provisioning_option CodedeployDeploymentGroup#green_fleet_provisioning_option}
        /// </remarks>
        [JsiiProperty(name: "greenFleetProvisioningOption", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption? GreenFleetProvisioningOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>terminate_blue_instances_on_deployment_success block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#terminate_blue_instances_on_deployment_success CodedeployDeploymentGroup#terminate_blue_instances_on_deployment_success}
        /// </remarks>
        [JsiiProperty(name: "terminateBlueInstancesOnDeploymentSuccess", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess? TerminateBlueInstancesOnDeploymentSuccess
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfig), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>deployment_ready_option block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#deployment_ready_option CodedeployDeploymentGroup#deployment_ready_option}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentReadyOption", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption? DeploymentReadyOption
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption?>();
            }

            /// <summary>green_fleet_provisioning_option block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#green_fleet_provisioning_option CodedeployDeploymentGroup#green_fleet_provisioning_option}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "greenFleetProvisioningOption", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption? GreenFleetProvisioningOption
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption?>();
            }

            /// <summary>terminate_blue_instances_on_deployment_success block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#terminate_blue_instances_on_deployment_success CodedeployDeploymentGroup#terminate_blue_instances_on_deployment_success}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "terminateBlueInstancesOnDeploymentSuccess", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess? TerminateBlueInstancesOnDeploymentSuccess
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess?>();
            }
        }
    }
}
