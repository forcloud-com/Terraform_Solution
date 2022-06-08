using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiClass(nativeType: typeof(aws.Msk.MskClusterLoggingInfoOutputReference), fullyQualifiedName: "aws.msk.MskClusterLoggingInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterLoggingInfoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterLoggingInfoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterLoggingInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterLoggingInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBrokerLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogs\"}}]")]
        public virtual void PutBrokerLogs(aws.Msk.IMskClusterLoggingInfoBrokerLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterLoggingInfoBrokerLogs)}, new object[]{@value});
        }

        [JsiiProperty(name: "brokerLogs", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsOutputReference\"}")]
        public virtual aws.Msk.MskClusterLoggingInfoBrokerLogsOutputReference BrokerLogs
        {
            get => GetInstanceProperty<aws.Msk.MskClusterLoggingInfoBrokerLogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "brokerLogsInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogs\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterLoggingInfoBrokerLogs? BrokerLogsInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterLoggingInfoBrokerLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfo\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterLoggingInfo? InternalValue
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterLoggingInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
