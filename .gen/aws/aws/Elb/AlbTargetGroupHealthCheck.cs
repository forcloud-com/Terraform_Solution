using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiByValue(fqn: "aws.elb.AlbTargetGroupHealthCheck")]
    public class AlbTargetGroupHealthCheck : aws.Elb.IAlbTargetGroupHealthCheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#enabled AlbTargetGroup#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#healthy_threshold AlbTargetGroup#healthy_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthyThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#interval AlbTargetGroup#interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Interval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#matcher AlbTargetGroup#matcher}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "matcher", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Matcher
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#path AlbTargetGroup#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#port AlbTargetGroup#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#protocol AlbTargetGroup#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#timeout AlbTargetGroup#timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Timeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_target_group#unhealthy_threshold AlbTargetGroup#unhealthy_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnhealthyThreshold
        {
            get;
            set;
        }
    }
}
