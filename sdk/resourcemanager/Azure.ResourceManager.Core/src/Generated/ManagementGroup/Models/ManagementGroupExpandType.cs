// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Core
{
    /// <summary> The Enum0. </summary>
    public readonly partial struct ManagementGroupExpandType : IEquatable<ManagementGroupExpandType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ManagementGroupExpandType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagementGroupExpandType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ChildrenValue = "children";
        private const string PathValue = "path";
        private const string AncestorsValue = "ancestors";

        /// <summary> children. </summary>
        public static ManagementGroupExpandType Children { get; } = new ManagementGroupExpandType(ChildrenValue);
        /// <summary> path. </summary>
        public static ManagementGroupExpandType Path { get; } = new ManagementGroupExpandType(PathValue);
        /// <summary> ancestors. </summary>
        public static ManagementGroupExpandType Ancestors { get; } = new ManagementGroupExpandType(AncestorsValue);
        /// <summary> Determines if two <see cref="ManagementGroupExpandType"/> values are the same. </summary>
        public static bool operator ==(ManagementGroupExpandType left, ManagementGroupExpandType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagementGroupExpandType"/> values are not the same. </summary>
        public static bool operator !=(ManagementGroupExpandType left, ManagementGroupExpandType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagementGroupExpandType"/>. </summary>
        public static implicit operator ManagementGroupExpandType(string value) => new ManagementGroupExpandType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagementGroupExpandType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagementGroupExpandType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
