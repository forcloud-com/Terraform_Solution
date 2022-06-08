using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfig")]
    public class CodedeployDeploymentConfigTrafficRoutingConfig : aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfig
    {
        /// <summary>time_based_canary block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#time_based_canary CodedeployDeploymentConfig#time_based_canary}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeBasedCanary", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary\"}", isOptional: true)]
        public aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary? TimeBasedCanary
        {
            get;
            set;
        }

        /// <summary>time_based_linear block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#time_based_linear CodedeployDeploymentConfig#time_based_linear}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeBasedLinear", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear\"}", isOptional: true)]
        public aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear? TimeBasedLinear
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#type CodedeployDeploymentConfig#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
