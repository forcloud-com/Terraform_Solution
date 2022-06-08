using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupDeploymentStyle), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupDeploymentStyle")]
    public interface ICodedeployDeploymentGroupDeploymentStyle
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#deployment_option CodedeployDeploymentGroup#deployment_option}.</summary>
        [JsiiProperty(name: "deploymentOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#deployment_type CodedeployDeploymentGroup#deployment_type}.</summary>
        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeploymentType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupDeploymentStyle), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupDeploymentStyle")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentGroupDeploymentStyle
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#deployment_option CodedeployDeploymentGroup#deployment_option}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeploymentOption
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#deployment_type CodedeployDeploymentGroup#deployment_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeploymentType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
