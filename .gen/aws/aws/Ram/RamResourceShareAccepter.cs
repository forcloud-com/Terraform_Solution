using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ram
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ram_resource_share_accepter aws_ram_resource_share_accepter}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ram.RamResourceShareAccepter), fullyQualifiedName: "aws.ram.RamResourceShareAccepter", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ram.RamResourceShareAccepterConfig\"}}]")]
    public class RamResourceShareAccepter : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ram_resource_share_accepter aws_ram_resource_share_accepter} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public RamResourceShareAccepter(Constructs.Construct scope, string id, aws.Ram.IRamResourceShareAccepterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RamResourceShareAccepter(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RamResourceShareAccepter(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ram.RamResourceShareAccepterTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Ram.IRamResourceShareAccepterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ram.IRamResourceShareAccepterTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Ram.RamResourceShareAccepter))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invitationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvitationArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "receiverAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReceiverAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Resources
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "senderAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SenderAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shareId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShareId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shareName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShareName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ram.RamResourceShareAccepterTimeoutsOutputReference\"}")]
        public virtual aws.Ram.RamResourceShareAccepterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Ram.RamResourceShareAccepterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "shareArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShareArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.ram.RamResourceShareAccepterTimeouts\"}", isOptional: true)]
        public virtual aws.Ram.IRamResourceShareAccepterTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Ram.IRamResourceShareAccepterTimeouts?>();
        }

        [JsiiProperty(name: "shareArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShareArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
