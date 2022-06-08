using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection aws_vpc_peering_connection}.</summary>
    [JsiiClass(nativeType: typeof(aws.Vpc.VpcPeeringConnection), fullyQualifiedName: "aws.vpc.VpcPeeringConnection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.vpc.VpcPeeringConnectionConfig\"}}]")]
    public class VpcPeeringConnection : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection aws_vpc_peering_connection} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VpcPeeringConnection(Constructs.Construct scope, string id, aws.Vpc.IVpcPeeringConnectionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnection(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccepter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepter\"}}]")]
        public virtual void PutAccepter(aws.Vpc.IVpcPeeringConnectionAccepter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Vpc.IVpcPeeringConnectionAccepter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequester", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpc.VpcPeeringConnectionRequester\"}}]")]
        public virtual void PutRequester(aws.Vpc.IVpcPeeringConnectionRequester @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Vpc.IVpcPeeringConnectionRequester)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpc.VpcPeeringConnectionTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Vpc.IVpcPeeringConnectionTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Vpc.IVpcPeeringConnectionTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetPeerOwnerId")]
        public virtual void ResetPeerOwnerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPeerRegion")]
        public virtual void ResetPeerRegion()
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

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Vpc.VpcPeeringConnection))!;

        [JsiiProperty(name: "accepter", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepterOutputReference\"}")]
        public virtual aws.Vpc.VpcPeeringConnectionAccepterOutputReference Accepter
        {
            get => GetInstanceProperty<aws.Vpc.VpcPeeringConnectionAccepterOutputReference>()!;
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

        [JsiiProperty(name: "requester", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionRequesterOutputReference\"}")]
        public virtual aws.Vpc.VpcPeeringConnectionRequesterOutputReference Requester
        {
            get => GetInstanceProperty<aws.Vpc.VpcPeeringConnectionRequesterOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionTimeoutsOutputReference\"}")]
        public virtual aws.Vpc.VpcPeeringConnectionTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Vpc.VpcPeeringConnectionTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accepterInput", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionAccepter\"}", isOptional: true)]
        public virtual aws.Vpc.IVpcPeeringConnectionAccepter? AccepterInput
        {
            get => GetInstanceProperty<aws.Vpc.IVpcPeeringConnectionAccepter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoAcceptInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoAcceptInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerOwnerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PeerOwnerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerRegionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PeerRegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "peerVpcIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PeerVpcIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requesterInput", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionRequester\"}", isOptional: true)]
        public virtual aws.Vpc.IVpcPeeringConnectionRequester? RequesterInput
        {
            get => GetInstanceProperty<aws.Vpc.IVpcPeeringConnectionRequester?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionTimeouts\"}", isOptional: true)]
        public virtual aws.Vpc.IVpcPeeringConnectionTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Vpc.IVpcPeeringConnectionTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autoAccept", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutoAccept
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerOwnerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerOwnerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerRegion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "peerVpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerVpcId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
