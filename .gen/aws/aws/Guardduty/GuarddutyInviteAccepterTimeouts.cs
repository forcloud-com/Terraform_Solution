using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    [JsiiByValue(fqn: "aws.guardduty.GuarddutyInviteAccepterTimeouts")]
    public class GuarddutyInviteAccepterTimeouts : aws.Guardduty.IGuarddutyInviteAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_invite_accepter#create GuarddutyInviteAccepter#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
