// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Core
{
    internal static partial class ResourceIdentityTypeExtensions
    {
        public static string ToSerialString(this ResourceIdentityType value) => value switch
        {
            ResourceIdentityType.SystemAssigned => "SystemAssigned",
            ResourceIdentityType.None => "None",
            ResourceIdentityType.UserAssigned => "UserAssigned",
            ResourceIdentityType.SystemAssignedUserAssigned => "SystemAssigned, UserAssigned",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResourceIdentityType value.")
        };

        public static ResourceIdentityType ToResourceIdentityType(this string value)
        {
            if (string.Equals(value, "SystemAssigned", StringComparison.InvariantCultureIgnoreCase)) return ResourceIdentityType.SystemAssigned;
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return ResourceIdentityType.None;
            if (string.Equals(value, "UserAssigned", StringComparison.InvariantCultureIgnoreCase)) return ResourceIdentityType.UserAssigned;
            if (string.Equals(value, "SystemAssigned, UserAssigned", StringComparison.InvariantCultureIgnoreCase)) return ResourceIdentityType.SystemAssignedUserAssigned;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResourceIdentityType value.");
        }
    }
}
