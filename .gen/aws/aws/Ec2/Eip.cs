using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/eip aws_eip}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.Eip), fullyQualifiedName: "aws.ec2.Eip", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.ec2.EipConfig\"}}]")]
    public class Eip : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/eip aws_eip} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Eip(Constructs.Construct scope, string id, aws.Ec2.IEipConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Eip(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Eip(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ec2.EipTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Ec2.IEipTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ec2.IEipTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssociateWithPrivateIp")]
        public virtual void ResetAssociateWithPrivateIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerOwnedIpv4Pool")]
        public virtual void ResetCustomerOwnedIpv4Pool()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstance")]
        public virtual void ResetInstance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkInterface")]
        public virtual void ResetNetworkInterface()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicIpv4Pool")]
        public virtual void ResetPublicIpv4Pool()
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

        [JsiiMethod(name: "resetVpc")]
        public virtual void ResetVpc()
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
        = GetStaticProperty<string>(typeof(aws.Ec2.Eip))!;

        [JsiiProperty(name: "allocationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AllocationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "associationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerOwnedIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerOwnedIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicDns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2.EipTimeoutsOutputReference\"}")]
        public virtual aws.Ec2.EipTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Ec2.EipTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "associateWithPrivateIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AssociateWithPrivateIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerOwnedIpv4PoolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerOwnedIpv4PoolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkInterfaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicIpv4PoolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicIpv4PoolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.ec2.EipTimeouts\"}", isOptional: true)]
        public virtual aws.Ec2.IEipTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Ec2.IEipTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? VpcInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "associateWithPrivateIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociateWithPrivateIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customerOwnedIpv4Pool", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerOwnedIpv4Pool
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Instance
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkInterface", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkInterface
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicIpv4Pool", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIpv4Pool
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

        [JsiiProperty(name: "vpc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Vpc
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
