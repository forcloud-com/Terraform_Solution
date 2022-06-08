using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_accepter aws_vpc_peering_connection_accepter}.</summary>
    [JsiiClass(nativeType: typeof(aws.Vpc.VpcPeeringConnectionAccepterA), fullyQualifiedName: "aws.vpc.VpcPeeringConnectionAccepterA", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepterAConfig\"}}]")]
    public class VpcPeeringConnectionAccepterA : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_accepter aws_vpc_peering_connection_accepter} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VpcPeeringConnectionAccepterA(Constructs.Construct scope, string id, aws.Vpc.IVpcPeeringConnectionAccepterAConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnectionAccepterA(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnectionAccepterA(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccepter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepterAccepter\"}}]")]
        public virtual void PutAccepter(aws.Vpc.IVpcPeeringConnectionAccepterAccepter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Vpc.IVpcPeeringConnectionAccepterAccepter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequester", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepterRequester\"}}]")]
        public virtual void PutRequester(aws.Vpc.IVpcPeeringConnectionAccepterRequester @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Vpc.IVpcPeeringConnectionAccepterRequester)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccepter")]
        public virtual void ResetAccepter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoAccept")]
        public virtual void ResetAutoAccept()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequester")]
        public virtual void ResetRequester()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
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
        = GetStaticProperty<string>(typeof(aws.Vpc.VpcPeeringConnectionAccepterA))!;

        [JsiiProperty(name: "accepter", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepterAccepterOutputReference\"}")]
        public virtual aws.Vpc.VpcPeeringConnectionAccepterAccepterOutputReference Accepter
        {
            get => GetInstanceProperty<aws.Vpc.VpcPeeringConnectionAccepterAccepterOutputReference>()!;
        }

        [JsiiProperty(name: "acceptStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcceptStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerOwnerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerOwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerVpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerVpcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requester", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepterRequesterOutputReference\"}")]
        public virtual aws.Vpc.VpcPeeringConnectionAccepterRequesterOutputReference Requester
        {
            get => GetInstanceProperty<aws.Vpc.VpcPeeringConnectionAccepterRequesterOutputReference>()!;
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accepterInput", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepterAccepter\"}", isOptional: true)]
        public virtual aws.Vpc.IVpcPeeringConnectionAccepterAccepter? AccepterInput
        {
            get => GetInstanceProperty<aws.Vpc.IVpcPeeringConnectionAccepterAccepter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoAcceptInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoAcceptInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requesterInput", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepterRequester\"}", isOptional: true)]
        public virtual aws.Vpc.IVpcPeeringConnectionAccepterRequester? RequesterInput
        {
            get => GetInstanceProperty<aws.Vpc.IVpcPeeringConnectionAccepterRequester?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcPeeringConnectionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcPeeringConnectionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autoAccept", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutoAccept
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcPeeringConnectionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
