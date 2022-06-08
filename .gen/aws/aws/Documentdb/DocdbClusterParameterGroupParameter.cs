using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Documentdb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.documentdb.DocdbClusterParameterGroupParameter")]
    public class DocdbClusterParameterGroupParameter : aws.Documentdb.IDocdbClusterParameterGroupParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_parameter_group#name DocdbClusterParameterGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_parameter_group#value DocdbClusterParameterGroup#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/docdb_cluster_parameter_group#apply_method DocdbClusterParameterGroup#apply_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applyMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplyMethod
        {
            get;
            set;
        }
    }
}
