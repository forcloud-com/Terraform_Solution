using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontDistributionRestrictionsOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionRestrictionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontDistributionRestrictionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontDistributionRestrictionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionRestrictionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionRestrictionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGeoRestriction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionRestrictionsGeoRestriction\"}}]")]
        public virtual void PutGeoRestriction(aws.Cloudfront.ICloudfrontDistributionRestrictionsGeoRestriction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontDistributionRestrictionsGeoRestriction)}, new object[]{@value});
        }

        [JsiiProperty(name: "geoRestriction", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionRestrictionsGeoRestrictionOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontDistributionRestrictionsGeoRestrictionOutputReference GeoRestriction
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontDistributionRestrictionsGeoRestrictionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoRestrictionInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionRestrictionsGeoRestriction\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionRestrictionsGeoRestriction? GeoRestrictionInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionRestrictionsGeoRestriction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionRestrictions\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionRestrictions? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionRestrictions?>();
            set => SetInstanceProperty(value);
        }
    }
}
