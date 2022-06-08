using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticbeanstalk
{
    [JsiiInterface(nativeType: typeof(IElasticBeanstalkEnvironmentSetting), fullyQualifiedName: "aws.elasticbeanstalk.ElasticBeanstalkEnvironmentSetting")]
    public interface IElasticBeanstalkEnvironmentSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_environment#name ElasticBeanstalkEnvironment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_environment#namespace ElasticBeanstalkEnvironment#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_environment#value ElasticBeanstalkEnvironment#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_environment#resource ElasticBeanstalkEnvironment#resource}.</summary>
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Resource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticBeanstalkEnvironmentSetting), fullyQualifiedName: "aws.elasticbeanstalk.ElasticBeanstalkEnvironmentSetting")]
        internal sealed class _Proxy : DeputyBase, aws.Elasticbeanstalk.IElasticBeanstalkEnvironmentSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_environment#name ElasticBeanstalkEnvironment#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_environment#namespace ElasticBeanstalkEnvironment#namespace}.</summary>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_environment#value ElasticBeanstalkEnvironment#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_environment#resource ElasticBeanstalkEnvironment#resource}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Resource
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
