using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerModelContainer), fullyQualifiedName: "aws.sagemaker.SagemakerModelContainer")]
    public interface ISagemakerModelContainer
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#image SagemakerModel#image}.</summary>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        string Image
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#container_hostname SagemakerModel#container_hostname}.</summary>
        [JsiiProperty(name: "containerHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContainerHostname
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#environment SagemakerModel#environment}.</summary>
        [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Environment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#model_data_url SagemakerModel#model_data_url}.</summary>
        [JsiiProperty(name: "modelDataUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModelDataUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelContainer), fullyQualifiedName: "aws.sagemaker.SagemakerModelContainer")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerModelContainer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#image SagemakerModel#image}.</summary>
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
            public string Image
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#container_hostname SagemakerModel#container_hostname}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "containerHostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContainerHostname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#environment SagemakerModel#environment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "environment", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Environment
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#model_data_url SagemakerModel#model_data_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modelDataUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModelDataUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
