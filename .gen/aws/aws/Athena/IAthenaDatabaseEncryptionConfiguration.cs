using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    [JsiiInterface(nativeType: typeof(IAthenaDatabaseEncryptionConfiguration), fullyQualifiedName: "aws.athena.AthenaDatabaseEncryptionConfiguration")]
    public interface IAthenaDatabaseEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_database#encryption_option AthenaDatabase#encryption_option}.</summary>
        [JsiiProperty(name: "encryptionOption", typeJson: "{\"primitive\":\"string\"}")]
        string EncryptionOption
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_database#kms_key AthenaDatabase#kms_key}.</summary>
        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaDatabaseEncryptionConfiguration), fullyQualifiedName: "aws.athena.AthenaDatabaseEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Athena.IAthenaDatabaseEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_database#encryption_option AthenaDatabase#encryption_option}.</summary>
            [JsiiProperty(name: "encryptionOption", typeJson: "{\"primitive\":\"string\"}")]
            public string EncryptionOption
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_database#kms_key AthenaDatabase#kms_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
