using System.Reflection;
using AutoMapper.Internal;

namespace ConfigValidation;

public static class IgnoredPropertySpecification
{
    public static bool IsIgnoredProperty(PropertyInfo property)
    {
        if (!property.IsPublic()) return true;

        return typeof(IHasIgnoredProperty).IsAssignableFrom(property.DeclaringType)
            && property.Name == nameof(IHasIgnoredProperty.IgnoredProperty);
    }
}