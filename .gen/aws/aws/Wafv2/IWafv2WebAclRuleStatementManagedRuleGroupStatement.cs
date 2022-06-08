using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatement")]
    public interface IWafv2WebAclRuleStatementManagedRuleGroupStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#name Wafv2WebAcl#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#vendor_name Wafv2WebAcl#vendor_name}.</summary>
        [JsiiProperty(name: "vendorName", typeJson: "{\"primitive\":\"string\"}")]
        string VendorName
        {
            get;
        }

        /// <summary>excluded_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#excluded_rule Wafv2WebAcl#excluded_rule}
        /// </remarks>
        [JsiiProperty(name: "excludedRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludedRule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementManagedRuleGroupStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#name Wafv2WebAcl#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#vendor_name Wafv2WebAcl#vendor_name}.</summary>
            [JsiiProperty(name: "vendorName", typeJson: "{\"primitive\":\"string\"}")]
            public string VendorName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>excluded_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#excluded_rule Wafv2WebAcl#excluded_rule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludedRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExcludedRule
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
