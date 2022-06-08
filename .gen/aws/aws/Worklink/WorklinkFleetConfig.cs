using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Worklink
{
    #pragma warning disable CS8618

    /// <summary>AWS WorkLink.</summary>
    [JsiiByValue(fqn: "aws.worklink.WorklinkFleetConfig")]
    public class WorklinkFleetConfig : aws.Worklink.IWorklinkFleetConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#name WorklinkFleet#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#audit_stream_arn WorklinkFleet#audit_stream_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "auditStreamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuditStreamArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#device_ca_certificate WorklinkFleet#device_ca_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceCaCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeviceCaCertificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#display_name WorklinkFleet#display_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DisplayName
        {
            get;
            set;
        }

        /// <summary>identity_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#identity_provider WorklinkFleet#identity_provider}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identityProvider", typeJson: "{\"fqn\":\"aws.worklink.WorklinkFleetIdentityProvider\"}", isOptional: true)]
        public aws.Worklink.IWorklinkFleetIdentityProvider? IdentityProvider
        {
            get;
            set;
        }

        /// <summary>network block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#network WorklinkFleet#network}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"aws.worklink.WorklinkFleetNetwork\"}", isOptional: true)]
        public aws.Worklink.IWorklinkFleetNetwork? Network
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet#optimize_for_end_user_location WorklinkFleet#optimize_for_end_user_location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "optimizeForEndUserLocation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? OptimizeForEndUserLocation
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
