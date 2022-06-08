using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticbeanstalk
{
    /// <summary>AWS Elastic Beanstalk.</summary>
    [JsiiInterface(nativeType: typeof(IElasticBeanstalkConfigurationTemplateConfig), fullyQualifiedName: "aws.elasticbeanstalk.ElasticBeanstalkConfigurationTemplateConfig")]
    public interface IElasticBeanstalkConfigurationTemplateConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#application ElasticBeanstalkConfigurationTemplate#application}.</summary>
        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
        string Application
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#name ElasticBeanstalkConfigurationTemplate#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#description ElasticBeanstalkConfigurationTemplate#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#environment_id ElasticBeanstalkConfigurationTemplate#environment_id}.</summary>
        [JsiiProperty(name: "environmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EnvironmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>setting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#setting ElasticBeanstalkConfigurationTemplate#setting}
        /// </remarks>
        [JsiiProperty(name: "setting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticbeanstalk.ElasticBeanstalkConfigurationTemplateSetting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Setting
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#solution_stack_name ElasticBeanstalkConfigurationTemplate#solution_stack_name}.</summary>
        [JsiiProperty(name: "solutionStackName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SolutionStackName
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Elastic Beanstalk.</summary>
        [JsiiTypeProxy(nativeType: typeof(IElasticBeanstalkConfigurationTemplateConfig), fullyQualifiedName: "aws.elasticbeanstalk.ElasticBeanstalkConfigurationTemplateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Elasticbeanstalk.IElasticBeanstalkConfigurationTemplateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#application ElasticBeanstalkConfigurationTemplate#application}.</summary>
            [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
            public string Application
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#name ElasticBeanstalkConfigurationTemplate#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#description ElasticBeanstalkConfigurationTemplate#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#environment_id ElasticBeanstalkConfigurationTemplate#environment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "environmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EnvironmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>setting block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#setting ElasticBeanstalkConfigurationTemplate#setting}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setting", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticbeanstalk.ElasticBeanstalkConfigurationTemplateSetting\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Setting
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_configuration_template#solution_stack_name ElasticBeanstalkConfigurationTemplate#solution_stack_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "solutionStackName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SolutionStackName
            {
                get => GetInstanceProperty<string?>();
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
