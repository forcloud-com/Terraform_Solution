using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchema), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchema")]
    public interface IKinesisAnalyticsApplicationReferenceDataSourcesSchema
    {
        /// <summary>record_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_columns KinesisAnalyticsApplication#record_columns}
        /// </remarks>
        [JsiiProperty(name: "recordColumns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns\"},\"kind\":\"array\"}}]}}")]
        object RecordColumns
        {
            get;
        }

        /// <summary>record_format block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_format KinesisAnalyticsApplication#record_format}
        /// </remarks>
        [JsiiProperty(name: "recordFormat", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat\"}")]
        aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat RecordFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_encoding KinesisAnalyticsApplication#record_encoding}.</summary>
        [JsiiProperty(name: "recordEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecordEncoding
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationReferenceDataSourcesSchema), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchema")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>record_columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_columns KinesisAnalyticsApplication#record_columns}
            /// </remarks>
            [JsiiProperty(name: "recordColumns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordColumns\"},\"kind\":\"array\"}}]}}")]
            public object RecordColumns
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>record_format block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_format KinesisAnalyticsApplication#record_format}
            /// </remarks>
            [JsiiProperty(name: "recordFormat", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat\"}")]
            public aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat RecordFormat
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSourcesSchemaRecordFormat>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_encoding KinesisAnalyticsApplication#record_encoding}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recordEncoding", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecordEncoding
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
