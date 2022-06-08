using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ram
{
    /// <summary>AWS Resource Access Manager.</summary>
    [JsiiInterface(nativeType: typeof(IRamResourceShareAccepterConfig), fullyQualifiedName: "aws.ram.RamResourceShareAccepterConfig")]
    public interface IRamResourceShareAccepterConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ram_resource_share_accepter#share_arn RamResourceShareAccepter#share_arn}.</summary>
        [JsiiProperty(name: "shareArn", typeJson: "{\"primitive\":\"string\"}")]
        string ShareArn
        {
            get;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ram_resource_share_accepter#timeouts RamResourceShareAccepter#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ram.RamResourceShareAccepterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ram.IRamResourceShareAccepterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Resource Access Manager.</summary>
        [JsiiTypeProxy(nativeType: typeof(IRamResourceShareAccepterConfig), fullyQualifiedName: "aws.ram.RamResourceShareAccepterConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ram.IRamResourceShareAccepterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ram_resource_share_accepter#share_arn RamResourceShareAccepter#share_arn}.</summary>
            [JsiiProperty(name: "shareArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ShareArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ram_resource_share_accepter#timeouts RamResourceShareAccepter#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ram.RamResourceShareAccepterTimeouts\"}", isOptional: true)]
            public aws.Ram.IRamResourceShareAccepterTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Ram.IRamResourceShareAccepterTimeouts?>();
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
