using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cur
{
    /// <summary>AWS Cost and Usage Report.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsCurReportDefinitionConfig), fullyQualifiedName: "aws.cur.DataAwsCurReportDefinitionConfig")]
    public interface IDataAwsCurReportDefinitionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/cur_report_definition#report_name DataAwsCurReportDefinition#report_name}.</summary>
        [JsiiProperty(name: "reportName", typeJson: "{\"primitive\":\"string\"}")]
        string ReportName
        {
            get;
        }

        /// <summary>AWS Cost and Usage Report.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsCurReportDefinitionConfig), fullyQualifiedName: "aws.cur.DataAwsCurReportDefinitionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cur.IDataAwsCurReportDefinitionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/cur_report_definition#report_name DataAwsCurReportDefinition#report_name}.</summary>
            [JsiiProperty(name: "reportName", typeJson: "{\"primitive\":\"string\"}")]
            public string ReportName
            {
                get => GetInstanceProperty<string>()!;
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
