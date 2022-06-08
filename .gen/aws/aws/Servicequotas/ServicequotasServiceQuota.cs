using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Servicequotas
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/servicequotas_service_quota aws_servicequotas_service_quota}.</summary>
    [JsiiClass(nativeType: typeof(aws.Servicequotas.ServicequotasServiceQuota), fullyQualifiedName: "aws.servicequotas.ServicequotasServiceQuota", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.servicequotas.ServicequotasServiceQuotaConfig\"}}]")]
    public class ServicequotasServiceQuota : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/servicequotas_service_quota aws_servicequotas_service_quota} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServicequotasServiceQuota(Constructs.Construct scope, string id, aws.Servicequotas.IServicequotasServiceQuotaConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicequotasServiceQuota(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServicequotasServiceQuota(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Servicequotas.ServicequotasServiceQuota))!;

        [JsiiProperty(name: "adjustable", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Adjustable
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "quotaName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QuotaName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "quotaCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QuotaCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ValueInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "quotaCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QuotaCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Value
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
