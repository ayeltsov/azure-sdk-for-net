// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Possible state values. </summary>
    public readonly partial struct FirewallPolicyIntrusionDetectionStateType : IEquatable<FirewallPolicyIntrusionDetectionStateType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="FirewallPolicyIntrusionDetectionStateType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FirewallPolicyIntrusionDetectionStateType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OffValue = "Off";
        private const string AlertValue = "Alert";
        private const string DenyValue = "Deny";

        /// <summary> Off. </summary>
        public static FirewallPolicyIntrusionDetectionStateType Off { get; } = new FirewallPolicyIntrusionDetectionStateType(OffValue);
        /// <summary> Alert. </summary>
        public static FirewallPolicyIntrusionDetectionStateType Alert { get; } = new FirewallPolicyIntrusionDetectionStateType(AlertValue);
        /// <summary> Deny. </summary>
        public static FirewallPolicyIntrusionDetectionStateType Deny { get; } = new FirewallPolicyIntrusionDetectionStateType(DenyValue);
        /// <summary> Determines if two <see cref="FirewallPolicyIntrusionDetectionStateType"/> values are the same. </summary>
        public static bool operator ==(FirewallPolicyIntrusionDetectionStateType left, FirewallPolicyIntrusionDetectionStateType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FirewallPolicyIntrusionDetectionStateType"/> values are not the same. </summary>
        public static bool operator !=(FirewallPolicyIntrusionDetectionStateType left, FirewallPolicyIntrusionDetectionStateType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FirewallPolicyIntrusionDetectionStateType"/>. </summary>
        public static implicit operator FirewallPolicyIntrusionDetectionStateType(string value) => new FirewallPolicyIntrusionDetectionStateType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FirewallPolicyIntrusionDetectionStateType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FirewallPolicyIntrusionDetectionStateType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
