// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
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
    public partial class LazyPropertyDelegateEntityEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelInMemoryTest+LazyPropertyDelegateEntity",
                typeof(CompiledModelInMemoryTest.LazyPropertyDelegateEntity),
                baseEntityType,
                propertyCount: 2,
                navigationCount: 1,
                servicePropertyCount: 2,
                foreignKeyCount: 1,
                unnamedIndexCount: 1,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyPropertyDelegateEntity).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelInMemoryTest.LazyPropertyDelegateEntity).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.SetGetter(
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_Id(entity),
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_Id(entity) == 0,
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_Id(instance),
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_Id(instance) == 0);
            id.SetSetter(
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_Id(entity) = value);
            id.SetMaterializationSetter(
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_Id(entity) = value);
            id.SetAccessors(
                (InternalEntityEntry entry) => entry.FlaggedAsStoreGenerated(0) ? entry.ReadStoreGeneratedValue<int>(0) : entry.FlaggedAsTemporary(0) && UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_Id((CompiledModelInMemoryTest.LazyPropertyDelegateEntity)entry.Entity) == 0 ? entry.ReadTemporaryValue<int>(0) : UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_Id((CompiledModelInMemoryTest.LazyPropertyDelegateEntity)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_Id((CompiledModelInMemoryTest.LazyPropertyDelegateEntity)entry.Entity),
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
            id.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("LazyPropertyDelegateEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_Id", "TestNamespace") });

            var lazyConstructorEntityId = runtimeEntityType.AddProperty(
                "LazyConstructorEntityId",
                typeof(int),
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyPropertyDelegateEntity).GetProperty("LazyConstructorEntityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelInMemoryTest.LazyPropertyDelegateEntity).GetField("<LazyConstructorEntityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            lazyConstructorEntityId.SetGetter(
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntityId(entity),
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntityId(entity) == 0,
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntityId(instance),
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntityId(instance) == 0);
            lazyConstructorEntityId.SetSetter(
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntityId(entity) = value);
            lazyConstructorEntityId.SetMaterializationSetter(
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntityId(entity) = value);
            lazyConstructorEntityId.SetAccessors(
                (InternalEntityEntry entry) => entry.FlaggedAsStoreGenerated(1) ? entry.ReadStoreGeneratedValue<int>(1) : entry.FlaggedAsTemporary(1) && UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntityId((CompiledModelInMemoryTest.LazyPropertyDelegateEntity)entry.Entity) == 0 ? entry.ReadTemporaryValue<int>(1) : UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntityId((CompiledModelInMemoryTest.LazyPropertyDelegateEntity)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntityId((CompiledModelInMemoryTest.LazyPropertyDelegateEntity)entry.Entity),
                (InternalEntityEntry entry) => entry.ReadOriginalValue<int>(lazyConstructorEntityId, 1),
                (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<int>(lazyConstructorEntityId, 1),
                (ValueBuffer valueBuffer) => valueBuffer[1]);
            lazyConstructorEntityId.SetPropertyIndexes(
                index: 1,
                originalValueIndex: 1,
                shadowIndex: -1,
                relationshipIndex: 1,
                storeGenerationIndex: 1);
            lazyConstructorEntityId.TypeMapping = InMemoryTypeMapping.Default.Clone(
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
            lazyConstructorEntityId.SetCurrentValueComparer(new EntryCurrentValueComparer<int>(lazyConstructorEntityId));
            lazyConstructorEntityId.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("LazyPropertyDelegateEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntityId", "TestNamespace") });

            var lazyLoader = runtimeEntityType.AddServiceProperty(
                "LazyLoader",
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyPropertyDelegateEntity).GetProperty("LazyLoader", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                serviceType: typeof(Action<object, string>));
            lazyLoader.SetPropertyIndexes(
                index: -1,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);

            var loaderState = runtimeEntityType.AddServiceProperty(
                "LoaderState",
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyPropertyDelegateEntity).GetProperty("LoaderState", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                serviceType: typeof(ILazyLoader));
            loaderState.SetPropertyIndexes(
                index: -1,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { lazyConstructorEntityId },
                unique: true);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("LazyConstructorEntityId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                unique: true,
                required: true);

            var lazyConstructorEntity = declaringEntityType.AddNavigation("LazyConstructorEntity",
                runtimeForeignKey,
                onDependent: true,
                typeof(CompiledModelInMemoryTest.LazyConstructorEntity),
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyPropertyDelegateEntity).GetProperty("LazyConstructorEntity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelInMemoryTest.LazyPropertyDelegateEntity).GetField("<LazyConstructorEntity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                propertyAccessMode: PropertyAccessMode.Field);

            lazyConstructorEntity.SetGetter(
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntity(entity),
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntity(entity) == null,
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntity(instance),
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntity(instance) == null);
            lazyConstructorEntity.SetSetter(
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity entity, CompiledModelInMemoryTest.LazyConstructorEntity value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntity(entity) = value);
            lazyConstructorEntity.SetMaterializationSetter(
                (CompiledModelInMemoryTest.LazyPropertyDelegateEntity entity, CompiledModelInMemoryTest.LazyConstructorEntity value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntity(entity) = value);
            lazyConstructorEntity.SetAccessors(
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntity((CompiledModelInMemoryTest.LazyPropertyDelegateEntity)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntity((CompiledModelInMemoryTest.LazyPropertyDelegateEntity)entry.Entity),
                null,
                (InternalEntityEntry entry) => entry.GetCurrentValue<CompiledModelInMemoryTest.LazyConstructorEntity>(lazyConstructorEntity),
                null);
            lazyConstructorEntity.SetPropertyIndexes(
                index: 0,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: 2,
                storeGenerationIndex: -1);
            lazyConstructorEntity.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("LazyPropertyDelegateEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntity", "TestNamespace") });
            var lazyPropertyDelegateEntity = principalEntityType.AddNavigation("LazyPropertyDelegateEntity",
                runtimeForeignKey,
                onDependent: false,
                typeof(CompiledModelInMemoryTest.LazyPropertyDelegateEntity),
                propertyInfo: typeof(CompiledModelInMemoryTest.LazyConstructorEntity).GetProperty("LazyPropertyDelegateEntity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelInMemoryTest.LazyConstructorEntity).GetField("<LazyPropertyDelegateEntity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                propertyAccessMode: PropertyAccessMode.Field);

            lazyPropertyDelegateEntity.SetGetter(
                (CompiledModelInMemoryTest.LazyConstructorEntity entity) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyDelegateEntity(entity),
                (CompiledModelInMemoryTest.LazyConstructorEntity entity) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyDelegateEntity(entity) == null,
                (CompiledModelInMemoryTest.LazyConstructorEntity instance) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyDelegateEntity(instance),
                (CompiledModelInMemoryTest.LazyConstructorEntity instance) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyDelegateEntity(instance) == null);
            lazyPropertyDelegateEntity.SetSetter(
                (CompiledModelInMemoryTest.LazyConstructorEntity entity, CompiledModelInMemoryTest.LazyPropertyDelegateEntity value) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyDelegateEntity(entity) = value);
            lazyPropertyDelegateEntity.SetMaterializationSetter(
                (CompiledModelInMemoryTest.LazyConstructorEntity entity, CompiledModelInMemoryTest.LazyPropertyDelegateEntity value) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyDelegateEntity(entity) = value);
            lazyPropertyDelegateEntity.SetAccessors(
                (InternalEntityEntry entry) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyDelegateEntity((CompiledModelInMemoryTest.LazyConstructorEntity)entry.Entity),
                (InternalEntityEntry entry) => LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyDelegateEntity((CompiledModelInMemoryTest.LazyConstructorEntity)entry.Entity),
                null,
                (InternalEntityEntry entry) => entry.GetCurrentValue<CompiledModelInMemoryTest.LazyPropertyDelegateEntity>(lazyPropertyDelegateEntity),
                null);
            lazyPropertyDelegateEntity.SetPropertyIndexes(
                index: 0,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: 1,
                storeGenerationIndex: -1);
            lazyPropertyDelegateEntity.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("LazyConstructorEntityEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyConstructorEntity_LazyPropertyDelegateEntity", "TestNamespace") });
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id")!;
            var lazyConstructorEntityId = runtimeEntityType.FindProperty("LazyConstructorEntityId")!;
            var key = runtimeEntityType.FindKey(new[] { id });
            key.SetPrincipalKeyValueFactory(KeyValueFactoryFactory.CreateSimpleNonNullableFactory<int>(key));
            key.SetIdentityMapFactory(IdentityMapFactoryFactory.CreateFactory<int>(key));
            var lazyConstructorEntity = runtimeEntityType.FindNavigation("LazyConstructorEntity")!;
            runtimeEntityType.SetOriginalValuesFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelInMemoryTest.LazyPropertyDelegateEntity)source.Entity;
                    return (ISnapshot)new Snapshot<int, int>(((ValueComparer<int>)((IProperty)id).GetValueComparer()).Snapshot(source.GetCurrentValue<int>(id)), ((ValueComparer<int>)((IProperty)lazyConstructorEntityId).GetValueComparer()).Snapshot(source.GetCurrentValue<int>(lazyConstructorEntityId)));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                () => (ISnapshot)new Snapshot<int, int>(((ValueComparer<int>)((IProperty)id).GetValueComparer()).Snapshot(default(int)), ((ValueComparer<int>)((IProperty)lazyConstructorEntityId).GetValueComparer()).Snapshot(default(int))));
            runtimeEntityType.SetTemporaryValuesFactory(
                (InternalEntityEntry source) => (ISnapshot)new Snapshot<int, int>(default(int), default(int)));
            runtimeEntityType.SetShadowValuesFactory(
                (IDictionary<string, object> source) => Snapshot.Empty);
            runtimeEntityType.SetEmptyShadowValuesFactory(
                () => Snapshot.Empty);
            runtimeEntityType.SetRelationshipSnapshotFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelInMemoryTest.LazyPropertyDelegateEntity)source.Entity;
                    return (ISnapshot)new Snapshot<int, int, object>(((ValueComparer<int>)((IProperty)id).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<int>(id)), ((ValueComparer<int>)((IProperty)lazyConstructorEntityId).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<int>(lazyConstructorEntityId)), UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntity(entity));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 2,
                navigationCount: 1,
                complexPropertyCount: 0,
                originalValueCount: 2,
                shadowCount: 0,
                relationshipCount: 3,
                storeGeneratedCount: 2);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Id>k__BackingField")]
        public static extern ref int UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_Id(CompiledModelInMemoryTest.LazyPropertyDelegateEntity @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<LazyConstructorEntityId>k__BackingField")]
        public static extern ref int UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntityId(CompiledModelInMemoryTest.LazyPropertyDelegateEntity @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<LazyConstructorEntity>k__BackingField")]
        public static extern ref CompiledModelInMemoryTest.LazyConstructorEntity UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_LazyPropertyDelegateEntity_LazyConstructorEntity(CompiledModelInMemoryTest.LazyPropertyDelegateEntity @this);
    }
}
