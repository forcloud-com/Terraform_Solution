using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    /// <summary>AWS Elastic Load Balancer.</summary>
    [JsiiByValue(fqn: "aws.elb.LbTargetGroupConfig")]
    public class LbTargetGroupConfig : aws.Elb.ILbTargetGroupConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#deregistration_delay LbTargetGroup#deregistration_delay}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deregistrationDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeregistrationDelay
        {
            get;
            set;
        }

        /// <summary>health_check block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#health_check LbTargetGroup#health_check}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.elb.LbTargetGroupHealthCheck\"}", isOptional: true)]
        public aws.Elb.ILbTargetGroupHealthCheck? HealthCheck
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#lambda_multi_value_headers_enabled LbTargetGroup#lambda_multi_value_headers_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaMultiValueHeadersEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? LambdaMultiValueHeadersEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#load_balancing_algorithm_type LbTargetGroup#load_balancing_algorithm_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancingAlgorithmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoadBalancingAlgorithmType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#name LbTargetGroup#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#name_prefix LbTargetGroup#name_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NamePrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#port LbTargetGroup#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#protocol LbTargetGroup#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#proxy_protocol_v2 LbTargetGroup#proxy_protocol_v2}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "proxyProtocolV2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ProxyProtocolV2
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#slow_start LbTargetGroup#slow_start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "slowStart", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SlowStart
        {
            get;
            set;
        }

        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#stickiness LbTargetGroup#stickiness}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.LbTargetGroupStickiness\"}", isOptional: true)]
        public aws.Elb.ILbTargetGroupStickiness? Stickiness
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#tags LbTargetGroup#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#target_type LbTargetGroup#target_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_target_group#vpc_id LbTargetGroup#vpc_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcId
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
