using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiByValue(fqn: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters : aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersLambdaParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#client_context SsmMaintenanceWindowTask#client_context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientContext", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientContext
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#payload SsmMaintenanceWindowTask#payload}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Payload
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#qualifier SsmMaintenanceWindowTask#qualifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "qualifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Qualifier
        {
            get;
            set;
        }
    }
}
