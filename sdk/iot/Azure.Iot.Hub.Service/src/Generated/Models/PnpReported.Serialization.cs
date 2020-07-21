// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    internal partial class PnpReported
    {
        internal static PnpReported DeserializePnpReported(JsonElement element)
        {
            Optional<object> value = default;
            Optional<DesiredState> desiredState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("desiredState"))
                {
                    desiredState = DesiredState.DeserializeDesiredState(property.Value);
                    continue;
                }
            }
            return new PnpReported(value.Value, desiredState.Value);
        }
    }
}