using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess")]
    public interface ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#action CodedeployDeploymentGroup#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#termination_wait_time_in_minutes CodedeployDeploymentGroup#termination_wait_time_in_minutes}.</summary>
        [JsiiProperty(name: "terminationWaitTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TerminationWaitTimeInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#action CodedeployDeploymentGroup#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#termination_wait_time_in_minutes CodedeployDeploymentGroup#termination_wait_time_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "terminationWaitTimeInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TerminationWaitTimeInMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
