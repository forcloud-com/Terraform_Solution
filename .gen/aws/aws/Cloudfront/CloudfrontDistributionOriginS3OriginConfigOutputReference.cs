using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontDistributionOriginS3OriginConfigOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOriginS3OriginConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontDistributionOriginS3OriginConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontDistributionOriginS3OriginConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionOriginS3OriginConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionOriginS3OriginConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "originAccessIdentityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OriginAccessIdentityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "originAccessIdentity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OriginAccessIdentity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginS3OriginConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionOriginS3OriginConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOriginS3OriginConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
