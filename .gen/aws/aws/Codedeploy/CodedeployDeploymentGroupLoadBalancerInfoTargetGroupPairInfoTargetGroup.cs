using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup")]
    public class CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup : aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#name CodedeployDeploymentGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
