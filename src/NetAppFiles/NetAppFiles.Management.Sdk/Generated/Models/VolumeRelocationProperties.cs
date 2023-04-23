// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Volume relocation properties
    /// </summary>
    public partial class VolumeRelocationProperties
    {
        /// <summary>
        /// Initializes a new instance of the VolumeRelocationProperties class.
        /// </summary>
        public VolumeRelocationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VolumeRelocationProperties class.
        /// </summary>
        /// <param name="relocationRequested">Has relocation been requested for
        /// this volume</param>
        /// <param name="readyToBeFinalized">Has relocation finished and is
        /// ready to be cleaned up</param>
        public VolumeRelocationProperties(bool? relocationRequested = default(bool?), bool? readyToBeFinalized = default(bool?))
        {
            RelocationRequested = relocationRequested;
            ReadyToBeFinalized = readyToBeFinalized;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets has relocation been requested for this volume
        /// </summary>
        [JsonProperty(PropertyName = "relocationRequested")]
        public bool? RelocationRequested { get; set; }

        /// <summary>
        /// Gets has relocation finished and is ready to be cleaned up
        /// </summary>
        [JsonProperty(PropertyName = "readyToBeFinalized")]
        public bool? ReadyToBeFinalized { get; private set; }

    }
}
