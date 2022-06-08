using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kms
{
    [JsiiInterface(nativeType: typeof(IDataAwsKmsSecretsSecret), fullyQualifiedName: "aws.kms.DataAwsKmsSecretsSecret")]
    public interface IDataAwsKmsSecretsSecret
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secrets#name DataAwsKmsSecrets#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secrets#payload DataAwsKmsSecrets#payload}.</summary>
        [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}")]
        string Payload
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secrets#context DataAwsKmsSecrets#context}.</summary>
        [JsiiProperty(name: "context", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Context
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secrets#grant_tokens DataAwsKmsSecrets#grant_tokens}.</summary>
        [JsiiProperty(name: "grantTokens", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? GrantTokens
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsKmsSecretsSecret), fullyQualifiedName: "aws.kms.DataAwsKmsSecretsSecret")]
        internal sealed class _Proxy : DeputyBase, aws.Kms.IDataAwsKmsSecretsSecret
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secrets#name DataAwsKmsSecrets#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secrets#payload DataAwsKmsSecrets#payload}.</summary>
            [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}")]
            public string Payload
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secrets#context DataAwsKmsSecrets#context}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "context", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Context
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/kms_secrets#grant_tokens DataAwsKmsSecrets#grant_tokens}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "grantTokens", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? GrantTokens
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
