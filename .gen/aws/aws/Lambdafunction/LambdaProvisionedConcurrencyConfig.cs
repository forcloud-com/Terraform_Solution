using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/lambda_provisioned_concurrency_config aws_lambda_provisioned_concurrency_config}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lambdafunction.LambdaProvisionedConcurrencyConfig), fullyQualifiedName: "aws.lambdafunction.LambdaProvisionedConcurrencyConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaProvisionedConcurrencyConfigConfig\"}}]")]
    public class LambdaProvisionedConcurrencyConfig : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/lambda_provisioned_concurrency_config aws_lambda_provisioned_concurrency_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LambdaProvisionedConcurrencyConfig(Constructs.Construct scope, string id, aws.Lambdafunction.ILambdaProvisionedConcurrencyConfigConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaProvisionedConcurrencyConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaProvisionedConcurrencyConfig(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaProvisionedConcurrencyConfigTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Lambdafunction.ILambdaProvisionedConcurrencyConfigTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaProvisionedConcurrencyConfigTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Lambdafunction.LambdaProvisionedConcurrencyConfig))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaProvisionedConcurrencyConfigTimeoutsOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaProvisionedConcurrencyConfigTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaProvisionedConcurrencyConfigTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "provisionedConcurrentExecutionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ProvisionedConcurrentExecutionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "qualifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QualifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaProvisionedConcurrencyConfigTimeouts\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaProvisionedConcurrencyConfigTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaProvisionedConcurrencyConfigTimeouts?>();
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "provisionedConcurrentExecutions", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedConcurrentExecutions
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
