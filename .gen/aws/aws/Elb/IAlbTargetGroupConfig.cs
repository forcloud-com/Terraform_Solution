using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    /// <summary>AWS Elastic Load Balancer.</summary>
    [JsiiInterface(nativeType: typeof(IAlbTargetGroupConfig), fullyQualifiedName: "aws.elb.AlbTargetGroupConfig")]
    public interface IAlbTargetGroupConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#deregistration_delay AlbTargetGroup#deregistration_delay}.</summary>
        [JsiiProperty(name: "deregistrationDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeregistrationDelay
        {
            get
            {
                return null;
            }
        }

        /// <summary>health_check block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#health_check AlbTargetGroup#health_check}
        /// </remarks>
        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.elb.AlbTargetGroupHealthCheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbTargetGroupHealthCheck? HealthCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#lambda_multi_value_headers_enabled AlbTargetGroup#lambda_multi_value_headers_enabled}.</summary>
        [JsiiProperty(name: "lambdaMultiValueHeadersEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaMultiValueHeadersEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#load_balancing_algorithm_type AlbTargetGroup#load_balancing_algorithm_type}.</summary>
        [JsiiProperty(name: "loadBalancingAlgorithmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoadBalancingAlgorithmType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#name AlbTargetGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#name_prefix AlbTargetGroup#name_prefix}.</summary>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#port AlbTargetGroup#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#protocol AlbTargetGroup#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#proxy_protocol_v2 AlbTargetGroup#proxy_protocol_v2}.</summary>
        [JsiiProperty(name: "proxyProtocolV2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProxyProtocolV2
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#slow_start AlbTargetGroup#slow_start}.</summary>
        [JsiiProperty(name: "slowStart", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SlowStart
        {
            get
            {
                return null;
            }
        }

        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#stickiness AlbTargetGroup#stickiness}
        /// </remarks>
        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.AlbTargetGroupStickiness\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbTargetGroupStickiness? Stickiness
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#tags AlbTargetGroup#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#target_type AlbTargetGroup#target_type}.</summary>
        [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#vpc_id AlbTargetGroup#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcId
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Elastic Load Balancer.</summary>
        [JsiiTypeProxy(nativeType: typeof(IAlbTargetGroupConfig), fullyQualifiedName: "aws.elb.AlbTargetGroupConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.IAlbTargetGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#deregistration_delay AlbTargetGroup#deregistration_delay}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deregistrationDelay", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeregistrationDelay
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>health_check block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#health_check AlbTargetGroup#health_check}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"aws.elb.AlbTargetGroupHealthCheck\"}", isOptional: true)]
            public aws.Elb.IAlbTargetGroupHealthCheck? HealthCheck
            {
                get => GetInstanceProperty<aws.Elb.IAlbTargetGroupHealthCheck?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#lambda_multi_value_headers_enabled AlbTargetGroup#lambda_multi_value_headers_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaMultiValueHeadersEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LambdaMultiValueHeadersEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#load_balancing_algorithm_type AlbTargetGroup#load_balancing_algorithm_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancingAlgorithmType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoadBalancingAlgorithmType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#name AlbTargetGroup#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#name_prefix AlbTargetGroup#name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#port AlbTargetGroup#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#protocol AlbTargetGroup#protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#proxy_protocol_v2 AlbTargetGroup#proxy_protocol_v2}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "proxyProtocolV2", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ProxyProtocolV2
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#slow_start AlbTargetGroup#slow_start}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "slowStart", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SlowStart
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>stickiness block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#stickiness AlbTargetGroup#stickiness}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.AlbTargetGroupStickiness\"}", isOptional: true)]
            public aws.Elb.IAlbTargetGroupStickiness? Stickiness
            {
                get => GetInstanceProperty<aws.Elb.IAlbTargetGroupStickiness?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#tags AlbTargetGroup#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#target_type AlbTargetGroup#target_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#vpc_id AlbTargetGroup#vpc_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcId
            {
                get => GetInstanceProperty<string?>();
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
