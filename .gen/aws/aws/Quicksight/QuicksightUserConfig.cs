using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    #pragma warning disable CS8618

    /// <summary>AWS QuickSight.</summary>
    [JsiiByValue(fqn: "aws.quicksight.QuicksightUserConfig")]
    public class QuicksightUserConfig : aws.Quicksight.IQuicksightUserConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#email QuicksightUser#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public string Email
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#identity_type QuicksightUser#identity_type}.</summary>
        [JsiiProperty(name: "identityType", typeJson: "{\"primitive\":\"string\"}")]
        public string IdentityType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#user_role QuicksightUser#user_role}.</summary>
        [JsiiProperty(name: "userRole", typeJson: "{\"primitive\":\"string\"}")]
        public string UserRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#aws_account_id QuicksightUser#aws_account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AwsAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#iam_arn QuicksightUser#iam_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IamArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#namespace QuicksightUser#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#session_name QuicksightUser#session_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SessionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_user#user_name QuicksightUser#user_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserName
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
