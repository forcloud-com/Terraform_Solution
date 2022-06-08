using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    [JsiiByValue(fqn: "aws.workspaces.WorkspacesDirectorySelfServicePermissions")]
    public class WorkspacesDirectorySelfServicePermissions : aws.Workspaces.IWorkspacesDirectorySelfServicePermissions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#change_compute_type WorkspacesDirectory#change_compute_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "changeComputeType", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ChangeComputeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#increase_volume_size WorkspacesDirectory#increase_volume_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "increaseVolumeSize", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IncreaseVolumeSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#rebuild_workspace WorkspacesDirectory#rebuild_workspace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rebuildWorkspace", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RebuildWorkspace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#restart_workspace WorkspacesDirectory#restart_workspace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "restartWorkspace", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RestartWorkspace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#switch_running_mode WorkspacesDirectory#switch_running_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "switchRunningMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SwitchRunningMode
        {
            get;
            set;
        }
    }
}
