using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.rds.DbOptionGroupOption")]
    public class DbOptionGroupOption : aws.Rds.IDbOptionGroupOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#option_name DbOptionGroup#option_name}.</summary>
        [JsiiProperty(name: "optionName", typeJson: "{\"primitive\":\"string\"}")]
        public string OptionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#db_security_group_memberships DbOptionGroup#db_security_group_memberships}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DbSecurityGroupMemberships
        {
            get;
            set;
        }

        /// <summary>option_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#option_settings DbOptionGroup#option_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "optionSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rds.DbOptionGroupOptionOptionSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OptionSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#port DbOptionGroup#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#version DbOptionGroup#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#vpc_security_group_memberships DbOptionGroup#vpc_security_group_memberships}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VpcSecurityGroupMemberships
        {
            get;
            set;
        }
    }
}
