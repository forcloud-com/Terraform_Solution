using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicequotas
{
    #pragma warning disable CS8618

    /// <summary>AWS Service Quotas.</summary>
    [JsiiByValue(fqn: "aws.servicequotas.DataAwsServicequotasServiceQuotaConfig")]
    public class DataAwsServicequotasServiceQuotaConfig : aws.Servicequotas.IDataAwsServicequotasServiceQuotaConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/servicequotas_service_quota#service_code DataAwsServicequotasServiceQuota#service_code}.</summary>
        [JsiiProperty(name: "serviceCode", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/servicequotas_service_quota#quota_code DataAwsServicequotasServiceQuota#quota_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "quotaCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QuotaCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/servicequotas_service_quota#quota_name DataAwsServicequotasServiceQuota#quota_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "quotaName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QuotaName
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
