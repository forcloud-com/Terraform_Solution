using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Storagegateway
{
    #pragma warning disable CS8618

    /// <summary>AWS Storage Gateway.</summary>
    [JsiiByValue(fqn: "aws.storagegateway.StoragegatewayGatewayConfig")]
    public class StoragegatewayGatewayConfig : aws.Storagegateway.IStoragegatewayGatewayConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_name StoragegatewayGateway#gateway_name}.</summary>
        [JsiiProperty(name: "gatewayName", typeJson: "{\"primitive\":\"string\"}")]
        public string GatewayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_timezone StoragegatewayGateway#gateway_timezone}.</summary>
        [JsiiProperty(name: "gatewayTimezone", typeJson: "{\"primitive\":\"string\"}")]
        public string GatewayTimezone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#activation_key StoragegatewayGateway#activation_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "activationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActivationKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#cloudwatch_log_group_arn StoragegatewayGateway#cloudwatch_log_group_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudwatchLogGroupArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_ip_address StoragegatewayGateway#gateway_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gatewayIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GatewayIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_type StoragegatewayGateway#gateway_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gatewayType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GatewayType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#gateway_vpc_endpoint StoragegatewayGateway#gateway_vpc_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gatewayVpcEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GatewayVpcEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#medium_changer_type StoragegatewayGateway#medium_changer_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mediumChangerType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MediumChangerType
        {
            get;
            set;
        }

        /// <summary>smb_active_directory_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#smb_active_directory_settings StoragegatewayGateway#smb_active_directory_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smbActiveDirectorySettings", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayGatewaySmbActiveDirectorySettings\"}", isOptional: true)]
        public aws.Storagegateway.IStoragegatewayGatewaySmbActiveDirectorySettings? SmbActiveDirectorySettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#smb_guest_password StoragegatewayGateway#smb_guest_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "smbGuestPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SmbGuestPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#tags StoragegatewayGateway#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#tape_drive_type StoragegatewayGateway#tape_drive_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tapeDriveType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TapeDriveType
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/storagegateway_gateway#timeouts StoragegatewayGateway#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.storagegateway.StoragegatewayGatewayTimeouts\"}", isOptional: true)]
        public aws.Storagegateway.IStoragegatewayGatewayTimeouts? Timeouts
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
