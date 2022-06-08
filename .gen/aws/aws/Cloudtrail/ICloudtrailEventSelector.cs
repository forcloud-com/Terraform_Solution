using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudtrail
{
    [JsiiInterface(nativeType: typeof(ICloudtrailEventSelector), fullyQualifiedName: "aws.cloudtrail.CloudtrailEventSelector")]
    public interface ICloudtrailEventSelector
    {
        /// <summary>data_resource block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#data_resource Cloudtrail#data_resource}
        /// </remarks>
        [JsiiProperty(name: "dataResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudtrail.CloudtrailEventSelectorDataResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataResource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#include_management_events Cloudtrail#include_management_events}.</summary>
        [JsiiProperty(name: "includeManagementEvents", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeManagementEvents
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#read_write_type Cloudtrail#read_write_type}.</summary>
        [JsiiProperty(name: "readWriteType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReadWriteType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudtrailEventSelector), fullyQualifiedName: "aws.cloudtrail.CloudtrailEventSelector")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudtrail.ICloudtrailEventSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>data_resource block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#data_resource Cloudtrail#data_resource}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataResource", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudtrail.CloudtrailEventSelectorDataResource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataResource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#include_management_events Cloudtrail#include_management_events}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeManagementEvents", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeManagementEvents
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#read_write_type Cloudtrail#read_write_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readWriteType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReadWriteType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
