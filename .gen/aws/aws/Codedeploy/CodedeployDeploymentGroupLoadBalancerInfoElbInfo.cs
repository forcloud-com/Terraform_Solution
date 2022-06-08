using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoElbInfo")]
    public class CodedeployDeploymentGroupLoadBalancerInfoElbInfo : aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoElbInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#name CodedeployDeploymentGroup#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
