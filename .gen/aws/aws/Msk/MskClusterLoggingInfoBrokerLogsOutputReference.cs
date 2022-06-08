using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiClass(nativeType: typeof(aws.Msk.MskClusterLoggingInfoBrokerLogsOutputReference), fullyQualifiedName: "aws.msk.MskClusterLoggingInfoBrokerLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterLoggingInfoBrokerLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterLoggingInfoBrokerLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterLoggingInfoBrokerLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterLoggingInfoBrokerLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsCloudwatchLogs\"}}]")]
        public virtual void PutCloudwatchLogs(aws.Msk.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFirehose", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsFirehose\"}}]")]
        public virtual void PutFirehose(aws.Msk.IMskClusterLoggingInfoBrokerLogsFirehose @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterLoggingInfoBrokerLogsFirehose)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsS3\"}}]")]
        public virtual void PutS3(aws.Msk.IMskClusterLoggingInfoBrokerLogsS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterLoggingInfoBrokerLogsS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogs")]
        public virtual void ResetCloudwatchLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirehose")]
        public virtual void ResetFirehose()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsCloudwatchLogsOutputReference\"}")]
        public virtual aws.Msk.MskClusterLoggingInfoBrokerLogsCloudwatchLogsOutputReference CloudwatchLogs
        {
            get => GetInstanceProperty<aws.Msk.MskClusterLoggingInfoBrokerLogsCloudwatchLogsOutputReference>()!;
        }

        [JsiiProperty(name: "firehose", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsFirehoseOutputReference\"}")]
        public virtual aws.Msk.MskClusterLoggingInfoBrokerLogsFirehoseOutputReference Firehose
        {
            get => GetInstanceProperty<aws.Msk.MskClusterLoggingInfoBrokerLogsFirehoseOutputReference>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsS3OutputReference\"}")]
        public virtual aws.Msk.MskClusterLoggingInfoBrokerLogsS3OutputReference S3
        {
            get => GetInstanceProperty<aws.Msk.MskClusterLoggingInfoBrokerLogsS3OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsCloudwatchLogs\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs? CloudwatchLogsInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterLoggingInfoBrokerLogsCloudwatchLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firehoseInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsFirehose\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterLoggingInfoBrokerLogsFirehose? FirehoseInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterLoggingInfoBrokerLogsFirehose?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogsS3\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterLoggingInfoBrokerLogsS3? S3Input
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterLoggingInfoBrokerLogsS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.msk.MskClusterLoggingInfoBrokerLogs\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterLoggingInfoBrokerLogs? InternalValue
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterLoggingInfoBrokerLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
