using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationOutputsSchema), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationOutputsSchema")]
    public interface IKinesisAnalyticsApplicationOutputsSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_format_type KinesisAnalyticsApplication#record_format_type}.</summary>
        [JsiiProperty(name: "recordFormatType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecordFormatType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationOutputsSchema), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationOutputsSchema")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationOutputsSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#record_format_type KinesisAnalyticsApplication#record_format_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recordFormatType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecordFormatType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
