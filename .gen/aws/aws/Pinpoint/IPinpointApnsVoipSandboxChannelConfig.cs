using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpoint
{
    /// <summary>AWS Pinpoint.</summary>
    [JsiiInterface(nativeType: typeof(IPinpointApnsVoipSandboxChannelConfig), fullyQualifiedName: "aws.pinpoint.PinpointApnsVoipSandboxChannelConfig")]
    public interface IPinpointApnsVoipSandboxChannelConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#application_id PinpointApnsVoipSandboxChannel#application_id}.</summary>
        [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
        string ApplicationId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#bundle_id PinpointApnsVoipSandboxChannel#bundle_id}.</summary>
        [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BundleId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#certificate PinpointApnsVoipSandboxChannel#certificate}.</summary>
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Certificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#default_authentication_method PinpointApnsVoipSandboxChannel#default_authentication_method}.</summary>
        [JsiiProperty(name: "defaultAuthenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultAuthenticationMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#enabled PinpointApnsVoipSandboxChannel#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#private_key PinpointApnsVoipSandboxChannel#private_key}.</summary>
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#team_id PinpointApnsVoipSandboxChannel#team_id}.</summary>
        [JsiiProperty(name: "teamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TeamId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#token_key PinpointApnsVoipSandboxChannel#token_key}.</summary>
        [JsiiProperty(name: "tokenKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#token_key_id PinpointApnsVoipSandboxChannel#token_key_id}.</summary>
        [JsiiProperty(name: "tokenKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Pinpoint.</summary>
        [JsiiTypeProxy(nativeType: typeof(IPinpointApnsVoipSandboxChannelConfig), fullyQualifiedName: "aws.pinpoint.PinpointApnsVoipSandboxChannelConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Pinpoint.IPinpointApnsVoipSandboxChannelConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#application_id PinpointApnsVoipSandboxChannel#application_id}.</summary>
            [JsiiProperty(name: "applicationId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApplicationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#bundle_id PinpointApnsVoipSandboxChannel#bundle_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bundleId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BundleId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#certificate PinpointApnsVoipSandboxChannel#certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Certificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#default_authentication_method PinpointApnsVoipSandboxChannel#default_authentication_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultAuthenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultAuthenticationMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#enabled PinpointApnsVoipSandboxChannel#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#private_key PinpointApnsVoipSandboxChannel#private_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#team_id PinpointApnsVoipSandboxChannel#team_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "teamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TeamId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#token_key PinpointApnsVoipSandboxChannel#token_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tokenKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_apns_voip_sandbox_channel#token_key_id PinpointApnsVoipSandboxChannel#token_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tokenKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenKeyId
            {
                get => GetInstanceProperty<string?>();
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
