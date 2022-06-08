using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    #pragma warning disable CS8618

    /// <summary>AWS Route 53.</summary>
    [JsiiByValue(fqn: "aws.route53.Route53HealthCheckConfig")]
    public class Route53HealthCheckConfig : aws.Route53.IRoute53HealthCheckConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#type Route53HealthCheck#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#child_healthchecks Route53HealthCheck#child_healthchecks}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "childHealthchecks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ChildHealthchecks
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#child_health_threshold Route53HealthCheck#child_health_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "childHealthThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ChildHealthThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#cloudwatch_alarm_name Route53HealthCheck#cloudwatch_alarm_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchAlarmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudwatchAlarmName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#cloudwatch_alarm_region Route53HealthCheck#cloudwatch_alarm_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchAlarmRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudwatchAlarmRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#enable_sni Route53HealthCheck#enable_sni}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableSni", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableSni
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#failure_threshold Route53HealthCheck#failure_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#fqdn Route53HealthCheck#fqdn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Fqdn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#insufficient_data_health_status Route53HealthCheck#insufficient_data_health_status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "insufficientDataHealthStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InsufficientDataHealthStatus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#invert_healthcheck Route53HealthCheck#invert_healthcheck}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "invertHealthcheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? InvertHealthcheck
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#ip_address Route53HealthCheck#ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#measure_latency Route53HealthCheck#measure_latency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "measureLatency", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? MeasureLatency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#port Route53HealthCheck#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#reference_name Route53HealthCheck#reference_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "referenceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReferenceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#regions Route53HealthCheck#regions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Regions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#request_interval Route53HealthCheck#request_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RequestInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#resource_path Route53HealthCheck#resource_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourcePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourcePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#search_string Route53HealthCheck#search_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "searchString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SearchString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#tags Route53HealthCheck#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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
