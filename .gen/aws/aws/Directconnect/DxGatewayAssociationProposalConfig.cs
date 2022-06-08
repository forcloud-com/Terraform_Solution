using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directconnect
{
    #pragma warning disable CS8618

    /// <summary>AWS Direct Connect.</summary>
    [JsiiByValue(fqn: "aws.directconnect.DxGatewayAssociationProposalConfig")]
    public class DxGatewayAssociationProposalConfig : aws.Directconnect.IDxGatewayAssociationProposalConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association_proposal#dx_gateway_id DxGatewayAssociationProposal#dx_gateway_id}.</summary>
        [JsiiProperty(name: "dxGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public string DxGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association_proposal#dx_gateway_owner_account_id DxGatewayAssociationProposal#dx_gateway_owner_account_id}.</summary>
        [JsiiProperty(name: "dxGatewayOwnerAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public string DxGatewayOwnerAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association_proposal#allowed_prefixes DxGatewayAssociationProposal#allowed_prefixes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedPrefixes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association_proposal#associated_gateway_id DxGatewayAssociationProposal#associated_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "associatedGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AssociatedGatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association_proposal#vpn_gateway_id DxGatewayAssociationProposal#vpn_gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpnGatewayId
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
