// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    internal static class KeyPermissionExtensions
    {
        public static string ToSerialString(this KeyPermission value) => value switch
        {
            KeyPermission.Read => "Read",
            KeyPermission.Full => "Full",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyPermission value.")
        };

        public static KeyPermission ToKeyPermission(this string value)
        {
            if (string.Equals(value, "Read", StringComparison.InvariantCultureIgnoreCase)) return KeyPermission.Read;
            if (string.Equals(value, "Full", StringComparison.InvariantCultureIgnoreCase)) return KeyPermission.Full;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyPermission value.");
        }
    }
}