using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    /// <summary>AWS IoT.</summary>
    [JsiiInterface(nativeType: typeof(IIotThingPrincipalAttachmentConfig), fullyQualifiedName: "aws.iot.IotThingPrincipalAttachmentConfig")]
    public interface IIotThingPrincipalAttachmentConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_principal_attachment#principal IotThingPrincipalAttachment#principal}.</summary>
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        string Principal
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_principal_attachment#thing IotThingPrincipalAttachment#thing}.</summary>
        [JsiiProperty(name: "thing", typeJson: "{\"primitive\":\"string\"}")]
        string Thing
        {
            get;
        }

        /// <summary>AWS IoT.</summary>
        [JsiiTypeProxy(nativeType: typeof(IIotThingPrincipalAttachmentConfig), fullyQualifiedName: "aws.iot.IotThingPrincipalAttachmentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Iot.IIotThingPrincipalAttachmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_principal_attachment#principal IotThingPrincipalAttachment#principal}.</summary>
            [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
            public string Principal
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_thing_principal_attachment#thing IotThingPrincipalAttachment#thing}.</summary>
            [JsiiProperty(name: "thing", typeJson: "{\"primitive\":\"string\"}")]
            public string Thing
            {
                get => GetInstanceProperty<string>()!;
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
