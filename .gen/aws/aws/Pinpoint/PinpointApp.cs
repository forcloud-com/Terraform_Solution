using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpoint
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app aws_pinpoint_app}.</summary>
    [JsiiClass(nativeType: typeof(aws.Pinpoint.PinpointApp), fullyQualifiedName: "aws.pinpoint.PinpointApp", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.pinpoint.PinpointAppConfig\"}}]")]
    public class PinpointApp : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app aws_pinpoint_app} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PinpointApp(Constructs.Construct scope, string id, aws.Pinpoint.IPinpointAppConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PinpointApp(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PinpointApp(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCampaignHook", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pinpoint.PinpointAppCampaignHook\"}}]")]
        public virtual void PutCampaignHook(aws.Pinpoint.IPinpointAppCampaignHook @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Pinpoint.IPinpointAppCampaignHook)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLimits", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pinpoint.PinpointAppLimits\"}}]")]
        public virtual void PutLimits(aws.Pinpoint.IPinpointAppLimits @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Pinpoint.IPinpointAppLimits)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQuietTime", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pinpoint.PinpointAppQuietTime\"}}]")]
        public virtual void PutQuietTime(aws.Pinpoint.IPinpointAppQuietTime @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Pinpoint.IPinpointAppQuietTime)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCampaignHook")]
        public virtual void ResetCampaignHook()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLimits")]
        public virtual void ResetLimits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamePrefix")]
        public virtual void ResetNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuietTime")]
        public virtual void ResetQuietTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.Pinpoint.PinpointApp))!;

        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "campaignHook", typeJson: "{\"fqn\":\"aws.pinpoint.PinpointAppCampaignHookOutputReference\"}")]
        public virtual aws.Pinpoint.PinpointAppCampaignHookOutputReference CampaignHook
        {
            get => GetInstanceProperty<aws.Pinpoint.PinpointAppCampaignHookOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"aws.pinpoint.PinpointAppLimitsOutputReference\"}")]
        public virtual aws.Pinpoint.PinpointAppLimitsOutputReference Limits
        {
            get => GetInstanceProperty<aws.Pinpoint.PinpointAppLimitsOutputReference>()!;
        }

        [JsiiProperty(name: "quietTime", typeJson: "{\"fqn\":\"aws.pinpoint.PinpointAppQuietTimeOutputReference\"}")]
        public virtual aws.Pinpoint.PinpointAppQuietTimeOutputReference QuietTime
        {
            get => GetInstanceProperty<aws.Pinpoint.PinpointAppQuietTimeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "campaignHookInput", typeJson: "{\"fqn\":\"aws.pinpoint.PinpointAppCampaignHook\"}", isOptional: true)]
        public virtual aws.Pinpoint.IPinpointAppCampaignHook? CampaignHookInput
        {
            get => GetInstanceProperty<aws.Pinpoint.IPinpointAppCampaignHook?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "limitsInput", typeJson: "{\"fqn\":\"aws.pinpoint.PinpointAppLimits\"}", isOptional: true)]
        public virtual aws.Pinpoint.IPinpointAppLimits? LimitsInput
        {
            get => GetInstanceProperty<aws.Pinpoint.IPinpointAppLimits?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quietTimeInput", typeJson: "{\"fqn\":\"aws.pinpoint.PinpointAppQuietTime\"}", isOptional: true)]
        public virtual aws.Pinpoint.IPinpointAppQuietTime? QuietTimeInput
        {
            get => GetInstanceProperty<aws.Pinpoint.IPinpointAppQuietTime?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
