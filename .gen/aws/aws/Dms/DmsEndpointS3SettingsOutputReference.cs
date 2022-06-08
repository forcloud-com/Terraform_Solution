using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    [JsiiClass(nativeType: typeof(aws.Dms.DmsEndpointS3SettingsOutputReference), fullyQualifiedName: "aws.dms.DmsEndpointS3SettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DmsEndpointS3SettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DmsEndpointS3SettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpointS3SettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DmsEndpointS3SettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBucketFolder")]
        public virtual void ResetBucketFolder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBucketName")]
        public virtual void ResetBucketName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompressionType")]
        public virtual void ResetCompressionType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCsvDelimiter")]
        public virtual void ResetCsvDelimiter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCsvRowDelimiter")]
        public virtual void ResetCsvRowDelimiter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternalTableDefinition")]
        public virtual void ResetExternalTableDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceAccessRoleArn")]
        public virtual void ResetServiceAccessRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketFolderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketFolderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompressionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "csvDelimiterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CsvDelimiterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "csvRowDelimiterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CsvRowDelimiterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalTableDefinitionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalTableDefinitionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceAccessRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bucketFolder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketFolder
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompressionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "csvDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CsvDelimiter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "csvRowDelimiter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CsvRowDelimiter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "externalTableDefinition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalTableDefinition
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dms.DmsEndpointS3Settings\"}", isOptional: true)]
        public virtual aws.Dms.IDmsEndpointS3Settings? InternalValue
        {
            get => GetInstanceProperty<aws.Dms.IDmsEndpointS3Settings?>();
            set => SetInstanceProperty(value);
        }
    }
}
