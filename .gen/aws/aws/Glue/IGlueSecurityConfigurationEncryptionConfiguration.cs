using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfiguration), fullyQualifiedName: "aws.glue.GlueSecurityConfigurationEncryptionConfiguration")]
    public interface IGlueSecurityConfigurationEncryptionConfiguration
    {
        /// <summary>cloudwatch_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#cloudwatch_encryption GlueSecurityConfiguration#cloudwatch_encryption}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchEncryption", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption\"}")]
        aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption CloudwatchEncryption
        {
            get;
        }

        /// <summary>job_bookmarks_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#job_bookmarks_encryption GlueSecurityConfiguration#job_bookmarks_encryption}
        /// </remarks>
        [JsiiProperty(name: "jobBookmarksEncryption", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption\"}")]
        aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption JobBookmarksEncryption
        {
            get;
        }

        /// <summary>s3_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#s3_encryption GlueSecurityConfiguration#s3_encryption}
        /// </remarks>
        [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationS3Encryption\"}")]
        aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption S3Encryption
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueSecurityConfigurationEncryptionConfiguration), fullyQualifiedName: "aws.glue.GlueSecurityConfigurationEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueSecurityConfigurationEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cloudwatch_encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#cloudwatch_encryption GlueSecurityConfiguration#cloudwatch_encryption}
            /// </remarks>
            [JsiiProperty(name: "cloudwatchEncryption", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption\"}")]
            public aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption CloudwatchEncryption
            {
                get => GetInstanceProperty<aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption>()!;
            }

            /// <summary>job_bookmarks_encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#job_bookmarks_encryption GlueSecurityConfiguration#job_bookmarks_encryption}
            /// </remarks>
            [JsiiProperty(name: "jobBookmarksEncryption", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption\"}")]
            public aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption JobBookmarksEncryption
            {
                get => GetInstanceProperty<aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption>()!;
            }

            /// <summary>s3_encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#s3_encryption GlueSecurityConfiguration#s3_encryption}
            /// </remarks>
            [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationS3Encryption\"}")]
            public aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption S3Encryption
            {
                get => GetInstanceProperty<aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption>()!;
            }
        }
    }
}
