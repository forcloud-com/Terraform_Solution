using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Worklink
{
    /// <summary>AWS WorkLink.</summary>
    [JsiiInterface(nativeType: typeof(IWorklinkFleetConfig), fullyQualifiedName: "aws.worklink.WorklinkFleetConfig")]
    public interface IWorklinkFleetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#name WorklinkFleet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#audit_stream_arn WorklinkFleet#audit_stream_arn}.</summary>
        [JsiiProperty(name: "auditStreamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuditStreamArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#device_ca_certificate WorklinkFleet#device_ca_certificate}.</summary>
        [JsiiProperty(name: "deviceCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeviceCaCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#display_name WorklinkFleet#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>identity_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#identity_provider WorklinkFleet#identity_provider}
        /// </remarks>
        [JsiiProperty(name: "identityProvider", typeJson: "{\"fqn\":\"aws.worklink.WorklinkFleetIdentityProvider\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Worklink.IWorklinkFleetIdentityProvider? IdentityProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#network WorklinkFleet#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"aws.worklink.WorklinkFleetNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Worklink.IWorklinkFleetNetwork? Network
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#optimize_for_end_user_location WorklinkFleet#optimize_for_end_user_location}.</summary>
        [JsiiProperty(name: "optimizeForEndUserLocation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OptimizeForEndUserLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS WorkLink.</summary>
        [JsiiTypeProxy(nativeType: typeof(IWorklinkFleetConfig), fullyQualifiedName: "aws.worklink.WorklinkFleetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Worklink.IWorklinkFleetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#name WorklinkFleet#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#audit_stream_arn WorklinkFleet#audit_stream_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "auditStreamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuditStreamArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#device_ca_certificate WorklinkFleet#device_ca_certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deviceCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeviceCaCertificate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#display_name WorklinkFleet#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>identity_provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#identity_provider WorklinkFleet#identity_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identityProvider", typeJson: "{\"fqn\":\"aws.worklink.WorklinkFleetIdentityProvider\"}", isOptional: true)]
            public aws.Worklink.IWorklinkFleetIdentityProvider? IdentityProvider
            {
                get => GetInstanceProperty<aws.Worklink.IWorklinkFleetIdentityProvider?>();
            }

            /// <summary>network block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#network WorklinkFleet#network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"aws.worklink.WorklinkFleetNetwork\"}", isOptional: true)]
            public aws.Worklink.IWorklinkFleetNetwork? Network
            {
                get => GetInstanceProperty<aws.Worklink.IWorklinkFleetNetwork?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#optimize_for_end_user_location WorklinkFleet#optimize_for_end_user_location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "optimizeForEndUserLocation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? OptimizeForEndUserLocation
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
