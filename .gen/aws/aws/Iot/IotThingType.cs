using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_type aws_iot_thing_type}.</summary>
    [JsiiClass(nativeType: typeof(aws.Iot.IotThingType), fullyQualifiedName: "aws.iot.IotThingType", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.iot.IotThingTypeConfig\"}}]")]
    public class IotThingType : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_type aws_iot_thing_type} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IotThingType(Constructs.Construct scope, string id, aws.Iot.IIotThingTypeConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotThingType(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotThingType(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotThingTypeProperties\"}}]")]
        public virtual void PutProperties(aws.Iot.IIotThingTypeProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotThingTypeProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeprecated")]
        public virtual void ResetDeprecated()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProperties")]
        public virtual void ResetProperties()
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
        = GetStaticProperty<string>(typeof(aws.Iot.IotThingType))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"aws.iot.IotThingTypePropertiesOutputReference\"}")]
        public virtual aws.Iot.IotThingTypePropertiesOutputReference Properties
        {
            get => GetInstanceProperty<aws.Iot.IotThingTypePropertiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deprecatedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeprecatedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propertiesInput", typeJson: "{\"fqn\":\"aws.iot.IotThingTypeProperties\"}", isOptional: true)]
        public virtual aws.Iot.IIotThingTypeProperties? PropertiesInput
        {
            get => GetInstanceProperty<aws.Iot.IIotThingTypeProperties?>();
        }

        [JsiiProperty(name: "deprecated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Deprecated
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
