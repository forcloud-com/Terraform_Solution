using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute")]
    public interface ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#listener_arns CodedeployDeploymentGroup#listener_arns}.</summary>
        [JsiiProperty(name: "listenerArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ListenerArns
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#listener_arns CodedeployDeploymentGroup#listener_arns}.</summary>
            [JsiiProperty(name: "listenerArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ListenerArns
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
