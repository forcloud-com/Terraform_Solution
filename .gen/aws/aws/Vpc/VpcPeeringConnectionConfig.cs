using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    #pragma warning disable CS8618

    /// <summary>AWS VPC.</summary>
    [JsiiByValue(fqn: "aws.vpc.VpcPeeringConnectionConfig")]
    public class VpcPeeringConnectionConfig : aws.Vpc.IVpcPeeringConnectionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#peer_vpc_id VpcPeeringConnection#peer_vpc_id}.</summary>
        [JsiiProperty(name: "peerVpcId", typeJson: "{\"primitive\":\"string\"}")]
        public string PeerVpcId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#vpc_id VpcPeeringConnection#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcId
        {
            get;
            set;
        }

        /// <summary>accepter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#accepter VpcPeeringConnection#accepter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accepter", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepter\"}", isOptional: true)]
        public aws.Vpc.IVpcPeeringConnectionAccepter? Accepter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#auto_accept VpcPeeringConnection#auto_accept}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoAccept", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoAccept
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#peer_owner_id VpcPeeringConnection#peer_owner_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerOwnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerOwnerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#peer_region VpcPeeringConnection#peer_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerRegion
        {
            get;
            set;
        }

        /// <summary>requester block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#requester VpcPeeringConnection#requester}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requester", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionRequester\"}", isOptional: true)]
        public aws.Vpc.IVpcPeeringConnectionRequester? Requester
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#tags VpcPeeringConnection#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection#timeouts VpcPeeringConnection#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionTimeouts\"}", isOptional: true)]
        public aws.Vpc.IVpcPeeringConnectionTimeouts? Timeouts
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
