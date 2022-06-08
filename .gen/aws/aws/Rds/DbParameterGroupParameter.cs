using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.rds.DbParameterGroupParameter")]
    public class DbParameterGroupParameter : aws.Rds.IDbParameterGroupParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_parameter_group#name DbParameterGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_parameter_group#value DbParameterGroup#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_parameter_group#apply_method DbParameterGroup#apply_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applyMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplyMethod
        {
            get;
            set;
        }
    }
}
