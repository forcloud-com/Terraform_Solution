using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Globalaccelerator
{
    #pragma warning disable CS8618

    /// <summary>AWS Global Accelerator.</summary>
    [JsiiByValue(fqn: "aws.globalaccelerator.GlobalacceleratorEndpointGroupConfig")]
    public class GlobalacceleratorEndpointGroupConfig : aws.Globalaccelerator.IGlobalacceleratorEndpointGroupConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#listener_arn GlobalacceleratorEndpointGroup#listener_arn}.</summary>
        [JsiiProperty(name: "listenerArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ListenerArn
        {
            get;
            set;
        }

        /// <summary>endpoint_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#endpoint_configuration GlobalacceleratorEndpointGroup#endpoint_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpointConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorEndpointGroupEndpointConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EndpointConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#endpoint_group_region GlobalacceleratorEndpointGroup#endpoint_group_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointGroupRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointGroupRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#health_check_interval_seconds GlobalacceleratorEndpointGroup#health_check_interval_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckIntervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthCheckIntervalSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#health_check_path GlobalacceleratorEndpointGroup#health_check_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#health_check_port GlobalacceleratorEndpointGroup#health_check_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthCheckPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#health_check_protocol GlobalacceleratorEndpointGroup#health_check_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckProtocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#threshold_count GlobalacceleratorEndpointGroup#threshold_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "thresholdCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ThresholdCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_endpoint_group#traffic_dial_percentage GlobalacceleratorEndpointGroup#traffic_dial_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trafficDialPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TrafficDialPercentage
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
