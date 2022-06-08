using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codedeploy
{
    [JsiiClass(nativeType: typeof(aws.Codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference), fullyQualifiedName: "aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentGroupBlueGreenDeploymentConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDeploymentReadyOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption\"}}]")]
        public virtual void PutDeploymentReadyOption(aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGreenFleetProvisioningOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption\"}}]")]
        public virtual void PutGreenFleetProvisioningOption(aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTerminateBlueInstancesOnDeploymentSuccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess\"}}]")]
        public virtual void PutTerminateBlueInstancesOnDeploymentSuccess(aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeploymentReadyOption")]
        public virtual void ResetDeploymentReadyOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGreenFleetProvisioningOption")]
        public virtual void ResetGreenFleetProvisioningOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminateBlueInstancesOnDeploymentSuccess")]
        public virtual void ResetTerminateBlueInstancesOnDeploymentSuccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "deploymentReadyOption", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionOutputReference DeploymentReadyOption
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOptionOutputReference>()!;
        }

        [JsiiProperty(name: "greenFleetProvisioningOption", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOptionOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOptionOutputReference GreenFleetProvisioningOption
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOptionOutputReference>()!;
        }

        [JsiiProperty(name: "terminateBlueInstancesOnDeploymentSuccess", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccessOutputReference\"}")]
        public virtual aws.Codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccessOutputReference TerminateBlueInstancesOnDeploymentSuccess
        {
            get => GetInstanceProperty<aws.Codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccessOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentReadyOptionInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption? DeploymentReadyOptionInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigDeploymentReadyOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "greenFleetProvisioningOptionInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption? GreenFleetProvisioningOptionInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigGreenFleetProvisioningOption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminateBlueInstancesOnDeploymentSuccessInput", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess? TerminateBlueInstancesOnDeploymentSuccessInput
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codedeploy.CodedeployDeploymentGroupBlueGreenDeploymentConfig\"}", isOptional: true)]
        public virtual aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Codedeploy.ICodedeployDeploymentGroupBlueGreenDeploymentConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
