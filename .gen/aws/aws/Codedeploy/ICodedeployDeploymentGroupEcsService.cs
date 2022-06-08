using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupEcsService), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupEcsService")]
    public interface ICodedeployDeploymentGroupEcsService
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#cluster_name CodedeployDeploymentGroup#cluster_name}.</summary>
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#service_name CodedeployDeploymentGroup#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupEcsService), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupEcsService")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentGroupEcsService
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#cluster_name CodedeployDeploymentGroup#cluster_name}.</summary>
            [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#service_name CodedeployDeploymentGroup#service_name}.</summary>
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
