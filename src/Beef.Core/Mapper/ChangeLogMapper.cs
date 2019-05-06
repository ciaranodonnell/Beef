﻿using Beef.Entities;
using System;

namespace Beef.Mapper
{
    /// <summary>
    /// Represents a <see cref="ChangeLog"/> to <typeparamref name="TDestEntity"/> mapper.
    /// </summary>
    /// <typeparam name="TDestEntity">The destination entity <see cref="Type"/>.</typeparam>
    public class ChangeLogMapper<TDestEntity> : EntityMapper<ChangeLog, TDestEntity> where TDestEntity : class, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeLogMapper{TDestEntity}"/> class.
        /// </summary>
        public ChangeLogMapper() : base(true)
        {
            var pm = GetBySrcePropertyName(ChangeLog.Property_CreatedBy);
            if (pm != null)
                pm.SetOperationTypes(OperationTypes.AnyExceptUpdate);

            pm = GetBySrcePropertyName(ChangeLog.Property_CreatedDate);
            if (pm != null)
                pm.SetOperationTypes(OperationTypes.AnyExceptUpdate);

            pm = GetBySrcePropertyName(ChangeLog.Property_UpdatedBy);
            if (pm != null)
                pm.SetOperationTypes(OperationTypes.AnyExceptCreate);

            pm = GetBySrcePropertyName(ChangeLog.Property_UpdatedDate);
            if (pm != null)
                pm.SetOperationTypes(OperationTypes.AnyExceptCreate);
        }

        /// <summary>
        /// Extension opportunity when performing a <see cref="EntityMapper{TSrce, TDest}.MapToDest(TSrce, OperationTypes)"/>.
        /// </summary>
        /// <param name="sourceEntity">The source entity.</param>
        /// <param name="destinationEntity">The destination entity.</param>
        /// <param name="operationType">The single <see cref="Mapper.OperationTypes"/> being performed to enable selection.</param>
        /// <returns>The destination entity.</returns>
        protected override ChangeLog OnMapToSrce(TDestEntity destinationEntity, ChangeLog sourceEntity, OperationTypes operationType)
        {
            return sourceEntity.IsInitial ? null : sourceEntity;
        }
    }
}