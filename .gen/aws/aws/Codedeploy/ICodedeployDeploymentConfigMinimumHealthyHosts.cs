using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentConfigMinimumHealthyHosts), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentConfigMinimumHealthyHosts")]
    public interface ICodedeployDeploymentConfigMinimumHealthyHosts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#type CodedeployDeploymentConfig#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#value CodedeployDeploymentConfig#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentConfigMinimumHealthyHosts), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentConfigMinimumHealthyHosts")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentConfigMinimumHealthyHosts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#type CodedeployDeploymentConfig#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#value CodedeployDeploymentConfig#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Value
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
