using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pricing
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.pricing.DataAwsPricingProductFilters")]
    public class DataAwsPricingProductFilters : aws.Pricing.IDataAwsPricingProductFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/pricing_product#field DataAwsPricingProduct#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        public string Field
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/pricing_product#value DataAwsPricingProduct#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
