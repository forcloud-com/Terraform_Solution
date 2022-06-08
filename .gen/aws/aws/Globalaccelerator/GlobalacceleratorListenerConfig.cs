using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Globalaccelerator
{
    #pragma warning disable CS8618

    /// <summary>AWS Global Accelerator.</summary>
    [JsiiByValue(fqn: "aws.globalaccelerator.GlobalacceleratorListenerConfig")]
    public class GlobalacceleratorListenerConfig : aws.Globalaccelerator.IGlobalacceleratorListenerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#accelerator_arn GlobalacceleratorListener#accelerator_arn}.</summary>
        [JsiiProperty(name: "acceleratorArn", typeJson: "{\"primitive\":\"string\"}")]
        public string AcceleratorArn
        {
            get;
            set;
        }

        /// <summary>port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#port_range GlobalacceleratorListener#port_range}
        /// </remarks>
        [JsiiProperty(name: "portRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorListenerPortRange\"},\"kind\":\"array\"}}]}}")]
        public object PortRange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#protocol GlobalacceleratorListener#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#client_affinity GlobalacceleratorListener#client_affinity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientAffinity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientAffinity
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
