using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>AWS VPC.</summary>
    [JsiiInterface(nativeType: typeof(IVpcPeeringConnectionOptionsConfig), fullyQualifiedName: "aws.vpc.VpcPeeringConnectionOptionsConfig")]
    public interface IVpcPeeringConnectionOptionsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options#vpc_peering_connection_id VpcPeeringConnectionOptions#vpc_peering_connection_id}.</summary>
        [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcPeeringConnectionId
        {
            get;
        }

        /// <summary>accepter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options#accepter VpcPeeringConnectionOptions#accepter}
        /// </remarks>
        [JsiiProperty(name: "accepter", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionOptionsAccepter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Vpc.IVpcPeeringConnectionOptionsAccepter? Accepter
        {
            get
            {
                return null;
            }
        }

        /// <summary>requester block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options#requester VpcPeeringConnectionOptions#requester}
        /// </remarks>
        [JsiiProperty(name: "requester", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionOptionsRequester\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Vpc.IVpcPeeringConnectionOptionsRequester? Requester
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS VPC.</summary>
        [JsiiTypeProxy(nativeType: typeof(IVpcPeeringConnectionOptionsConfig), fullyQualifiedName: "aws.vpc.VpcPeeringConnectionOptionsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Vpc.IVpcPeeringConnectionOptionsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options#vpc_peering_connection_id VpcPeeringConnectionOptions#vpc_peering_connection_id}.</summary>
            [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcPeeringConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>accepter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options#accepter VpcPeeringConnectionOptions#accepter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accepter", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionOptionsAccepter\"}", isOptional: true)]
            public aws.Vpc.IVpcPeeringConnectionOptionsAccepter? Accepter
            {
                get => GetInstanceProperty<aws.Vpc.IVpcPeeringConnectionOptionsAccepter?>();
            }

            /// <summary>requester block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options#requester VpcPeeringConnectionOptions#requester}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requester", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionOptionsRequester\"}", isOptional: true)]
            public aws.Vpc.IVpcPeeringConnectionOptionsRequester? Requester
            {
                get => GetInstanceProperty<aws.Vpc.IVpcPeeringConnectionOptionsRequester?>();
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
