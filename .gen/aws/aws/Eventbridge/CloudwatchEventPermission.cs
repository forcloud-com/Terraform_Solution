using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_permission aws_cloudwatch_event_permission}.</summary>
    [JsiiClass(nativeType: typeof(aws.Eventbridge.CloudwatchEventPermission), fullyQualifiedName: "aws.eventbridge.CloudwatchEventPermission", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventPermissionConfig\"}}]")]
    public class CloudwatchEventPermission : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_permission aws_cloudwatch_event_permission} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudwatchEventPermission(Constructs.Construct scope, string id, aws.Eventbridge.ICloudwatchEventPermissionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventPermission(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventPermission(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCondition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventPermissionCondition\"}}]")]
        public virtual void PutCondition(aws.Eventbridge.ICloudwatchEventPermissionCondition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventPermissionCondition)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAction")]
        public virtual void ResetAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCondition")]
        public virtual void ResetCondition()
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
        = GetStaticProperty<string>(typeof(aws.Eventbridge.CloudwatchEventPermission))!;

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventPermissionConditionOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventPermissionConditionOutputReference Condition
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventPermissionConditionOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "conditionInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventPermissionCondition\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventPermissionCondition? ConditionInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventPermissionCondition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "principalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrincipalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statementIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatementIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Principal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "statementId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatementId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
