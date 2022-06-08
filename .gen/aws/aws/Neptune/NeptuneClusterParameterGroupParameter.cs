using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Neptune
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.neptune.NeptuneClusterParameterGroupParameter")]
    public class NeptuneClusterParameterGroupParameter : aws.Neptune.INeptuneClusterParameterGroupParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_parameter_group#name NeptuneClusterParameterGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_parameter_group#value NeptuneClusterParameterGroup#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/neptune_cluster_parameter_group#apply_method NeptuneClusterParameterGroup#apply_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applyMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplyMethod
        {
            get;
            set;
        }
    }
}
