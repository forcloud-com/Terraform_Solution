using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    [JsiiByValue(fqn: "aws.dms.DmsEndpointKinesisSettings")]
    public class DmsEndpointKinesisSettings : aws.Dms.IDmsEndpointKinesisSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#message_format DmsEndpoint#message_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#service_access_role_arn DmsEndpoint#service_access_role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccessRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#stream_arn DmsEndpoint#stream_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StreamArn
        {
            get;
            set;
        }
    }
}
