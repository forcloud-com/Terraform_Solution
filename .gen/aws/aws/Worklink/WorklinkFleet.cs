using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Worklink
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet aws_worklink_fleet}.</summary>
    [JsiiClass(nativeType: typeof(aws.Worklink.WorklinkFleet), fullyQualifiedName: "aws.worklink.WorklinkFleet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.worklink.WorklinkFleetConfig\"}}]")]
    public class WorklinkFleet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/worklink_fleet aws_worklink_fleet} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WorklinkFleet(Constructs.Construct scope, string id, aws.Worklink.IWorklinkFleetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorklinkFleet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorklinkFleet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdentityProvider", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.worklink.WorklinkFleetIdentityProvider\"}}]")]
        public virtual void PutIdentityProvider(aws.Worklink.IWorklinkFleetIdentityProvider @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Worklink.IWorklinkFleetIdentityProvider)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.worklink.WorklinkFleetNetwork\"}}]")]
        public virtual void PutNetwork(aws.Worklink.IWorklinkFleetNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Worklink.IWorklinkFleetNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuditStreamArn")]
        public virtual void ResetAuditStreamArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceCaCertificate")]
        public virtual void ResetDeviceCaCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisplayName")]
        public virtual void ResetDisplayName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentityProvider")]
        public virtual void ResetIdentityProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetwork")]
        public virtual void ResetNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOptimizeForEndUserLocation")]
        public virtual void ResetOptimizeForEndUserLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(aws.Worklink.WorklinkFleet))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "companyCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompanyCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identityProvider", typeJson: "{\"fqn\":\"aws.worklink.WorklinkFleetIdentityProviderOutputReference\"}")]
        public virtual aws.Worklink.WorklinkFleetIdentityProviderOutputReference IdentityProvider
        {
            get => GetInstanceProperty<aws.Worklink.WorklinkFleetIdentityProviderOutputReference>()!;
        }

        [JsiiProperty(name: "lastUpdatedTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUpdatedTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"aws.worklink.WorklinkFleetNetworkOutputReference\"}")]
        public virtual aws.Worklink.WorklinkFleetNetworkOutputReference Network
        {
            get => GetInstanceProperty<aws.Worklink.WorklinkFleetNetworkOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditStreamArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuditStreamArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceCaCertificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceCaCertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityProviderInput", typeJson: "{\"fqn\":\"aws.worklink.WorklinkFleetIdentityProvider\"}", isOptional: true)]
        public virtual aws.Worklink.IWorklinkFleetIdentityProvider? IdentityProviderInput
        {
            get => GetInstanceProperty<aws.Worklink.IWorklinkFleetIdentityProvider?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"fqn\":\"aws.worklink.WorklinkFleetNetwork\"}", isOptional: true)]
        public virtual aws.Worklink.IWorklinkFleetNetwork? NetworkInput
        {
            get => GetInstanceProperty<aws.Worklink.IWorklinkFleetNetwork?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "optimizeForEndUserLocationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OptimizeForEndUserLocationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "auditStreamArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditStreamArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deviceCaCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceCaCertificate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "optimizeForEndUserLocation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object OptimizeForEndUserLocation
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
