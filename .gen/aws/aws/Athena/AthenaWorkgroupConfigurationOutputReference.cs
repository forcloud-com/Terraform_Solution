using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    [JsiiClass(nativeType: typeof(aws.Athena.AthenaWorkgroupConfigurationOutputReference), fullyQualifiedName: "aws.athena.AthenaWorkgroupConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AthenaWorkgroupConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AthenaWorkgroupConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaWorkgroupConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaWorkgroupConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResultConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfiguration\"}}]")]
        public virtual void PutResultConfiguration(aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBytesScannedCutoffPerQuery")]
        public virtual void ResetBytesScannedCutoffPerQuery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnforceWorkgroupConfiguration")]
        public virtual void ResetEnforceWorkgroupConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublishCloudwatchMetricsEnabled")]
        public virtual void ResetPublishCloudwatchMetricsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResultConfiguration")]
        public virtual void ResetResultConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "resultConfiguration", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfigurationOutputReference\"}")]
        public virtual aws.Athena.AthenaWorkgroupConfigurationResultConfigurationOutputReference ResultConfiguration
        {
            get => GetInstanceProperty<aws.Athena.AthenaWorkgroupConfigurationResultConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bytesScannedCutoffPerQueryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BytesScannedCutoffPerQueryInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enforceWorkgroupConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnforceWorkgroupConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publishCloudwatchMetricsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PublishCloudwatchMetricsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resultConfigurationInput", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfiguration\"}", isOptional: true)]
        public virtual aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration? ResultConfigurationInput
        {
            get => GetInstanceProperty<aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration?>();
        }

        [JsiiProperty(name: "bytesScannedCutoffPerQuery", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BytesScannedCutoffPerQuery
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enforceWorkgroupConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnforceWorkgroupConfiguration
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publishCloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PublishCloudwatchMetricsEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfiguration\"}", isOptional: true)]
        public virtual aws.Athena.IAthenaWorkgroupConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Athena.IAthenaWorkgroupConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
