using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiClass(nativeType: typeof(aws.Codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigOutputReference), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodedeployDeploymentConfigTrafficRoutingConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodedeployDeploymentConfigTrafficRoutingConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentConfigTrafficRoutingConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentConfigTrafficRoutingConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeBasedCanary", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary\"}}]")]
        public virtual void PutTimeBasedCanary(aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeBasedLinear", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear\"}}]")]
        public virtual void PutTimeBasedLinear(aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTimeBasedCanary")]
        public virtual void ResetTimeBasedCanary()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeBasedLinear")]
        public virtual void ResetTimeBasedLinear()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "timeBasedCanary", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanaryOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanaryOutputReference TimeBasedCanary
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanaryOutputReference>()!;
        }

        [JsiiProperty(name: "timeBasedLinear", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinearOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinearOutputReference TimeBasedLinear
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinearOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeBasedCanaryInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary? TimeBasedCanaryInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeBasedLinearInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear? TimeBasedLinearInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentConfigTrafficRoutingConfig\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentConfigTrafficRoutingConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
