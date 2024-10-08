// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Azure specific reprotect input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2A")]
    public partial class A2AReprotectInput : ReverseReplicationProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the A2AReprotectInput class.
        /// </summary>
        public A2AReprotectInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2AReprotectInput class.
        /// </summary>

        /// <param name="recoveryContainerId">The recovery container Id.
        /// </param>

        /// <param name="vmDisks">The list of vm disk details.
        /// </param>

        /// <param name="recoveryResourceGroupId">The recovery resource group Id. Valid for V2 scenarios.
        /// </param>

        /// <param name="recoveryCloudServiceId">The recovery cloud service Id. Valid for V1 scenarios.
        /// </param>

        /// <param name="recoveryAvailabilitySetId">The recovery availability set.
        /// </param>

        /// <param name="policyId">The Policy Id.
        /// </param>
        public A2AReprotectInput(string recoveryContainerId = default(string), System.Collections.Generic.IList<A2AVmDiskInputDetails> vmDisks = default(System.Collections.Generic.IList<A2AVmDiskInputDetails>), string recoveryResourceGroupId = default(string), string recoveryCloudServiceId = default(string), string recoveryAvailabilitySetId = default(string), string policyId = default(string))

        {
            this.RecoveryContainerId = recoveryContainerId;
            this.VMDisks = vmDisks;
            this.RecoveryResourceGroupId = recoveryResourceGroupId;
            this.RecoveryCloudServiceId = recoveryCloudServiceId;
            this.RecoveryAvailabilitySetId = recoveryAvailabilitySetId;
            this.PolicyId = policyId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the recovery container Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryContainerId")]
        public string RecoveryContainerId {get; set; }

        /// <summary>
        /// Gets or sets the list of vm disk details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmDisks")]
        public System.Collections.Generic.IList<A2AVmDiskInputDetails> VMDisks {get; set; }

        /// <summary>
        /// Gets or sets the recovery resource group Id. Valid for V2 scenarios.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryResourceGroupId")]
        public string RecoveryResourceGroupId {get; set; }

        /// <summary>
        /// Gets or sets the recovery cloud service Id. Valid for V1 scenarios.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryCloudServiceId")]
        public string RecoveryCloudServiceId {get; set; }

        /// <summary>
        /// Gets or sets the recovery availability set.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryAvailabilitySetId")]
        public string RecoveryAvailabilitySetId {get; set; }

        /// <summary>
        /// Gets or sets the Policy Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "policyId")]
        public string PolicyId {get; set; }
    }
}