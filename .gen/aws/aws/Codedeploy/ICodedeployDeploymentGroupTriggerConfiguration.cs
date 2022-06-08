using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupTriggerConfiguration), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupTriggerConfiguration")]
    public interface ICodedeployDeploymentGroupTriggerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#trigger_events CodedeployDeploymentGroup#trigger_events}.</summary>
        [JsiiProperty(name: "triggerEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] TriggerEvents
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#trigger_name CodedeployDeploymentGroup#trigger_name}.</summary>
        [JsiiProperty(name: "triggerName", typeJson: "{\"primitive\":\"string\"}")]
        string TriggerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#trigger_target_arn CodedeployDeploymentGroup#trigger_target_arn}.</summary>
        [JsiiProperty(name: "triggerTargetArn", typeJson: "{\"primitive\":\"string\"}")]
        string TriggerTargetArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupTriggerConfiguration), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupTriggerConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentGroupTriggerConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#trigger_events CodedeployDeploymentGroup#trigger_events}.</summary>
            [JsiiProperty(name: "triggerEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] TriggerEvents
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#trigger_name CodedeployDeploymentGroup#trigger_name}.</summary>
            [JsiiProperty(name: "triggerName", typeJson: "{\"primitive\":\"string\"}")]
            public string TriggerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#trigger_target_arn CodedeployDeploymentGroup#trigger_target_arn}.</summary>
            [JsiiProperty(name: "triggerTargetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TriggerTargetArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
