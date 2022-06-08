using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.GlueSecurityConfigurationEncryptionConfiguration")]
    public class GlueSecurityConfigurationEncryptionConfiguration : aws.Glue.IGlueSecurityConfigurationEncryptionConfiguration
    {
        /// <summary>cloudwatch_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#cloudwatch_encryption GlueSecurityConfiguration#cloudwatch_encryption}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchEncryption", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption\"}")]
        public aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption CloudwatchEncryption
        {
            get;
            set;
        }

        /// <summary>job_bookmarks_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#job_bookmarks_encryption GlueSecurityConfiguration#job_bookmarks_encryption}
        /// </remarks>
        [JsiiProperty(name: "jobBookmarksEncryption", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption\"}")]
        public aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption JobBookmarksEncryption
        {
            get;
            set;
        }

        /// <summary>s3_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_security_configuration#s3_encryption GlueSecurityConfiguration#s3_encryption}
        /// </remarks>
        [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.glue.GlueSecurityConfigurationEncryptionConfigurationS3Encryption\"}")]
        public aws.Glue.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption S3Encryption
        {
            get;
            set;
        }
    }
}
