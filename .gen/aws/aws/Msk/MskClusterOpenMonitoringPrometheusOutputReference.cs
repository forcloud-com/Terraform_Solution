using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiClass(nativeType: typeof(aws.Msk.MskClusterOpenMonitoringPrometheusOutputReference), fullyQualifiedName: "aws.msk.MskClusterOpenMonitoringPrometheusOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MskClusterOpenMonitoringPrometheusOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MskClusterOpenMonitoringPrometheusOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterOpenMonitoringPrometheusOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterOpenMonitoringPrometheusOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putJmxExporter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheusJmxExporter\"}}]")]
        public virtual void PutJmxExporter(aws.Msk.IMskClusterOpenMonitoringPrometheusJmxExporter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterOpenMonitoringPrometheusJmxExporter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNodeExporter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheusNodeExporter\"}}]")]
        public virtual void PutNodeExporter(aws.Msk.IMskClusterOpenMonitoringPrometheusNodeExporter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterOpenMonitoringPrometheusNodeExporter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetJmxExporter")]
        public virtual void ResetJmxExporter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeExporter")]
        public virtual void ResetNodeExporter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "jmxExporter", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheusJmxExporterOutputReference\"}")]
        public virtual aws.Msk.MskClusterOpenMonitoringPrometheusJmxExporterOutputReference JmxExporter
        {
            get => GetInstanceProperty<aws.Msk.MskClusterOpenMonitoringPrometheusJmxExporterOutputReference>()!;
        }

        [JsiiProperty(name: "nodeExporter", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheusNodeExporterOutputReference\"}")]
        public virtual aws.Msk.MskClusterOpenMonitoringPrometheusNodeExporterOutputReference NodeExporter
        {
            get => GetInstanceProperty<aws.Msk.MskClusterOpenMonitoringPrometheusNodeExporterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "jmxExporterInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheusJmxExporter\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterOpenMonitoringPrometheusJmxExporter? JmxExporterInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterOpenMonitoringPrometheusJmxExporter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeExporterInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheusNodeExporter\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterOpenMonitoringPrometheusNodeExporter? NodeExporterInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterOpenMonitoringPrometheusNodeExporter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.msk.MskClusterOpenMonitoringPrometheus\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterOpenMonitoringPrometheus? InternalValue
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterOpenMonitoringPrometheus?>();
            set => SetInstanceProperty(value);
        }
    }
}
