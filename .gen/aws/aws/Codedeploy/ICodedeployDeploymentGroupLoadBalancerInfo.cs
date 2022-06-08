using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiInterface(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfo), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfo")]
    public interface ICodedeployDeploymentGroupLoadBalancerInfo
    {
        /// <summary>elb_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#elb_info CodedeployDeploymentGroup#elb_info}
        /// </remarks>
        [JsiiProperty(name: "elbInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoElbInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ElbInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_group_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#target_group_info CodedeployDeploymentGroup#target_group_info}
        /// </remarks>
        [JsiiProperty(name: "targetGroupInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TargetGroupInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>target_group_pair_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#target_group_pair_info CodedeployDeploymentGroup#target_group_pair_info}
        /// </remarks>
        [JsiiProperty(name: "targetGroupPairInfo", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo? TargetGroupPairInfo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodedeployDeploymentGroupLoadBalancerInfo), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfo")]
        internal sealed class _Proxy : DeputyBase, aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>elb_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#elb_info CodedeployDeploymentGroup#elb_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "elbInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoElbInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ElbInfo
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>target_group_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#target_group_info CodedeployDeploymentGroup#target_group_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TargetGroupInfo
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>target_group_pair_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/codedeploy_deployment_group#target_group_pair_info CodedeployDeploymentGroup#target_group_pair_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupPairInfo", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo\"}", isOptional: true)]
            public aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo? TargetGroupPairInfo
            {
                get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo?>();
            }
        }
    }
}
