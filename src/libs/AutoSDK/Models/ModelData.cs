using System.Collections.Immutable;
using AutoSDK.Extensions;

namespace AutoSDK.Models;

public readonly record struct ModelData(
    SchemaContext SchemaContext,
    string Id,
    ImmutableArray<ModelData> Parents,
    string Namespace,
    Settings Settings,
    ModelStyle Style,
    ImmutableArray<PropertyData> Properties,
    ImmutableArray<PropertyData> EnumValues,
    string Summary,
    bool IsDeprecated
)
{
    public static ModelData FromSchemaContext(
        SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        
        var parents = new List<ModelData>();
        var parent = context.Parent;
        while (parent != null)
        {
            if (parent.ClassData.HasValue)
            {
                parents.Add(parent.ClassData!.Value);
            }
            parent = parent.Parent;
        }

        parents.Reverse();
        
        return new ModelData(
            SchemaContext: context,
            Id: context.Id,
            Parents: parents.ToImmutableArray(),
            Namespace: context.Settings.Namespace,
            Style: context.Schema.IsEnum() ? ModelStyle.Enumeration : context.Settings.ModelStyle,
            Settings: context.Settings,
            Properties: !context.Schema.IsEnum()
                ? context.Children
                    .Where(x => x is { IsProperty: true, PropertyData: not null })
                    .SelectMany(x => x.ComputedProperties)
                    .ToImmutableArray() : [],
            EnumValues: context.Schema.IsEnum()
                ? context.ComputeEnum().Values.ToImmutableArray()
                : [],
            Summary: context.Schema.GetSummary(),
            IsDeprecated: context.Schema.Deprecated
            );
    }

    public string ClassName => Id;// Settings.NamingConvention switch
    // {
    //     NamingConvention.ConcatNames => Parents.IsEmpty ? Name : $"{Parents.Last().ClassName}{Name}",
    //     
    //     _ => string.Empty,
    // };

    public string GlobalClassName => $"global::{Namespace}.{ClassName}";
    
    public string ExternalClassName => Settings.NamingConvention switch
    {
        NamingConvention.ConcatNames => ClassName,
        NamingConvention.InnerClasses => string.Join(".", Parents.Select(x => x.ClassName).Concat([ClassName])),
        _ => string.Empty,
    };
    
    public string FileNameWithoutExtension => $"{Namespace}.Models.{ExternalClassName}";
}