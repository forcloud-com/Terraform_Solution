using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument")]
    public interface IWafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#name Wafv2WebAclLoggingConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclLoggingConfigurationRedactedFieldsSingleQueryArgument
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#name Wafv2WebAclLoggingConfiguration#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
