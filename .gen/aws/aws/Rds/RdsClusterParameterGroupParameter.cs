using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.rds.RdsClusterParameterGroupParameter")]
    public class RdsClusterParameterGroupParameter : aws.Rds.IRdsClusterParameterGroupParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_parameter_group#name RdsClusterParameterGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_parameter_group#value RdsClusterParameterGroup#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/rds_cluster_parameter_group#apply_method RdsClusterParameterGroup#apply_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applyMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplyMethod
        {
            get;
            set;
        }
    }
}
