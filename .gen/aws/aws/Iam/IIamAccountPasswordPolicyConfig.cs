using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iam
{
    /// <summary>AWS Identity and Access Management.</summary>
    [JsiiInterface(nativeType: typeof(IIamAccountPasswordPolicyConfig), fullyQualifiedName: "aws.iam.IamAccountPasswordPolicyConfig")]
    public interface IIamAccountPasswordPolicyConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#allow_users_to_change_password IamAccountPasswordPolicy#allow_users_to_change_password}.</summary>
        [JsiiProperty(name: "allowUsersToChangePassword", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowUsersToChangePassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#hard_expiry IamAccountPasswordPolicy#hard_expiry}.</summary>
        [JsiiProperty(name: "hardExpiry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HardExpiry
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#max_password_age IamAccountPasswordPolicy#max_password_age}.</summary>
        [JsiiProperty(name: "maxPasswordAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPasswordAge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#minimum_password_length IamAccountPasswordPolicy#minimum_password_length}.</summary>
        [JsiiProperty(name: "minimumPasswordLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumPasswordLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#password_reuse_prevention IamAccountPasswordPolicy#password_reuse_prevention}.</summary>
        [JsiiProperty(name: "passwordReusePrevention", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PasswordReusePrevention
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#require_lowercase_characters IamAccountPasswordPolicy#require_lowercase_characters}.</summary>
        [JsiiProperty(name: "requireLowercaseCharacters", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireLowercaseCharacters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#require_numbers IamAccountPasswordPolicy#require_numbers}.</summary>
        [JsiiProperty(name: "requireNumbers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireNumbers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#require_symbols IamAccountPasswordPolicy#require_symbols}.</summary>
        [JsiiProperty(name: "requireSymbols", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireSymbols
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#require_uppercase_characters IamAccountPasswordPolicy#require_uppercase_characters}.</summary>
        [JsiiProperty(name: "requireUppercaseCharacters", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireUppercaseCharacters
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Identity and Access Management.</summary>
        [JsiiTypeProxy(nativeType: typeof(IIamAccountPasswordPolicyConfig), fullyQualifiedName: "aws.iam.IamAccountPasswordPolicyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Iam.IIamAccountPasswordPolicyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#allow_users_to_change_password IamAccountPasswordPolicy#allow_users_to_change_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowUsersToChangePassword", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowUsersToChangePassword
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#hard_expiry IamAccountPasswordPolicy#hard_expiry}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hardExpiry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? HardExpiry
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#max_password_age IamAccountPasswordPolicy#max_password_age}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPasswordAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPasswordAge
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#minimum_password_length IamAccountPasswordPolicy#minimum_password_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumPasswordLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumPasswordLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#password_reuse_prevention IamAccountPasswordPolicy#password_reuse_prevention}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordReusePrevention", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PasswordReusePrevention
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#require_lowercase_characters IamAccountPasswordPolicy#require_lowercase_characters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireLowercaseCharacters", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireLowercaseCharacters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#require_numbers IamAccountPasswordPolicy#require_numbers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireNumbers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireNumbers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#require_symbols IamAccountPasswordPolicy#require_symbols}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireSymbols", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireSymbols
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iam_account_password_policy#require_uppercase_characters IamAccountPasswordPolicy#require_uppercase_characters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireUppercaseCharacters", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireUppercaseCharacters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
