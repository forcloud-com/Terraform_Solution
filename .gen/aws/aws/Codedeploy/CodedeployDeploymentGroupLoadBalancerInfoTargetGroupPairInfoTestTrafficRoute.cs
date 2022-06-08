using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute")]
    public class CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute : aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#listener_arns CodedeployDeploymentGroup#listener_arns}.</summary>
        [JsiiProperty(name: "listenerArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ListenerArns
        {
            get;
            set;
        }
    }
}
