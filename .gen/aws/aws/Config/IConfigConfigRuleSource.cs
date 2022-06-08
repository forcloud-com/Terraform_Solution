using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    [JsiiInterface(nativeType: typeof(IConfigConfigRuleSource), fullyQualifiedName: "aws.config.ConfigConfigRuleSource")]
    public interface IConfigConfigRuleSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#owner ConfigConfigRule#owner}.</summary>
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        string Owner
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#source_identifier ConfigConfigRule#source_identifier}.</summary>
        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string SourceIdentifier
        {
            get;
        }

        /// <summary>source_detail block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#source_detail ConfigConfigRule#source_detail}
        /// </remarks>
        [JsiiProperty(name: "sourceDetail", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.config.ConfigConfigRuleSourceSourceDetail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceDetail
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConfigRuleSource), fullyQualifiedName: "aws.config.ConfigConfigRuleSource")]
        internal sealed class _Proxy : DeputyBase, aws.Config.IConfigConfigRuleSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#owner ConfigConfigRule#owner}.</summary>
            [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
            public string Owner
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#source_identifier ConfigConfigRule#source_identifier}.</summary>
            [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>source_detail block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#source_detail ConfigConfigRule#source_detail}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceDetail", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.config.ConfigConfigRuleSourceSourceDetail\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourceDetail
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
