using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    [JsiiClass(nativeType: typeof(aws.Dms.DmsEndpointElasticsearchSettingsOutputReference), fullyQualifiedName: "aws.dms.DmsEndpointElasticsearchSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DmsEndpointElasticsearchSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DmsEndpointElasticsearchSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpointElasticsearchSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpointElasticsearchSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetErrorRetryDuration")]
        public virtual void ResetErrorRetryDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFullLoadErrorPercentage")]
        public virtual void ResetFullLoadErrorPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorRetryDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ErrorRetryDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fullLoadErrorPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FullLoadErrorPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceAccessRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "endpointUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "errorRetryDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ErrorRetryDuration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fullLoadErrorPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FullLoadErrorPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccessRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointElasticsearchSettings\"}", isOptional: true)]
        public virtual aws.Dms.IDmsEndpointElasticsearchSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Dms.IDmsEndpointElasticsearchSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
