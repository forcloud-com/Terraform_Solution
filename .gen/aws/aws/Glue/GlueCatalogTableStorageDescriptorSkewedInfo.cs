using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GlueCatalogTableStorageDescriptorSkewedInfo")]
    public class GlueCatalogTableStorageDescriptorSkewedInfo : aws.Glue.IGlueCatalogTableStorageDescriptorSkewedInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#skewed_column_names GlueCatalogTable#skewed_column_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skewedColumnNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SkewedColumnNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#skewed_column_value_location_maps GlueCatalogTable#skewed_column_value_location_maps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skewedColumnValueLocationMaps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? SkewedColumnValueLocationMaps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#skewed_column_values GlueCatalogTable#skewed_column_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skewedColumnValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SkewedColumnValues
        {
            get;
            set;
        }
    }
}
