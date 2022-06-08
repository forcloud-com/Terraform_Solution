using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    [JsiiClass(nativeType: typeof(aws.Appsync.AppsyncGraphqlApiLogConfigOutputReference), fullyQualifiedName: "aws.appsync.AppsyncGraphqlApiLogConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppsyncGraphqlApiLogConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppsyncGraphqlApiLogConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApiLogConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApiLogConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetExcludeVerboseContent")]
        public virtual void ResetExcludeVerboseContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudwatchLogsRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeVerboseContentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ExcludeVerboseContentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldLogLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FieldLogLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cloudwatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudwatchLogsRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "excludeVerboseContent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ExcludeVerboseContent
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fieldLogLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FieldLogLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiLogConfig\"}", isOptional: true)]
        public virtual aws.Appsync.IAppsyncGraphqlApiLogConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Appsync.IAppsyncGraphqlApiLogConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
