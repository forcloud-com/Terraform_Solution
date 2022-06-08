using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    [JsiiInterface(nativeType: typeof(ISesEventDestinationSnsDestination), fullyQualifiedName: "aws.ses.SesEventDestinationSnsDestination")]
    public interface ISesEventDestinationSnsDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#topic_arn SesEventDestination#topic_arn}.</summary>
        [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
        string TopicArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISesEventDestinationSnsDestination), fullyQualifiedName: "aws.ses.SesEventDestinationSnsDestination")]
        internal sealed class _Proxy : DeputyBase, aws.Ses.ISesEventDestinationSnsDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#topic_arn SesEventDestination#topic_arn}.</summary>
            [JsiiProperty(name: "topicArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
