using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafregional.WafregionalSizeConstraintSetSizeConstraintsFieldToMatch")]
    public class WafregionalSizeConstraintSetSizeConstraintsFieldToMatch : aws.Wafregional.IWafregionalSizeConstraintSetSizeConstraintsFieldToMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#type WafregionalSizeConstraintSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#data WafregionalSizeConstraintSet#data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Data
        {
            get;
            set;
        }
    }
}
