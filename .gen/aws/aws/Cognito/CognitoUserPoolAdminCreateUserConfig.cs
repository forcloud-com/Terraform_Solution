using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolAdminCreateUserConfig")]
    public class CognitoUserPoolAdminCreateUserConfig : aws.Cognito.ICognitoUserPoolAdminCreateUserConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#allow_admin_create_user_only CognitoUserPool#allow_admin_create_user_only}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowAdminCreateUserOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowAdminCreateUserOnly
        {
            get;
            set;
        }

        /// <summary>invite_message_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#invite_message_template CognitoUserPool#invite_message_template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inviteMessageTemplate", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate\"}", isOptional: true)]
        public aws.Cognito.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate? InviteMessageTemplate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#unused_account_validity_days CognitoUserPool#unused_account_validity_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unusedAccountValidityDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnusedAccountValidityDays
        {
            get;
            set;
        }
    }
}
