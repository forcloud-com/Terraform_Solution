using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directconnect
{
    /// <summary>AWS Direct Connect.</summary>
    [JsiiInterface(nativeType: typeof(IDxGatewayAssociationConfig), fullyQualifiedName: "aws.directconnect.DxGatewayAssociationConfig")]
    public interface IDxGatewayAssociationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#dx_gateway_id DxGatewayAssociation#dx_gateway_id}.</summary>
        [JsiiProperty(name: "dxGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        string DxGatewayId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#allowed_prefixes DxGatewayAssociation#allowed_prefixes}.</summary>
        [JsiiProperty(name: "allowedPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedPrefixes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#associated_gateway_id DxGatewayAssociation#associated_gateway_id}.</summary>
        [JsiiProperty(name: "associatedGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AssociatedGatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#associated_gateway_owner_account_id DxGatewayAssociation#associated_gateway_owner_account_id}.</summary>
        [JsiiProperty(name: "associatedGatewayOwnerAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AssociatedGatewayOwnerAccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#proposal_id DxGatewayAssociation#proposal_id}.</summary>
        [JsiiProperty(name: "proposalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProposalId
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#timeouts DxGatewayAssociation#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directconnect.DxGatewayAssociationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Directconnect.IDxGatewayAssociationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#vpn_gateway_id DxGatewayAssociation#vpn_gateway_id}.</summary>
        [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpnGatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Direct Connect.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDxGatewayAssociationConfig), fullyQualifiedName: "aws.directconnect.DxGatewayAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Directconnect.IDxGatewayAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#dx_gateway_id DxGatewayAssociation#dx_gateway_id}.</summary>
            [JsiiProperty(name: "dxGatewayId", typeJson: "{\"primitive\":\"string\"}")]
            public string DxGatewayId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#allowed_prefixes DxGatewayAssociation#allowed_prefixes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedPrefixes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#associated_gateway_id DxGatewayAssociation#associated_gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "associatedGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AssociatedGatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#associated_gateway_owner_account_id DxGatewayAssociation#associated_gateway_owner_account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "associatedGatewayOwnerAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AssociatedGatewayOwnerAccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#proposal_id DxGatewayAssociation#proposal_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "proposalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProposalId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#timeouts DxGatewayAssociation#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.directconnect.DxGatewayAssociationTimeouts\"}", isOptional: true)]
            public aws.Directconnect.IDxGatewayAssociationTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Directconnect.IDxGatewayAssociationTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association#vpn_gateway_id DxGatewayAssociation#vpn_gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpnGatewayId
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
