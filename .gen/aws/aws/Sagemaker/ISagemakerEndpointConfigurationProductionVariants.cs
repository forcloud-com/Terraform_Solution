using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointConfigurationProductionVariants), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationProductionVariants")]
    public interface ISagemakerEndpointConfigurationProductionVariants
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#initial_instance_count SagemakerEndpointConfiguration#initial_instance_count}.</summary>
        [JsiiProperty(name: "initialInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double InitialInstanceCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#instance_type SagemakerEndpointConfiguration#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#model_name SagemakerEndpointConfiguration#model_name}.</summary>
        [JsiiProperty(name: "modelName", typeJson: "{\"primitive\":\"string\"}")]
        string ModelName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#accelerator_type SagemakerEndpointConfiguration#accelerator_type}.</summary>
        [JsiiProperty(name: "acceleratorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AcceleratorType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#initial_variant_weight SagemakerEndpointConfiguration#initial_variant_weight}.</summary>
        [JsiiProperty(name: "initialVariantWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InitialVariantWeight
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#variant_name SagemakerEndpointConfiguration#variant_name}.</summary>
        [JsiiProperty(name: "variantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VariantName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointConfigurationProductionVariants), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationProductionVariants")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerEndpointConfigurationProductionVariants
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#initial_instance_count SagemakerEndpointConfiguration#initial_instance_count}.</summary>
            [JsiiProperty(name: "initialInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double InitialInstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#instance_type SagemakerEndpointConfiguration#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#model_name SagemakerEndpointConfiguration#model_name}.</summary>
            [JsiiProperty(name: "modelName", typeJson: "{\"primitive\":\"string\"}")]
            public string ModelName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#accelerator_type SagemakerEndpointConfiguration#accelerator_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acceleratorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AcceleratorType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#initial_variant_weight SagemakerEndpointConfiguration#initial_variant_weight}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "initialVariantWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InitialVariantWeight
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#variant_name SagemakerEndpointConfiguration#variant_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "variantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VariantName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
