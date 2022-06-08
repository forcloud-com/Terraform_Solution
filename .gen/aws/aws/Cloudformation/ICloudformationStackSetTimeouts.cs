using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudformation
{
    [JsiiInterface(nativeType: typeof(ICloudformationStackSetTimeouts), fullyQualifiedName: "aws.cloudformation.CloudformationStackSetTimeouts")]
    public interface ICloudformationStackSetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack_set#update CloudformationStackSet#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudformationStackSetTimeouts), fullyQualifiedName: "aws.cloudformation.CloudformationStackSetTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudformation.ICloudformationStackSetTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack_set#update CloudformationStackSet#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
