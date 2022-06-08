using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfiguration")]
    public class KinesisAnalyticsApplicationInputsProcessingConfiguration : aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfiguration
    {
        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#lambda KinesisAnalyticsApplication#lambda}
        /// </remarks>
        [JsiiProperty(name: "lambda", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputsProcessingConfigurationLambda\"}")]
        public aws.Kinesis.IKinesisAnalyticsApplicationInputsProcessingConfigurationLambda Lambda
        {
            get;
            set;
        }
    }
}
