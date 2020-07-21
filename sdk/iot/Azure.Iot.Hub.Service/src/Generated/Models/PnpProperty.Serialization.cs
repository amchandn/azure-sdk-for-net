// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    internal partial class PnpProperty
    {
        internal static PnpProperty DeserializePnpProperty(JsonElement element)
        {
            Optional<PnpReported> reported = default;
            Optional<PnpDesired> desired = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reported"))
                {
                    reported = PnpReported.DeserializePnpReported(property.Value);
                    continue;
                }
                if (property.NameEquals("desired"))
                {
                    desired = PnpDesired.DeserializePnpDesired(property.Value);
                    continue;
                }
            }
            return new PnpProperty(reported.Value, desired.Value);
        }
    }
}