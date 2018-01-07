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

    /// <summary>DTO object: [LookupCode]</summary>
    [Serializable]
    public class LookupCodeDto : BaseDto
    {

        /// <summary>[Code]</summary>
        public string Code { get; set; }

        /// <summary>[CreateDateTime]</summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>[CreateUserId]</summary>
        public string CreateUserId { get; set; }

        /// <summary>[Description]</summary>
        public string Description { get; set; }

        /// <summary>[Display]</summary>
        public string Display { get; set; }

        /// <summary>[Name]</summary>
        public string Name { get; set; }

        /// <summary>[UpdateDateTime]</summary>
        public DateTime UpdateDateTime { get; set; }

        /// <summary>[UpdateUserId]</summary>
        public string UpdateUserId { get; set; }

        //Navigational properties
        public virtual LookupNameDto LookupName { get; set; }

        //Reverse navigational properties
        public virtual List<LookupValueDto> LookupValues { get; private set; } = new List<LookupValueDto>();

    }

}
