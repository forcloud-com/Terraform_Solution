using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiClass(nativeType: typeof(aws.Kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatOutputReference), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KinesisAnalyticsApplicationInputsSchemaRecordFormatOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KinesisAnalyticsApplicationInputsSchemaRecordFormatOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationInputsSchemaRecordFormatOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KinesisAnalyticsApplicationInputsSchemaRecordFormatOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMappingParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters\"}}]")]
        public virtual void PutMappingParameters(aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMappingParameters")]
        public virtual void ResetMappingParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "mappingParameters", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersOutputReference\"}")]
        public virtual aws.Kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersOutputReference MappingParameters
        {
            get => GetInstanceProperty<aws.Kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersOutputReference>()!;
        }

        [JsiiProperty(name: "recordFormatType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordFormatType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "mappingParametersInput", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters? MappingParametersInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormat\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormat? InternalValue
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormat?>();
            set => SetInstanceProperty(value);
        }
    }
}
