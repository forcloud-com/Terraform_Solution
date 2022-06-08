using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codedeploy.CodedeployDeploymentGroupEcsService")]
    public class CodedeployDeploymentGroupEcsService : aws.Codedeploy.ICodedeployDeploymentGroupEcsService
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#cluster_name CodedeployDeploymentGroup#cluster_name}.</summary>
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#service_name CodedeployDeploymentGroup#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceName
        {
            get;
            set;
        }
    }
}
