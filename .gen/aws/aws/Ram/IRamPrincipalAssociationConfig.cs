using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ram
{
    /// <summary>AWS Resource Access Manager.</summary>
    [JsiiInterface(nativeType: typeof(IRamPrincipalAssociationConfig), fullyQualifiedName: "aws.ram.RamPrincipalAssociationConfig")]
    public interface IRamPrincipalAssociationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ram_principal_association#principal RamPrincipalAssociation#principal}.</summary>
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        string Principal
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ram_principal_association#resource_share_arn RamPrincipalAssociation#resource_share_arn}.</summary>
        [JsiiProperty(name: "resourceShareArn", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceShareArn
        {
            get;
        }

        /// <summary>AWS Resource Access Manager.</summary>
        [JsiiTypeProxy(nativeType: typeof(IRamPrincipalAssociationConfig), fullyQualifiedName: "aws.ram.RamPrincipalAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ram.IRamPrincipalAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ram_principal_association#principal RamPrincipalAssociation#principal}.</summary>
            [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
            public string Principal
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ram_principal_association#resource_share_arn RamPrincipalAssociation#resource_share_arn}.</summary>
            [JsiiProperty(name: "resourceShareArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceShareArn
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
