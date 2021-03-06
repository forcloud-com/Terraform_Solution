using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiByValue(fqn: "aws.AwsProviderAssumeRole")]
    public class AwsProviderAssumeRole : aws.IAwsProviderAssumeRole
    {
        /// <summary>The external ID to use when assuming the role.</summary>
        /// <remarks>
        /// If omitted, no external ID is passed to the AssumeRole call.
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#external_id AwsProvider#external_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalId
        {
            get;
            set;
        }

        /// <summary>The permissions applied when assuming a role.</summary>
        /// <remarks>
        /// You cannot use, this policy to grant further permissions that are in excess to those of the,  role that is being assumed.
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#policy AwsProvider#policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Policy
        {
            get;
            set;
        }

        /// <summary>The ARN of an IAM role to assume prior to making API calls.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#role_arn AwsProvider#role_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleArn
        {
            get;
            set;
        }

        /// <summary>The session name to use when assuming the role.</summary>
        /// <remarks>
        /// If omitted, no session name is passed to the AssumeRole call.
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws#session_name AwsProvider#session_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sessionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SessionName
        {
            get;
            set;
        }
    }
}
