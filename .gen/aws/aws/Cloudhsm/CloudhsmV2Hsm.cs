using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudhsm
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cloudhsm_v2_hsm aws_cloudhsm_v2_hsm}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudhsm.CloudhsmV2Hsm), fullyQualifiedName: "aws.cloudhsm.CloudhsmV2Hsm", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudhsm.CloudhsmV2HsmConfig\"}}]")]
    public class CloudhsmV2Hsm : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cloudhsm_v2_hsm aws_cloudhsm_v2_hsm} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudhsmV2Hsm(Constructs.Construct scope, string id, aws.Cloudhsm.ICloudhsmV2HsmConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudhsmV2Hsm(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudhsmV2Hsm(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudhsm.CloudhsmV2HsmTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Cloudhsm.ICloudhsmV2HsmTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudhsm.ICloudhsmV2HsmTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAvailabilityZone")]
        public virtual void ResetAvailabilityZone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpAddress")]
        public virtual void ResetIpAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
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
        = GetStaticProperty<string>(typeof(aws.Cloudhsm.CloudhsmV2Hsm))!;

        [JsiiProperty(name: "hsmEniId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HsmEniId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hsmId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HsmId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hsmState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HsmState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.cloudhsm.CloudhsmV2HsmTimeoutsOutputReference\"}")]
        public virtual aws.Cloudhsm.CloudhsmV2HsmTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Cloudhsm.CloudhsmV2HsmTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityZoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.cloudhsm.CloudhsmV2HsmTimeouts\"}", isOptional: true)]
        public virtual aws.Cloudhsm.ICloudhsmV2HsmTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Cloudhsm.ICloudhsmV2HsmTimeouts?>();
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
