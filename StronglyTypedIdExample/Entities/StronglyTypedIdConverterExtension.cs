using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StronglyTypedIdExample.Entities;

public static class StronglyTypedIdConverterExtension
{
    public static void HasStronglyTypedId<TProperty>(this PropertyBuilder<TProperty> builder) where TProperty : StronglyTypedId?
    {
        builder
            .HasColumnName(builder.Metadata.Name)
            .HasConversion(
                obj => obj == null ? default : obj.Value,
                id => (TProperty) Activator.CreateInstance(typeof(TProperty), id)!)
            .ValueGeneratedOnAdd();
    }
}
