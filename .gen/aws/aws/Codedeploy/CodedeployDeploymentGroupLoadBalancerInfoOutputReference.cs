using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiClass(nativeType: typeof(aws.Codedeploy.CodedeployDeploymentGroupLoadBalancerInfoOutputReference), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodedeployDeploymentGroupLoadBalancerInfoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodedeployDeploymentGroupLoadBalancerInfoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroupLoadBalancerInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroupLoadBalancerInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTargetGroupPairInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo\"}}]")]
        public virtual void PutTargetGroupPairInfo(aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetElbInfo")]
        public virtual void ResetElbInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetGroupInfo")]
        public virtual void ResetTargetGroupInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetGroupPairInfo")]
        public virtual void ResetTargetGroupPairInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "targetGroupPairInfo", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoOutputReference TargetGroupPairInfo
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "elbInfoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoElbInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ElbInfoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupInfoInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TargetGroupInfoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupPairInfoInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo? TargetGroupPairInfoInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo?>();
        }

        [JsiiProperty(name: "elbInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoElbInfo\"},\"kind\":\"array\"}}]}}")]
        public virtual object ElbInfo
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetGroupInfo", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupInfo\"},\"kind\":\"array\"}}]}}")]
        public virtual object TargetGroupInfo
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfo\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfo? InternalValue
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
