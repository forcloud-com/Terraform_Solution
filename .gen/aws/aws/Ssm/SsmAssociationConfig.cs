using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    #pragma warning disable CS8618

    /// <summary>AWS Systems Manager.</summary>
    [JsiiByValue(fqn: "aws.ssm.SsmAssociationConfig")]
    public class SsmAssociationConfig : aws.Ssm.ISsmAssociationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#name SsmAssociation#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#association_name SsmAssociation#association_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "associationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AssociationName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#automation_target_parameter_name SsmAssociation#automation_target_parameter_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "automationTargetParameterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutomationTargetParameterName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#compliance_severity SsmAssociation#compliance_severity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "complianceSeverity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ComplianceSeverity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#document_version SsmAssociation#document_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DocumentVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#instance_id SsmAssociation#instance_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#max_concurrency SsmAssociation#max_concurrency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxConcurrency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#max_errors SsmAssociation#max_errors}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxErrors", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxErrors
        {
            get;
            set;
        }

        /// <summary>output_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#output_location SsmAssociation#output_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputLocation", typeJson: "{\"fqn\":\"aws.ssm.SsmAssociationOutputLocation\"}", isOptional: true)]
        public aws.Ssm.ISsmAssociationOutputLocation? OutputLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#parameters SsmAssociation#parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#schedule_expression SsmAssociation#schedule_expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ScheduleExpression
        {
            get;
            set;
        }

        /// <summary>targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_association#targets SsmAssociation#targets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmAssociationTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Targets
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
