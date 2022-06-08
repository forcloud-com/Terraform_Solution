using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiInterface(nativeType: typeof(IWafSizeConstraintSetSizeConstraints), fullyQualifiedName: "aws.waf.WafSizeConstraintSetSizeConstraints")]
    public interface IWafSizeConstraintSetSizeConstraints
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set#comparison_operator WafSizeConstraintSet#comparison_operator}.</summary>
        [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
        string ComparisonOperator
        {
            get;
        }

        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set#field_to_match WafSizeConstraintSet#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.waf.WafSizeConstraintSetSizeConstraintsFieldToMatch\"}")]
        aws.Waf.IWafSizeConstraintSetSizeConstraintsFieldToMatch FieldToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set#size WafSizeConstraintSet#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set#text_transformation WafSizeConstraintSet#text_transformation}.</summary>
        [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
        string TextTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafSizeConstraintSetSizeConstraints), fullyQualifiedName: "aws.waf.WafSizeConstraintSetSizeConstraints")]
        internal sealed class _Proxy : DeputyBase, aws.Waf.IWafSizeConstraintSetSizeConstraints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set#comparison_operator WafSizeConstraintSet#comparison_operator}.</summary>
            [JsiiProperty(name: "comparisonOperator", typeJson: "{\"primitive\":\"string\"}")]
            public string ComparisonOperator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set#field_to_match WafSizeConstraintSet#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.waf.WafSizeConstraintSetSizeConstraintsFieldToMatch\"}")]
            public aws.Waf.IWafSizeConstraintSetSizeConstraintsFieldToMatch FieldToMatch
            {
                get => GetInstanceProperty<aws.Waf.IWafSizeConstraintSetSizeConstraintsFieldToMatch>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set#size WafSizeConstraintSet#size}.</summary>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set#text_transformation WafSizeConstraintSet#text_transformation}.</summary>
            [JsiiProperty(name: "textTransformation", typeJson: "{\"primitive\":\"string\"}")]
            public string TextTransformation
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
