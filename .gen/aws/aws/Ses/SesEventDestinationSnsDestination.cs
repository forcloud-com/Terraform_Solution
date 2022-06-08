using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ses.SesEventDestinationSnsDestination")]
    public class SesEventDestinationSnsDestination : aws.Ses.ISesEventDestinationSnsDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#topic_arn SesEventDestination#topic_arn}.</summary>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        public string TopicArn
        {
            get;
            set;
        }
    }
}
