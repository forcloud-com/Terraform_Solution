using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiClass(nativeType: typeof(aws.Msk.MskClusterOpenMonitoringOutputReference), fullyQualifiedName: "aws.msk.MskClusterOpenMonitoringOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterOpenMonitoringOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterOpenMonitoringOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterOpenMonitoringOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterOpenMonitoringOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPrometheus", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheus\"}}]")]
        public virtual void PutPrometheus(aws.Msk.IMskClusterOpenMonitoringPrometheus @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterOpenMonitoringPrometheus)}, new object[]{@value});
        }

        [JsiiProperty(name: "prometheus", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheusOutputReference\"}")]
        public virtual aws.Msk.MskClusterOpenMonitoringPrometheusOutputReference Prometheus
        {
            get => GetInstanceProperty<aws.Msk.MskClusterOpenMonitoringPrometheusOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "prometheusInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheus\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterOpenMonitoringPrometheus? PrometheusInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterOpenMonitoringPrometheus?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoring\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterOpenMonitoring? InternalValue
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterOpenMonitoring?>();
            set => SetInstanceProperty(value);
        }
    }
}
