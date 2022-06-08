using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    [JsiiClass(nativeType: typeof(aws.Apigateway.ApiGatewayUsagePlanQuotaSettingsOutputReference), fullyQualifiedName: "aws.apigateway.ApiGatewayUsagePlanQuotaSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiGatewayUsagePlanQuotaSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiGatewayUsagePlanQuotaSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayUsagePlanQuotaSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiGatewayUsagePlanQuotaSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetOffset")]
        public virtual void ResetOffset()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "limitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "offsetInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OffsetInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "periodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PeriodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Limit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Offset
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Period
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apigateway.ApiGatewayUsagePlanQuotaSettings\"}", isOptional: true)]
        public virtual aws.Apigateway.IApiGatewayUsagePlanQuotaSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Apigateway.IApiGatewayUsagePlanQuotaSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
