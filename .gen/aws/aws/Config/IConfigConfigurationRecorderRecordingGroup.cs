using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    [JsiiInterface(nativeType: typeof(IConfigConfigurationRecorderRecordingGroup), fullyQualifiedName: "aws.config.ConfigConfigurationRecorderRecordingGroup")]
    public interface IConfigConfigurationRecorderRecordingGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#all_supported ConfigConfigurationRecorder#all_supported}.</summary>
        [JsiiProperty(name: "allSupported", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllSupported
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#include_global_resource_types ConfigConfigurationRecorder#include_global_resource_types}.</summary>
        [JsiiProperty(name: "includeGlobalResourceTypes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeGlobalResourceTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#resource_types ConfigConfigurationRecorder#resource_types}.</summary>
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ResourceTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConfigurationRecorderRecordingGroup), fullyQualifiedName: "aws.config.ConfigConfigurationRecorderRecordingGroup")]
        internal sealed class _Proxy : DeputyBase, aws.Config.IConfigConfigurationRecorderRecordingGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#all_supported ConfigConfigurationRecorder#all_supported}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allSupported", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllSupported
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#include_global_resource_types ConfigConfigurationRecorder#include_global_resource_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeGlobalResourceTypes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeGlobalResourceTypes
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#resource_types ConfigConfigurationRecorder#resource_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ResourceTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
