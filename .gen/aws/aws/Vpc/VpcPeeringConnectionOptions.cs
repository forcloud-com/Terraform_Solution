using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options aws_vpc_peering_connection_options}.</summary>
    [JsiiClass(nativeType: typeof(aws.Vpc.VpcPeeringConnectionOptions), fullyQualifiedName: "aws.vpc.VpcPeeringConnectionOptions", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.vpc.VpcPeeringConnectionOptionsConfig\"}}]")]
    public class VpcPeeringConnectionOptions : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/vpc_peering_connection_options aws_vpc_peering_connection_options} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VpcPeeringConnectionOptions(Constructs.Construct scope, string id, aws.Vpc.IVpcPeeringConnectionOptionsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnectionOptions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcPeeringConnectionOptions(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccepter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpc.VpcPeeringConnectionOptionsAccepter\"}}]")]
        public virtual void PutAccepter(aws.Vpc.IVpcPeeringConnectionOptionsAccepter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Vpc.IVpcPeeringConnectionOptionsAccepter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRequester", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpc.VpcPeeringConnectionOptionsRequester\"}}]")]
        public virtual void PutRequester(aws.Vpc.IVpcPeeringConnectionOptionsRequester @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Vpc.IVpcPeeringConnectionOptionsRequester)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccepter")]
        public virtual void ResetAccepter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequester")]
        public virtual void ResetRequester()
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
        = GetStaticProperty<string>(typeof(aws.Vpc.VpcPeeringConnectionOptions))!;

        [JsiiProperty(name: "accepter", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionOptionsAccepterOutputReference\"}")]
        public virtual aws.Vpc.VpcPeeringConnectionOptionsAccepterOutputReference Accepter
        {
            get => GetInstanceProperty<aws.Vpc.VpcPeeringConnectionOptionsAccepterOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requester", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionOptionsRequesterOutputReference\"}")]
        public virtual aws.Vpc.VpcPeeringConnectionOptionsRequesterOutputReference Requester
        {
            get => GetInstanceProperty<aws.Vpc.VpcPeeringConnectionOptionsRequesterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accepterInput", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionOptionsAccepter\"}", isOptional: true)]
        public virtual aws.Vpc.IVpcPeeringConnectionOptionsAccepter? AccepterInput
        {
            get => GetInstanceProperty<aws.Vpc.IVpcPeeringConnectionOptionsAccepter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requesterInput", typeJson: "{\"fqn\":\"aws.vpc.VpcPeeringConnectionOptionsRequester\"}", isOptional: true)]
        public virtual aws.Vpc.IVpcPeeringConnectionOptionsRequester? RequesterInput
        {
            get => GetInstanceProperty<aws.Vpc.IVpcPeeringConnectionOptionsRequester?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcPeeringConnectionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcPeeringConnectionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "vpcPeeringConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcPeeringConnectionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
