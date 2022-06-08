using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationInputsParallelism), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsParallelism")]
    public interface IKinesisAnalyticsApplicationInputsParallelism
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#count KinesisAnalyticsApplication#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        double Count
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationInputsParallelism), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationInputsParallelism")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationInputsParallelism
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#count KinesisAnalyticsApplication#count}.</summary>
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
            public double Count
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
