using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo")]
    public interface ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#name CodedeployDeploymentGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#name CodedeployDeploymentGroup#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
