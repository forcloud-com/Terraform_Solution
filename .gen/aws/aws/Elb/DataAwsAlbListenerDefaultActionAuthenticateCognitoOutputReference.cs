using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiClass(nativeType: typeof(aws.Elb.DataAwsAlbListenerDefaultActionAuthenticateCognitoOutputReference), fullyQualifiedName: "aws.elb.DataAwsAlbListenerDefaultActionAuthenticateCognitoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsAlbListenerDefaultActionAuthenticateCognitoOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsAlbListenerDefaultActionAuthenticateCognitoOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAlbListenerDefaultActionAuthenticateCognitoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAlbListenerDefaultActionAuthenticateCognitoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "authenticationRequestExtraParams", returnsJson: "{\"type\":{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"fqn\":\"cdktf.IResolvable\"}]}}}", parametersJson: "[{\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual object AuthenticationRequestExtraParams(string key)
        {
            return InvokeInstanceMethod<object>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiProperty(name: "onUnauthenticatedRequest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnUnauthenticatedRequest
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scope
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sessionCookieName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SessionCookieName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sessionTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SessionTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "userPoolArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPoolArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userPoolClientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPoolClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userPoolDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPoolDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elb.DataAwsAlbListenerDefaultActionAuthenticateCognito\"}", isOptional: true)]
        public virtual aws.Elb.IDataAwsAlbListenerDefaultActionAuthenticateCognito? InternalValue
        {
            get => GetInstanceProperty<aws.Elb.IDataAwsAlbListenerDefaultActionAuthenticateCognito?>();
            set => SetInstanceProperty(value);
        }
    }
}
