// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Update.Internal;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    public partial class DbContextModel
    {
        private DbContextModel()
            : base(skipDetectChanges: false, modelId: new Guid("00000000-0000-0000-0000-000000000000"), entityTypeCount: 1)
        {
        }

        partial void Initialize()
        {
            var data = DataEntityType.Create(this);

            DataEntityType.CreateAnnotations(data);

            var sequences = new Dictionary<(string, string), ISequence>();
            var hL = new RuntimeSequence(
                "HL",
                this,
                typeof(long),
                schema: "S",
                incrementBy: 10);

            sequences[("HL", "S")] = hL;

            AddAnnotation("Relational:Sequences", sequences);
            AddAnnotation("Relational:MaxIdentifierLength", 128);
            AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            AddRuntimeAnnotation("Relational:RelationalModelFactory", () => CreateRelationalModel());
        }

        private IRelationalModel CreateRelationalModel()
        {
            var relationalModel = new RelationalModel(this);

            var data = FindEntityType("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+Data")!;

            var defaultTableMappings = new List<TableMappingBase<ColumnMappingBase>>();
            data.SetRuntimeAnnotation("Relational:DefaultMappings", defaultTableMappings);
            var microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase = new TableBase("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+Data", null, relationalModel);
            var blobColumnBase = new ColumnBase<ColumnMappingBase>("Blob", "varbinary(max)", microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase)
            {
                IsNullable = true
            };
            microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase.Columns.Add("Blob", blobColumnBase);
            var idColumnBase = new ColumnBase<ColumnMappingBase>("Id", "int", microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase);
            microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase.Columns.Add("Id", idColumnBase);
            relationalModel.DefaultTables.Add("Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+Data", microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase);
            var microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase = new TableMappingBase<ColumnMappingBase>(data, microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase, null);
            microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataTableBase.AddTypeMapping(microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase, false);
            defaultTableMappings.Add(microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)idColumnBase, data.FindProperty("Id")!, microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)blobColumnBase, data.FindProperty("Blob")!, microsoftEntityFrameworkCoreScaffoldingCompiledModelTestBaseDataMappingBase);

            var tableMappings = new List<TableMapping>();
            data.SetRuntimeAnnotation("Relational:TableMappings", tableMappings);
            var dataTable = new Table("Data", null, relationalModel);
            var idColumn = new Column("Id", "int", dataTable);
            dataTable.Columns.Add("Id", idColumn);
            idColumn.Accessors = ColumnAccessorsFactory.CreateGeneric<int>(idColumn);
            var blobColumn = new Column("Blob", "varbinary(max)", dataTable)
            {
                IsNullable = true
            };
            dataTable.Columns.Add("Blob", blobColumn);
            blobColumn.Accessors = ColumnAccessorsFactory.CreateGeneric<byte[]>(blobColumn);
            relationalModel.Tables.Add(("Data", null), dataTable);
            var dataTableMapping = new TableMapping(data, dataTable, null);
            dataTable.AddTypeMapping(dataTableMapping, false);
            tableMappings.Add(dataTableMapping);
            RelationalModel.CreateColumnMapping(idColumn, data.FindProperty("Id")!, dataTableMapping);
            RelationalModel.CreateColumnMapping(blobColumn, data.FindProperty("Blob")!, dataTableMapping);
            var pK_Data = new UniqueConstraint("PK_Data", dataTable, new[] { idColumn });
            dataTable.PrimaryKey = pK_Data;
            pK_Data.SetRowKeyValueFactory(new SimpleRowKeyValueFactory<int>(pK_Data));
            var pK_DataKey = RelationalModel.GetKey(this,
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+Data",
                new[] { "Id" });
            pK_Data.MappedKeys.Add(pK_DataKey);
            RelationalModel.GetOrCreateUniqueConstraints(pK_DataKey).Add(pK_Data);
            dataTable.UniqueConstraints.Add("PK_Data", pK_Data);
            return relationalModel.MakeReadOnly();
        }
    }
}
