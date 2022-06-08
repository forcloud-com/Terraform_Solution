using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    [JsiiClass(nativeType: typeof(aws.Appsync.AppsyncGraphqlApiUserPoolConfigOutputReference), fullyQualifiedName: "aws.appsync.AppsyncGraphqlApiUserPoolConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppsyncGraphqlApiUserPoolConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppsyncGraphqlApiUserPoolConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApiUserPoolConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApiUserPoolConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAppIdClientRegex")]
        public virtual void ResetAppIdClientRegex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAwsRegion")]
        public virtual void ResetAwsRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "appIdClientRegexInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppIdClientRegexInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsRegionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwsRegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserPoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "appIdClientRegex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppIdClientRegex
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "awsRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsRegion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiUserPoolConfig\"}", isOptional: true)]
        public virtual aws.Appsync.IAppsyncGraphqlApiUserPoolConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Appsync.IAppsyncGraphqlApiUserPoolConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
