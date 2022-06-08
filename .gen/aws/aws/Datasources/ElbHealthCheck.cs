using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasources
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasources.ElbHealthCheck")]
    public class ElbHealthCheck : aws.Datasources.IElbHealthCheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#healthy_threshold Elb#healthy_threshold}.</summary>
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public double HealthyThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#interval Elb#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        public double Interval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#target Elb#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        public string Target
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#timeout Elb#timeout}.</summary>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public double Timeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#unhealthy_threshold Elb#unhealthy_threshold}.</summary>
        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public double UnhealthyThreshold
        {
            get;
            set;
        }
    }
}
