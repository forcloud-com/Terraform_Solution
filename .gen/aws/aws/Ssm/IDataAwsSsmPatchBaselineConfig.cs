using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    /// <summary>AWS Systems Manager.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsSsmPatchBaselineConfig), fullyQualifiedName: "aws.ssm.DataAwsSsmPatchBaselineConfig")]
    public interface IDataAwsSsmPatchBaselineConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ssm_patch_baseline#owner DataAwsSsmPatchBaseline#owner}.</summary>
        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        string Owner
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ssm_patch_baseline#default_baseline DataAwsSsmPatchBaseline#default_baseline}.</summary>
        [JsiiProperty(name: "defaultBaseline", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultBaseline
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ssm_patch_baseline#name_prefix DataAwsSsmPatchBaseline#name_prefix}.</summary>
        [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ssm_patch_baseline#operating_system DataAwsSsmPatchBaseline#operating_system}.</summary>
        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperatingSystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Systems Manager.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsSsmPatchBaselineConfig), fullyQualifiedName: "aws.ssm.DataAwsSsmPatchBaselineConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ssm.IDataAwsSsmPatchBaselineConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ssm_patch_baseline#owner DataAwsSsmPatchBaseline#owner}.</summary>
            [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
            public string Owner
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ssm_patch_baseline#default_baseline DataAwsSsmPatchBaseline#default_baseline}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultBaseline", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DefaultBaseline
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ssm_patch_baseline#name_prefix DataAwsSsmPatchBaseline#name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ssm_patch_baseline#operating_system DataAwsSsmPatchBaseline#operating_system}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperatingSystem
            {
                get => GetInstanceProperty<string?>();
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
