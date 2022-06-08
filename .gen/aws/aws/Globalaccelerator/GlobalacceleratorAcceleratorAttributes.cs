using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Globalaccelerator
{
    [JsiiByValue(fqn: "aws.globalaccelerator.GlobalacceleratorAcceleratorAttributes")]
    public class GlobalacceleratorAcceleratorAttributes : aws.Globalaccelerator.IGlobalacceleratorAcceleratorAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_accelerator#flow_logs_enabled GlobalacceleratorAccelerator#flow_logs_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "flowLogsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? FlowLogsEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_accelerator#flow_logs_s3_bucket GlobalacceleratorAccelerator#flow_logs_s3_bucket}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "flowLogsS3Bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FlowLogsS3Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_accelerator#flow_logs_s3_prefix GlobalacceleratorAccelerator#flow_logs_s3_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "flowLogsS3Prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FlowLogsS3Prefix
        {
            get;
            set;
        }
    }
}
