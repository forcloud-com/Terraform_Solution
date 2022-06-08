using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping aws_lambda_event_source_mapping}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lambdafunction.LambdaEventSourceMapping), fullyQualifiedName: "aws.lambdafunction.LambdaEventSourceMapping", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingConfig\"}}]")]
    public class LambdaEventSourceMapping : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping aws_lambda_event_source_mapping} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LambdaEventSourceMapping(Constructs.Construct scope, string id, aws.Lambdafunction.ILambdaEventSourceMappingConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaEventSourceMapping(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaEventSourceMapping(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestinationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfig\"}}]")]
        public virtual void PutDestinationConfig(aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBatchSize")]
        public virtual void ResetBatchSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBisectBatchOnFunctionError")]
        public virtual void ResetBisectBatchOnFunctionError()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationConfig")]
        public virtual void ResetDestinationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumBatchingWindowInSeconds")]
        public virtual void ResetMaximumBatchingWindowInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumRecordAgeInSeconds")]
        public virtual void ResetMaximumRecordAgeInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumRetryAttempts")]
        public virtual void ResetMaximumRetryAttempts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParallelizationFactor")]
        public virtual void ResetParallelizationFactor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartingPosition")]
        public virtual void ResetStartingPosition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartingPositionTimestamp")]
        public virtual void ResetStartingPositionTimestamp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Lambdafunction.LambdaEventSourceMapping))!;

        [JsiiProperty(name: "destinationConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaEventSourceMappingDestinationConfigOutputReference DestinationConfig
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaEventSourceMappingDestinationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastProcessingResult", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastProcessingResult
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stateTransitionReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateTransitionReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "batchSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BatchSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bisectBatchOnFunctionErrorInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BisectBatchOnFunctionErrorInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationConfigInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfig\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfig? DestinationConfigInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventSourceArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventSourceArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumBatchingWindowInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumBatchingWindowInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumRecordAgeInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumRecordAgeInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumRetryAttemptsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumRetryAttemptsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parallelizationFactorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ParallelizationFactorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startingPositionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartingPositionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startingPositionTimestampInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartingPositionTimestampInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BatchSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bisectBatchOnFunctionError", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object BisectBatchOnFunctionError
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventSourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventSourceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumBatchingWindowInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumBatchingWindowInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumRecordAgeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumRecordAgeInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumRetryAttempts
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parallelizationFactor", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ParallelizationFactor
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartingPosition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startingPositionTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartingPositionTimestamp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
