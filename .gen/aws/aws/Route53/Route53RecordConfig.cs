using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    #pragma warning disable CS8618

    /// <summary>AWS Route 53.</summary>
    [JsiiByValue(fqn: "aws.route53.Route53RecordConfig")]
    public class Route53RecordConfig : aws.Route53.IRoute53RecordConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#name Route53Record#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#type Route53Record#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#zone_id Route53Record#zone_id}.</summary>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public string ZoneId
        {
            get;
            set;
        }

        /// <summary>alias block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#alias Route53Record#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordAlias\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Alias
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#allow_overwrite Route53Record#allow_overwrite}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowOverwrite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowOverwrite
        {
            get;
            set;
        }

        /// <summary>failover_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#failover_routing_policy Route53Record#failover_routing_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failoverRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordFailoverRoutingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FailoverRoutingPolicy
        {
            get;
            set;
        }

        /// <summary>geolocation_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#geolocation_routing_policy Route53Record#geolocation_routing_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geolocationRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordGeolocationRoutingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GeolocationRoutingPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#health_check_id Route53Record#health_check_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheckId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HealthCheckId
        {
            get;
            set;
        }

        /// <summary>latency_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#latency_routing_policy Route53Record#latency_routing_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "latencyRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordLatencyRoutingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LatencyRoutingPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#multivalue_answer_routing_policy Route53Record#multivalue_answer_routing_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "multivalueAnswerRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? MultivalueAnswerRoutingPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#records Route53Record#records}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "records", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Records
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#set_identifier Route53Record#set_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "setIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SetIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#ttl Route53Record#ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ttl
        {
            get;
            set;
        }

        /// <summary>weighted_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#weighted_routing_policy Route53Record#weighted_routing_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "weightedRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordWeightedRoutingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WeightedRoutingPolicy
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
