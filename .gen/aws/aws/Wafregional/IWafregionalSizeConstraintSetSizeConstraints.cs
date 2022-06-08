using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafregional
{
    [JsiiInterface(nativeType: typeof(IWafregionalSizeConstraintSetSizeConstraints), fullyQualifiedName: "aws.wafregional.WafregionalSizeConstraintSetSizeConstraints")]
    public interface IWafregionalSizeConstraintSetSizeConstraints
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#comparison_operator WafregionalSizeConstraintSet#comparison_operator}.</summary>
        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
        string ComparisonOperator
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#field_to_match WafregionalSizeConstraintSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalSizeConstraintSetSizeConstraintsFieldToMatch\"}")]
        aws.Wafregional.IWafregionalSizeConstraintSetSizeConstraintsFieldToMatch FieldToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#size WafregionalSizeConstraintSet#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#text_transformation WafregionalSizeConstraintSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafregionalSizeConstraintSetSizeConstraints), fullyQualifiedName: "aws.wafregional.WafregionalSizeConstraintSetSizeConstraints")]
        internal sealed class _Proxy : DeputyBase, aws.Wafregional.IWafregionalSizeConstraintSetSizeConstraints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#comparison_operator WafregionalSizeConstraintSet#comparison_operator}.</summary>
            [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string ComparisonOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#field_to_match WafregionalSizeConstraintSet#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafregional.WafregionalSizeConstraintSetSizeConstraintsFieldToMatch\"}")]
            public aws.Wafregional.IWafregionalSizeConstraintSetSizeConstraintsFieldToMatch FieldToMatch
            {
                get => GetInstanceProperty<aws.Wafregional.IWafregionalSizeConstraintSetSizeConstraintsFieldToMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#size WafregionalSizeConstraintSet#size}.</summary>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafregional_size_constraint_set#text_transformation WafregionalSizeConstraintSet#text_transformation}.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
