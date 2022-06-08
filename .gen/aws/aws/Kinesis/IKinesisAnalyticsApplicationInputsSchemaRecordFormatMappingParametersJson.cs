using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson")]
    public interface IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_row_path KinesisAnalyticsApplication#record_row_path}.</summary>
        [JsiiProperty(name: "recordRowPath", typeJson: "{\"primitive\":\"string\"}")]
        string RecordRowPath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationInputsSchemaRecordFormatMappingParametersJson
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_row_path KinesisAnalyticsApplication#record_row_path}.</summary>
            [JsiiProperty(name: "recordRowPath", typeJson: "{\"primitive\":\"string\"}")]
            public string RecordRowPath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
