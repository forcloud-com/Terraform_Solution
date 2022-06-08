using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat")]
    public interface IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat
    {
        /// <summary>mapping_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#mapping_parameters KinesisAnalyticsApplication#mapping_parameters}
        /// </remarks>
        [JsiiProperty(name: "mappingParameters", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters? MappingParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>mapping_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#mapping_parameters KinesisAnalyticsApplication#mapping_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mappingParameters", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters? MappingParameters
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormatMappingParameters?>();
            }
        }
    }
}
