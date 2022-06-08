using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    [JsiiInterface(nativeType: typeof(IAthenaWorkgroupConfiguration), fullyQualifiedName: "aws.athena.AthenaWorkgroupConfiguration")]
    public interface IAthenaWorkgroupConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#bytes_scanned_cutoff_per_query AthenaWorkgroup#bytes_scanned_cutoff_per_query}.</summary>
        [JsiiProperty(name: "bytesScannedCutoffPerQuery", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BytesScannedCutoffPerQuery
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#enforce_workgroup_configuration AthenaWorkgroup#enforce_workgroup_configuration}.</summary>
        [JsiiProperty(name: "enforceWorkgroupConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnforceWorkgroupConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#publish_cloudwatch_metrics_enabled AthenaWorkgroup#publish_cloudwatch_metrics_enabled}.</summary>
        [JsiiProperty(name: "publishCloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublishCloudwatchMetricsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>result_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#result_configuration AthenaWorkgroup#result_configuration}
        /// </remarks>
        [JsiiProperty(name: "resultConfiguration", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration? ResultConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAthenaWorkgroupConfiguration), fullyQualifiedName: "aws.athena.AthenaWorkgroupConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Athena.IAthenaWorkgroupConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#bytes_scanned_cutoff_per_query AthenaWorkgroup#bytes_scanned_cutoff_per_query}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bytesScannedCutoffPerQuery", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BytesScannedCutoffPerQuery
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#enforce_workgroup_configuration AthenaWorkgroup#enforce_workgroup_configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enforceWorkgroupConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnforceWorkgroupConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#publish_cloudwatch_metrics_enabled AthenaWorkgroup#publish_cloudwatch_metrics_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publishCloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PublishCloudwatchMetricsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>result_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#result_configuration AthenaWorkgroup#result_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resultConfiguration", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfiguration\"}", isOptional: true)]
            public aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration? ResultConfiguration
            {
                get => GetInstanceProperty<aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration?>();
            }
        }
    }
}
