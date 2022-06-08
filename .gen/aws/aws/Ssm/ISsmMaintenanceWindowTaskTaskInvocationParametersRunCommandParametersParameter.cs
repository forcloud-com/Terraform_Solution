using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter")]
    public interface ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#name SsmMaintenanceWindowTask#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#values SsmMaintenanceWindowTask#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter")]
        internal sealed class _Proxy : DeputyBase, aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersRunCommandParametersParameter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#name SsmMaintenanceWindowTask#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#values SsmMaintenanceWindowTask#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
