using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cur
{
    #pragma warning disable CS8618

    /// <summary>AWS Cost and Usage Report.</summary>
    [JsiiByValue(fqn: "aws.cur.CurReportDefinitionConfig")]
    public class CurReportDefinitionConfig : aws.Cur.ICurReportDefinitionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#additional_schema_elements CurReportDefinition#additional_schema_elements}.</summary>
        [JsiiProperty(name: "additionalSchemaElements", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AdditionalSchemaElements
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#compression CurReportDefinition#compression}.</summary>
        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
        public string Compression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#format CurReportDefinition#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public string Format
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#report_name CurReportDefinition#report_name}.</summary>
        [JsiiProperty(name: "reportName", typeJson: "{\"primitive\":\"string\"}")]
        public string ReportName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#s3_bucket CurReportDefinition#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#s3_region CurReportDefinition#s3_region}.</summary>
        [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}")]
        public string S3Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#time_unit CurReportDefinition#time_unit}.</summary>
        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeUnit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#additional_artifacts CurReportDefinition#additional_artifacts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AdditionalArtifacts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#s3_prefix CurReportDefinition#s3_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "s3Prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? S3Prefix
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
