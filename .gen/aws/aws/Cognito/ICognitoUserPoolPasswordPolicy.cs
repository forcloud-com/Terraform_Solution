using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolPasswordPolicy), fullyQualifiedName: "aws.cognito.CognitoUserPoolPasswordPolicy")]
    public interface ICognitoUserPoolPasswordPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#minimum_length CognitoUserPool#minimum_length}.</summary>
        [JsiiProperty(name: "minimumLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinimumLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#require_lowercase CognitoUserPool#require_lowercase}.</summary>
        [JsiiProperty(name: "requireLowercase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireLowercase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#require_numbers CognitoUserPool#require_numbers}.</summary>
        [JsiiProperty(name: "requireNumbers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireNumbers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#require_symbols CognitoUserPool#require_symbols}.</summary>
        [JsiiProperty(name: "requireSymbols", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireSymbols
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#require_uppercase CognitoUserPool#require_uppercase}.</summary>
        [JsiiProperty(name: "requireUppercase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireUppercase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#temporary_password_validity_days CognitoUserPool#temporary_password_validity_days}.</summary>
        [JsiiProperty(name: "temporaryPasswordValidityDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TemporaryPasswordValidityDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolPasswordPolicy), fullyQualifiedName: "aws.cognito.CognitoUserPoolPasswordPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoUserPoolPasswordPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#minimum_length CognitoUserPool#minimum_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinimumLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#require_lowercase CognitoUserPool#require_lowercase}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireLowercase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireLowercase
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#require_numbers CognitoUserPool#require_numbers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireNumbers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireNumbers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#require_symbols CognitoUserPool#require_symbols}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireSymbols", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireSymbols
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#require_uppercase CognitoUserPool#require_uppercase}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requireUppercase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RequireUppercase
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#temporary_password_validity_days CognitoUserPool#temporary_password_validity_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "temporaryPasswordValidityDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TemporaryPasswordValidityDays
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
