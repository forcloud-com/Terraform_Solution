using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpoint
{
    #pragma warning disable CS8618

    /// <summary>AWS Pinpoint.</summary>
    [JsiiByValue(fqn: "aws.pinpoint.PinpointApnsVoipChannelConfig")]
    public class PinpointApnsVoipChannelConfig : aws.Pinpoint.IPinpointApnsVoipChannelConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_channel#application_id PinpointApnsVoipChannel#application_id}.</summary>
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        public string ApplicationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_channel#bundle_id PinpointApnsVoipChannel#bundle_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BundleId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_channel#certificate PinpointApnsVoipChannel#certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_channel#default_authentication_method PinpointApnsVoipChannel#default_authentication_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultAuthenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultAuthenticationMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_channel#enabled PinpointApnsVoipChannel#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_channel#private_key PinpointApnsVoipChannel#private_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_channel#team_id PinpointApnsVoipChannel#team_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "teamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TeamId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_channel#token_key PinpointApnsVoipChannel#token_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tokenKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_channel#token_key_id PinpointApnsVoipChannel#token_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tokenKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenKeyId
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
