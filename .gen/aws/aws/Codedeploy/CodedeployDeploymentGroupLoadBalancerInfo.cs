using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfo")]
    public class CodedeployDeploymentGroupLoadBalancerInfo : aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfo
    {
        /// <summary>elb_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#elb_info CodedeployDeploymentGroup#elb_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "elbInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoElbInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ElbInfo
        {
            get;
            set;
        }

        /// <summary>target_group_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#target_group_info CodedeployDeploymentGroup#target_group_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TargetGroupInfo
        {
            get;
            set;
        }

        /// <summary>target_group_pair_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#target_group_pair_info CodedeployDeploymentGroup#target_group_pair_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupPairInfo", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo\"}", isOptional: true)]
        public aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo? TargetGroupPairInfo
        {
            get;
            set;
        }
    }
}
