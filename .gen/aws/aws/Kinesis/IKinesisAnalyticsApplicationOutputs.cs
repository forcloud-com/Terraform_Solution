using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationOutputs), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationOutputs")]
    public interface IKinesisAnalyticsApplicationOutputs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#name KinesisAnalyticsApplication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#schema KinesisAnalyticsApplication#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputsSchema\"}")]
        aws.Kinesis.IKinesisAnalyticsApplicationOutputsSchema Schema
        {
            get;
        }

        /// <summary>kinesis_firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#kinesis_firehose KinesisAnalyticsApplication#kinesis_firehose}
        /// </remarks>
        [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputsKinesisFirehose\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationOutputsKinesisFirehose? KinesisFirehose
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
        [JsiiProperty(name: "kinesisStream", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputsKinesisStream\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationOutputsKinesisStream? KinesisStream
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#lambda KinesisAnalyticsApplication#lambda}
        /// </remarks>
        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputsLambda\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationOutputsLambda? Lambda
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationOutputs), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationOutputs")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationOutputs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#name KinesisAnalyticsApplication#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#schema KinesisAnalyticsApplication#schema}
            /// </remarks>
            [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputsSchema\"}")]
            public aws.Kinesis.IKinesisAnalyticsApplicationOutputsSchema Schema
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationOutputsSchema>()!;
            }

            /// <summary>kinesis_firehose block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#kinesis_firehose KinesisAnalyticsApplication#kinesis_firehose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisFirehose", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputsKinesisFirehose\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationOutputsKinesisFirehose? KinesisFirehose
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationOutputsKinesisFirehose?>();
            }

            /// <summary>kinesis_stream block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#kinesis_stream KinesisAnalyticsApplication#kinesis_stream}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisStream", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputsKinesisStream\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationOutputsKinesisStream? KinesisStream
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationOutputsKinesisStream?>();
            }

            /// <summary>lambda block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#lambda KinesisAnalyticsApplication#lambda}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputsLambda\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationOutputsLambda? Lambda
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationOutputsLambda?>();
            }
        }
    }
}
