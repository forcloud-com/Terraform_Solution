using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormat), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormat")]
    public interface IKinesisAnalyticsApplicationInputsSchemaRecordFormat
    {
        /// <summary>mapping_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#mapping_parameters KinesisAnalyticsApplication#mapping_parameters}
        /// </remarks>
        [JsiiProperty(name: "mappingParameters", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters? MappingParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormat), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormat")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>mapping_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#mapping_parameters KinesisAnalyticsApplication#mapping_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mappingParameters", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters? MappingParameters
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters?>();
            }
        }
    }
}
