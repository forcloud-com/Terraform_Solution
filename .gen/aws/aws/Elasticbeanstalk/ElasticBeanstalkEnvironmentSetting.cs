using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticbeanstalk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticbeanstalk.ElasticBeanstalkEnvironmentSetting")]
    public class ElasticBeanstalkEnvironmentSetting : aws.Elasticbeanstalk.IElasticBeanstalkEnvironmentSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_environment#name ElasticBeanstalkEnvironment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_environment#namespace ElasticBeanstalkEnvironment#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_environment#value ElasticBeanstalkEnvironment#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_environment#resource ElasticBeanstalkEnvironment#resource}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Resource
        {
            get;
            set;
        }
    }
}
