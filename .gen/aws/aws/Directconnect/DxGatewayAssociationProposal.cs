using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Directconnect
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association_proposal aws_dx_gateway_association_proposal}.</summary>
    [JsiiClass(nativeType: typeof(aws.Directconnect.DxGatewayAssociationProposal), fullyQualifiedName: "aws.directconnect.DxGatewayAssociationProposal", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.directconnect.DxGatewayAssociationProposalConfig\"}}]")]
    public class DxGatewayAssociationProposal : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/dx_gateway_association_proposal aws_dx_gateway_association_proposal} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DxGatewayAssociationProposal(Constructs.Construct scope, string id, aws.Directconnect.IDxGatewayAssociationProposalConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DxGatewayAssociationProposal(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DxGatewayAssociationProposal(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAllowedPrefixes")]
        public virtual void ResetAllowedPrefixes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAssociatedGatewayId")]
        public virtual void ResetAssociatedGatewayId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpnGatewayId")]
        public virtual void ResetVpnGatewayId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Directconnect.DxGatewayAssociationProposal))!;

        [JsiiProperty(name: "associatedGatewayOwnerAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedGatewayOwnerAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "associatedGatewayType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedGatewayType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedPrefixesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedPrefixesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "associatedGatewayIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssociatedGatewayIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dxGatewayIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DxGatewayIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dxGatewayOwnerAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DxGatewayOwnerAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpnGatewayIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpnGatewayIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allowedPrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedPrefixes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "associatedGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedGatewayId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dxGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DxGatewayId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dxGatewayOwnerAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DxGatewayOwnerAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpnGatewayId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
