// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request to update model settings. One of "name" or "defaultTypeId" must
    /// be set.
    /// </summary>
    public partial class UpdateModelSettingsRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateModelSettingsRequest class.
        /// </summary>
        public UpdateModelSettingsRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateModelSettingsRequest class.
        /// </summary>
        /// <param name="name">Model display name which is shown in the UX and
        /// mutable by the user. Initial value is "DefaultModel".</param>
        /// <param name="defaultTypeId">Default type id of the model that new
        /// instances will automatically belong to.</param>
        public UpdateModelSettingsRequest(string name = default(string), System.Guid? defaultTypeId = default(System.Guid?))
        {
            Name = name;
            DefaultTypeId = defaultTypeId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets model display name which is shown in the UX and
        /// mutable by the user. Initial value is "DefaultModel".
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets default type id of the model that new instances will
        /// automatically belong to.
        /// </summary>
        [JsonProperty(PropertyName = "defaultTypeId")]
        public System.Guid? DefaultTypeId { get; set; }

    }
}
