using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    #pragma warning disable CS8618

    /// <summary>AWS OpsWorks.</summary>
    [JsiiByValue(fqn: "aws.opsworks.OpsworksRdsDbInstanceConfig")]
    public class OpsworksRdsDbInstanceConfig : aws.Opsworks.IOpsworksRdsDbInstanceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_rds_db_instance#db_password OpsworksRdsDbInstance#db_password}.</summary>
        [JsiiProperty(name: "dbPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string DbPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_rds_db_instance#db_user OpsworksRdsDbInstance#db_user}.</summary>
        [JsiiProperty(name: "dbUser", typeJson: "{\"primitive\":\"string\"}")]
        public string DbUser
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_rds_db_instance#rds_db_instance_arn OpsworksRdsDbInstance#rds_db_instance_arn}.</summary>
        [JsiiProperty(name: "rdsDbInstanceArn", typeJson: "{\"primitive\":\"string\"}")]
        public string RdsDbInstanceArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_rds_db_instance#stack_id OpsworksRdsDbInstance#stack_id}.</summary>
        [JsiiProperty(name: "stackId", typeJson: "{\"primitive\":\"string\"}")]
        public string StackId
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
