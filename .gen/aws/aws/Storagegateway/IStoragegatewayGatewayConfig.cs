using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    /// <summary>AWS Storage Gateway.</summary>
    [JsiiInterface(nativeType: typeof(IStoragegatewayGatewayConfig), fullyQualifiedName: "aws.storagegateway.StoragegatewayGatewayConfig")]
    public interface IStoragegatewayGatewayConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_name StoragegatewayGateway#gateway_name}.</summary>
        [JsiiProperty(name: "gatewayName", typeJson: "{\"primitive\":\"string\"}")]
        string GatewayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_timezone StoragegatewayGateway#gateway_timezone}.</summary>
        [JsiiProperty(name: "gatewayTimezone", typeJson: "{\"primitive\":\"string\"}")]
        string GatewayTimezone
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#activation_key StoragegatewayGateway#activation_key}.</summary>
        [JsiiProperty(name: "activationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActivationKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#cloudwatch_log_group_arn StoragegatewayGateway#cloudwatch_log_group_arn}.</summary>
        [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudwatchLogGroupArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_ip_address StoragegatewayGateway#gateway_ip_address}.</summary>
        [JsiiProperty(name: "gatewayIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GatewayIpAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_type StoragegatewayGateway#gateway_type}.</summary>
        [JsiiProperty(name: "gatewayType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GatewayType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_vpc_endpoint StoragegatewayGateway#gateway_vpc_endpoint}.</summary>
        [JsiiProperty(name: "gatewayVpcEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GatewayVpcEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#medium_changer_type StoragegatewayGateway#medium_changer_type}.</summary>
        [JsiiProperty(name: "mediumChangerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MediumChangerType
        {
            get
            {
                return null;
            }
        }

        /// <summary>smb_active_directory_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#smb_active_directory_settings StoragegatewayGateway#smb_active_directory_settings}
        /// </remarks>
        [JsiiProperty(name: "smbActiveDirectorySettings", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayGatewaySmbActiveDirectorySettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Storagegateway.IStoragegatewayGatewaySmbActiveDirectorySettings? SmbActiveDirectorySettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#smb_guest_password StoragegatewayGateway#smb_guest_password}.</summary>
        [JsiiProperty(name: "smbGuestPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SmbGuestPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#tags StoragegatewayGateway#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#tape_drive_type StoragegatewayGateway#tape_drive_type}.</summary>
        [JsiiProperty(name: "tapeDriveType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TapeDriveType
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#timeouts StoragegatewayGateway#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayGatewayTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Storagegateway.IStoragegatewayGatewayTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Storage Gateway.</summary>
        [JsiiTypeProxy(nativeType: typeof(IStoragegatewayGatewayConfig), fullyQualifiedName: "aws.storagegateway.StoragegatewayGatewayConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Storagegateway.IStoragegatewayGatewayConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_name StoragegatewayGateway#gateway_name}.</summary>
            [JsiiProperty(name: "gatewayName", typeJson: "{\"primitive\":\"string\"}")]
            public string GatewayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_timezone StoragegatewayGateway#gateway_timezone}.</summary>
            [JsiiProperty(name: "gatewayTimezone", typeJson: "{\"primitive\":\"string\"}")]
            public string GatewayTimezone
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#activation_key StoragegatewayGateway#activation_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "activationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActivationKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#cloudwatch_log_group_arn StoragegatewayGateway#cloudwatch_log_group_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudwatchLogGroupArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_ip_address StoragegatewayGateway#gateway_ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gatewayIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GatewayIpAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_type StoragegatewayGateway#gateway_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gatewayType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GatewayType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_vpc_endpoint StoragegatewayGateway#gateway_vpc_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gatewayVpcEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GatewayVpcEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#medium_changer_type StoragegatewayGateway#medium_changer_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mediumChangerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MediumChangerType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>smb_active_directory_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#smb_active_directory_settings StoragegatewayGateway#smb_active_directory_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "smbActiveDirectorySettings", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayGatewaySmbActiveDirectorySettings\"}", isOptional: true)]
            public aws.Storagegateway.IStoragegatewayGatewaySmbActiveDirectorySettings? SmbActiveDirectorySettings
            {
                get => GetInstanceProperty<aws.Storagegateway.IStoragegatewayGatewaySmbActiveDirectorySettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#smb_guest_password StoragegatewayGateway#smb_guest_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "smbGuestPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SmbGuestPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#tags StoragegatewayGateway#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#tape_drive_type StoragegatewayGateway#tape_drive_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tapeDriveType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TapeDriveType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#timeouts StoragegatewayGateway#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayGatewayTimeouts\"}", isOptional: true)]
            public aws.Storagegateway.IStoragegatewayGatewayTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Storagegateway.IStoragegatewayGatewayTimeouts?>();
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
