// ----------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a compiler emitter: FACTS.Framework.Analysis.Generators.DAL.EntityEmitter
//
// Changes to this file may cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
// ----------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using PFML.Shared.Model.DbDtos;
using FACTS.Framework.DAL;

namespace PFML.DAL.Model.DbEntities
{

    /// <summary>[LookupName]</summary>
    [Table("LookupName", Schema="dbo")]
    public class LookupName : BaseEntity
    {

        /// <summary>[CreateDateTime]</summary>
        [Required]
        [Column("CreateDateTime")]
        public DateTime CreateDateTime { get; set; }

        /// <summary>[CreateUserId]</summary>
        [Required]
        [MaxLength(50)]
        [Column("CreateUserId")]
        public string CreateUserId { get; set; }

        /// <summary>[Description]</summary>
        [MaxLength(500)]
        [Column("Description")]
        public string Description { get; set; }

        /// <summary>[Name]</summary>
        [Key]
        [Required]
        [MaxLength(50)]
        [Column("Name", Order=1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Name { get; set; }

        /// <summary>[UpdateDateTime]</summary>
        [Required]
        [Column("UpdateDateTime")]
        [ConcurrencyCheck]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>[UpdateUserId]</summary>
        [Required]
        [MaxLength(50)]
        [Column("UpdateUserId")]
        public string UpdateUserId { get; set; }

        private ICollection<LookupCode> lookupCodes { get; set; }
        public virtual ICollection<LookupCode> LookupCodes { get { return lookupCodes ?? (lookupCodes = new Collection<LookupCode>()); } protected set { lookupCodes = value; } }

        private ICollection<LookupProperty> lookupProperties { get; set; }
        public virtual ICollection<LookupProperty> LookupProperties { get { return lookupProperties ?? (lookupProperties = new Collection<LookupProperty>()); } protected set { lookupProperties = value; } }

        public override void SetAuditFields(EntityState state)
        {
            string username = FACTS.Framework.Service.Context.UserName ?? "UNKNOWN";
            DateTime timestamp = DateTime.Now;

            if (state == EntityState.Added)
            {
                CreateUserId = username;
                CreateDateTime = new System.Data.SqlTypes.SqlDateTime(timestamp).Value;
                UpdateUserId = username;
                UpdateDateTime = new System.Data.SqlTypes.SqlDateTime(timestamp).Value;
            }
            else if (state == EntityState.Modified)
            {
                UpdateUserId = username;
                UpdateDateTime = new System.Data.SqlTypes.SqlDateTime(timestamp).Value;
            }
        }

        internal static void ModelCreating(DbModelBuilder builder)
        {
            builder.Entity<LookupName>().Property(x => x.CreateUserId).IsUnicode(false);
            builder.Entity<LookupName>().Property(x => x.Description).IsUnicode(false);
            builder.Entity<LookupName>().Property(x => x.Name).IsUnicode(false);
            builder.Entity<LookupName>().Property(x => x.UpdateUserId).IsUnicode(false);
        }

        /// <summary>Convert from LookupName entity to DTO</summary>
        /// <param name="dbContext">DB Context to use for setting DTO state</param>
        /// <param name="dto">DTO to use if already created instead of creating new one (can be inherited class instead as opposed to base class)</param>
        /// <param name="entityDtos">Used internally to track which entities have been converted to DTO's already (to avoid re-converting when circularly referenced)</param>
        /// <returns>Resultant LookupName DTO</returns>
        public LookupNameDto ToDtoDeep(FACTS.Framework.DAL.DbContext dbContext, LookupNameDto dto = null, Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto> entityDtos = null)
        {
            entityDtos = entityDtos ?? new Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto>();
            if (entityDtos.ContainsKey(this))
            {
                return (LookupNameDto)entityDtos[this];
            }

            dto = ToDto(dto);
            entityDtos.Add(this, dto);

            System.Data.Entity.Infrastructure.DbEntityEntry<LookupName> entry = dbContext?.Entry(this);
            dto.IsNew = (entry?.State == EntityState.Added);
            dto.IsDeleted = (entry?.State == EntityState.Deleted);

            if (entry?.Collection(x => x.LookupCodes)?.IsLoaded == true)
            {
                foreach (LookupCode lookupCode in LookupCodes)
                {
                    dto.LookupCodes.Add(lookupCode.ToDtoDeep(dbContext, entityDtos: entityDtos));
                }
            }
            if (entry?.Collection(x => x.LookupProperties)?.IsLoaded == true)
            {
                foreach (LookupProperty lookupProperty in LookupProperties)
                {
                    dto.LookupProperties.Add(lookupProperty.ToDtoDeep(dbContext, entityDtos: entityDtos));
                }
            }

            return dto;
        }

        /// <summary>Convert from LookupName entity to DTO w/o checking entity state or entity navigation</summary>
        /// <param name="dto">DTO to use if already created instead of creating new one (can be inherited class instead as opposed to base class)</param>
        /// <returns>Resultant LookupName DTO</returns>
        public LookupNameDto ToDto(LookupNameDto dto = null)
        {

            dto = dto ?? new LookupNameDto();
            dto.IsNew = false;

            dto.CreateDateTime = CreateDateTime;
            dto.CreateUserId = CreateUserId;
            dto.Description = Description;
            dto.Name = Name;
            dto.UpdateDateTime = UpdateDateTime;
            dto.UpdateUserId = UpdateUserId;

            return dto;
        }

        /// <summary>Convert from LookupName DTO to entity</summary>
        /// <param name="dbContext">DB Context to use for attaching entity</param>
        /// <param name="dto">DTO to convert from</param>
        /// <param name="dtoEntities">Used internally to track which dtos have been converted to entites already (to avoid re-converting when circularly referenced)</param>
        /// <returns>Resultant LookupName entity</returns>
        public static LookupName FromDto(FACTS.Framework.DAL.DbContext dbContext, LookupNameDto dto, Dictionary<FACTS.Framework.Dto.BaseDto, BaseEntity> dtoEntities = null)
        {
            dtoEntities = dtoEntities ?? new Dictionary<FACTS.Framework.Dto.BaseDto, BaseEntity>();
            if (dtoEntities.ContainsKey(dto))
            {
                return (LookupName)dtoEntities[dto];
            }

            LookupName entity = new LookupName();
            dtoEntities.Add(dto, entity);

            entity.CreateDateTime = dto.CreateDateTime;
            entity.CreateUserId = dto.CreateUserId;
            entity.Description = dto.Description;
            entity.Name = dto.Name;
            entity.UpdateDateTime = dto.UpdateDateTime;
            entity.UpdateUserId = dto.UpdateUserId;

            if (dto.LookupCodes != null)
            {
                foreach (LookupCodeDto lookupCode in dto.LookupCodes)
                {
                    entity.LookupCodes.Add(DbEntities.LookupCode.FromDto(dbContext, lookupCode, dtoEntities));
                }
            }
            if (dto.LookupProperties != null)
            {
                foreach (LookupPropertyDto lookupProperty in dto.LookupProperties)
                {
                    entity.LookupProperties.Add(DbEntities.LookupProperty.FromDto(dbContext, lookupProperty, dtoEntities));
                }
            }

            if (dbContext != null)
            {
                dbContext.Entry(entity).State = (dto.IsNew ? EntityState.Added : (dto.IsDeleted ? EntityState.Deleted : EntityState.Modified));
            }

            return entity;
        }

    }

    /// <summary>Extension methods related to LookupName entity</summary>
    public static class LookupNameExtension
    {

        /// <summary>Convert IEnumerable LookupName to list of DTOs</summary>
        /// <param name="entities">IEnumerable LookupNames</param>
        /// <param name="dbContext">DB Context to use for setting state of DTO</param>
        /// <returns>List of DTO LookupNames</returns>
        public static List<LookupNameDto> ToDtoListDeep(this IEnumerable<LookupName> entities, FACTS.Framework.DAL.DbContext dbContext)
        {
            Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto> entityDtos = new Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto>();
            List<LookupNameDto> dtos = new List<LookupNameDto>();
            foreach (LookupName entity in entities)
            {
                dtos.Add(entity.ToDtoDeep(dbContext, entityDtos: entityDtos));
            }
            return dtos;
        }

        /// <summary>Convert L2E LookupName to list of DTOs</summary>
        /// <param name="entities">L2E LookupNames</param>
        /// <param name="dbContext">DB Context to use for setting state of DTO</param>
        /// <returns>List of DTO LookupNames</returns>
        public static List<LookupNameDto> ToDtoListDeep(this IQueryable<LookupName> entities, FACTS.Framework.DAL.DbContext dbContext)
        {
            Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto> entityDtos = new Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto>();
            List<LookupNameDto> dtos = new List<LookupNameDto>();
            foreach (LookupName entity in entities)
            {
                dtos.Add(entity.ToDtoDeep(dbContext, entityDtos: entityDtos));
            }
            return dtos;
        }

        /// <summary>Convert L2E LookupName to list of customized DTOs</summary>
        /// <typeparam name="T">Custom DTO derived from LookupNameDto</typeparam>
        /// <param name="entities">L2E LookupNames</param>
        /// <param name="dbContext">DB Context to use for setting state of DTO</param>
        /// <returns>List of DTO customized LookupNames</returns>
        public static List<T> ToDtoListDeep<T>(this IQueryable<LookupName> entities, FACTS.Framework.DAL.DbContext dbContext) where T : LookupNameDto, new()
        {
            Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto> entityDtos = new Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto>();
            List<T> dtos = new List<T>();
            foreach (LookupName entity in entities)
            {
                dtos.Add((T)entity.ToDtoDeep(dbContext, new T(), entityDtos));
            }
            return dtos;
        }

        /// <summary>Convert IEnumerable LookupName to list of DTOs w/o checking entity state or entity navigation</summary>
        /// <param name="entities">IEnumerable LookupNames</param>
        /// <returns>List of DTO LookupNames</returns>
        public static List<LookupNameDto> ToDtoList(this IEnumerable<LookupName> entities)
        {
            List<LookupNameDto> dtos = new List<LookupNameDto>();
            foreach (LookupName entity in entities)
            {
                dtos.Add(entity.ToDto());
            }
            return dtos;
        }

        /// <summary>Convert L2E LookupName to list of DTOs w/o checking entity state or entity navigation</summary>
        /// <param name="entities">L2E LookupNames</param>
        /// <returns>List of DTO LookupNames</returns>
        public static List<LookupNameDto> ToDtoList(this IQueryable<LookupName> entities)
        {
            List<LookupNameDto> dtos = new List<LookupNameDto>();
            foreach (LookupName entity in entities)
            {
                dtos.Add(entity.ToDto());
            }
            return dtos;
        }

        /// <summary>Convert L2E LookupName to list of customized DTOs w/o checking entity state or entity navigation</summary>
        /// <typeparam name="T">Custom DTO derived from LookupNameDto</typeparam>
        /// <param name="entities">L2E LookupNames</param>
        /// <returns>List of DTO customized LookupNames</returns>
        public static List<T> ToDtoList<T>(this IQueryable<LookupName> entities) where T : LookupNameDto, new()
        {
            List<T> dtos = new List<T>();
            foreach (LookupName entity in entities)
            {
                dtos.Add((T)entity.ToDto(new T()));
            }
            return dtos;
        }

    }

}
