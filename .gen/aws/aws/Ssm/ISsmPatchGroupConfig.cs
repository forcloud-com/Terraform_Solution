using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    /// <summary>AWS Systems Manager.</summary>
    [JsiiInterface(nativeType: typeof(ISsmPatchGroupConfig), fullyQualifiedName: "aws.ssm.SsmPatchGroupConfig")]
    public interface ISsmPatchGroupConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_group#baseline_id SsmPatchGroup#baseline_id}.</summary>
        [JsiiProperty(name: "baselineId", typeJson: "{\"primitive\":\"string\"}")]
        string BaselineId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_group#patch_group SsmPatchGroup#patch_group}.</summary>
        [JsiiProperty(name: "patchGroup", typeJson: "{\"primitive\":\"string\"}")]
        string PatchGroup
        {
            get;
        }

        /// <summary>AWS Systems Manager.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISsmPatchGroupConfig), fullyQualifiedName: "aws.ssm.SsmPatchGroupConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ssm.ISsmPatchGroupConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_group#baseline_id SsmPatchGroup#baseline_id}.</summary>
            [JsiiProperty(name: "baselineId", typeJson: "{\"primitive\":\"string\"}")]
            public string BaselineId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_patch_group#patch_group SsmPatchGroup#patch_group}.</summary>
            [JsiiProperty(name: "patchGroup", typeJson: "{\"primitive\":\"string\"}")]
            public string PatchGroup
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
