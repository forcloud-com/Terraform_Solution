using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    /// <summary>AWS Lambda.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsLambdaLayerVersionConfig), fullyQualifiedName: "aws.lambdafunction.DataAwsLambdaLayerVersionConfig")]
    public interface IDataAwsLambdaLayerVersionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lambda_layer_version#layer_name DataAwsLambdaLayerVersion#layer_name}.</summary>
        [JsiiProperty(name: "layerName", typeJson: "{\"primitive\":\"string\"}")]
        string LayerName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lambda_layer_version#compatible_runtime DataAwsLambdaLayerVersion#compatible_runtime}.</summary>
        [JsiiProperty(name: "compatibleRuntime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompatibleRuntime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lambda_layer_version#version DataAwsLambdaLayerVersion#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Version
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Lambda.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsLambdaLayerVersionConfig), fullyQualifiedName: "aws.lambdafunction.DataAwsLambdaLayerVersionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.IDataAwsLambdaLayerVersionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lambda_layer_version#layer_name DataAwsLambdaLayerVersion#layer_name}.</summary>
            [JsiiProperty(name: "layerName", typeJson: "{\"primitive\":\"string\"}")]
            public string LayerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lambda_layer_version#compatible_runtime DataAwsLambdaLayerVersion#compatible_runtime}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compatibleRuntime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompatibleRuntime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/lambda_layer_version#version DataAwsLambdaLayerVersion#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Version
            {
                get => GetInstanceProperty<double?>();
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
