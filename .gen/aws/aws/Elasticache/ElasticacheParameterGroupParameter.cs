using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticache
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticache.ElasticacheParameterGroupParameter")]
    public class ElasticacheParameterGroupParameter : aws.Elasticache.IElasticacheParameterGroupParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_parameter_group#name ElasticacheParameterGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/elasticache_parameter_group#value ElasticacheParameterGroup#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
