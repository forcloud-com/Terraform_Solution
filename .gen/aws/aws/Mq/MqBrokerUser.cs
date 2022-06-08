using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mq.MqBrokerUser")]
    public class MqBrokerUser : aws.Mq.IMqBrokerUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#password MqBroker#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#username MqBroker#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#console_access MqBroker#console_access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "consoleAccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ConsoleAccess
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#groups MqBroker#groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Groups
        {
            get;
            set;
        }
    }
}
