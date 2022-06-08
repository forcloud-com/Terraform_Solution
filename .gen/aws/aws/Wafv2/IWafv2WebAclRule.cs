using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRule), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRule")]
    public interface IWafv2WebAclRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#name Wafv2WebAcl#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#priority Wafv2WebAcl#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        double Priority
        {
            get;
        }

        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#statement Wafv2WebAcl#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatement\"}")]
        aws.Wafv2.IWafv2WebAclRuleStatement Statement
        {
            get;
        }

        /// <summary>visibility_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#visibility_config Wafv2WebAcl#visibility_config}
        /// </remarks>
        [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleVisibilityConfig\"}")]
        aws.Wafv2.IWafv2WebAclRuleVisibilityConfig VisibilityConfig
        {
            get;
        }

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#action Wafv2WebAcl#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleAction? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>override_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#override_action Wafv2WebAcl#override_action}
        /// </remarks>
        [JsiiProperty(name: "overrideAction", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleOverrideAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleOverrideAction? OverrideAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRule), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRule")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRule
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

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#priority Wafv2WebAcl#priority}.</summary>
            [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
            public double Priority
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#statement Wafv2WebAcl#statement}
            /// </remarks>
            [JsiiProperty(name: "statement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatement\"}")]
            public aws.Wafv2.IWafv2WebAclRuleStatement Statement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatement>()!;
            }

            /// <summary>visibility_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#visibility_config Wafv2WebAcl#visibility_config}
            /// </remarks>
            [JsiiProperty(name: "visibilityConfig", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleVisibilityConfig\"}")]
            public aws.Wafv2.IWafv2WebAclRuleVisibilityConfig VisibilityConfig
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleVisibilityConfig>()!;
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#action Wafv2WebAcl#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleAction\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleAction? Action
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleAction?>();
            }

            /// <summary>override_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#override_action Wafv2WebAcl#override_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrideAction", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleOverrideAction\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleOverrideAction? OverrideAction
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleOverrideAction?>();
            }
        }
    }
}
