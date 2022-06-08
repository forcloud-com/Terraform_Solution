using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    #pragma warning disable CS8618

    /// <summary>AWS Lambda.</summary>
    [JsiiByValue(fqn: "aws.lambdafunction.LambdaEventSourceMappingConfig")]
    public class LambdaEventSourceMappingConfig : aws.Lambdafunction.ILambdaEventSourceMappingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#event_source_arn LambdaEventSourceMapping#event_source_arn}.</summary>
        [JsiiProperty(name: "eventSourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public string EventSourceArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#function_name LambdaEventSourceMapping#function_name}.</summary>
        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public string FunctionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#batch_size LambdaEventSourceMapping#batch_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BatchSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#bisect_batch_on_function_error LambdaEventSourceMapping#bisect_batch_on_function_error}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bisectBatchOnFunctionError", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? BisectBatchOnFunctionError
        {
            get;
            set;
        }

        /// <summary>destination_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#destination_config LambdaEventSourceMapping#destination_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destinationConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfig\"}", isOptional: true)]
        public aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfig? DestinationConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#enabled LambdaEventSourceMapping#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#maximum_batching_window_in_seconds LambdaEventSourceMapping#maximum_batching_window_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumBatchingWindowInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumBatchingWindowInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#maximum_record_age_in_seconds LambdaEventSourceMapping#maximum_record_age_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumRecordAgeInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumRecordAgeInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#maximum_retry_attempts LambdaEventSourceMapping#maximum_retry_attempts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumRetryAttempts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#parallelization_factor LambdaEventSourceMapping#parallelization_factor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parallelizationFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ParallelizationFactor
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#starting_position LambdaEventSourceMapping#starting_position}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartingPosition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#starting_position_timestamp LambdaEventSourceMapping#starting_position_timestamp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startingPositionTimestamp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartingPositionTimestamp
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
