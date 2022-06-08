using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    #pragma warning disable CS8618

    /// <summary>AWS Simple Email Service.</summary>
    [JsiiByValue(fqn: "aws.ses.SesEventDestinationConfig")]
    public class SesEventDestinationConfig : aws.Ses.ISesEventDestinationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#configuration_set_name SesEventDestination#configuration_set_name}.</summary>
        [JsiiProperty(name: "configurationSetName", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigurationSetName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#matching_types SesEventDestination#matching_types}.</summary>
        [JsiiProperty(name: "matchingTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] MatchingTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#name SesEventDestination#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>cloudwatch_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#cloudwatch_destination SesEventDestination#cloudwatch_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesEventDestinationCloudwatchDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CloudwatchDestination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#enabled SesEventDestination#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get;
            set;
        }

        /// <summary>kinesis_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#kinesis_destination SesEventDestination#kinesis_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kinesisDestination", typeJson: "{\"fqn\":\"aws.ses.SesEventDestinationKinesisDestination\"}", isOptional: true)]
        public aws.Ses.ISesEventDestinationKinesisDestination? KinesisDestination
        {
            get;
            set;
        }

        /// <summary>sns_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#sns_destination SesEventDestination#sns_destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snsDestination", typeJson: "{\"fqn\":\"aws.ses.SesEventDestinationSnsDestination\"}", isOptional: true)]
        public aws.Ses.ISesEventDestinationSnsDestination? SnsDestination
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
