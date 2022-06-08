using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.GlueCatalogTableStorageDescriptorSortColumns")]
    public class GlueCatalogTableStorageDescriptorSortColumns : aws.Glue.IGlueCatalogTableStorageDescriptorSortColumns
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#column GlueCatalogTable#column}.</summary>
        [JsiiProperty(name: "column", typeJson: "{\"primitive\":\"string\"}")]
        public string Column
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#sort_order GlueCatalogTable#sort_order}.</summary>
        [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"number\"}")]
        public double SortOrder
        {
            get;
            set;
        }
    }
}
