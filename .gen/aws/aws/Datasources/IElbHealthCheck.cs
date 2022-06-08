using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasources
{
    [JsiiInterface(nativeType: typeof(IElbHealthCheck), fullyQualifiedName: "aws.datasources.ElbHealthCheck")]
    public interface IElbHealthCheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#healthy_threshold Elb#healthy_threshold}.</summary>
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        double HealthyThreshold
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#interval Elb#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        double Interval
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#target Elb#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        string Target
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#timeout Elb#timeout}.</summary>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        double Timeout
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#unhealthy_threshold Elb#unhealthy_threshold}.</summary>
        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        double UnhealthyThreshold
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElbHealthCheck), fullyQualifiedName: "aws.datasources.ElbHealthCheck")]
        internal sealed class _Proxy : DeputyBase, aws.Datasources.IElbHealthCheck
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#healthy_threshold Elb#healthy_threshold}.</summary>
            [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
            public double HealthyThreshold
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#interval Elb#interval}.</summary>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
            public double Interval
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#target Elb#target}.</summary>
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
            public string Target
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#timeout Elb#timeout}.</summary>
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
            public double Timeout
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elb#unhealthy_threshold Elb#unhealthy_threshold}.</summary>
            [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
            public double UnhealthyThreshold
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
