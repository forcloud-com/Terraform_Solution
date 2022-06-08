using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParameters), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParameters")]
    public interface ISsmMaintenanceWindowTaskTaskInvocationParameters
    {
        /// <summary>automation_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#automation_parameters SsmMaintenanceWindowTask#automation_parameters}
        /// </remarks>
        [JsiiProperty(name: "automationParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters? AutomationParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#lambda_parameters SsmMaintenanceWindowTask#lambda_parameters}
        /// </remarks>
        [JsiiProperty(name: "lambdaParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters? LambdaParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>run_command_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#run_command_parameters SsmMaintenanceWindowTask#run_command_parameters}
        /// </remarks>
        [JsiiProperty(name: "runCommandParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters? RunCommandParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_functions_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#step_functions_parameters SsmMaintenanceWindowTask#step_functions_parameters}
        /// </remarks>
        [JsiiProperty(name: "stepFunctionsParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters? StepFunctionsParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParameters), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>automation_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#automation_parameters SsmMaintenanceWindowTask#automation_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "automationParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters\"}", isOptional: true)]
            public aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters? AutomationParameters
            {
                get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters?>();
            }

            /// <summary>lambda_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#lambda_parameters SsmMaintenanceWindowTask#lambda_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters\"}", isOptional: true)]
            public aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters? LambdaParameters
            {
                get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters?>();
            }

            /// <summary>run_command_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#run_command_parameters SsmMaintenanceWindowTask#run_command_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runCommandParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters\"}", isOptional: true)]
            public aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters? RunCommandParameters
            {
                get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParameters?>();
            }

            /// <summary>step_functions_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#step_functions_parameters SsmMaintenanceWindowTask#step_functions_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepFunctionsParameters", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters\"}", isOptional: true)]
            public aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters? StepFunctionsParameters
            {
                get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters?>();
            }
        }
    }
}
