using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ses.SesEventDestinationKinesisDestination")]
    public class SesEventDestinationKinesisDestination : aws.Ses.ISesEventDestinationKinesisDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#role_arn SesEventDestination#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#stream_arn SesEventDestination#stream_arn}.</summary>
        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        public string StreamArn
        {
            get;
            set;
        }
    }
}
