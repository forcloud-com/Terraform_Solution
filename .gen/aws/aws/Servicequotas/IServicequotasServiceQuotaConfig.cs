using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicequotas
{
    /// <summary>AWS Service Quotas.</summary>
    [JsiiInterface(nativeType: typeof(IServicequotasServiceQuotaConfig), fullyQualifiedName: "aws.servicequotas.ServicequotasServiceQuotaConfig")]
    public interface IServicequotasServiceQuotaConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/servicequotas_service_quota#quota_code ServicequotasServiceQuota#quota_code}.</summary>
        [JsiiProperty(name: "quotaCode", typeJson: "{\"primitive\":\"string\"}")]
        string QuotaCode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/servicequotas_service_quota#service_code ServicequotasServiceQuota#service_code}.</summary>
        [JsiiProperty(name: "serviceCode", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceCode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/servicequotas_service_quota#value ServicequotasServiceQuota#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        /// <summary>AWS Service Quotas.</summary>
        [JsiiTypeProxy(nativeType: typeof(IServicequotasServiceQuotaConfig), fullyQualifiedName: "aws.servicequotas.ServicequotasServiceQuotaConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Servicequotas.IServicequotasServiceQuotaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/servicequotas_service_quota#quota_code ServicequotasServiceQuota#quota_code}.</summary>
            [JsiiProperty(name: "quotaCode", typeJson: "{\"primitive\":\"string\"}")]
            public string QuotaCode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/servicequotas_service_quota#service_code ServicequotasServiceQuota#service_code}.</summary>
            [JsiiProperty(name: "serviceCode", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceCode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/servicequotas_service_quota#value ServicequotasServiceQuota#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
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
