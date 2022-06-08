using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecServiceDiscoveryOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshVirtualNodeSpecServiceDiscoveryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshVirtualNodeSpecServiceDiscoveryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecServiceDiscoveryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecServiceDiscoveryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAwsCloudMap", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap\"}}]")]
        public virtual void PutAwsCloudMap(aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryDns\"}}]")]
        public virtual void PutDns(aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryDns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryDns)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAwsCloudMap")]
        public virtual void ResetAwsCloudMap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDns")]
        public virtual void ResetDns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "awsCloudMap", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMapOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMapOutputReference AwsCloudMap
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMapOutputReference>()!;
        }

        [JsiiProperty(name: "dns", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryDnsOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecServiceDiscoveryDnsOutputReference Dns
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecServiceDiscoveryDnsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsCloudMapInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap? AwsCloudMapInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryAwsCloudMap?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscoveryDns\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryDns? DnsInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscoveryDns?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecServiceDiscovery\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscovery? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecServiceDiscovery?>();
            set => SetInstanceProperty(value);
        }
    }
}
