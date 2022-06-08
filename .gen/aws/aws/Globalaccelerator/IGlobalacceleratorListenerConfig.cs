using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Globalaccelerator
{
    /// <summary>AWS Global Accelerator.</summary>
    [JsiiInterface(nativeType: typeof(IGlobalacceleratorListenerConfig), fullyQualifiedName: "aws.globalaccelerator.GlobalacceleratorListenerConfig")]
    public interface IGlobalacceleratorListenerConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#accelerator_arn GlobalacceleratorListener#accelerator_arn}.</summary>
        [JsiiProperty(name: "acceleratorArn", typeJson: "{\"primitive\":\"string\"}")]
        string AcceleratorArn
        {
            get;
        }

        /// <summary>port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#port_range GlobalacceleratorListener#port_range}
        /// </remarks>
        [JsiiProperty(name: "portRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorListenerPortRange\"},\"kind\":\"array\"}}]}}")]
        object PortRange
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#protocol GlobalacceleratorListener#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#client_affinity GlobalacceleratorListener#client_affinity}.</summary>
        [JsiiProperty(name: "clientAffinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientAffinity
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Global Accelerator.</summary>
        [JsiiTypeProxy(nativeType: typeof(IGlobalacceleratorListenerConfig), fullyQualifiedName: "aws.globalaccelerator.GlobalacceleratorListenerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Globalaccelerator.IGlobalacceleratorListenerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#accelerator_arn GlobalacceleratorListener#accelerator_arn}.</summary>
            [JsiiProperty(name: "acceleratorArn", typeJson: "{\"primitive\":\"string\"}")]
            public string AcceleratorArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#port_range GlobalacceleratorListener#port_range}
            /// </remarks>
            [JsiiProperty(name: "portRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorListenerPortRange\"},\"kind\":\"array\"}}]}}")]
            public object PortRange
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#protocol GlobalacceleratorListener#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#client_affinity GlobalacceleratorListener#client_affinity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientAffinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientAffinity
            {
                get => GetInstanceProperty<string?>();
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
