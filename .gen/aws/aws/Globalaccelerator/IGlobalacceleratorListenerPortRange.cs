using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Globalaccelerator
{
    [JsiiInterface(nativeType: typeof(IGlobalacceleratorListenerPortRange), fullyQualifiedName: "aws.globalaccelerator.GlobalacceleratorListenerPortRange")]
    public interface IGlobalacceleratorListenerPortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#from_port GlobalacceleratorListener#from_port}.</summary>
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FromPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#to_port GlobalacceleratorListener#to_port}.</summary>
        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ToPort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlobalacceleratorListenerPortRange), fullyQualifiedName: "aws.globalaccelerator.GlobalacceleratorListenerPortRange")]
        internal sealed class _Proxy : DeputyBase, aws.Globalaccelerator.IGlobalacceleratorListenerPortRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#from_port GlobalacceleratorListener#from_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FromPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener#to_port GlobalacceleratorListener#to_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ToPort
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
