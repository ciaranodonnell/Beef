/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using Beef.RefData;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Entities
{
    /// <summary>
    /// Provides for the required <b>ReferenceData</b> capabilities. 
    /// </summary>
    public partial interface IReferenceData : IReferenceDataProvider
    {
        #region Collections

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.CountryCollection"/>.
        /// </summary>
        RefDataNamespace.CountryCollection Country { get; }

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.USStateCollection"/>.
        /// </summary>
        RefDataNamespace.USStateCollection USState { get; }

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.GenderCollection"/>.
        /// </summary>
        RefDataNamespace.GenderCollection Gender { get; }

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.EyeColorCollection"/>.
        /// </summary>
        RefDataNamespace.EyeColorCollection EyeColor { get; }

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.PowerSourceCollection"/>.
        /// </summary>
        RefDataNamespace.PowerSourceCollection PowerSource { get; }

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.CompanyCollection"/>.
        /// </summary>
        RefDataNamespace.CompanyCollection Company { get; }

        /// <summary> 
        /// Gets the <see cref="RefDataNamespace.StatusCollection"/>.
        /// </summary>
        RefDataNamespace.StatusCollection Status { get; }

        #endregion
    }
}

#pragma warning restore
#nullable restore