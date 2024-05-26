// This file includes code from the StefH/AnyOf project,
// which is licensed under the MIT license.
// Original code: https://github.com/StefH/AnyOf
// MIT License: https://github.com/StefH/AnyOf/blob/main/LICENSE

using System;
using System.ComponentModel;
using System.Globalization;

#nullable enable

namespace AnyOfTypes;

public class AnyOfConverter<TFirst, TSecond> : TypeConverter
{
    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType)
    {
        return sourceType == typeof(OneOf<TFirst, TSecond>) || sourceType == typeof(TFirst) || sourceType == typeof(TSecond) || base.CanConvertFrom(context, sourceType);
    }

    public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType)
    {
        return destinationType != null && (destinationType == typeof(OneOf<TFirst, TSecond>) || destinationType == typeof(TFirst) || destinationType == typeof(TSecond) || base.CanConvertTo(context, destinationType));
    }

    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object? value)
    {
        if (value == null)
        {
            return null;
        }

        if (value is OneOf<TFirst, TSecond> anyOfValue)
        {
            return anyOfValue;
        }

        if (value is TFirst first)
        {
            return new OneOf<TFirst, TSecond>(first);
        }

        if (value is TSecond second)
        {
            return new OneOf<TFirst, TSecond>(second);
        }

        // Fall back to the base implementation if the value cannot be converted.
        return base.ConvertFrom(context!, culture!, value);
    }

    public override object? ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
    {
        if (value is null)
        {
            return null;
        }

        if (destinationType == typeof(OneOf<TFirst, TSecond>))
        {
            return value;
        }

        if (destinationType == typeof(TFirst))
        {
            return ((OneOf<TFirst, TSecond>)value).First;
        }

        if (destinationType == typeof(TSecond))
        {
            return ((OneOf<TFirst, TSecond>)value).Second;
        }

        //if (value is AnyOf<TFirst, TSecond> anyOfValue)
        //{
        //    if (destinationType == typeof(AnyOf<TFirst, TSecond>))
        //    {
        //        return value;
        //    }

        //    if (destinationType == typeof(TFirst))
        //    {
        //        return anyOfValue.First;
        //    }

        //    if (destinationType == typeof(TSecond))
        //    {
        //        return anyOfValue.Second;
        //    }
        //}

        // Fall back to the base implementation if the value cannot be converted.
        return base.ConvertTo(context, culture, value, destinationType);
    }
}