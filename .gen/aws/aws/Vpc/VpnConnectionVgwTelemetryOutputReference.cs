using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    [JsiiClass(nativeType: typeof(aws.Vpc.VpnConnectionVgwTelemetryOutputReference), fullyQualifiedName: "aws.vpc.VpnConnectionVgwTelemetryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class VpnConnectionVgwTelemetryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public VpnConnectionVgwTelemetryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnConnectionVgwTelemetryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnConnectionVgwTelemetryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "acceptedRouteCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AcceptedRouteCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lastStatusChange", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastStatusChange
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outsideIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutsideIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.vpc.VpnConnectionVgwTelemetry\"}", isOptional: true)]
        public virtual aws.Vpc.IVpnConnectionVgwTelemetry? InternalValue
        {
            get => GetInstanceProperty<aws.Vpc.IVpnConnectionVgwTelemetry?>();
            set => SetInstanceProperty(value);
        }
    }
}
