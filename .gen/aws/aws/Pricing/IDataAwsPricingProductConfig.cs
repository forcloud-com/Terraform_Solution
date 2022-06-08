using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pricing
{
    /// <summary>AWS Pricing.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsPricingProductConfig), fullyQualifiedName: "aws.pricing.DataAwsPricingProductConfig")]
    public interface IDataAwsPricingProductConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>filters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/pricing_product#filters DataAwsPricingProduct#filters}
        /// </remarks>
        [JsiiProperty(name: "filters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pricing.DataAwsPricingProductFilters\"},\"kind\":\"array\"}}]}}")]
        object Filters
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/pricing_product#service_code DataAwsPricingProduct#service_code}.</summary>
        [JsiiProperty(name: "serviceCode", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceCode
        {
            get;
        }

        /// <summary>AWS Pricing.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsPricingProductConfig), fullyQualifiedName: "aws.pricing.DataAwsPricingProductConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Pricing.IDataAwsPricingProductConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>filters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/pricing_product#filters DataAwsPricingProduct#filters}
            /// </remarks>
            [JsiiProperty(name: "filters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.pricing.DataAwsPricingProductFilters\"},\"kind\":\"array\"}}]}}")]
            public object Filters
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/pricing_product#service_code DataAwsPricingProduct#service_code}.</summary>
            [JsiiProperty(name: "serviceCode", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceCode
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
