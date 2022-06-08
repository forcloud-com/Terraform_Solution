using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerModelContainer")]
    public class SagemakerModelContainer : aws.Sagemaker.ISagemakerModelContainer
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#image SagemakerModel#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public string Image
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#container_hostname SagemakerModel#container_hostname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "containerHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerHostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#environment SagemakerModel#environment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Environment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#model_data_url SagemakerModel#model_data_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelDataUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelDataUrl
        {
            get;
            set;
        }
    }
}
