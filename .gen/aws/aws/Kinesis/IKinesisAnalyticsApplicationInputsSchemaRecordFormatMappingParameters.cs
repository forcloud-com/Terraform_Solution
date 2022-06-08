using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters")]
    public interface IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters
    {
        /// <summary>csv block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#csv KinesisAnalyticsApplication#csv}
        /// </remarks>
        [JsiiProperty(name: "csv", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv? Csv
        {
            get
            {
                return null;
            }
        }

        /// <summary>json block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#json KinesisAnalyticsApplication#json}
        /// </remarks>
        [JsiiProperty(name: "json", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson? Json
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>csv block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#csv KinesisAnalyticsApplication#csv}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "csv", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv? Csv
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersCsv?>();
            }

            /// <summary>json block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#json KinesisAnalyticsApplication#json}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "json", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson? Json
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson?>();
            }
        }
    }
}
