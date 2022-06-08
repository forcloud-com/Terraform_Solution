using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.efs.EfsFileSystemLifecyclePolicy")]
    public class EfsFileSystemLifecyclePolicy : aws.Efs.IEfsFileSystemLifecyclePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_file_system#transition_to_ia EfsFileSystem#transition_to_ia}.</summary>
        [JsiiProperty(name: "transitionToIa", typeJson: "{\"primitive\":\"string\"}")]
        public string TransitionToIa
        {
            get;
            set;
        }
    }
}
