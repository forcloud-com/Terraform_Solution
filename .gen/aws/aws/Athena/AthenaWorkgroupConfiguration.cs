using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    [JsiiByValue(fqn: "aws.athena.AthenaWorkgroupConfiguration")]
    public class AthenaWorkgroupConfiguration : aws.Athena.IAthenaWorkgroupConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#bytes_scanned_cutoff_per_query AthenaWorkgroup#bytes_scanned_cutoff_per_query}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bytesScannedCutoffPerQuery", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BytesScannedCutoffPerQuery
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#enforce_workgroup_configuration AthenaWorkgroup#enforce_workgroup_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enforceWorkgroupConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnforceWorkgroupConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#publish_cloudwatch_metrics_enabled AthenaWorkgroup#publish_cloudwatch_metrics_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publishCloudwatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PublishCloudwatchMetricsEnabled
        {
            get;
            set;
        }

        /// <summary>result_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/athena_workgroup#result_configuration AthenaWorkgroup#result_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resultConfiguration", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationResultConfiguration\"}", isOptional: true)]
        public aws.Athena.IAthenaWorkgroupConfigurationResultConfiguration? ResultConfiguration
        {
            get;
            set;
        }
    }
}
