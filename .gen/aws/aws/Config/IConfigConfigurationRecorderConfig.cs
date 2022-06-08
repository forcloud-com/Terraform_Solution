using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    /// <summary>AWS Config.</summary>
    [JsiiInterface(nativeType: typeof(IConfigConfigurationRecorderConfig), fullyQualifiedName: "aws.config.ConfigConfigurationRecorderConfig")]
    public interface IConfigConfigurationRecorderConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#role_arn ConfigConfigurationRecorder#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        string RoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#name ConfigConfigurationRecorder#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>recording_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#recording_group ConfigConfigurationRecorder#recording_group}
        /// </remarks>
        [JsiiProperty(name: "recordingGroup", typeJson: "{\"fqn\":\"aws.config.ConfigConfigurationRecorderRecordingGroup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Config.IConfigConfigurationRecorderRecordingGroup? RecordingGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Config.</summary>
        [JsiiTypeProxy(nativeType: typeof(IConfigConfigurationRecorderConfig), fullyQualifiedName: "aws.config.ConfigConfigurationRecorderConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Config.IConfigConfigurationRecorderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#role_arn ConfigConfigurationRecorder#role_arn}.</summary>
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#name ConfigConfigurationRecorder#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>recording_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_configuration_recorder#recording_group ConfigConfigurationRecorder#recording_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recordingGroup", typeJson: "{\"fqn\":\"aws.config.ConfigConfigurationRecorderRecordingGroup\"}", isOptional: true)]
            public aws.Config.IConfigConfigurationRecorderRecordingGroup? RecordingGroup
            {
                get => GetInstanceProperty<aws.Config.IConfigConfigurationRecorderRecordingGroup?>();
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
