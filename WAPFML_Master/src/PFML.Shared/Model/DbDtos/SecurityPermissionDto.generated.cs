// ----------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a compiler emitter: FACTS.Framework.Analysis.Generators.DAL.DtoEmitter
//
// Changes to this file may cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
// ----------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using FACTS.Framework.Dto;

namespace PFML.Shared.Model.DbDtos
{

    /// <summary>DTO object: [SecurityPermission]</summary>
    [Serializable]
    public class SecurityPermissionDto : BaseDto
    {

        /// <summary>[AccessType]</summary>
        public string AccessType { get; set; }

        /// <summary>[CreateDateTime]</summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>[CreateUserId]</summary>
        public string CreateUserId { get; set; }

        /// <summary>[SourceName]</summary>
        public string SourceName { get; set; }

        /// <summary>[SourceType]</summary>
        public string SourceType { get; set; }

        /// <summary>[TargetName]</summary>
        public string TargetName { get; set; }

        /// <summary>[TargetType]</summary>
        public string TargetType { get; set; }

        /// <summary>[UpdateDateTime]</summary>
        public DateTime UpdateDateTime { get; set; }

        /// <summary>[UpdateUserId]</summary>
        public string UpdateUserId { get; set; }

    }

}
