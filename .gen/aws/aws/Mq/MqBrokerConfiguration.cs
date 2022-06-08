using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    [JsiiByValue(fqn: "aws.mq.MqBrokerConfiguration")]
    public class MqBrokerConfiguration : aws.Mq.IMqBrokerConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#id MqBroker#id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#revision MqBroker#revision}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Revision
        {
            get;
            set;
        }
    }
}
