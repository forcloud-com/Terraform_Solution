using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    [JsiiClass(nativeType: typeof(aws.Efs.EfsAccessPointPosixUserOutputReference), fullyQualifiedName: "aws.efs.EfsAccessPointPosixUserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EfsAccessPointPosixUserOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EfsAccessPointPosixUserOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsAccessPointPosixUserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsAccessPointPosixUserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSecondaryGids")]
        public virtual void ResetSecondaryGids()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "gidInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GidInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryGidsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? SecondaryGidsInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uidInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UidInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "gid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Gid
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondaryGids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] SecondaryGids
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Uid
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.efs.EfsAccessPointPosixUser\"}", isOptional: true)]
        public virtual aws.Efs.IEfsAccessPointPosixUser? InternalValue
        {
            get => GetInstanceProperty<aws.Efs.IEfsAccessPointPosixUser?>();
            set => SetInstanceProperty(value);
        }
    }
}
