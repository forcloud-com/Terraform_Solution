using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kms
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kms.DataAwsKmsSecretsSecret")]
    public class DataAwsKmsSecretsSecret : aws.Kms.IDataAwsKmsSecretsSecret
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secrets#name DataAwsKmsSecrets#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secrets#payload DataAwsKmsSecrets#payload}.</summary>
        [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}")]
        public string Payload
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secrets#context DataAwsKmsSecrets#context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "context", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Context
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secrets#grant_tokens DataAwsKmsSecrets#grant_tokens}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "grantTokens", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GrantTokens
        {
            get;
            set;
        }
    }
}
