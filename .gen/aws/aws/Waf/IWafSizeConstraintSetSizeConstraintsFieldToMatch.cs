using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiInterface(nativeType: typeof(IWafSizeConstraintSetSizeConstraintsFieldToMatch), fullyQualifiedName: "aws.waf.WafSizeConstraintSetSizeConstraintsFieldToMatch")]
    public interface IWafSizeConstraintSetSizeConstraintsFieldToMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set#type WafSizeConstraintSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set#data WafSizeConstraintSet#data}.</summary>
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Data
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafSizeConstraintSetSizeConstraintsFieldToMatch), fullyQualifiedName: "aws.waf.WafSizeConstraintSetSizeConstraintsFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.Waf.IWafSizeConstraintSetSizeConstraintsFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set#type WafSizeConstraintSet#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set#data WafSizeConstraintSet#data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Data
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
