using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontDistributionCacheBehaviorForwardedValuesOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionCacheBehaviorForwardedValuesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontDistributionCacheBehaviorForwardedValuesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontDistributionCacheBehaviorForwardedValuesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionCacheBehaviorForwardedValuesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionCacheBehaviorForwardedValuesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionCacheBehaviorForwardedValuesCookies\"}}]")]
        public virtual void PutCookies(aws.Cloudfront.ICloudfrontDistributionCacheBehaviorForwardedValuesCookies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontDistributionCacheBehaviorForwardedValuesCookies)}, new object[]{@value});
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

        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionCacheBehaviorForwardedValuesCookiesOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontDistributionCacheBehaviorForwardedValuesCookiesOutputReference Cookies
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontDistributionCacheBehaviorForwardedValuesCookiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookiesInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionCacheBehaviorForwardedValuesCookies\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionCacheBehaviorForwardedValuesCookies? CookiesInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionCacheBehaviorForwardedValuesCookies?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionCacheBehaviorForwardedValues\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionCacheBehaviorForwardedValues? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionCacheBehaviorForwardedValues?>();
            set => SetInstanceProperty(value);
        }
    }
}
