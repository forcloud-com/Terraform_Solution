using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo")]
    public class CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo : aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo
    {
        /// <summary>prod_traffic_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#prod_traffic_route CodedeployDeploymentGroup#prod_traffic_route}
        /// </remarks>
        [JsiiProperty(name: "prodTrafficRoute", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute\"}")]
        public aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute ProdTrafficRoute
        {
            get;
            set;
        }

        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#target_group CodedeployDeploymentGroup#target_group}
        /// </remarks>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup\"},\"kind\":\"array\"}}]}}")]
        public object TargetGroup
        {
            get;
            set;
        }

        /// <summary>test_traffic_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#test_traffic_route CodedeployDeploymentGroup#test_traffic_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "testTrafficRoute", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute\"}", isOptional: true)]
        public aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute? TestTrafficRoute
        {
            get;
            set;
        }
    }
}
