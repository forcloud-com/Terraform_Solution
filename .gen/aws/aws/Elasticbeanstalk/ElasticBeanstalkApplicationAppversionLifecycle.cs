using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticbeanstalk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticbeanstalk.ElasticBeanstalkApplicationAppversionLifecycle")]
    public class ElasticBeanstalkApplicationAppversionLifecycle : aws.Elasticbeanstalk.IElasticBeanstalkApplicationAppversionLifecycle
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_application#service_role ElasticBeanstalkApplication#service_role}.</summary>
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_application#delete_source_from_s3 ElasticBeanstalkApplication#delete_source_from_s3}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteSourceFromS3", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DeleteSourceFromS3
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_application#max_age_in_days ElasticBeanstalkApplication#max_age_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAgeInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAgeInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elastic_beanstalk_application#max_count ElasticBeanstalkApplication#max_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxCount
        {
            get;
            set;
        }
    }
}
