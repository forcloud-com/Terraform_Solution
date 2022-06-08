using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    /// <summary>AWS SageMaker.</summary>
    [JsiiInterface(nativeType: typeof(ISagemakerModelConfig), fullyQualifiedName: "aws.sagemaker.SagemakerModelConfig")]
    public interface ISagemakerModelConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#execution_role_arn SagemakerModel#execution_role_arn}.</summary>
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionRoleArn
        {
            get;
        }

        /// <summary>container block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#container SagemakerModel#container}
        /// </remarks>
        [JsiiProperty(name: "container", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerModelContainer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Container
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#enable_network_isolation SagemakerModel#enable_network_isolation}.</summary>
        [JsiiProperty(name: "enableNetworkIsolation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableNetworkIsolation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#name SagemakerModel#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>primary_container block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#primary_container SagemakerModel#primary_container}
        /// </remarks>
        [JsiiProperty(name: "primaryContainer", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerModelPrimaryContainer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerModelPrimaryContainer? PrimaryContainer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#tags SagemakerModel#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#vpc_config SagemakerModel#vpc_config}
        /// </remarks>
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerModelVpcConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerModelVpcConfig? VpcConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS SageMaker.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISagemakerModelConfig), fullyQualifiedName: "aws.sagemaker.SagemakerModelConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerModelConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#execution_role_arn SagemakerModel#execution_role_arn}.</summary>
            [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>container block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#container SagemakerModel#container}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "container", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerModelContainer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Container
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#enable_network_isolation SagemakerModel#enable_network_isolation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableNetworkIsolation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableNetworkIsolation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#name SagemakerModel#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>primary_container block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#primary_container SagemakerModel#primary_container}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "primaryContainer", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerModelPrimaryContainer\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerModelPrimaryContainer? PrimaryContainer
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerModelPrimaryContainer?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#tags SagemakerModel#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>vpc_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_model#vpc_config SagemakerModel#vpc_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerModelVpcConfig\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerModelVpcConfig? VpcConfig
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerModelVpcConfig?>();
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
