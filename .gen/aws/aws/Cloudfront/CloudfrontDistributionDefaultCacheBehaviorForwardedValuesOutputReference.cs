using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValuesOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValuesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontDistributionDefaultCacheBehaviorForwardedValuesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontDistributionDefaultCacheBehaviorForwardedValuesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionDefaultCacheBehaviorForwardedValuesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionDefaultCacheBehaviorForwardedValuesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies\"}}]")]
        public virtual void PutCookies(aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHeaders")]
        public virtual void ResetHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryStringCacheKeys")]
        public virtual void ResetQueryStringCacheKeys()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookiesOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookiesOutputReference Cookies
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookiesInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies? CookiesInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorForwardedValuesCookies?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? HeadersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringCacheKeysInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? QueryStringCacheKeysInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? QueryStringInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Headers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object QueryString
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queryStringCacheKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] QueryStringCacheKeys
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValues\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorForwardedValues? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorForwardedValues?>();
            set => SetInstanceProperty(value);
        }
    }
}
