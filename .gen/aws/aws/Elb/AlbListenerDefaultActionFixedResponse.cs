using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.AlbListenerDefaultActionFixedResponse")]
    public class AlbListenerDefaultActionFixedResponse : aws.Elb.IAlbListenerDefaultActionFixedResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#content_type AlbListener#content_type}.</summary>
        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#message_body AlbListener#message_body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageBody
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#status_code AlbListener#status_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StatusCode
        {
            get;
            set;
        }
    }
}
