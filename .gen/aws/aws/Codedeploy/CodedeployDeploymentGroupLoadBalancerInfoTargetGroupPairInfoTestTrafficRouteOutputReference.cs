using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiClass(nativeType: typeof(aws.Codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRouteOutputReference), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRouteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "listenerArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ListenerArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "listenerArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ListenerArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute? InternalValue
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
