using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    /// <summary>AWS Simple Email Service.</summary>
    [JsiiInterface(nativeType: typeof(ISesEventDestinationConfig), fullyQualifiedName: "aws.ses.SesEventDestinationConfig")]
    public interface ISesEventDestinationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#configuration_set_name SesEventDestination#configuration_set_name}.</summary>
        [JsiiProperty(name: "configurationSetName", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigurationSetName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#matching_types SesEventDestination#matching_types}.</summary>
        [JsiiProperty(name: "matchingTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] MatchingTypes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#name SesEventDestination#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>cloudwatch_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#cloudwatch_destination SesEventDestination#cloudwatch_destination}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesEventDestinationCloudwatchDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudwatchDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#enabled SesEventDestination#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#kinesis_destination SesEventDestination#kinesis_destination}
        /// </remarks>
        [JsiiProperty(name: "kinesisDestination", typeJson: "{\"fqn\":\"aws.ses.SesEventDestinationKinesisDestination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ses.ISesEventDestinationKinesisDestination? KinesisDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>sns_destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#sns_destination SesEventDestination#sns_destination}
        /// </remarks>
        [JsiiProperty(name: "snsDestination", typeJson: "{\"fqn\":\"aws.ses.SesEventDestinationSnsDestination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ses.ISesEventDestinationSnsDestination? SnsDestination
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Simple Email Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISesEventDestinationConfig), fullyQualifiedName: "aws.ses.SesEventDestinationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ses.ISesEventDestinationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#configuration_set_name SesEventDestination#configuration_set_name}.</summary>
            [JsiiProperty(name: "configurationSetName", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigurationSetName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#matching_types SesEventDestination#matching_types}.</summary>
            [JsiiProperty(name: "matchingTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] MatchingTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#name SesEventDestination#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cloudwatch_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#cloudwatch_destination SesEventDestination#cloudwatch_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesEventDestinationCloudwatchDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CloudwatchDestination
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#enabled SesEventDestination#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>kinesis_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#kinesis_destination SesEventDestination#kinesis_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisDestination", typeJson: "{\"fqn\":\"aws.ses.SesEventDestinationKinesisDestination\"}", isOptional: true)]
            public aws.Ses.ISesEventDestinationKinesisDestination? KinesisDestination
            {
                get => GetInstanceProperty<aws.Ses.ISesEventDestinationKinesisDestination?>();
            }

            /// <summary>sns_destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_event_destination#sns_destination SesEventDestination#sns_destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snsDestination", typeJson: "{\"fqn\":\"aws.ses.SesEventDestinationSnsDestination\"}", isOptional: true)]
            public aws.Ses.ISesEventDestinationSnsDestination? SnsDestination
            {
                get => GetInstanceProperty<aws.Ses.ISesEventDestinationSnsDestination?>();
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
