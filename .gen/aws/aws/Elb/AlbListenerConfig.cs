using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    /// <summary>AWS Elastic Load Balancer.</summary>
    [JsiiByValue(fqn: "aws.elb.AlbListenerConfig")]
    public class AlbListenerConfig : aws.Elb.IAlbListenerConfig
    {
        /// <summary>default_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#default_action AlbListener#default_action}
        /// </remarks>
        [JsiiProperty(name: "defaultAction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerDefaultAction\"},\"kind\":\"array\"}}]}}")]
        public object DefaultAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#load_balancer_arn AlbListener#load_balancer_arn}.</summary>
        [JsiiProperty(name: "loadBalancerArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LoadBalancerArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#port AlbListener#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#certificate_arn AlbListener#certificate_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#protocol AlbListener#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#ssl_policy AlbListener#ssl_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslPolicy
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#timeouts AlbListener#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.elb.AlbListenerTimeouts\"}", isOptional: true)]
        public aws.Elb.IAlbListenerTimeouts? Timeouts
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
