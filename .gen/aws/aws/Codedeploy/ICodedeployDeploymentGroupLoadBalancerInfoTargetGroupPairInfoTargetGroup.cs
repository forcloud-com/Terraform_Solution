using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup")]
    public interface ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#name CodedeployDeploymentGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#name CodedeployDeploymentGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
