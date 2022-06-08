using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiClass(nativeType: typeof(aws.Msk.MskClusterEncryptionInfoOutputReference), fullyQualifiedName: "aws.msk.MskClusterEncryptionInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterEncryptionInfoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterEncryptionInfoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterEncryptionInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterEncryptionInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEncryptionInTransit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterEncryptionInfoEncryptionInTransit\"}}]")]
        public virtual void PutEncryptionInTransit(aws.Msk.IMskClusterEncryptionInfoEncryptionInTransit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterEncryptionInfoEncryptionInTransit)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEncryptionAtRestKmsKeyArn")]
        public virtual void ResetEncryptionAtRestKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionInTransit")]
        public virtual void ResetEncryptionInTransit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "encryptionInTransit", typeJson: "{\"fqn\":\"aws.msk.MskClusterEncryptionInfoEncryptionInTransitOutputReference\"}")]
        public virtual aws.Msk.MskClusterEncryptionInfoEncryptionInTransitOutputReference EncryptionInTransit
        {
            get => GetInstanceProperty<aws.Msk.MskClusterEncryptionInfoEncryptionInTransitOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionAtRestKmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EncryptionAtRestKmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionInTransitInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterEncryptionInfoEncryptionInTransit\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterEncryptionInfoEncryptionInTransit? EncryptionInTransitInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterEncryptionInfoEncryptionInTransit?>();
        }

        [JsiiProperty(name: "encryptionAtRestKmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionAtRestKmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.msk.MskClusterEncryptionInfo\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterEncryptionInfo? InternalValue
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterEncryptionInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
