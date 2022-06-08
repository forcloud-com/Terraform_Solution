using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/guardduty_invite_accepter aws_guardduty_invite_accepter}.</summary>
    [JsiiClass(nativeType: typeof(aws.Guardduty.GuarddutyInviteAccepter), fullyQualifiedName: "aws.guardduty.GuarddutyInviteAccepter", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.guardduty.GuarddutyInviteAccepterConfig\"}}]")]
    public class GuarddutyInviteAccepter : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/guardduty_invite_accepter aws_guardduty_invite_accepter} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GuarddutyInviteAccepter(Constructs.Construct scope, string id, aws.Guardduty.IGuarddutyInviteAccepterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyInviteAccepter(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyInviteAccepter(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.guardduty.GuarddutyInviteAccepterTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Guardduty.IGuarddutyInviteAccepterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Guardduty.IGuarddutyInviteAccepterTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Guardduty.GuarddutyInviteAccepter))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyInviteAccepterTimeoutsOutputReference\"}")]
        public virtual aws.Guardduty.GuarddutyInviteAccepterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Guardduty.GuarddutyInviteAccepterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "detectorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DetectorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyInviteAccepterTimeouts\"}", isOptional: true)]
        public virtual aws.Guardduty.IGuarddutyInviteAccepterTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Guardduty.IGuarddutyInviteAccepterTimeouts?>();
        }

        [JsiiProperty(name: "detectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DetectorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
