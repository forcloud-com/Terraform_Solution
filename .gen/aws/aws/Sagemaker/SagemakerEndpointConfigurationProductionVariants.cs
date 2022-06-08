using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerEndpointConfigurationProductionVariants")]
    public class SagemakerEndpointConfigurationProductionVariants : aws.Sagemaker.ISagemakerEndpointConfigurationProductionVariants
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#initial_instance_count SagemakerEndpointConfiguration#initial_instance_count}.</summary>
        [JsiiProperty(name: "initialInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public double InitialInstanceCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#instance_type SagemakerEndpointConfiguration#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#model_name SagemakerEndpointConfiguration#model_name}.</summary>
        [JsiiProperty(name: "modelName", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#accelerator_type SagemakerEndpointConfiguration#accelerator_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acceleratorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AcceleratorType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#initial_variant_weight SagemakerEndpointConfiguration#initial_variant_weight}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "initialVariantWeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InitialVariantWeight
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#variant_name SagemakerEndpointConfiguration#variant_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "variantName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VariantName
        {
            get;
            set;
        }
    }
}
