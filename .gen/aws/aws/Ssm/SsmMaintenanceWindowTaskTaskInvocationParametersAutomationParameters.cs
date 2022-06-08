using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiByValue(fqn: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters : aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#document_version SsmMaintenanceWindowTask#document_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DocumentVersion
        {
            get;
            set;
        }

        /// <summary>parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#parameter SsmMaintenanceWindowTask#parameter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Parameter
        {
            get;
            set;
        }
    }
}
