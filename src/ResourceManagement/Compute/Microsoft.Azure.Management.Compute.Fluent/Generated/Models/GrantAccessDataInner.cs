// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Azure;
    using Management;
    using Compute;
    using Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data used for requesting a SAS.
    /// </summary>
    public partial class GrantAccessDataInner
    {
        /// <summary>
        /// Initializes a new instance of the GrantAccessDataInner class.
        /// </summary>
        public GrantAccessDataInner() { }

        /// <summary>
        /// Initializes a new instance of the GrantAccessDataInner class.
        /// </summary>
        /// <param name="access">Possible values include: 'None',
        /// 'Read'</param>
        /// <param name="durationInSeconds">Time duration in seconds until the
        /// SAS access expires.</param>
        public GrantAccessDataInner(AccessLevel access, int durationInSeconds)
        {
            Access = access;
            DurationInSeconds = durationInSeconds;
        }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Read'
        /// </summary>
        [JsonProperty(PropertyName = "access")]
        public AccessLevel Access { get; set; }

        /// <summary>
        /// Gets or sets time duration in seconds until the SAS access expires.
        /// </summary>
        [JsonProperty(PropertyName = "durationInSeconds")]
        public int DurationInSeconds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
