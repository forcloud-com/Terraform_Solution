using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicequotas
{
    /// <summary>AWS Service Quotas.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsServicequotasServiceQuotaConfig), fullyQualifiedName: "aws.servicequotas.DataAwsServicequotasServiceQuotaConfig")]
    public interface IDataAwsServicequotasServiceQuotaConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/servicequotas_service_quota#service_code DataAwsServicequotasServiceQuota#service_code}.</summary>
        [JsiiProperty(name: "serviceCode", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceCode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/servicequotas_service_quota#quota_code DataAwsServicequotasServiceQuota#quota_code}.</summary>
        [JsiiProperty(name: "quotaCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QuotaCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/servicequotas_service_quota#quota_name DataAwsServicequotasServiceQuota#quota_name}.</summary>
        [JsiiProperty(name: "quotaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QuotaName
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Service Quotas.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsServicequotasServiceQuotaConfig), fullyQualifiedName: "aws.servicequotas.DataAwsServicequotasServiceQuotaConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Servicequotas.IDataAwsServicequotasServiceQuotaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/servicequotas_service_quota#service_code DataAwsServicequotasServiceQuota#service_code}.</summary>
            [JsiiProperty(name: "serviceCode", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceCode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/servicequotas_service_quota#quota_code DataAwsServicequotasServiceQuota#quota_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "quotaCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QuotaCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/servicequotas_service_quota#quota_name DataAwsServicequotasServiceQuota#quota_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "quotaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QuotaName
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
