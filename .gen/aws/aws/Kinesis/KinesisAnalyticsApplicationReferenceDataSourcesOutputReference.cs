using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesOutputReference), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KinesisAnalyticsApplicationReferenceDataSourcesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationReferenceDataSourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationReferenceDataSourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesS3\"}}]")]
        public virtual void PutS3(aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchema", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchema\"}}]")]
        public virtual void PutSchema(aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchema @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchema)}, new object[]{@value});
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesS3OutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesS3OutputReference S3
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesS3OutputReference>()!;
        }

        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaOutputReference Schema
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesS3\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesS3? S3Input
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchema\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchema? SchemaInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchema?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSources\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSources? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSources?>();
            set => SetInstanceProperty(value);
        }
    }
}
