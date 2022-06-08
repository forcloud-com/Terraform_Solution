using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GlueCatalogTableStorageDescriptor")]
    public class GlueCatalogTableStorageDescriptor : aws.Glue.IGlueCatalogTableStorageDescriptor
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#bucket_columns GlueCatalogTable#bucket_columns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bucketColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BucketColumns
        {
            get;
            set;
        }

        /// <summary>columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#columns GlueCatalogTable#columns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "columns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Columns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#compressed GlueCatalogTable#compressed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compressed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Compressed
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#input_format GlueCatalogTable#input_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InputFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#location GlueCatalogTable#location}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Location
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#number_of_buckets GlueCatalogTable#number_of_buckets}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numberOfBuckets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumberOfBuckets
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#output_format GlueCatalogTable#output_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutputFormat
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

        /// <summary>ser_de_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#ser_de_info GlueCatalogTable#ser_de_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serDeInfo", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSerDeInfo\"}", isOptional: true)]
        public aws.Glue.IGlueCatalogTableStorageDescriptorSerDeInfo? SerDeInfo
        {
            get;
            set;
        }

        /// <summary>skewed_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#skewed_info GlueCatalogTable#skewed_info}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "skewedInfo", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSkewedInfo\"}", isOptional: true)]
        public aws.Glue.IGlueCatalogTableStorageDescriptorSkewedInfo? SkewedInfo
        {
            get;
            set;
        }

        /// <summary>sort_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#sort_columns GlueCatalogTable#sort_columns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sortColumns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSortColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SortColumns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#stored_as_sub_directories GlueCatalogTable#stored_as_sub_directories}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storedAsSubDirectories", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? StoredAsSubDirectories
        {
            get;
            set;
        }
    }
}
