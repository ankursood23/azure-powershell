// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support
{

    /// <summary>Argument completer implementation for SubscriptionReregistrationResult.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.ProviderHub.Support.SubscriptionReregistrationResultTypeConverter))]
    public partial struct SubscriptionReregistrationResult :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "NotApplicable".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'NotApplicable'", "NotApplicable", global::System.Management.Automation.CompletionResultType.ParameterValue, "NotApplicable");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ConditionalUpdate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ConditionalUpdate'", "ConditionalUpdate", global::System.Management.Automation.CompletionResultType.ParameterValue, "ConditionalUpdate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ForcedUpdate".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ForcedUpdate'", "ForcedUpdate", global::System.Management.Automation.CompletionResultType.ParameterValue, "ForcedUpdate");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Failed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Failed'", "Failed", global::System.Management.Automation.CompletionResultType.ParameterValue, "Failed");
            }
        }
    }
}