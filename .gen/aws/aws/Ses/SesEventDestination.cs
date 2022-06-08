using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination aws_ses_event_destination}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ses.SesEventDestination), fullyQualifiedName: "aws.ses.SesEventDestination", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ses.SesEventDestinationConfig\"}}]")]
    public class SesEventDestination : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination aws_ses_event_destination} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SesEventDestination(Constructs.Construct scope, string id, aws.Ses.ISesEventDestinationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesEventDestination(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesEventDestination(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKinesisDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ses.SesEventDestinationKinesisDestination\"}}]")]
        public virtual void PutKinesisDestination(aws.Ses.ISesEventDestinationKinesisDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ses.ISesEventDestinationKinesisDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnsDestination", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ses.SesEventDestinationSnsDestination\"}}]")]
        public virtual void PutSnsDestination(aws.Ses.ISesEventDestinationSnsDestination @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ses.ISesEventDestinationSnsDestination)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchDestination")]
        public virtual void ResetCloudwatchDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisDestination")]
        public virtual void ResetKinesisDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnsDestination")]
        public virtual void ResetSnsDestination()
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
        = GetStaticProperty<string>(typeof(aws.Ses.SesEventDestination))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kinesisDestination", typeJson: "{\"fqn\":\"aws.ses.SesEventDestinationKinesisDestinationOutputReference\"}")]
        public virtual aws.Ses.SesEventDestinationKinesisDestinationOutputReference KinesisDestination
        {
            get => GetInstanceProperty<aws.Ses.SesEventDestinationKinesisDestinationOutputReference>()!;
        }

        [JsiiProperty(name: "snsDestination", typeJson: "{\"fqn\":\"aws.ses.SesEventDestinationSnsDestinationOutputReference\"}")]
        public virtual aws.Ses.SesEventDestinationSnsDestinationOutputReference SnsDestination
        {
            get => GetInstanceProperty<aws.Ses.SesEventDestinationSnsDestinationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchDestinationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesEventDestinationCloudwatchDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CloudwatchDestinationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationSetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationSetNameInput
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
        [JsiiProperty(name: "kinesisDestinationInput", typeJson: "{\"fqn\":\"aws.ses.SesEventDestinationKinesisDestination\"}", isOptional: true)]
        public virtual aws.Ses.ISesEventDestinationKinesisDestination? KinesisDestinationInput
        {
            get => GetInstanceProperty<aws.Ses.ISesEventDestinationKinesisDestination?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchingTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? MatchingTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snsDestinationInput", typeJson: "{\"fqn\":\"aws.ses.SesEventDestinationSnsDestination\"}", isOptional: true)]
        public virtual aws.Ses.ISesEventDestinationSnsDestination? SnsDestinationInput
        {
            get => GetInstanceProperty<aws.Ses.ISesEventDestinationSnsDestination?>();
        }

        [JsiiProperty(name: "cloudwatchDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesEventDestinationCloudwatchDestination\"},\"kind\":\"array\"}}]}}")]
        public virtual object CloudwatchDestination
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configurationSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationSetName
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

        [JsiiProperty(name: "matchingTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MatchingTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
