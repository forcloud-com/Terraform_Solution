using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Organizations
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/organizations_organization aws_organizations_organization}.</summary>
    [JsiiClass(nativeType: typeof(aws.Organizations.DataAwsOrganizationsOrganization), fullyQualifiedName: "aws.organizations.DataAwsOrganizationsOrganization", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.organizations.DataAwsOrganizationsOrganizationConfig\"}}]")]
    public class DataAwsOrganizationsOrganization : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/organizations_organization aws_organizations_organization} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsOrganizationsOrganization(Constructs.Construct scope, string id, aws.Organizations.IDataAwsOrganizationsOrganizationConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOrganizationsOrganization(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOrganizationsOrganization(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Organizations.DataAwsOrganizationsOrganization))!;

        [JsiiProperty(name: "accounts", typeJson: "{\"fqn\":\"aws.organizations.DataAwsOrganizationsOrganizationAccountsList\"}")]
        public virtual aws.Organizations.DataAwsOrganizationsOrganizationAccountsList Accounts
        {
            get => GetInstanceProperty<aws.Organizations.DataAwsOrganizationsOrganizationAccountsList>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "awsServiceAccessPrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AwsServiceAccessPrincipals
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "enabledPolicyTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledPolicyTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "featureSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FeatureSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterAccountArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterAccountArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterAccountEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterAccountEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nonMasterAccounts", typeJson: "{\"fqn\":\"aws.organizations.DataAwsOrganizationsOrganizationNonMasterAccountsList\"}")]
        public virtual aws.Organizations.DataAwsOrganizationsOrganizationNonMasterAccountsList NonMasterAccounts
        {
            get => GetInstanceProperty<aws.Organizations.DataAwsOrganizationsOrganizationNonMasterAccountsList>()!;
        }

        [JsiiProperty(name: "roots", typeJson: "{\"fqn\":\"aws.organizations.DataAwsOrganizationsOrganizationRootsList\"}")]
        public virtual aws.Organizations.DataAwsOrganizationsOrganizationRootsList Roots
        {
            get => GetInstanceProperty<aws.Organizations.DataAwsOrganizationsOrganizationRootsList>()!;
        }
    }
}
