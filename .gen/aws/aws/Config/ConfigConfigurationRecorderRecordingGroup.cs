using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    [JsiiByValue(fqn: "aws.config.ConfigConfigurationRecorderRecordingGroup")]
    public class ConfigConfigurationRecorderRecordingGroup : aws.Config.IConfigConfigurationRecorderRecordingGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#all_supported ConfigConfigurationRecorder#all_supported}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allSupported", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllSupported
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#include_global_resource_types ConfigConfigurationRecorder#include_global_resource_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeGlobalResourceTypes", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncludeGlobalResourceTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#resource_types ConfigConfigurationRecorder#resource_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResourceTypes
        {
            get;
            set;
        }
    }
}
