using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iam
{
    /// <summary>AWS Identity and Access Management.</summary>
    [JsiiByValue(fqn: "aws.iam.IamAccountPasswordPolicyConfig")]
    public class IamAccountPasswordPolicyConfig : aws.Iam.IIamAccountPasswordPolicyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#allow_users_to_change_password IamAccountPasswordPolicy#allow_users_to_change_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowUsersToChangePassword", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowUsersToChangePassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#hard_expiry IamAccountPasswordPolicy#hard_expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hardExpiry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? HardExpiry
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#max_password_age IamAccountPasswordPolicy#max_password_age}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPasswordAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPasswordAge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#minimum_password_length IamAccountPasswordPolicy#minimum_password_length}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumPasswordLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumPasswordLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#password_reuse_prevention IamAccountPasswordPolicy#password_reuse_prevention}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordReusePrevention", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PasswordReusePrevention
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#require_lowercase_characters IamAccountPasswordPolicy#require_lowercase_characters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireLowercaseCharacters", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireLowercaseCharacters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#require_numbers IamAccountPasswordPolicy#require_numbers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireNumbers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireNumbers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#require_symbols IamAccountPasswordPolicy#require_symbols}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireSymbols", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireSymbols
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#require_uppercase_characters IamAccountPasswordPolicy#require_uppercase_characters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireUppercaseCharacters", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RequireUppercaseCharacters
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
