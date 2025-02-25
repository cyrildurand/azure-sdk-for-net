// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Core
{
    /// <summary> The child information of a management group used during creation. </summary>
    public partial class CreateManagementGroupChildInfo
    {
        /// <summary> Initializes a new instance of CreateManagementGroupChildInfo. </summary>
        internal CreateManagementGroupChildInfo()
        {
            Children = new ChangeTrackingList<CreateManagementGroupChildInfo>();
        }

        /// <summary> The fully qualified resource type which includes provider namespace (e.g. Microsoft.Management/managementGroups). </summary>
        public ManagementGroupChildType? Type { get; }
        /// <summary> The fully qualified ID for the child resource (management group or subscription).  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </summary>
        public string Id { get; }
        /// <summary> The name of the child entity. </summary>
        public string Name { get; }
        /// <summary> The friendly name of the child resource. </summary>
        public string DisplayName { get; }
        /// <summary> The list of children. </summary>
        public IReadOnlyList<CreateManagementGroupChildInfo> Children { get; }
    }
}
