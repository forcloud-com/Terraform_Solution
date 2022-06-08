using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudwatch
{
    [JsiiInterface(nativeType: typeof(ICloudwatchMetricAlarmMetricQuery), fullyQualifiedName: "aws.cloudwatch.CloudwatchMetricAlarmMetricQuery")]
    public interface ICloudwatchMetricAlarmMetricQuery
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#id CloudwatchMetricAlarm#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#expression CloudwatchMetricAlarm#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#label CloudwatchMetricAlarm#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        /// <summary>metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#metric CloudwatchMetricAlarm#metric}
        /// </remarks>
        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"aws.cloudwatch.CloudwatchMetricAlarmMetricQueryMetric\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudwatch.ICloudwatchMetricAlarmMetricQueryMetric? Metric
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#return_data CloudwatchMetricAlarm#return_data}.</summary>
        [JsiiProperty(name: "returnData", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReturnData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchMetricAlarmMetricQuery), fullyQualifiedName: "aws.cloudwatch.CloudwatchMetricAlarmMetricQuery")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudwatch.ICloudwatchMetricAlarmMetricQuery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#id CloudwatchMetricAlarm#id}.</summary>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#expression CloudwatchMetricAlarm#expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#label CloudwatchMetricAlarm#label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>metric block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#metric CloudwatchMetricAlarm#metric}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"aws.cloudwatch.CloudwatchMetricAlarmMetricQueryMetric\"}", isOptional: true)]
            public aws.Cloudwatch.ICloudwatchMetricAlarmMetricQueryMetric? Metric
            {
                get => GetInstanceProperty<aws.Cloudwatch.ICloudwatchMetricAlarmMetricQueryMetric?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_metric_alarm#return_data CloudwatchMetricAlarm#return_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "returnData", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ReturnData
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
