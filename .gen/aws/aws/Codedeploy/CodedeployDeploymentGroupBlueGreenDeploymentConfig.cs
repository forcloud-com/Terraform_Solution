using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfig")]
    public class CodedeployDeploymentGroupBlueGreenDeploymentConfig : aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfig
    {
        /// <summary>deployment_ready_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#deployment_ready_option CodedeployDeploymentGroup#deployment_ready_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deploymentReadyOption", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption\"}", isOptional: true)]
        public aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption? DeploymentReadyOption
        {
            get;
            set;
        }

        /// <summary>green_fleet_provisioning_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#green_fleet_provisioning_option CodedeployDeploymentGroup#green_fleet_provisioning_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "greenFleetProvisioningOption", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption\"}", isOptional: true)]
        public aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption? GreenFleetProvisioningOption
        {
            get;
            set;
        }

        /// <summary>terminate_blue_instances_on_deployment_success block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#terminate_blue_instances_on_deployment_success CodedeployDeploymentGroup#terminate_blue_instances_on_deployment_success}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "terminateBlueInstancesOnDeploymentSuccess", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess\"}", isOptional: true)]
        public aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess? TerminateBlueInstancesOnDeploymentSuccess
        {
            get;
            set;
        }
    }
}
