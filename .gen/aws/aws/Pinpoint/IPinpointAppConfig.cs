using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpoint
{
    /// <summary>AWS Pinpoint.</summary>
    [JsiiInterface(nativeType: typeof(IPinpointAppConfig), fullyQualifiedName: "aws.pinpoint.PinpointAppConfig")]
    public interface IPinpointAppConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>campaign_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#campaign_hook PinpointApp#campaign_hook}
        /// </remarks>
        [JsiiProperty(name: "campaignHook", typeJson: "{\"fqn\":\"aws.pinpoint.PinpointAppCampaignHook\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Pinpoint.IPinpointAppCampaignHook? CampaignHook
        {
            get
            {
                return null;
            }
        }

        /// <summary>limits block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#limits PinpointApp#limits}
        /// </remarks>
        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"aws.pinpoint.PinpointAppLimits\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Pinpoint.IPinpointAppLimits? Limits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#name PinpointApp#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#name_prefix PinpointApp#name_prefix}.</summary>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>quiet_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#quiet_time PinpointApp#quiet_time}
        /// </remarks>
        [JsiiProperty(name: "quietTime", typeJson: "{\"fqn\":\"aws.pinpoint.PinpointAppQuietTime\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Pinpoint.IPinpointAppQuietTime? QuietTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#tags PinpointApp#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Pinpoint.</summary>
        [JsiiTypeProxy(nativeType: typeof(IPinpointAppConfig), fullyQualifiedName: "aws.pinpoint.PinpointAppConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Pinpoint.IPinpointAppConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>campaign_hook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#campaign_hook PinpointApp#campaign_hook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "campaignHook", typeJson: "{\"fqn\":\"aws.pinpoint.PinpointAppCampaignHook\"}", isOptional: true)]
            public aws.Pinpoint.IPinpointAppCampaignHook? CampaignHook
            {
                get => GetInstanceProperty<aws.Pinpoint.IPinpointAppCampaignHook?>();
            }

            /// <summary>limits block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#limits PinpointApp#limits}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"aws.pinpoint.PinpointAppLimits\"}", isOptional: true)]
            public aws.Pinpoint.IPinpointAppLimits? Limits
            {
                get => GetInstanceProperty<aws.Pinpoint.IPinpointAppLimits?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#name PinpointApp#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#name_prefix PinpointApp#name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>quiet_time block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#quiet_time PinpointApp#quiet_time}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "quietTime", typeJson: "{\"fqn\":\"aws.pinpoint.PinpointAppQuietTime\"}", isOptional: true)]
            public aws.Pinpoint.IPinpointAppQuietTime? QuietTime
            {
                get => GetInstanceProperty<aws.Pinpoint.IPinpointAppQuietTime?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#tags PinpointApp#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
