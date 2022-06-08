using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dms
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dms.DmsEndpointKafkaSettings")]
    public class DmsEndpointKafkaSettings : aws.Dms.IDmsEndpointKafkaSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#broker DmsEndpoint#broker}.</summary>
        [JsiiProperty(name: "broker", typeJson: "{\"primitive\":\"string\"}")]
        public string Broker
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dms_endpoint#topic DmsEndpoint#topic}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Topic
        {
            get;
            set;
        }
    }
}
