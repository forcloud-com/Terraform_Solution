using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary")]
    public interface ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#interval CodedeployDeploymentConfig#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Interval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#percentage CodedeployDeploymentConfig#percentage}.</summary>
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Percentage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#interval CodedeployDeploymentConfig#interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Interval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#percentage CodedeployDeploymentConfig#percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Percentage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
