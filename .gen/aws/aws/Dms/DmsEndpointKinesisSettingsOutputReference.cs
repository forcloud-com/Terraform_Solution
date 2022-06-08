using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    [JsiiClass(nativeType: typeof(aws.Dms.DmsEndpointKinesisSettingsOutputReference), fullyQualifiedName: "aws.dms.DmsEndpointKinesisSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DmsEndpointKinesisSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DmsEndpointKinesisSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpointKinesisSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpointKinesisSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMessageFormat")]
        public virtual void ResetMessageFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceAccessRoleArn")]
        public virtual void ResetServiceAccessRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamArn")]
        public virtual void ResetStreamArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "messageFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MessageFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceAccessRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreamArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MessageFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccessRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointKinesisSettings\"}", isOptional: true)]
        public virtual aws.Dms.IDmsEndpointKinesisSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Dms.IDmsEndpointKinesisSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
