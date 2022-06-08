using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption")]
    public interface ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#action CodedeployDeploymentGroup#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#action CodedeployDeploymentGroup#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
