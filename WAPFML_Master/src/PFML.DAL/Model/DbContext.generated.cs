// ----------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a compiler emitter: FACTS.Framework.Analysis.Generators.DAL.ContextEmitter
//
// Changes to this file may cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
// ----------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using PFML.DAL.Model.DbEntities;

namespace PFML.DAL.Model
{

    [DbConfigurationType(typeof(FACTS.Framework.DAL.DbConfigurationSqlServer))]
    public class DbContext : FACTS.Framework.DAL.DbContext
    {

        protected override string ModelPrefix { get { return "Db"; } }
        protected override string ModelVersion { get { return "180102145717"; } }

        /// <summary>Static initializer to remove initial calls to DB (not requred if not using migrations)</summary>
        static DbContext()
        {
            Database.SetInitializer<DbContext>(null);
        }

        /// <summary>Constructor</summary>
        public DbContext()
        {
            Database.Log = (log) =>
            {
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    System.Diagnostics.Debug.WriteLine(log);
                }
                FACTS.Framework.Logging.Logger.LogDatabase(log);
            };
        }

        /// <summary>[Table: LookupCode]</summary>
        public virtual DbSet<LookupCode> LookupCodes { get; set; }

        /// <summary>[Table: LookupName]</summary>
        public virtual DbSet<LookupName> LookupNames { get; set; }

        /// <summary>[Table: LookupProperty]</summary>
        public virtual DbSet<LookupProperty> LookupProperties { get; set; }

        /// <summary>[Table: LookupValue]</summary>
        public virtual DbSet<LookupValue> LookupValues { get; set; }

        /// <summary>[Table: SecurityDefinition]</summary>
        public virtual DbSet<SecurityDefinition> SecurityDefinitions { get; set; }

        /// <summary>[Table: SecurityPermission]</summary>
        public virtual DbSet<SecurityPermission> SecurityPermissions { get; set; }

        ///<summary>IQueryable to use for returing only a single row from a DB query</summary>
        public IQueryable<LookupCode> DummyRecord { get { return LookupCodes.Take(1); } }

        /// <summary>DB Procedure: [sp_Person]</summary>
        /// <returns>Number of rows affected</returns>
        public virtual int SPPerson()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Person");
        }

        #region Model Creation

        private static DbModel BuildModel()
        {
            DbModelBuilder builder = new DbModelBuilder();

            builder.Entity<LookupCode>();
            builder.Entity<LookupName>();
            builder.Entity<LookupProperty>();
            builder.Entity<LookupValue>();
            builder.Entity<SecurityDefinition>();
            builder.Entity<SecurityPermission>();

            DbEntities.LookupCode.ModelCreating(builder);
            DbEntities.LookupName.ModelCreating(builder);
            DbEntities.LookupProperty.ModelCreating(builder);
            DbEntities.LookupValue.ModelCreating(builder);
            DbEntities.SecurityDefinition.ModelCreating(builder);
            DbEntities.SecurityPermission.ModelCreating(builder);

            DbModel model = builder.Build(new DbProviderInfo("System.Data.SqlClient", "2008"));

            ReadOnlyCollection<PrimitiveType> storeTypes = model.ProviderManifest.GetStoreTypes();
            BuildSPPerson(model, storeTypes);

            return model;
        }

        private static EdmType GetEdmType(DbModel model, ReadOnlyCollection<PrimitiveType> storeTypes, PrimitiveTypeKind typeKind)
        {
            return model.ProviderManifest.GetStoreType(TypeUsage.CreateDefaultTypeUsage(PrimitiveType.GetEdmPrimitiveType(typeKind))).EdmType;
        }

        private static void BuildSPPerson(DbModel model, ReadOnlyCollection<PrimitiveType> storeTypes)
        {
            EdmFunctionPayload payload = new EdmFunctionPayload { Schema = "dbo", StoreFunctionName = "sp_Person", IsComposable = false };
            EdmFunction function = EdmFunction.Create("sp_Person", "CodeFirstDatabaseSchema", DataSpace.SSpace, payload, null);
            model.StoreModel.AddItem(function);

            EdmFunctionPayload payloadImport = new EdmFunctionPayload { IsFunctionImport = true, IsComposable = false };
            EdmFunction functionImport = EdmFunction.Create("sp_Person", "CodeFirstNamespace", DataSpace.CSpace, payloadImport, null);
            model.ConceptualModel.Container.AddFunctionImport(functionImport);

            FunctionImportResultMapping functionImportResultMapping = null;
            FunctionImportMappingNonComposable functionImportMapping = CreateFunctionImportMappingNonComposable(functionImport, function, functionImportResultMapping, model.ConceptualToStoreMapping);
            model.ConceptualToStoreMapping.AddFunctionImportMapping(functionImportMapping);
        }

        #endregion

    }

}
