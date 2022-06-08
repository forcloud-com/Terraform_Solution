using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontDistributionDefaultCacheBehaviorOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontDistributionDefaultCacheBehaviorOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudfrontDistributionDefaultCacheBehaviorOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionDefaultCacheBehaviorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionDefaultCacheBehaviorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putForwardedValues", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValues\"}}]")]
        public virtual void PutForwardedValues(aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorForwardedValues @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorForwardedValues)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompress")]
        public virtual void ResetCompress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultTtl")]
        public virtual void ResetDefaultTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFieldLevelEncryptionId")]
        public virtual void ResetFieldLevelEncryptionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaFunctionAssociation")]
        public virtual void ResetLambdaFunctionAssociation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxTtl")]
        public virtual void ResetMaxTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinTtl")]
        public virtual void ResetMinTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmoothStreaming")]
        public virtual void ResetSmoothStreaming()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrustedSigners")]
        public virtual void ResetTrustedSigners()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "forwardedValues", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValuesOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValuesOutputReference ForwardedValues
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValuesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedMethodsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedMethodsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cachedMethodsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CachedMethodsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CompressInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldLevelEncryptionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FieldLevelEncryptionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardedValuesInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorForwardedValues\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorForwardedValues? ForwardedValuesInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehaviorForwardedValues?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionAssociationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LambdaFunctionAssociationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smoothStreamingInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SmoothStreamingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetOriginIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetOriginIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustedSignersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TrustedSignersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewerProtocolPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ViewerProtocolPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedMethods
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cachedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CachedMethods
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Compress
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fieldLevelEncryptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FieldLevelEncryptionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lambdaFunctionAssociation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorLambdaFunctionAssociation\"},\"kind\":\"array\"}}]}}")]
        public virtual object LambdaFunctionAssociation
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smoothStreaming", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SmoothStreaming
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetOriginId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetOriginId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trustedSigners", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TrustedSigners
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "viewerProtocolPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViewerProtocolPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehavior\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehavior? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehavior?>();
            set => SetInstanceProperty(value);
        }
    }
}
