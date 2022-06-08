using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersOutputReference), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCsv", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv\"}}]")]
        public virtual void PutCsv(aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJson", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson\"}}]")]
        public virtual void PutJson(aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCsv")]
        public virtual void ResetCsv()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJson")]
        public virtual void ResetJson()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "csv", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsvOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsvOutputReference Csv
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsvOutputReference>()!;
        }

        [JsiiProperty(name: "json", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJsonOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJsonOutputReference Json
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJsonOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "csvInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv? CsvInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersCsv?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jsonInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson? JsonInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParametersJson?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
