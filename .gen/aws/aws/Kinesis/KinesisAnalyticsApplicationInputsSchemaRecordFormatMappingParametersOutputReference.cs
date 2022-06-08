using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersOutputReference), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCsv", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv\"}}]")]
        public virtual void PutCsv(aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJson", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson\"}}]")]
        public virtual void PutJson(aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson)}, new object[]{@value});
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

        [JsiiProperty(name: "csv", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsvOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsvOutputReference Csv
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsvOutputReference>()!;
        }

        [JsiiProperty(name: "json", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJsonOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJsonOutputReference Json
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJsonOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "csvInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv? CsvInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jsonInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson? JsonInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
