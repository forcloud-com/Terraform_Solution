using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiByValue(fqn: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters : aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#input SsmMaintenanceWindowTask#input}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Input
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#name SsmMaintenanceWindowTask#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
