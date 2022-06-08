using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel aws_config_delivery_channel}.</summary>
    [JsiiClass(nativeType: typeof(aws.Config.ConfigDeliveryChannel), fullyQualifiedName: "aws.config.ConfigDeliveryChannel", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.config.ConfigDeliveryChannelConfig\"}}]")]
    public class ConfigDeliveryChannel : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/config_delivery_channel aws_config_delivery_channel} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ConfigDeliveryChannel(Constructs.Construct scope, string id, aws.Config.IConfigDeliveryChannelConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigDeliveryChannel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigDeliveryChannel(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSnapshotDeliveryProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.config.ConfigDeliveryChannelSnapshotDeliveryProperties\"}}]")]
        public virtual void PutSnapshotDeliveryProperties(aws.Config.IConfigDeliveryChannelSnapshotDeliveryProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Config.IConfigDeliveryChannelSnapshotDeliveryProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3KeyPrefix")]
        public virtual void ResetS3KeyPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotDeliveryProperties")]
        public virtual void ResetSnapshotDeliveryProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnsTopicArn")]
        public virtual void ResetSnsTopicArn()
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
        = GetStaticProperty<string>(typeof(aws.Config.ConfigDeliveryChannel))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "snapshotDeliveryProperties", typeJson: "{\"fqn\":\"aws.config.ConfigDeliveryChannelSnapshotDeliveryPropertiesOutputReference\"}")]
        public virtual aws.Config.ConfigDeliveryChannelSnapshotDeliveryPropertiesOutputReference SnapshotDeliveryProperties
        {
            get => GetInstanceProperty<aws.Config.ConfigDeliveryChannelSnapshotDeliveryPropertiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3BucketNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3BucketNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3KeyPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3KeyPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotDeliveryPropertiesInput", typeJson: "{\"fqn\":\"aws.config.ConfigDeliveryChannelSnapshotDeliveryProperties\"}", isOptional: true)]
        public virtual aws.Config.IConfigDeliveryChannelSnapshotDeliveryProperties? SnapshotDeliveryPropertiesInput
        {
            get => GetInstanceProperty<aws.Config.IConfigDeliveryChannelSnapshotDeliveryProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snsTopicArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SnsTopicArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3BucketName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3BucketName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3KeyPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3KeyPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snsTopicArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnsTopicArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
