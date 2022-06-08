using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GlueCatalogTableStorageDescriptorSerDeInfo")]
    public class GlueCatalogTableStorageDescriptorSerDeInfo : aws.Glue.IGlueCatalogTableStorageDescriptorSerDeInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#name GlueCatalogTable#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#parameters GlueCatalogTable#parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#serialization_library GlueCatalogTable#serialization_library}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serializationLibrary", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SerializationLibrary
        {
            get;
            set;
        }
    }
}
