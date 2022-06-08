using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputs), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputs")]
    public interface IKinesisAnalyticsApplicationInputs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#name_prefix KinesisAnalyticsApplication#name_prefix}.</summary>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
        string NamePrefix
        {
            get;
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#schema KinesisAnalyticsApplication#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchema\"}")]
        aws.Kinesis.IKinesisAnalyticsApplicationInputsSchema Schema
        {
            get;
        }

        /// <summary>kinesis_firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#kinesis_firehose KinesisAnalyticsApplication#kinesis_firehose}
        /// </remarks>
        [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsKinesisFirehose\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisFirehose? KinesisFirehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_stream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#kinesis_stream KinesisAnalyticsApplication#kinesis_stream}
        /// </remarks>
        [JsiiProperty(name: "kinesisStream", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsKinesisStream\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisStream? KinesisStream
        {
            get
            {
                return null;
            }
        }

        /// <summary>parallelism block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#parallelism KinesisAnalyticsApplication#parallelism}
        /// </remarks>
        [JsiiProperty(name: "parallelism", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsParallelism\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationInputsParallelism? Parallelism
        {
            get
            {
                return null;
            }
        }

        /// <summary>processing_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#processing_configuration KinesisAnalyticsApplication#processing_configuration}
        /// </remarks>
        [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfiguration? ProcessingConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputs), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputs")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationInputs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#name_prefix KinesisAnalyticsApplication#name_prefix}.</summary>
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}")]
            public string NamePrefix
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#schema KinesisAnalyticsApplication#schema}
            /// </remarks>
            [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsSchema\"}")]
            public aws.Kinesis.IKinesisAnalyticsApplicationInputsSchema Schema
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsSchema>()!;
            }

            /// <summary>kinesis_firehose block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#kinesis_firehose KinesisAnalyticsApplication#kinesis_firehose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsKinesisFirehose\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisFirehose? KinesisFirehose
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisFirehose?>();
            }

            /// <summary>kinesis_stream block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#kinesis_stream KinesisAnalyticsApplication#kinesis_stream}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisStream", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsKinesisStream\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisStream? KinesisStream
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsKinesisStream?>();
            }

            /// <summary>parallelism block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#parallelism KinesisAnalyticsApplication#parallelism}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parallelism", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsParallelism\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationInputsParallelism? Parallelism
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsParallelism?>();
            }

            /// <summary>processing_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#processing_configuration KinesisAnalyticsApplication#processing_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "processingConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfiguration? ProcessingConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfiguration?>();
            }
        }
    }
}
