using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.waf.WafSqlInjectionMatchSetSqlInjectionMatchTuples")]
    public class WafSqlInjectionMatchSetSqlInjectionMatchTuples : aws.Waf.IWafSqlInjectionMatchSetSqlInjectionMatchTuples
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_sql_injection_match_set#field_to_match WafSqlInjectionMatchSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.waf.WafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch\"}")]
        public aws.Waf.IWafSqlInjectionMatchSetSqlInjectionMatchTuplesFieldToMatch FieldToMatch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_sql_injection_match_set#text_transformation WafSqlInjectionMatchSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        public string TextTransformation
        {
            get;
            set;
        }
    }
}
