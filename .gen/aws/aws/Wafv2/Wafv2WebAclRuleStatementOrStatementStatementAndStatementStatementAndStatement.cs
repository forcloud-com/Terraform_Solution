using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementAndStatement")]
    public class Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementAndStatement : aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementAndStatementStatementAndStatement
    {
        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#statement Wafv2WebAcl#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementAndStatementStatementAndStatementStatement\"},\"kind\":\"array\"}}]}}")]
        public object Statement
        {
            get;
            set;
        }
    }
}
