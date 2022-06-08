using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudwatch
{
    /// <summary>AWS CloudWatch.</summary>
    [JsiiInterface(nativeType: typeof(ICloudwatchDashboardConfig), fullyQualifiedName: "aws.cloudwatch.CloudwatchDashboardConfig")]
    public interface ICloudwatchDashboardConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_dashboard#dashboard_body CloudwatchDashboard#dashboard_body}.</summary>
        [JsiiProperty(name: "dashboardBody", typeJson: "{\"primitive\":\"string\"}")]
        string DashboardBody
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_dashboard#dashboard_name CloudwatchDashboard#dashboard_name}.</summary>
        [JsiiProperty(name: "dashboardName", typeJson: "{\"primitive\":\"string\"}")]
        string DashboardName
        {
            get;
        }

        /// <summary>AWS CloudWatch.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICloudwatchDashboardConfig), fullyQualifiedName: "aws.cloudwatch.CloudwatchDashboardConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudwatch.ICloudwatchDashboardConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_dashboard#dashboard_body CloudwatchDashboard#dashboard_body}.</summary>
            [JsiiProperty(name: "dashboardBody", typeJson: "{\"primitive\":\"string\"}")]
            public string DashboardBody
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_dashboard#dashboard_name CloudwatchDashboard#dashboard_name}.</summary>
            [JsiiProperty(name: "dashboardName", typeJson: "{\"primitive\":\"string\"}")]
            public string DashboardName
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
