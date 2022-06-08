using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpoint
{
    [JsiiInterface(nativeType: typeof(IPinpointAppLimits), fullyQualifiedName: "aws.pinpoint.PinpointAppLimits")]
    public interface IPinpointAppLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#daily PinpointApp#daily}.</summary>
        [JsiiProperty(name: "daily", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Daily
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#maximum_duration PinpointApp#maximum_duration}.</summary>
        [JsiiProperty(name: "maximumDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#messages_per_second PinpointApp#messages_per_second}.</summary>
        [JsiiProperty(name: "messagesPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MessagesPerSecond
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#total PinpointApp#total}.</summary>
        [JsiiProperty(name: "total", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Total
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPinpointAppLimits), fullyQualifiedName: "aws.pinpoint.PinpointAppLimits")]
        internal sealed class _Proxy : DeputyBase, aws.Pinpoint.IPinpointAppLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#daily PinpointApp#daily}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "daily", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Daily
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#maximum_duration PinpointApp#maximum_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#messages_per_second PinpointApp#messages_per_second}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messagesPerSecond", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MessagesPerSecond
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#total PinpointApp#total}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "total", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Total
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
