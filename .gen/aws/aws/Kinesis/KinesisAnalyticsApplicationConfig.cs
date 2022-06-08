using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    /// <summary>AWS Kinesis.</summary>
    [JsiiByValue(fqn: "aws.kinesis.KinesisAnalyticsApplicationConfig")]
    public class KinesisAnalyticsApplicationConfig : aws.Kinesis.IKinesisAnalyticsApplicationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#name KinesisAnalyticsApplication#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>cloudwatch_logging_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#cloudwatch_logging_options KinesisAnalyticsApplication#cloudwatch_logging_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLoggingOptions", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationCloudwatchLoggingOptions\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationCloudwatchLoggingOptions? CloudwatchLoggingOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#code KinesisAnalyticsApplication#code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Code
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#description KinesisAnalyticsApplication#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>inputs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#inputs KinesisAnalyticsApplication#inputs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inputs", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationInputs\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationInputs? Inputs
        {
            get;
            set;
        }

        /// <summary>outputs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#outputs KinesisAnalyticsApplication#outputs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationOutputs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Outputs
        {
            get;
            set;
        }

        /// <summary>reference_data_sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#reference_data_sources KinesisAnalyticsApplication#reference_data_sources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "referenceDataSources", typeJson: "{\"fqn\":\"aws.kinesis.KinesisAnalyticsApplicationReferenceDataSources\"}", isOptional: true)]
        public aws.Kinesis.IKinesisAnalyticsApplicationReferenceDataSources? ReferenceDataSources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesis_analytics_application#tags KinesisAnalyticsApplication#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
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
