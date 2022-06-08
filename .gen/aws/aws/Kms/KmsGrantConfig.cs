using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kms
{
    #pragma warning disable CS8618

    /// <summary>AWS Key Management Service.</summary>
    [JsiiByValue(fqn: "aws.kms.KmsGrantConfig")]
    public class KmsGrantConfig : aws.Kms.IKmsGrantConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kms_grant#grantee_principal KmsGrant#grantee_principal}.</summary>
        [JsiiProperty(name: "granteePrincipal", typeJson: "{\"primitive\":\"string\"}")]
        public string GranteePrincipal
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kms_grant#key_id KmsGrant#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kms_grant#operations KmsGrant#operations}.</summary>
        [JsiiProperty(name: "operations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Operations
        {
            get;
            set;
        }

        /// <summary>constraints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kms_grant#constraints KmsGrant#constraints}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "constraints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.kms.KmsGrantConstraints\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Constraints
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kms_grant#grant_creation_tokens KmsGrant#grant_creation_tokens}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "grantCreationTokens", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GrantCreationTokens
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kms_grant#name KmsGrant#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kms_grant#retire_on_delete KmsGrant#retire_on_delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retireOnDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RetireOnDelete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kms_grant#retiring_principal KmsGrant#retiring_principal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retiringPrincipal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RetiringPrincipal
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
