// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Json;

#pragma warning disable 219, 612, 618
#nullable disable

[EntityFrameworkInternal]
public partial class EntityType1
{
    public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
    {
        var runtimeEntityType = model.AddEntityType(
            "1",
            typeof(Dictionary<string, object>),
            baseEntityType,
            sharedClrType: true,
            indexerPropertyInfo: RuntimeEntityType.FindIndexerProperty(typeof(Dictionary<string, object>)),
            propertyBag: true,
            propertyCount: 1,
            keyCount: 1);

        var id = runtimeEntityType.AddProperty(
            "Id",
            typeof(int),
            propertyInfo: runtimeEntityType.FindIndexerPropertyInfo(),
            valueGenerated: ValueGenerated.OnAdd,
            afterSaveBehavior: PropertySaveBehavior.Throw);
        id.SetGetter(
            (Dictionary<string, object> entity) => (((IDictionary<string, object>)entity).ContainsKey("Id") ? entity["Id"] : null) == null ? 0 : (int)(((IDictionary<string, object>)entity).ContainsKey("Id") ? entity["Id"] : null),
            (Dictionary<string, object> entity) => (((IDictionary<string, object>)entity).ContainsKey("Id") ? entity["Id"] : null) == null,
            (Dictionary<string, object> instance) => (((IDictionary<string, object>)instance).ContainsKey("Id") ? instance["Id"] : null) == null ? 0 : (int)(((IDictionary<string, object>)instance).ContainsKey("Id") ? instance["Id"] : null),
            (Dictionary<string, object> instance) => (((IDictionary<string, object>)instance).ContainsKey("Id") ? instance["Id"] : null) == null);
        id.SetSetter(
            (Dictionary<string, object> entity, int value) => entity["Id"] = (object)value);
        id.SetMaterializationSetter(
            (Dictionary<string, object> entity, int value) => entity["Id"] = (object)value);
        id.SetAccessors(
            (InternalEntityEntry entry) =>
            {
                if (entry.FlaggedAsStoreGenerated(0))
                {
                    return entry.ReadStoreGeneratedValue<int>(0);
                }
                else
                {
                    {
                        if (entry.FlaggedAsTemporary(0) && (((IDictionary<string, object>)(Dictionary<string, object>)entry.Entity).ContainsKey("Id") ? ((Dictionary<string, object>)entry.Entity)["Id"] : null) == null)
                        {
                            return entry.ReadTemporaryValue<int>(0);
                        }
                        else
                        {
                            var nullableValue = ((IDictionary<string, object>)(Dictionary<string, object>)entry.Entity).ContainsKey("Id") ? ((Dictionary<string, object>)entry.Entity)["Id"] : null;
                            return nullableValue == null ? default(int) : (int)nullableValue;
                        }
                    }
                }
            },
            (InternalEntityEntry entry) =>
            {
                var nullableValue = ((IDictionary<string, object>)(Dictionary<string, object>)entry.Entity).ContainsKey("Id") ? ((Dictionary<string, object>)entry.Entity)["Id"] : null;
                return nullableValue == null ? default(int) : (int)nullableValue;
            },
            (InternalEntityEntry entry) => entry.ReadOriginalValue<int>(id, 0),
            (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<int>(id, 0),
            (ValueBuffer valueBuffer) => valueBuffer[0]);
        id.SetPropertyIndexes(
            index: 0,
            originalValueIndex: 0,
            shadowIndex: -1,
            relationshipIndex: 0,
            storeGenerationIndex: 0);
        id.TypeMapping = InMemoryTypeMapping.Default.Clone(
            comparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            keyComparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            providerValueComparer: new ValueComparer<int>(
                (int v1, int v2) => v1 == v2,
                (int v) => v,
                (int v) => v),
            clrType: typeof(int),
            jsonValueReaderWriter: JsonInt32ReaderWriter.Instance);
        id.SetCurrentValueComparer(new EntryCurrentValueComparer<int>(id));

        var key = runtimeEntityType.AddKey(
            new[] { id });
        runtimeEntityType.SetPrimaryKey(key);

        return runtimeEntityType;
    }

    public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
    {
        var id = runtimeEntityType.FindProperty("Id")!;
        var key = runtimeEntityType.FindKey(new[] { id });
        key.SetPrincipalKeyValueFactory(KeyValueFactoryFactory.CreateSimpleNonNullableFactory<int>(key));
        key.SetIdentityMapFactory(IdentityMapFactoryFactory.CreateFactory<int>(key));
        runtimeEntityType.SetOriginalValuesFactory(
            (InternalEntityEntry source) =>
            {
                var entity = (Dictionary<string, object>)source.Entity;
                return (ISnapshot)new Snapshot<int>(((ValueComparer<int>)((IProperty)id).GetValueComparer()).Snapshot(source.GetCurrentValue<int>(id)));
            });
        runtimeEntityType.SetStoreGeneratedValuesFactory(
            () => (ISnapshot)new Snapshot<int>(((ValueComparer<int>)((IProperty)id).GetValueComparer()).Snapshot(default(int))));
        runtimeEntityType.SetTemporaryValuesFactory(
            (InternalEntityEntry source) => (ISnapshot)new Snapshot<int>(default(int)));
        runtimeEntityType.SetShadowValuesFactory(
            (IDictionary<string, object> source) => Snapshot.Empty);
        runtimeEntityType.SetEmptyShadowValuesFactory(
            () => Snapshot.Empty);
        runtimeEntityType.SetRelationshipSnapshotFactory(
            (InternalEntityEntry source) =>
            {
                var entity = (Dictionary<string, object>)source.Entity;
                return (ISnapshot)new Snapshot<int>(((ValueComparer<int>)((IProperty)id).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<int>(id)));
            });
        runtimeEntityType.Counts = new PropertyCounts(
            propertyCount: 1,
            navigationCount: 0,
            complexPropertyCount: 0,
            originalValueCount: 1,
            shadowCount: 0,
            relationshipCount: 1,
            storeGeneratedCount: 1);

        Customize(runtimeEntityType);
    }

    static partial void Customize(RuntimeEntityType runtimeEntityType);
}
