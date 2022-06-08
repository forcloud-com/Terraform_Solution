using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationInputsParallelism")]
    public class KinesisAnalyticsApplicationInputsParallelism : aws.Kinesis.IKinesisAnalyticsApplicationInputsParallelism
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#count KinesisAnalyticsApplication#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public double Count
        {
            get;
            set;
        }
    }
}
