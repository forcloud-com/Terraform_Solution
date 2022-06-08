using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudhsm
{
    [JsiiClass(nativeType: typeof(aws.Cloudhsm.DataAwsCloudhsmV2ClusterClusterCertificatesOutputReference), fullyQualifiedName: "aws.cloudhsm.DataAwsCloudhsmV2ClusterClusterCertificatesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsCloudhsmV2ClusterClusterCertificatesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsCloudhsmV2ClusterClusterCertificatesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudhsmV2ClusterClusterCertificatesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudhsmV2ClusterClusterCertificatesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "awsHardwareCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsHardwareCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterCsr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterCsr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hsmCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HsmCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "manufacturerHardwareCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManufacturerHardwareCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudhsm.DataAwsCloudhsmV2ClusterClusterCertificates\"}", isOptional: true)]
        public virtual aws.Cloudhsm.IDataAwsCloudhsmV2ClusterClusterCertificates? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudhsm.IDataAwsCloudhsmV2ClusterClusterCertificates?>();
            set => SetInstanceProperty(value);
        }
    }
}
