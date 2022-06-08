using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentConfigMinimumHealthyHosts")]
    public class CodedeployDeploymentConfigMinimumHealthyHosts : aws.Codedeploy.ICodedeployDeploymentConfigMinimumHealthyHosts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#type CodedeployDeploymentConfig#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_config#value CodedeployDeploymentConfig#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Value
        {
            get;
            set;
        }
    }
}
