using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentConfigTrafficRoutingConfig), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfig")]
    public interface ICodedeployDeploymentConfigTrafficRoutingConfig
    {
        /// <summary>time_based_canary block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#time_based_canary CodedeployDeploymentConfig#time_based_canary}
        /// </remarks>
        [JsiiProperty(name: "timeBasedCanary", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary? TimeBasedCanary
        {
            get
            {
                return null;
            }
        }

        /// <summary>time_based_linear block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#time_based_linear CodedeployDeploymentConfig#time_based_linear}
        /// </remarks>
        [JsiiProperty(name: "timeBasedLinear", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear? TimeBasedLinear
        {
            get
            {
                return null;
            }
        }

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

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentConfigTrafficRoutingConfig), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>time_based_canary block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#time_based_canary CodedeployDeploymentConfig#time_based_canary}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeBasedCanary", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary? TimeBasedCanary
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary?>();
            }

            /// <summary>time_based_linear block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#time_based_linear CodedeployDeploymentConfig#time_based_linear}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeBasedLinear", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear? TimeBasedLinear
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#type CodedeployDeploymentConfig#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
