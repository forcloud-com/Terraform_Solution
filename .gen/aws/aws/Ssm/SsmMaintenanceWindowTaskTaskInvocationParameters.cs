using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiByValue(fqn: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParameters")]
    public class SsmMaintenanceWindowTaskTaskInvocationParameters : aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParameters
    {
        /// <summary>automation_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#automation_parameters SsmMaintenanceWindowTask#automation_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "automationParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters\"}", isOptional: true)]
        public aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters? AutomationParameters
        {
            get;
            set;
        }

        /// <summary>lambda_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#lambda_parameters SsmMaintenanceWindowTask#lambda_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters\"}", isOptional: true)]
        public aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters? LambdaParameters
        {
            get;
            set;
        }

        /// <summary>run_command_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#run_command_parameters SsmMaintenanceWindowTask#run_command_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runCommandParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters\"}", isOptional: true)]
        public aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters? RunCommandParameters
        {
            get;
            set;
        }

        /// <summary>step_functions_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#step_functions_parameters SsmMaintenanceWindowTask#step_functions_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stepFunctionsParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters\"}", isOptional: true)]
        public aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters? StepFunctionsParameters
        {
            get;
            set;
        }
    }
}
