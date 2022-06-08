using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentGroupTriggerConfiguration")]
    public class CodedeployDeploymentGroupTriggerConfiguration : aws.Codedeploy.ICodedeployDeploymentGroupTriggerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#trigger_events CodedeployDeploymentGroup#trigger_events}.</summary>
        [JsiiProperty(name: "triggerEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] TriggerEvents
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#trigger_name CodedeployDeploymentGroup#trigger_name}.</summary>
        [JsiiProperty(name: "triggerName", typeJson: "{\"primitive\":\"string\"}")]
        public string TriggerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#trigger_target_arn CodedeployDeploymentGroup#trigger_target_arn}.</summary>
        [JsiiProperty(name: "triggerTargetArn", typeJson: "{\"primitive\":\"string\"}")]
        public string TriggerTargetArn
        {
            get;
            set;
        }
    }
}
