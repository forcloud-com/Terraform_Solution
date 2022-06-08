using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dms.DmsEndpointElasticsearchSettings")]
    public class DmsEndpointElasticsearchSettings : aws.Dms.IDmsEndpointElasticsearchSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#endpoint_uri DmsEndpoint#endpoint_uri}.</summary>
        [JsiiProperty(name: "endpointUri", typeJson: "{\"primitive\":\"string\"}")]
        public string EndpointUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#service_access_role_arn DmsEndpoint#service_access_role_arn}.</summary>
        [JsiiProperty(name: "serviceAccessRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceAccessRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#error_retry_duration DmsEndpoint#error_retry_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorRetryDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ErrorRetryDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#full_load_error_percentage DmsEndpoint#full_load_error_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fullLoadErrorPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FullLoadErrorPercentage
        {
            get;
            set;
        }
    }
}
