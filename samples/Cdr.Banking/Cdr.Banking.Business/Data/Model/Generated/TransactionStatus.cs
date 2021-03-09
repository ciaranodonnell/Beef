/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Beef.RefData.Model;
using Newtonsoft.Json;

namespace Cdr.Banking.Business.Data.Model
{
    /// <summary>
    /// Represents the Transaction Status model.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TransactionStatus : ReferenceDataBaseGuid
    {
    }

    /// <summary>
    /// Represents the <see cref="TransactionStatus"/> collection.
    /// </summary>
    public partial class TransactionStatusCollection : List<TransactionStatus> { }
}

#pragma warning restore
#nullable restore