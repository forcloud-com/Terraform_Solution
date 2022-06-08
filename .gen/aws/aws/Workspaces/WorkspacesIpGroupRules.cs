using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.workspaces.WorkspacesIpGroupRules")]
    public class WorkspacesIpGroupRules : aws.Workspaces.IWorkspacesIpGroupRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_ip_group#source WorkspacesIpGroup#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_ip_group#description WorkspacesIpGroup#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
