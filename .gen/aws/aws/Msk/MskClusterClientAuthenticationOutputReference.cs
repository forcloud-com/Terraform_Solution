using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiClass(nativeType: typeof(aws.Msk.MskClusterClientAuthenticationOutputReference), fullyQualifiedName: "aws.msk.MskClusterClientAuthenticationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterClientAuthenticationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterClientAuthenticationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterClientAuthenticationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterClientAuthenticationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterClientAuthenticationTls\"}}]")]
        public virtual void PutTls(aws.Msk.IMskClusterClientAuthenticationTls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterClientAuthenticationTls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTls")]
        public virtual void ResetTls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthenticationTlsOutputReference\"}")]
        public virtual aws.Msk.MskClusterClientAuthenticationTlsOutputReference Tls
        {
            get => GetInstanceProperty<aws.Msk.MskClusterClientAuthenticationTlsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthenticationTls\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterClientAuthenticationTls? TlsInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterClientAuthenticationTls?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthentication\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterClientAuthentication? InternalValue
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterClientAuthentication?>();
            set => SetInstanceProperty(value);
        }
    }
}
