using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipv4_cidr_block_association aws_vpc_ipv4_cidr_block_association}.</summary>
    [JsiiClass(nativeType: typeof(aws.Vpc.VpcIpv4CidrBlockAssociation), fullyQualifiedName: "aws.vpc.VpcIpv4CidrBlockAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.vpc.VpcIpv4CidrBlockAssociationConfig\"}}]")]
    public class VpcIpv4CidrBlockAssociation : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/vpc_ipv4_cidr_block_association aws_vpc_ipv4_cidr_block_association} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VpcIpv4CidrBlockAssociation(Constructs.Construct scope, string id, aws.Vpc.IVpcIpv4CidrBlockAssociationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcIpv4CidrBlockAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpcIpv4CidrBlockAssociation(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpc.VpcIpv4CidrBlockAssociationTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Vpc.IVpcIpv4CidrBlockAssociationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Vpc.IVpcIpv4CidrBlockAssociationTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Vpc.VpcIpv4CidrBlockAssociation))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.vpc.VpcIpv4CidrBlockAssociationTimeoutsOutputReference\"}")]
        public virtual aws.Vpc.VpcIpv4CidrBlockAssociationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Vpc.VpcIpv4CidrBlockAssociationTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cidrBlockInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CidrBlockInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.vpc.VpcIpv4CidrBlockAssociationTimeouts\"}", isOptional: true)]
        public virtual aws.Vpc.IVpcIpv4CidrBlockAssociationTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Vpc.IVpcIpv4CidrBlockAssociationTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CidrBlock
        {
            get => GetInstanceProperty<string>()!;
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
