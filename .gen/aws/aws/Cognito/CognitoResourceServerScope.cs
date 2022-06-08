using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognito.CognitoResourceServerScope")]
    public class CognitoResourceServerScope : aws.Cognito.ICognitoResourceServerScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_resource_server#scope_description CognitoResourceServer#scope_description}.</summary>
        [JsiiProperty(name: "scopeDescription", typeJson: "{\"primitive\":\"string\"}")]
        public string ScopeDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_resource_server#scope_name CognitoResourceServer#scope_name}.</summary>
        [JsiiProperty(name: "scopeName", typeJson: "{\"primitive\":\"string\"}")]
        public string ScopeName
        {
            get;
            set;
        }
    }
}
