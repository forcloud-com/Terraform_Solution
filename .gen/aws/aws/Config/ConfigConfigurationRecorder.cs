using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder aws_config_configuration_recorder}.</summary>
    [JsiiClass(nativeType: typeof(aws.Config.ConfigConfigurationRecorder), fullyQualifiedName: "aws.config.ConfigConfigurationRecorder", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.config.ConfigConfigurationRecorderConfig\"}}]")]
    public class ConfigConfigurationRecorder : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder aws_config_configuration_recorder} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ConfigConfigurationRecorder(Constructs.Construct scope, string id, aws.Config.IConfigConfigurationRecorderConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationRecorder(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationRecorder(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRecordingGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.config.ConfigConfigurationRecorderRecordingGroup\"}}]")]
        public virtual void PutRecordingGroup(aws.Config.IConfigConfigurationRecorderRecordingGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Config.IConfigConfigurationRecorderRecordingGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecordingGroup")]
        public virtual void ResetRecordingGroup()
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
        = GetStaticProperty<string>(typeof(aws.Config.ConfigConfigurationRecorder))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recordingGroup", typeJson: "{\"fqn\":\"aws.config.ConfigConfigurationRecorderRecordingGroupOutputReference\"}")]
        public virtual aws.Config.ConfigConfigurationRecorderRecordingGroupOutputReference RecordingGroup
        {
            get => GetInstanceProperty<aws.Config.ConfigConfigurationRecorderRecordingGroupOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordingGroupInput", typeJson: "{\"fqn\":\"aws.config.ConfigConfigurationRecorderRecordingGroup\"}", isOptional: true)]
        public virtual aws.Config.IConfigConfigurationRecorderRecordingGroup? RecordingGroupInput
        {
            get => GetInstanceProperty<aws.Config.IConfigConfigurationRecorderRecordingGroup?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
