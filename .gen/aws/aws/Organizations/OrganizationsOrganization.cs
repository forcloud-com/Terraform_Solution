using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Organizations
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/organizations_organization aws_organizations_organization}.</summary>
    [JsiiClass(nativeType: typeof(aws.Organizations.OrganizationsOrganization), fullyQualifiedName: "aws.organizations.OrganizationsOrganization", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.organizations.OrganizationsOrganizationConfig\"}}]")]
    public class OrganizationsOrganization : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/organizations_organization aws_organizations_organization} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OrganizationsOrganization(Constructs.Construct scope, string id, aws.Organizations.IOrganizationsOrganizationConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OrganizationsOrganization(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OrganizationsOrganization(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAwsServiceAccessPrincipals")]
        public virtual void ResetAwsServiceAccessPrincipals()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabledPolicyTypes")]
        public virtual void ResetEnabledPolicyTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeatureSet")]
        public virtual void ResetFeatureSet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(aws.Organizations.OrganizationsOrganization))!;

        [JsiiProperty(name: "accounts", typeJson: "{\"fqn\":\"aws.organizations.OrganizationsOrganizationAccountsList\"}")]
        public virtual aws.Organizations.OrganizationsOrganizationAccountsList Accounts
        {
            get => GetInstanceProperty<aws.Organizations.OrganizationsOrganizationAccountsList>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
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

        [JsiiProperty(name: "nonMasterAccounts", typeJson: "{\"fqn\":\"aws.organizations.OrganizationsOrganizationNonMasterAccountsList\"}")]
        public virtual aws.Organizations.OrganizationsOrganizationNonMasterAccountsList NonMasterAccounts
        {
            get => GetInstanceProperty<aws.Organizations.OrganizationsOrganizationNonMasterAccountsList>()!;
        }

        [JsiiProperty(name: "roots", typeJson: "{\"fqn\":\"aws.organizations.OrganizationsOrganizationRootsList\"}")]
        public virtual aws.Organizations.OrganizationsOrganizationRootsList Roots
        {
            get => GetInstanceProperty<aws.Organizations.OrganizationsOrganizationRootsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsServiceAccessPrincipalsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AwsServiceAccessPrincipalsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledPolicyTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EnabledPolicyTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featureSetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FeatureSetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "awsServiceAccessPrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AwsServiceAccessPrincipals
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabledPolicyTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledPolicyTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "featureSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FeatureSet
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
