using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleAction), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleAction")]
    public interface IWafv2WebAclRuleAction
    {
        /// <summary>allow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#allow Wafv2WebAcl#allow}
        /// </remarks>
        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionAllow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleActionAllow? Allow
        {
            get
            {
                return null;
            }
        }

        /// <summary>block block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#block Wafv2WebAcl#block}
        /// </remarks>
        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionBlock\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleActionBlock? Block
        {
            get
            {
                return null;
            }
        }

        /// <summary>count block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#count Wafv2WebAcl#count}
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionCount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleActionCount? Count
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleAction), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleAction")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>allow block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#allow Wafv2WebAcl#allow}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionAllow\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleActionAllow? Allow
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleActionAllow?>();
            }

            /// <summary>block block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#block Wafv2WebAcl#block}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionBlock\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleActionBlock? Block
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleActionBlock?>();
            }

            /// <summary>count block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#count Wafv2WebAcl#count}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionCount\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleActionCount? Count
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleActionCount?>();
            }
        }
    }
}
