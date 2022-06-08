using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiClass(nativeType: typeof(aws.Codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionOutputReference), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetActionOnTimeout")]
        public virtual void ResetActionOnTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitTimeInMinutes")]
        public virtual void ResetWaitTimeInMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionOnTimeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionOnTimeoutInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitTimeInMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WaitTimeInMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "actionOnTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionOnTimeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitTimeInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WaitTimeInMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption? InternalValue
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption?>();
            set => SetInstanceProperty(value);
        }
    }
}
