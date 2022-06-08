using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption")]
    public class CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption : aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#action CodedeployDeploymentGroup#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }
    }
}
