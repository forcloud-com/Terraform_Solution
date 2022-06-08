using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolDeviceConfiguration")]
    public class CognitoUserPoolDeviceConfiguration : aws.Cognito.ICognitoUserPoolDeviceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#challenge_required_on_new_device CognitoUserPool#challenge_required_on_new_device}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "challengeRequiredOnNewDevice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ChallengeRequiredOnNewDevice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#device_only_remembered_on_user_prompt CognitoUserPool#device_only_remembered_on_user_prompt}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceOnlyRememberedOnUserPrompt", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DeviceOnlyRememberedOnUserPrompt
        {
            get;
            set;
        }
    }
}
