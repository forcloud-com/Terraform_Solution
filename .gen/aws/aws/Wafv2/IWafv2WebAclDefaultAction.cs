using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclDefaultAction), fullyQualifiedName: "aws.wafv2.Wafv2WebAclDefaultAction")]
    public interface IWafv2WebAclDefaultAction
    {
        /// <summary>allow block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#allow Wafv2WebAcl#allow}
        /// </remarks>
        [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionAllow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclDefaultActionAllow? Allow
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
        [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionBlock\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclDefaultActionBlock? Block
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclDefaultAction), fullyQualifiedName: "aws.wafv2.Wafv2WebAclDefaultAction")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclDefaultAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>allow block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#allow Wafv2WebAcl#allow}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allow", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionAllow\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclDefaultActionAllow? Allow
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclDefaultActionAllow?>();
            }

            /// <summary>block block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#block Wafv2WebAcl#block}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "block", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionBlock\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclDefaultActionBlock? Block
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclDefaultActionBlock?>();
            }
        }
    }
}
