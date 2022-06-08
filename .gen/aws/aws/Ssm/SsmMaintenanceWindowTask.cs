using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task aws_ssm_maintenance_window_task}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ssm.SsmMaintenanceWindowTask), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTask", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskConfig\"}}]")]
    public class SsmMaintenanceWindowTask : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task aws_ssm_maintenance_window_task} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SsmMaintenanceWindowTask(Constructs.Construct scope, string id, aws.Ssm.ISsmMaintenanceWindowTaskConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmMaintenanceWindowTask(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmMaintenanceWindowTask(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLoggingInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskLoggingInfo\"}}]")]
        public virtual void PutLoggingInfo(aws.Ssm.ISsmMaintenanceWindowTaskLoggingInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ssm.ISsmMaintenanceWindowTaskLoggingInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTaskInvocationParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParameters\"}}]")]
        public virtual void PutTaskInvocationParameters(aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingInfo")]
        public virtual void ResetLoggingInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriority")]
        public virtual void ResetPriority()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskInvocationParameters")]
        public virtual void ResetTaskInvocationParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskParameters")]
        public virtual void ResetTaskParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Ssm.SsmMaintenanceWindowTask))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loggingInfo", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskLoggingInfoOutputReference\"}")]
        public virtual aws.Ssm.SsmMaintenanceWindowTaskLoggingInfoOutputReference LoggingInfo
        {
            get => GetInstanceProperty<aws.Ssm.SsmMaintenanceWindowTaskLoggingInfoOutputReference>()!;
        }

        [JsiiProperty(name: "taskInvocationParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference\"}")]
        public virtual aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference TaskInvocationParameters
        {
            get => GetInstanceProperty<aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInfoInput", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskLoggingInfo\"}", isOptional: true)]
        public virtual aws.Ssm.ISsmMaintenanceWindowTaskLoggingInfo? LoggingInfoInput
        {
            get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskLoggingInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxConcurrencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxErrorsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxErrorsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TargetsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskInvocationParametersInput", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParameters\"}", isOptional: true)]
        public virtual aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParameters? TaskInvocationParametersInput
        {
            get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskParametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TaskParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "windowIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WindowIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxConcurrency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxErrors
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTargets\"},\"kind\":\"array\"}}]}}")]
        public virtual object Targets
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskParameters\"},\"kind\":\"array\"}}]}}")]
        public virtual object TaskParameters
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "windowId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WindowId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
