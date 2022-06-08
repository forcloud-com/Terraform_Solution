using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters")]
    public interface ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#input SsmMaintenanceWindowTask#input}.</summary>
        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#name SsmMaintenanceWindowTask#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersStepFunctionsParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#input SsmMaintenanceWindowTask#input}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Input
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#name SsmMaintenanceWindowTask#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
