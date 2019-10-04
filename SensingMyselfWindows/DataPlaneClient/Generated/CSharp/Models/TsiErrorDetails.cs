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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Additional error information.
    /// </summary>
    public partial class TsiErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the TsiErrorDetails class.
        /// </summary>
        public TsiErrorDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TsiErrorDetails class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="code">Language-independent, human-readable string that
        /// defines a service-specific error code. This code serves as a more
        /// specific indicator for the HTTP error code specified in the
        /// response. Can be used to programatically handle specific error
        /// cases.</param>
        /// <param name="message">Human-readable, language-independent
        /// representation of the error. It is intended as an aid to developers
        /// and is not suitable for exposure to end users.</param>
        public TsiErrorDetails(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string code = default(string), string message = default(string))
        {
            AdditionalProperties = additionalProperties;
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets language-independent, human-readable string that defines a
        /// service-specific error code. This code serves as a more specific
        /// indicator for the HTTP error code specified in the response. Can be
        /// used to programatically handle specific error cases.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets human-readable, language-independent representation of the
        /// error. It is intended as an aid to developers and is not suitable
        /// for exposure to end users.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

    }
}
