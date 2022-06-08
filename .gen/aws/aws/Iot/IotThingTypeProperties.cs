using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    [JsiiByValue(fqn: "aws.iot.IotThingTypeProperties")]
    public class IotThingTypeProperties : aws.Iot.IIotThingTypeProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_type#description IotThingType#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_type#searchable_attributes IotThingType#searchable_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "searchableAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SearchableAttributes
        {
            get;
            set;
        }
    }
}
