using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ses_identity_notification_topic aws_ses_identity_notification_topic}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ses.SesIdentityNotificationTopic), fullyQualifiedName: "aws.ses.SesIdentityNotificationTopic", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ses.SesIdentityNotificationTopicConfig\"}}]")]
    public class SesIdentityNotificationTopic : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ses_identity_notification_topic aws_ses_identity_notification_topic} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SesIdentityNotificationTopic(Constructs.Construct scope, string id, aws.Ses.ISesIdentityNotificationTopicConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesIdentityNotificationTopic(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesIdentityNotificationTopic(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetIncludeOriginalHeaders")]
        public virtual void ResetIncludeOriginalHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTopicArn")]
        public virtual void ResetTopicArn()
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
        = GetStaticProperty<string>(typeof(aws.Ses.SesIdentityNotificationTopic))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeOriginalHeadersInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IncludeOriginalHeadersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NotificationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TopicArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "identity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Identity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includeOriginalHeaders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object IncludeOriginalHeaders
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TopicArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
