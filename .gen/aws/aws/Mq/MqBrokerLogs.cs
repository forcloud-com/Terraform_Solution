using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    [JsiiByValue(fqn: "aws.mq.MqBrokerLogs")]
    public class MqBrokerLogs : aws.Mq.IMqBrokerLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#audit MqBroker#audit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "audit", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Audit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#general MqBroker#general}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "general", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? General
        {
            get;
            set;
        }
    }
}
