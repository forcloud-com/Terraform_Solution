using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    /// <summary>AWS Route 53.</summary>
    [JsiiInterface(nativeType: typeof(IRoute53HealthCheckConfig), fullyQualifiedName: "aws.route53.Route53HealthCheckConfig")]
    public interface IRoute53HealthCheckConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#type Route53HealthCheck#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#child_healthchecks Route53HealthCheck#child_healthchecks}.</summary>
        [JsiiProperty(name: "childHealthchecks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ChildHealthchecks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#child_health_threshold Route53HealthCheck#child_health_threshold}.</summary>
        [JsiiProperty(name: "childHealthThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ChildHealthThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#cloudwatch_alarm_name Route53HealthCheck#cloudwatch_alarm_name}.</summary>
        [JsiiProperty(name: "cloudwatchAlarmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudwatchAlarmName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#cloudwatch_alarm_region Route53HealthCheck#cloudwatch_alarm_region}.</summary>
        [JsiiProperty(name: "cloudwatchAlarmRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudwatchAlarmRegion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#enable_sni Route53HealthCheck#enable_sni}.</summary>
        [JsiiProperty(name: "enableSni", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableSni
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#failure_threshold Route53HealthCheck#failure_threshold}.</summary>
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailureThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#fqdn Route53HealthCheck#fqdn}.</summary>
        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Fqdn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#insufficient_data_health_status Route53HealthCheck#insufficient_data_health_status}.</summary>
        [JsiiProperty(name: "insufficientDataHealthStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InsufficientDataHealthStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#invert_healthcheck Route53HealthCheck#invert_healthcheck}.</summary>
        [JsiiProperty(name: "invertHealthcheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InvertHealthcheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#ip_address Route53HealthCheck#ip_address}.</summary>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#measure_latency Route53HealthCheck#measure_latency}.</summary>
        [JsiiProperty(name: "measureLatency", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MeasureLatency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#port Route53HealthCheck#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#reference_name Route53HealthCheck#reference_name}.</summary>
        [JsiiProperty(name: "referenceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReferenceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#regions Route53HealthCheck#regions}.</summary>
        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Regions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#request_interval Route53HealthCheck#request_interval}.</summary>
        [JsiiProperty(name: "requestInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RequestInterval
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#resource_path Route53HealthCheck#resource_path}.</summary>
        [JsiiProperty(name: "resourcePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourcePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#search_string Route53HealthCheck#search_string}.</summary>
        [JsiiProperty(name: "searchString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SearchString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#tags Route53HealthCheck#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Route 53.</summary>
        [JsiiTypeProxy(nativeType: typeof(IRoute53HealthCheckConfig), fullyQualifiedName: "aws.route53.Route53HealthCheckConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Route53.IRoute53HealthCheckConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#type Route53HealthCheck#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#child_healthchecks Route53HealthCheck#child_healthchecks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "childHealthchecks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ChildHealthchecks
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#child_health_threshold Route53HealthCheck#child_health_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "childHealthThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ChildHealthThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#cloudwatch_alarm_name Route53HealthCheck#cloudwatch_alarm_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchAlarmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudwatchAlarmName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#cloudwatch_alarm_region Route53HealthCheck#cloudwatch_alarm_region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchAlarmRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudwatchAlarmRegion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#enable_sni Route53HealthCheck#enable_sni}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableSni", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableSni
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#failure_threshold Route53HealthCheck#failure_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailureThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#fqdn Route53HealthCheck#fqdn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Fqdn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#insufficient_data_health_status Route53HealthCheck#insufficient_data_health_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "insufficientDataHealthStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InsufficientDataHealthStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#invert_healthcheck Route53HealthCheck#invert_healthcheck}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "invertHealthcheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? InvertHealthcheck
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#ip_address Route53HealthCheck#ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#measure_latency Route53HealthCheck#measure_latency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "measureLatency", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? MeasureLatency
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#port Route53HealthCheck#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#reference_name Route53HealthCheck#reference_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "referenceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReferenceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#regions Route53HealthCheck#regions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Regions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#request_interval Route53HealthCheck#request_interval}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requestInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RequestInterval
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#resource_path Route53HealthCheck#resource_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourcePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourcePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#search_string Route53HealthCheck#search_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SearchString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53_health_check#tags Route53HealthCheck#tags}.</summary>
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
