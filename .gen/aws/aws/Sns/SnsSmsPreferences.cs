using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sns
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences aws_sns_sms_preferences}.</summary>
    [JsiiClass(nativeType: typeof(aws.Sns.SnsSmsPreferences), fullyQualifiedName: "aws.sns.SnsSmsPreferences", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.sns.SnsSmsPreferencesConfig\"}}]")]
    public class SnsSmsPreferences : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/sns_sms_preferences aws_sns_sms_preferences} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SnsSmsPreferences(Constructs.Construct scope, string id, aws.Sns.ISnsSmsPreferencesConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SnsSmsPreferences(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SnsSmsPreferences(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDefaultSenderId")]
        public virtual void ResetDefaultSenderId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultSmsType")]
        public virtual void ResetDefaultSmsType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeliveryStatusIamRoleArn")]
        public virtual void ResetDeliveryStatusIamRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeliveryStatusSuccessSamplingRate")]
        public virtual void ResetDeliveryStatusSuccessSamplingRate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonthlySpendLimit")]
        public virtual void ResetMonthlySpendLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsageReportS3Bucket")]
        public virtual void ResetUsageReportS3Bucket()
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
        = GetStaticProperty<string>(typeof(aws.Sns.SnsSmsPreferences))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultSenderIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultSenderIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultSmsTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultSmsTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryStatusIamRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeliveryStatusIamRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryStatusSuccessSamplingRateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeliveryStatusSuccessSamplingRateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monthlySpendLimitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonthlySpendLimitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usageReportS3BucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsageReportS3BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "defaultSenderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultSenderId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultSmsType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultSmsType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deliveryStatusIamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeliveryStatusIamRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deliveryStatusSuccessSamplingRate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeliveryStatusSuccessSamplingRate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monthlySpendLimit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonthlySpendLimit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usageReportS3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageReportS3Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
