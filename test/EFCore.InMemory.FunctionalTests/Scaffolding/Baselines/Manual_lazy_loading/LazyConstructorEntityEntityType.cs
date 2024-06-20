// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Json;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class LazyConstructorEntityEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelInMemoryTest+LazyConstructorEntity",
                typeof(CompiledModelInMemoryTest.LazyConstructorEntity),
                baseEntityType,
                propertyCount: 1,
                navigationCount: 2,
                servicePropertyCount: 1,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyConstructorEntity).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelInMemoryTest.LazyConstructorEntity).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.SetGetter(
                (CompiledModelInMemoryTest.LazyConstructorEntity entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_Id(entity),
                (CompiledModelInMemoryTest.LazyConstructorEntity entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_Id(entity) == 0,
                (CompiledModelInMemoryTest.LazyConstructorEntity instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_Id(instance),
                (CompiledModelInMemoryTest.LazyConstructorEntity instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_Id(instance) == 0);
            id.SetSetter(
                (CompiledModelInMemoryTest.LazyConstructorEntity entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_Id(entity) = value);
            id.SetMaterializationSetter(
                (CompiledModelInMemoryTest.LazyConstructorEntity entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_Id(entity) = value);
            id.SetAccessors(
                (InternalEntityEntry entry) => entry.FlaggedAsStoreGenerated(0) ? entry.ReadStoreGeneratedValue<int>(0) : entry.FlaggedAsTemporary(0) && UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_Id((CompiledModelInMemoryTest.LazyConstructorEntity)entry.Entity) == 0 ? entry.ReadTemporaryValue<int>(0) : UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_Id((CompiledModelInMemoryTest.LazyConstructorEntity)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_Id((CompiledModelInMemoryTest.LazyConstructorEntity)entry.Entity),
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
            id.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_Id", "TestNamespace") });

            var _loader = runtimeEntityType.AddServiceProperty(
                "_loader",
                fieldInfo: typeof(CompiledModelInMemoryTest.LazyConstructorEntity).GetField("_loader", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                serviceType: typeof(ILazyLoader));
            _loader.SetPropertyIndexes(
                index: -1,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);

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
            var lazyPropertyDelegateEntity = runtimeEntityType.FindNavigation("LazyPropertyDelegateEntity")!;
            var lazyPropertyEntity = runtimeEntityType.FindNavigation("LazyPropertyEntity")!;
            runtimeEntityType.SetOriginalValuesFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelInMemoryTest.LazyConstructorEntity)source.Entity;
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
                    var entity = (CompiledModelInMemoryTest.LazyConstructorEntity)source.Entity;
                    return (ISnapshot)new Snapshot<int, object, object>(((ValueComparer<int>)((IProperty)id).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<int>(id)), UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyDelegateEntity(entity), UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyEntity(entity));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 1,
                navigationCount: 2,
                complexPropertyCount: 0,
                originalValueCount: 1,
                shadowCount: 0,
                relationshipCount: 3,
                storeGeneratedCount: 1);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Id>k__BackingField")]
        public static extern ref int UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_Id(CompiledModelInMemoryTest.LazyConstructorEntity @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<LazyPropertyDelegateEntity>k__BackingField")]
        public static extern ref CompiledModelInMemoryTest.LazyPropertyDelegateEntity UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyDelegateEntity(CompiledModelInMemoryTest.LazyConstructorEntity @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<LazyPropertyEntity>k__BackingField")]
        public static extern ref CompiledModelInMemoryTest.LazyPropertyEntity UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyEntity(CompiledModelInMemoryTest.LazyConstructorEntity @this);
    }
}
