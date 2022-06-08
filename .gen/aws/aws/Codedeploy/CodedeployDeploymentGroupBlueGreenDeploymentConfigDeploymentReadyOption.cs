using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption")]
    public class CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption : aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#action_on_timeout CodedeployDeploymentGroup#action_on_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionOnTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActionOnTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#wait_time_in_minutes CodedeployDeploymentGroup#wait_time_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "waitTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WaitTimeInMinutes
        {
            get;
            set;
        }
    }
}
