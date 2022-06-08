using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiClass(nativeType: typeof(aws.Glue.GlueSecurityConfigurationEncryptionConfigurationOutputReference), fullyQualifiedName: "aws.glue.GlueSecurityConfigurationEncryptionConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueSecurityConfigurationEncryptionConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueSecurityConfigurationEncryptionConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueSecurityConfigurationEncryptionConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueSecurityConfigurationEncryptionConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption\"}}]")]
        public virtual void PutCloudwatchEncryption(aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJobBookmarksEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption\"}}]")]
        public virtual void PutJobBookmarksEncryption(aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Encryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationS3Encryption\"}}]")]
        public virtual void PutS3Encryption(aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption)}, new object[]{@value});
        }

        [JsiiProperty(name: "cloudwatchEncryption", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryptionOutputReference\"}")]
        public virtual aws.Glue.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryptionOutputReference CloudwatchEncryption
        {
            get => GetInstanceProperty<aws.Glue.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "jobBookmarksEncryption", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryptionOutputReference\"}")]
        public virtual aws.Glue.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryptionOutputReference JobBookmarksEncryption
        {
            get => GetInstanceProperty<aws.Glue.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationS3EncryptionOutputReference\"}")]
        public virtual aws.Glue.GlueSecurityConfigurationEncryptionConfigurationS3EncryptionOutputReference S3Encryption
        {
            get => GetInstanceProperty<aws.Glue.GlueSecurityConfigurationEncryptionConfigurationS3EncryptionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchEncryptionInput", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption\"}", isOptional: true)]
        public virtual aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption? CloudwatchEncryptionInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobBookmarksEncryptionInput", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption\"}", isOptional: true)]
        public virtual aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption? JobBookmarksEncryptionInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3EncryptionInput", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationS3Encryption\"}", isOptional: true)]
        public virtual aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption? S3EncryptionInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfiguration\"}", isOptional: true)]
        public virtual aws.Glue.IGlueSecurityConfigurationEncryptionConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Glue.IGlueSecurityConfigurationEncryptionConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
