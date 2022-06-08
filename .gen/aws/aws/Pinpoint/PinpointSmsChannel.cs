using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpoint
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_sms_channel aws_pinpoint_sms_channel}.</summary>
    [JsiiClass(nativeType: typeof(aws.Pinpoint.PinpointSmsChannel), fullyQualifiedName: "aws.pinpoint.PinpointSmsChannel", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.pinpoint.PinpointSmsChannelConfig\"}}]")]
    public class PinpointSmsChannel : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_sms_channel aws_pinpoint_sms_channel} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PinpointSmsChannel(Constructs.Construct scope, string id, aws.Pinpoint.IPinpointSmsChannelConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PinpointSmsChannel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PinpointSmsChannel(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSenderId")]
        public virtual void ResetSenderId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShortCode")]
        public virtual void ResetShortCode()
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
        = GetStaticProperty<string>(typeof(aws.Pinpoint.PinpointSmsChannel))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "promotionalMessagesPerSecond", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PromotionalMessagesPerSecond
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "transactionalMessagesPerSecond", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TransactionalMessagesPerSecond
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "senderIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SenderIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shortCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShortCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "senderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SenderId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shortCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
