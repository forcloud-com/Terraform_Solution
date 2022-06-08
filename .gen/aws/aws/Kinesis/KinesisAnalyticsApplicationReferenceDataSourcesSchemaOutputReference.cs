using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaOutputReference), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesSchemaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KinesisAnalyticsApplicationReferenceDataSourcesSchemaOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationReferenceDataSourcesSchemaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationReferenceDataSourcesSchemaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRecordFormat", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat\"}}]")]
        public virtual void PutRecordFormat(aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRecordEncoding")]
        public virtual void ResetRecordEncoding()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "recordFormat", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatOutputReference RecordFormat
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordColumnsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RecordColumnsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordEncodingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecordEncodingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordFormatInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat? RecordFormatInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat?>();
        }

        [JsiiProperty(name: "recordColumns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns\"},\"kind\":\"array\"}}]}}")]
        public virtual object RecordColumns
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recordEncoding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordEncoding
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchema\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchema? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchema?>();
            set => SetInstanceProperty(value);
        }
    }
}
