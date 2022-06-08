using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentGroupOnPremisesInstanceTagFilter")]
    public class CodedeployDeploymentGroupOnPremisesInstanceTagFilter : aws.Codedeploy.ICodedeployDeploymentGroupOnPremisesInstanceTagFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#key CodedeployDeploymentGroup#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#type CodedeployDeploymentGroup#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#value CodedeployDeploymentGroup#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
