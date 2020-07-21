// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The ConfigurationQueriesTestInput. </summary>
    public partial class ConfigurationQueriesTestInput
    {
        /// <summary> Initializes a new instance of ConfigurationQueriesTestInput. </summary>
        public ConfigurationQueriesTestInput()
        {
            CustomMetricQueries = new ChangeTrackingDictionary<string, string>();
        }

        public string TargetCondition { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> CustomMetricQueries { get; }
    }
}