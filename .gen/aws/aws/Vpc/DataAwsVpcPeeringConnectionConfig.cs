using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>AWS VPC.</summary>
    [JsiiByValue(fqn: "aws.vpc.DataAwsVpcPeeringConnectionConfig")]
    public class DataAwsVpcPeeringConnectionConfig : aws.Vpc.IDataAwsVpcPeeringConnectionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_peering_connection#cidr_block DataAwsVpcPeeringConnection#cidr_block}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CidrBlock
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_peering_connection#filter DataAwsVpcPeeringConnection#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpc.DataAwsVpcPeeringConnectionFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Filter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_peering_connection#owner_id DataAwsVpcPeeringConnection#owner_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OwnerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_peering_connection#peer_cidr_block DataAwsVpcPeeringConnection#peer_cidr_block}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerCidrBlock", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerCidrBlock
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_peering_connection#peer_owner_id DataAwsVpcPeeringConnection#peer_owner_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerOwnerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerOwnerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_peering_connection#peer_region DataAwsVpcPeeringConnection#peer_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_peering_connection#peer_vpc_id DataAwsVpcPeeringConnection#peer_vpc_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "peerVpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PeerVpcId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_peering_connection#region DataAwsVpcPeeringConnection#region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Region
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_peering_connection#status DataAwsVpcPeeringConnection#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_peering_connection#tags DataAwsVpcPeeringConnection#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/vpc_peering_connection#vpc_id DataAwsVpcPeeringConnection#vpc_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VpcId
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
