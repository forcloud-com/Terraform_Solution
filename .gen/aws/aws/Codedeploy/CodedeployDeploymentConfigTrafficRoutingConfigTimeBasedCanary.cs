using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary")]
    public class CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary : aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#interval CodedeployDeploymentConfig#interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Interval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#percentage CodedeployDeploymentConfig#percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Percentage
        {
            get;
            set;
        }
    }
}
