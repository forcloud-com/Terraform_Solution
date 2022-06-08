using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Pinpoint
{
    [JsiiInterface(nativeType: typeof(IPinpointAppQuietTime), fullyQualifiedName: "aws.pinpoint.PinpointAppQuietTime")]
    public interface IPinpointAppQuietTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#end PinpointApp#end}.</summary>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? End
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#start PinpointApp#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Start
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPinpointAppQuietTime), fullyQualifiedName: "aws.pinpoint.PinpointAppQuietTime")]
        internal sealed class _Proxy : DeputyBase, aws.Pinpoint.IPinpointAppQuietTime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#end PinpointApp#end}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? End
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/pinpoint_app#start PinpointApp#start}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Start
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
