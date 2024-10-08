using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AnyOfTypes;

#nullable enable

namespace AutoSDK.JsonConverters
{
    [DebuggerDisplay("{_thisType}, AnyOfType = {_currentType}; Type = {_currentValueType?.Name}; Value = '{ToString()}'")]
    public readonly struct OneOf<TFirst, TSecond> : IEquatable<OneOf<TFirst, TSecond>>
    {
        private readonly string _thisType => $"OneOf<{typeof(TFirst).Name}, {typeof(TSecond).Name}>";

        [MemberNotNullWhen(true, nameof(First))]
        public bool IsFirst => First != null;
        
        [MemberNotNullWhen(true, nameof(Second))]
        public bool IsSecond => Second != null;

        public bool Validate()
        {
            return IsOneOf;
        }
        
        public bool IsAnyOf =>
            IsFirst || IsSecond;
        
        public bool IsOneOf =>
            IsFirst && !IsSecond ||
            !IsFirst && IsSecond;
        
        public bool IsAllOf =>
            IsFirst && IsSecond;

        public static implicit operator OneOf<TFirst, TSecond>(TFirst value) => new OneOf<TFirst, TSecond>(value);

        public static implicit operator TFirst?(OneOf<TFirst, TSecond> @this) => @this.First;

        public OneOf(TFirst value)
        {
            First = value;
        }

        public TFirst? First { get; init; }

        public static implicit operator OneOf<TFirst, TSecond>(TSecond value) => new OneOf<TFirst, TSecond>(value);

        public static implicit operator TSecond?(OneOf<TFirst, TSecond> @this) => @this.Second;

        public OneOf(TSecond value)
        {
            Second = value;
        }

        public TSecond? Second { get; init; }

        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                First,
                Second,
                typeof(TFirst),
                typeof(TSecond),
            };
            return HashCodeCalculator.GetHashCode(fields);
        }

        public bool Equals(OneOf<TFirst, TSecond> other)
        {
            return EqualityComparer<TFirst?>.Default.Equals(First, other.First) &&
                   EqualityComparer<TSecond?>.Default.Equals(Second, other.Second);
        }

        public static bool operator ==(OneOf<TFirst, TSecond> obj1, OneOf<TFirst, TSecond> obj2)
        {
            return EqualityComparer<OneOf<TFirst, TSecond>>.Default.Equals(obj1, obj2);
        }

        public static bool operator !=(OneOf<TFirst, TSecond> obj1, OneOf<TFirst, TSecond> obj2)
        {
            return !(obj1 == obj2);
        }

        public override bool Equals(object? obj)
        {
            return obj is OneOf<TFirst, TSecond> o && Equals(o);
        }

        public override string ToString()
        {
            return $"{First}{Second}";
        }
    }
}
