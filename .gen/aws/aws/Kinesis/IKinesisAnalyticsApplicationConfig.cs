using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    /// <summary>AWS Kinesis.</summary>
    [JsiiInterface(nativeType: typeof(IKinesisAnalyticsApplicationConfig), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationConfig")]
    public interface IKinesisAnalyticsApplicationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#name KinesisAnalyticsApplication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#cloudwatch_logging_options KinesisAnalyticsApplication#cloudwatch_logging_options}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationCloudwatchLoggingOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationCloudwatchLoggingOptions? CloudwatchLoggingOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#code KinesisAnalyticsApplication#code}.</summary>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Code
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#description KinesisAnalyticsApplication#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>inputs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#inputs KinesisAnalyticsApplication#inputs}
        /// </remarks>
        [JsiiProperty(name: "inputs", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationInputs? Inputs
        {
            get
            {
                return null;
            }
        }

        /// <summary>outputs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#outputs KinesisAnalyticsApplication#outputs}
        /// </remarks>
        [JsiiProperty(name: "outputs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Outputs
        {
            get
            {
                return null;
            }
        }

        /// <summary>reference_data_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#reference_data_sources KinesisAnalyticsApplication#reference_data_sources}
        /// </remarks>
        [JsiiProperty(name: "referenceDataSources", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSources\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSources? ReferenceDataSources
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#tags KinesisAnalyticsApplication#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Kinesis.</summary>
        [JsiiTypeProxy(nativeType: typeof(IKinesisAnalyticsApplicationConfig), fullyQualifiedName: "aws.kinesis.KinesisAnalyticsApplicationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisAnalyticsApplicationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#name KinesisAnalyticsApplication#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cloudwatch_logging_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#cloudwatch_logging_options KinesisAnalyticsApplication#cloudwatch_logging_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationCloudwatchLoggingOptions\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationCloudwatchLoggingOptions? CloudwatchLoggingOptions
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationCloudwatchLoggingOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#code KinesisAnalyticsApplication#code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Code
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#description KinesisAnalyticsApplication#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>inputs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#inputs KinesisAnalyticsApplication#inputs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputs", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputs\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationInputs? Inputs
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationInputs?>();
            }

            /// <summary>outputs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#outputs KinesisAnalyticsApplication#outputs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "outputs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Outputs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>reference_data_sources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#reference_data_sources KinesisAnalyticsApplication#reference_data_sources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "referenceDataSources", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSources\"}", isOptional: true)]
            public aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSources? ReferenceDataSources
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSources?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#tags KinesisAnalyticsApplication#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
