using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    [JsiiInterface(nativeType: typeof(IWafregionalSizeConstraintSetSizeConstraintsFieldToMatch), fullyQualifiedName: "aws.wafregional.WafregionalSizeConstraintSetSizeConstraintsFieldToMatch")]
    public interface IWafregionalSizeConstraintSetSizeConstraintsFieldToMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#type WafregionalSizeConstraintSet#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#data WafregionalSizeConstraintSet#data}.</summary>
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Data
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalSizeConstraintSetSizeConstraintsFieldToMatch), fullyQualifiedName: "aws.wafregional.WafregionalSizeConstraintSetSizeConstraintsFieldToMatch")]
        internal sealed class _Proxy : DeputyBase, aws.Wafregional.IWafregionalSizeConstraintSetSizeConstraintsFieldToMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#type WafregionalSizeConstraintSet#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#data WafregionalSizeConstraintSet#data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Data
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
