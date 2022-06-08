using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    /// <summary>AWS Elastic Load Balancer.</summary>
    [JsiiInterface(nativeType: typeof(ILbListenerConfig), fullyQualifiedName: "aws.elb.LbListenerConfig")]
    public interface ILbListenerConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>default_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#default_action LbListener#default_action}
        /// </remarks>
        [JsiiProperty(name: "defaultAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerDefaultAction\"},\"kind\":\"array\"}}]}}")]
        object DefaultAction
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#load_balancer_arn LbListener#load_balancer_arn}.</summary>
        [JsiiProperty(name: "loadBalancerArn", typeJson: "{\"primitive\":\"string\"}")]
        string LoadBalancerArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#port LbListener#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#certificate_arn LbListener#certificate_arn}.</summary>
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#protocol LbListener#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#ssl_policy LbListener#ssl_policy}.</summary>
        [JsiiProperty(name: "sslPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#timeouts LbListener#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elb.LbListenerTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.ILbListenerTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Elastic Load Balancer.</summary>
        [JsiiTypeProxy(nativeType: typeof(ILbListenerConfig), fullyQualifiedName: "aws.elb.LbListenerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.ILbListenerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#default_action LbListener#default_action}
            /// </remarks>
            [JsiiProperty(name: "defaultAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerDefaultAction\"},\"kind\":\"array\"}}]}}")]
            public object DefaultAction
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#load_balancer_arn LbListener#load_balancer_arn}.</summary>
            [JsiiProperty(name: "loadBalancerArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LoadBalancerArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#port LbListener#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#certificate_arn LbListener#certificate_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#protocol LbListener#protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#ssl_policy LbListener#ssl_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#timeouts LbListener#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elb.LbListenerTimeouts\"}", isOptional: true)]
            public aws.Elb.ILbListenerTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Elb.ILbListenerTimeouts?>();
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
