using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudwatch
{
    [JsiiInterface(nativeType: typeof(ICloudwatchLogMetricFilterMetricTransformation), fullyQualifiedName: "aws.cloudwatch.CloudwatchLogMetricFilterMetricTransformation")]
    public interface ICloudwatchLogMetricFilterMetricTransformation
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter#name CloudwatchLogMetricFilter#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter#namespace CloudwatchLogMetricFilter#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter#value CloudwatchLogMetricFilter#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter#default_value CloudwatchLogMetricFilter#default_value}.</summary>
        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchLogMetricFilterMetricTransformation), fullyQualifiedName: "aws.cloudwatch.CloudwatchLogMetricFilterMetricTransformation")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudwatch.ICloudwatchLogMetricFilterMetricTransformation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter#name CloudwatchLogMetricFilter#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter#namespace CloudwatchLogMetricFilter#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter#value CloudwatchLogMetricFilter#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_log_metric_filter#default_value CloudwatchLogMetricFilter#default_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
