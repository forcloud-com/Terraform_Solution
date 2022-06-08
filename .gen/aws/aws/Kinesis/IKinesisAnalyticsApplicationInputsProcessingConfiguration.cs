using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsProcessingConfiguration), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfiguration")]
    public interface IKinesisAnalyticsApplicationInputsProcessingConfiguration
    {
        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#lambda KinesisAnalyticsApplication#lambda}
        /// </remarks>
        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfigurationLambda\"}")]
        aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfigurationLambda Lambda
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsProcessingConfiguration), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>lambda block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#lambda KinesisAnalyticsApplication#lambda}
            /// </remarks>
            [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfigurationLambda\"}")]
            public aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfigurationLambda Lambda
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfigurationLambda>()!;
            }
        }
    }
}
