using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    [JsiiInterface(nativeType: typeof(IWorkspacesIpGroupRules), fullyQualifiedName: "aws.workspaces.WorkspacesIpGroupRules")]
    public interface IWorkspacesIpGroupRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_ip_group#source WorkspacesIpGroup#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_ip_group#description WorkspacesIpGroup#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspacesIpGroupRules), fullyQualifiedName: "aws.workspaces.WorkspacesIpGroupRules")]
        internal sealed class _Proxy : DeputyBase, aws.Workspaces.IWorkspacesIpGroupRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_ip_group#source WorkspacesIpGroup#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_ip_group#description WorkspacesIpGroup#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
