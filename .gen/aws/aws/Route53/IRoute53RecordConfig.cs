using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    /// <summary>AWS Route 53.</summary>
    [JsiiInterface(nativeType: typeof(IRoute53RecordConfig), fullyQualifiedName: "aws.route53.Route53RecordConfig")]
    public interface IRoute53RecordConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#name Route53Record#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#type Route53Record#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#zone_id Route53Record#zone_id}.</summary>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>alias block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#alias Route53Record#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordAlias\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#allow_overwrite Route53Record#allow_overwrite}.</summary>
        [JsiiProperty(name: "allowOverwrite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowOverwrite
        {
            get
            {
                return null;
            }
        }

        /// <summary>failover_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#failover_routing_policy Route53Record#failover_routing_policy}
        /// </remarks>
        [JsiiProperty(name: "failoverRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordFailoverRoutingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailoverRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>geolocation_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#geolocation_routing_policy Route53Record#geolocation_routing_policy}
        /// </remarks>
        [JsiiProperty(name: "geolocationRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordGeolocationRoutingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GeolocationRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#health_check_id Route53Record#health_check_id}.</summary>
        [JsiiProperty(name: "healthCheckId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HealthCheckId
        {
            get
            {
                return null;
            }
        }

        /// <summary>latency_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#latency_routing_policy Route53Record#latency_routing_policy}
        /// </remarks>
        [JsiiProperty(name: "latencyRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordLatencyRoutingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LatencyRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#multivalue_answer_routing_policy Route53Record#multivalue_answer_routing_policy}.</summary>
        [JsiiProperty(name: "multivalueAnswerRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MultivalueAnswerRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#records Route53Record#records}.</summary>
        [JsiiProperty(name: "records", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Records
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#set_identifier Route53Record#set_identifier}.</summary>
        [JsiiProperty(name: "setIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SetIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#ttl Route53Record#ttl}.</summary>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ttl
        {
            get
            {
                return null;
            }
        }

        /// <summary>weighted_routing_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#weighted_routing_policy Route53Record#weighted_routing_policy}
        /// </remarks>
        [JsiiProperty(name: "weightedRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordWeightedRoutingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WeightedRoutingPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Route 53.</summary>
        [JsiiTypeProxy(nativeType: typeof(IRoute53RecordConfig), fullyQualifiedName: "aws.route53.Route53RecordConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Route53.IRoute53RecordConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#name Route53Record#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#type Route53Record#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#zone_id Route53Record#zone_id}.</summary>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>alias block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#alias Route53Record#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordAlias\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Alias
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#allow_overwrite Route53Record#allow_overwrite}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowOverwrite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowOverwrite
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>failover_routing_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#failover_routing_policy Route53Record#failover_routing_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failoverRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordFailoverRoutingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FailoverRoutingPolicy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>geolocation_routing_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#geolocation_routing_policy Route53Record#geolocation_routing_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "geolocationRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordGeolocationRoutingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GeolocationRoutingPolicy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#health_check_id Route53Record#health_check_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheckId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HealthCheckId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>latency_routing_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#latency_routing_policy Route53Record#latency_routing_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "latencyRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordLatencyRoutingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LatencyRoutingPolicy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#multivalue_answer_routing_policy Route53Record#multivalue_answer_routing_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "multivalueAnswerRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? MultivalueAnswerRoutingPolicy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#records Route53Record#records}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "records", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Records
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#set_identifier Route53Record#set_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "setIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SetIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#ttl Route53Record#ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ttl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>weighted_routing_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_record#weighted_routing_policy Route53Record#weighted_routing_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "weightedRoutingPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.route53.Route53RecordWeightedRoutingPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? WeightedRoutingPolicy
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
