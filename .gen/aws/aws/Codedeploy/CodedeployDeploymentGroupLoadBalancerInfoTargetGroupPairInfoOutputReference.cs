using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiClass(nativeType: typeof(aws.Codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoOutputReference), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putProdTrafficRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute\"}}]")]
        public virtual void PutProdTrafficRoute(aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTestTrafficRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute\"}}]")]
        public virtual void PutTestTrafficRoute(aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTestTrafficRoute")]
        public virtual void ResetTestTrafficRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "prodTrafficRoute", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteOutputReference ProdTrafficRoute
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteOutputReference>()!;
        }

        [JsiiProperty(name: "testTrafficRoute", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRouteOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRouteOutputReference TestTrafficRoute
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRouteOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "prodTrafficRouteInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute? ProdTrafficRouteInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TargetGroupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "testTrafficRouteInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute? TestTrafficRouteInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute?>();
        }

        [JsiiProperty(name: "targetGroup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTargetGroup\"},\"kind\":\"array\"}}]}}")]
        public virtual object TargetGroup
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo? InternalValue
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
