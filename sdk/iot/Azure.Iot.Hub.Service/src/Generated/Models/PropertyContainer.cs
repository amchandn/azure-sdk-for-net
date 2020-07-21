// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> Represents Twin properties. </summary>
    public partial class PropertyContainer
    {
        /// <summary> Initializes a new instance of PropertyContainer. </summary>
        public PropertyContainer()
        {
            Desired = new ChangeTrackingDictionary<string, object>();
            Reported = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Used in conjunction with reported properties to synchronize device configuration or condition. Desired properties can only be set by the solution back end and can be read by the device app. The device app can also be notified in real time of changes on the desired properties. </summary>
        public IDictionary<string, object> Desired { get; }
        /// <summary> Used in conjunction with desired properties to synchronize device configuration or condition. Reported properties can only be set by the device app and can be read and queried by the solution back end. </summary>
        public IDictionary<string, object> Reported { get; }
    }
}