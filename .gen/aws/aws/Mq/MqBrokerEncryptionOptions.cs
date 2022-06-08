using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    [JsiiByValue(fqn: "aws.mq.MqBrokerEncryptionOptions")]
    public class MqBrokerEncryptionOptions : aws.Mq.IMqBrokerEncryptionOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#kms_key_id MqBroker#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mq_broker#use_aws_owned_key MqBroker#use_aws_owned_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useAwsOwnedKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseAwsOwnedKey
        {
            get;
            set;
        }
    }
}
