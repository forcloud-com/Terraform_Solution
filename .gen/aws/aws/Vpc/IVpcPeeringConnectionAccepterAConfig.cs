using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>AWS VPC.</summary>
    [JsiiInterface(nativeType: typeof(IVpcPeeringConnectionAccepterAConfig), fullyQualifiedName: "aws.vpc.VpcPeeringConnectionAccepterAConfig")]
    public interface IVpcPeeringConnectionAccepterAConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_accepter#vpc_peering_connection_id VpcPeeringConnectionAccepterA#vpc_peering_connection_id}.</summary>
        [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcPeeringConnectionId
        {
            get;
        }

        /// <summary>accepter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_accepter#accepter VpcPeeringConnectionAccepterA#accepter}
        /// </remarks>
        [JsiiProperty(name: "accepter", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepterAccepter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Vpc.IVpcPeeringConnectionAccepterAccepter? Accepter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_accepter#auto_accept VpcPeeringConnectionAccepterA#auto_accept}.</summary>
        [JsiiProperty(name: "autoAccept", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoAccept
        {
            get
            {
                return null;
            }
        }

        /// <summary>requester block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_accepter#requester VpcPeeringConnectionAccepterA#requester}
        /// </remarks>
        [JsiiProperty(name: "requester", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepterRequester\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Vpc.IVpcPeeringConnectionAccepterRequester? Requester
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_accepter#tags VpcPeeringConnectionAccepterA#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS VPC.</summary>
        [JsiiTypeProxy(nativeType: typeof(IVpcPeeringConnectionAccepterAConfig), fullyQualifiedName: "aws.vpc.VpcPeeringConnectionAccepterAConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Vpc.IVpcPeeringConnectionAccepterAConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_accepter#vpc_peering_connection_id VpcPeeringConnectionAccepterA#vpc_peering_connection_id}.</summary>
            [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcPeeringConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>accepter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_accepter#accepter VpcPeeringConnectionAccepterA#accepter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accepter", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepterAccepter\"}", isOptional: true)]
            public aws.Vpc.IVpcPeeringConnectionAccepterAccepter? Accepter
            {
                get => GetInstanceProperty<aws.Vpc.IVpcPeeringConnectionAccepterAccepter?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_accepter#auto_accept VpcPeeringConnectionAccepterA#auto_accept}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoAccept", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutoAccept
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>requester block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_accepter#requester VpcPeeringConnectionAccepterA#requester}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requester", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepterRequester\"}", isOptional: true)]
            public aws.Vpc.IVpcPeeringConnectionAccepterRequester? Requester
            {
                get => GetInstanceProperty<aws.Vpc.IVpcPeeringConnectionAccepterRequester?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_accepter#tags VpcPeeringConnectionAccepterA#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
