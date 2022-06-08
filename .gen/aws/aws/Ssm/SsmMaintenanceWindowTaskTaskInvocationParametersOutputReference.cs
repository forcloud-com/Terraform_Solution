using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiClass(nativeType: typeof(aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutomationParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters\"}}]")]
        public virtual void PutAutomationParameters(aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters\"}}]")]
        public virtual void PutLambdaParameters(aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRunCommandParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters\"}}]")]
        public virtual void PutRunCommandParameters(aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStepFunctionsParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters\"}}]")]
        public virtual void PutStepFunctionsParameters(aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutomationParameters")]
        public virtual void ResetAutomationParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaParameters")]
        public virtual void ResetLambdaParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunCommandParameters")]
        public virtual void ResetRunCommandParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepFunctionsParameters")]
        public virtual void ResetStepFunctionsParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "automationParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersOutputReference\"}")]
        public virtual aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersOutputReference AutomationParameters
        {
            get => GetInstanceProperty<aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersOutputReference>()!;
        }

        [JsiiProperty(name: "lambdaParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParametersOutputReference\"}")]
        public virtual aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParametersOutputReference LambdaParameters
        {
            get => GetInstanceProperty<aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParametersOutputReference>()!;
        }

        [JsiiProperty(name: "runCommandParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersOutputReference\"}")]
        public virtual aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersOutputReference RunCommandParameters
        {
            get => GetInstanceProperty<aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersOutputReference>()!;
        }

        [JsiiProperty(name: "stepFunctionsParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParametersOutputReference\"}")]
        public virtual aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParametersOutputReference StepFunctionsParameters
        {
            get => GetInstanceProperty<aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automationParametersInput", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters\"}", isOptional: true)]
        public virtual aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters? AutomationParametersInput
        {
            get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaParametersInput", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters\"}", isOptional: true)]
        public virtual aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters? LambdaParametersInput
        {
            get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runCommandParametersInput", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters\"}", isOptional: true)]
        public virtual aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters? RunCommandParametersInput
        {
            get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepFunctionsParametersInput", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters\"}", isOptional: true)]
        public virtual aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters? StepFunctionsParametersInput
        {
            get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParameters\"}", isOptional: true)]
        public virtual aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParameters? InternalValue
        {
            get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
