// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> The ExportImportDevice. </summary>
    public partial class ExportImportDevice
    {
        /// <summary> Initializes a new instance of ExportImportDevice. </summary>
        public ExportImportDevice()
        {
            Tags = new ChangeTrackingDictionary<string, object>();
            ParentScopes = new ChangeTrackingList<string>();
        }

        /// <summary> Device Id is always required. </summary>
        public string Id { get; set; }
        /// <summary> ModuleId is applicable to modules only. </summary>
        public string ModuleId { get; set; }
        /// <summary> ETag parameter is only used for pre-conditioning the update when importMode is updateIfMatchETag. </summary>
        public string ETag { get; set; }
        public ExportImportDeviceImportMode? ImportMode { get; set; }
        /// <summary> Status is optional and defaults to enabled. </summary>
        public ExportImportDeviceStatus? Status { get; set; }
        public string StatusReason { get; set; }
        /// <summary> Authentication parameter is optional and defaults to SAS if not provided. In that case, we auto-generate primary/secondary access keys. </summary>
        public AuthenticationMechanism Authentication { get; set; }
        /// <summary> twinETag parameter is only used for pre-conditioning the update when importMode is updateTwinIfMatchETag. </summary>
        public string TwinETag { get; set; }
        /// <summary> Dictionary of &lt;any&gt;. </summary>
        public IDictionary<string, object> Tags { get; }
        /// <summary> Properties are optional and defaults to empty object. </summary>
        public PropertyContainer Properties { get; set; }
        /// <summary> Capabilities param is optional and defaults to no capability. </summary>
        public DeviceCapabilities Capabilities { get; set; }
        public string DeviceScope { get; set; }
        public IList<string> ParentScopes { get; }
    }
}