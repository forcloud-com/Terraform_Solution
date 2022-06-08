using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiInterface(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters")]
    public interface ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#document_version SsmMaintenanceWindowTask#document_version}.</summary>
        [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DocumentVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#parameter SsmMaintenanceWindowTask#parameter}
        /// </remarks>
        [JsiiProperty(name: "parameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Parameter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#document_version SsmMaintenanceWindowTask#document_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DocumentVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>parameter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#parameter SsmMaintenanceWindowTask#parameter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Parameter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
