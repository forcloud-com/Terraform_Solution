using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pricing
{
    [JsiiInterface(nativeType: typeof(IDataAwsPricingProductFilters), fullyQualifiedName: "aws.pricing.DataAwsPricingProductFilters")]
    public interface IDataAwsPricingProductFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/pricing_product#field DataAwsPricingProduct#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        string Field
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/pricing_product#value DataAwsPricingProduct#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsPricingProductFilters), fullyQualifiedName: "aws.pricing.DataAwsPricingProductFilters")]
        internal sealed class _Proxy : DeputyBase, aws.Pricing.IDataAwsPricingProductFilters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/pricing_product#field DataAwsPricingProduct#field}.</summary>
            [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
            public string Field
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/pricing_product#value DataAwsPricingProduct#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
