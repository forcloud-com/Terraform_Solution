using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    [JsiiClass(nativeType: typeof(aws.Athena.AthenaWorkgroupConfigurationResultConfigurationOutputReference), fullyQualifiedName: "aws.athena.AthenaWorkgroupConfigurationResultConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AthenaWorkgroupConfigurationResultConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AthenaWorkgroupConfigurationResultConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaWorkgroupConfigurationResultConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaWorkgroupConfigurationResultConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEncryptionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration\"}}]")]
        public virtual void PutEncryptionConfiguration(aws.Athena.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Athena.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEncryptionConfiguration")]
        public virtual void ResetEncryptionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputLocation")]
        public virtual void ResetOutputLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfigurationOutputReference\"}")]
        public virtual aws.Athena.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfigurationOutputReference EncryptionConfiguration
        {
            get => GetInstanceProperty<aws.Athena.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfigurationInput", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration\"}", isOptional: true)]
        public virtual aws.Athena.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration? EncryptionConfigurationInput
        {
            get => GetInstanceProperty<aws.Athena.IAthenaWorkgroupConfigurationResultConfigurationEncryptionConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputLocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputLocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "outputLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputLocation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfiguration\"}", isOptional: true)]
        public virtual aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
