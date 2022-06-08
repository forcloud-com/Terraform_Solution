using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/lambda_function_event_invoke_config aws_lambda_function_event_invoke_config}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lambdafunction.LambdaFunctionEventInvokeConfig), fullyQualifiedName: "aws.lambdafunction.LambdaFunctionEventInvokeConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigConfig\"}}]")]
    public class LambdaFunctionEventInvokeConfig : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/lambda_function_event_invoke_config aws_lambda_function_event_invoke_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LambdaFunctionEventInvokeConfig(Constructs.Construct scope, string id, aws.Lambdafunction.ILambdaFunctionEventInvokeConfigConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunctionEventInvokeConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaFunctionEventInvokeConfig(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestinationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfig\"}}]")]
        public virtual void PutDestinationConfig(aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDestinationConfig")]
        public virtual void ResetDestinationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumEventAgeInSeconds")]
        public virtual void ResetMaximumEventAgeInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumRetryAttempts")]
        public virtual void ResetMaximumRetryAttempts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQualifier")]
        public virtual void ResetQualifier()
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
        = GetStaticProperty<string>(typeof(aws.Lambdafunction.LambdaFunctionEventInvokeConfig))!;

        [JsiiProperty(name: "destinationConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOutputReference DestinationConfig
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationConfigInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfig\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfig? DestinationConfigInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumEventAgeInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumEventAgeInSecondsInput
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
        [JsiiProperty(name: "qualifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QualifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumEventAgeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumEventAgeInSeconds
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

        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Qualifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
