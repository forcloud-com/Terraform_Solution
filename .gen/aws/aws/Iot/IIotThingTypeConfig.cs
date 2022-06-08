using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    /// <summary>AWS IoT.</summary>
    [JsiiInterface(nativeType: typeof(IIotThingTypeConfig), fullyQualifiedName: "aws.iot.IotThingTypeConfig")]
    public interface IIotThingTypeConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_type#name IotThingType#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_type#deprecated IotThingType#deprecated}.</summary>
        [JsiiProperty(name: "deprecated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Deprecated
        {
            get
            {
                return null;
            }
        }

        /// <summary>properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_type#properties IotThingType#properties}
        /// </remarks>
        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"aws.iot.IotThingTypeProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotThingTypeProperties? Properties
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS IoT.</summary>
        [JsiiTypeProxy(nativeType: typeof(IIotThingTypeConfig), fullyQualifiedName: "aws.iot.IotThingTypeConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Iot.IIotThingTypeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_type#name IotThingType#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_type#deprecated IotThingType#deprecated}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deprecated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Deprecated
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_type#properties IotThingType#properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"aws.iot.IotThingTypeProperties\"}", isOptional: true)]
            public aws.Iot.IIotThingTypeProperties? Properties
            {
                get => GetInstanceProperty<aws.Iot.IIotThingTypeProperties?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
