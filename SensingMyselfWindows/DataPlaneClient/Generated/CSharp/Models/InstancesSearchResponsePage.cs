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
    /// Single page of time series instance search results.
    /// </summary>
    public partial class InstancesSearchResponsePage
    {
        /// <summary>
        /// Initializes a new instance of the InstancesSearchResponsePage
        /// class.
        /// </summary>
        public InstancesSearchResponsePage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InstancesSearchResponsePage
        /// class.
        /// </summary>
        /// <param name="instances">List of top instances matching the query by
        /// relevance. May be empty or null.</param>
        /// <param name="instancesContinuationToken">If returned, this means
        /// that current results represent a partial result. Continuation token
        /// allows to get the next page of results. To get the next page of
        /// query results, send the same request with continuation token
        /// parameter in "x-ms-continuation" HTTP header.</param>
        public InstancesSearchResponsePage(IList<InstanceHit> instances = default(IList<InstanceHit>), string instancesContinuationToken = default(string))
        {
            Instances = instances;
            InstancesContinuationToken = instancesContinuationToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of top instances matching the query by relevance. May be
        /// empty or null.
        /// </summary>
        [JsonProperty(PropertyName = "instances")]
        public IList<InstanceHit> Instances { get; private set; }

        /// <summary>
        /// Gets if returned, this means that current results represent a
        /// partial result. Continuation token allows to get the next page of
        /// results. To get the next page of query results, send the same
        /// request with continuation token parameter in "x-ms-continuation"
        /// HTTP header.
        /// </summary>
        [JsonProperty(PropertyName = "instancesContinuationToken")]
        public string InstancesContinuationToken { get; private set; }

    }
}
