using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dlm
{
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule")]
    public interface IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#interval DlmLifecyclePolicy#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        double Interval
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#interval_unit DlmLifecyclePolicy#interval_unit}.</summary>
        [JsiiProperty(name: "intervalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IntervalUnit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#times DlmLifecyclePolicy#times}.</summary>
        [JsiiProperty(name: "times", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Times
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleCreateRule")]
        internal sealed class _Proxy : DeputyBase, aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleCreateRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#interval DlmLifecyclePolicy#interval}.</summary>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
            public double Interval
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#interval_unit DlmLifecyclePolicy#interval_unit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "intervalUnit", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IntervalUnit
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#times DlmLifecyclePolicy#times}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "times", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Times
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
