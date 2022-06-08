using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cur
{
    /// <summary>AWS Cost and Usage Report.</summary>
    [JsiiInterface(nativeType: typeof(ICurReportDefinitionConfig), fullyQualifiedName: "aws.cur.CurReportDefinitionConfig")]
    public interface ICurReportDefinitionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#additional_schema_elements CurReportDefinition#additional_schema_elements}.</summary>
        [JsiiProperty(name: "additionalSchemaElements", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AdditionalSchemaElements
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#compression CurReportDefinition#compression}.</summary>
        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
        string Compression
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#format CurReportDefinition#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        string Format
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#report_name CurReportDefinition#report_name}.</summary>
        [JsiiProperty(name: "reportName", typeJson: "{\"primitive\":\"string\"}")]
        string ReportName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#s3_bucket CurReportDefinition#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
        string S3Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#s3_region CurReportDefinition#s3_region}.</summary>
        [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}")]
        string S3Region
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#time_unit CurReportDefinition#time_unit}.</summary>
        [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
        string TimeUnit
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#additional_artifacts CurReportDefinition#additional_artifacts}.</summary>
        [JsiiProperty(name: "additionalArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AdditionalArtifacts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#s3_prefix CurReportDefinition#s3_prefix}.</summary>
        [JsiiProperty(name: "s3Prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? S3Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Cost and Usage Report.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICurReportDefinitionConfig), fullyQualifiedName: "aws.cur.CurReportDefinitionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cur.ICurReportDefinitionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#additional_schema_elements CurReportDefinition#additional_schema_elements}.</summary>
            [JsiiProperty(name: "additionalSchemaElements", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AdditionalSchemaElements
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#compression CurReportDefinition#compression}.</summary>
            [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
            public string Compression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#format CurReportDefinition#format}.</summary>
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
            public string Format
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#report_name CurReportDefinition#report_name}.</summary>
            [JsiiProperty(name: "reportName", typeJson: "{\"primitive\":\"string\"}")]
            public string ReportName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#s3_bucket CurReportDefinition#s3_bucket}.</summary>
            [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#s3_region CurReportDefinition#s3_region}.</summary>
            [JsiiProperty(name: "s3Region", typeJson: "{\"primitive\":\"string\"}")]
            public string S3Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#time_unit CurReportDefinition#time_unit}.</summary>
            [JsiiProperty(name: "timeUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeUnit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#additional_artifacts CurReportDefinition#additional_artifacts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalArtifacts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AdditionalArtifacts
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cur_report_definition#s3_prefix CurReportDefinition#s3_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "s3Prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? S3Prefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
