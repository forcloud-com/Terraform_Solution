using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie
{
    /// <summary>AWS Macie.</summary>
    [JsiiInterface(nativeType: typeof(IMacieMemberAccountAssociationConfig), fullyQualifiedName: "aws.macie.MacieMemberAccountAssociationConfig")]
    public interface IMacieMemberAccountAssociationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie_member_account_association#member_account_id MacieMemberAccountAssociation#member_account_id}.</summary>
        [JsiiProperty(name: "memberAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string MemberAccountId
        {
            get;
        }

        /// <summary>AWS Macie.</summary>
        [JsiiTypeProxy(nativeType: typeof(IMacieMemberAccountAssociationConfig), fullyQualifiedName: "aws.macie.MacieMemberAccountAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Macie.IMacieMemberAccountAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie_member_account_association#member_account_id MacieMemberAccountAssociation#member_account_id}.</summary>
            [JsiiProperty(name: "memberAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string MemberAccountId
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
