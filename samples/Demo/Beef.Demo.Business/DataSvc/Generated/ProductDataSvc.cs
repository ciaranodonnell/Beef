/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Business;
using Beef.Entities;
using Beef.Demo.Business.Data;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business.DataSvc
{
    /// <summary>
    /// Provides the <see cref="Product"/> data repository services.
    /// </summary>
    public partial class ProductDataSvc : IProductDataSvc
    {
        private readonly IProductData _data;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDataSvc"/> class.
        /// </summary>
        /// <param name="data">The <see cref="IProductData"/>.</param>
        public ProductDataSvc(IProductData data)
            { _data = Check.NotNull(data, nameof(data)); ProductDataSvcCtor(); }

        partial void ProductDataSvcCtor(); // Enables additional functionality to be added to the constructor.

        /// <summary>
        /// Gets the specified <see cref="Product"/>.
        /// </summary>
        /// <param name="id">The <see cref="Product"/> identifier.</param>
        /// <returns>The selected <see cref="Product"/> where found.</returns>
        public Task<Product?> GetAsync(int id) => DataSvcInvoker.Current.InvokeAsync(this, async () =>
        {
            var __result = await _data.GetAsync(id).ConfigureAwait(false);
            return __result;
        });

        /// <summary>
        /// Gets the <see cref="ProductCollectionResult"/> that contains the items that match the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="Entities.ProductArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>The <see cref="ProductCollectionResult"/>.</returns>
        public Task<ProductCollectionResult> GetByArgsAsync(ProductArgs? args, PagingArgs? paging) => DataSvcInvoker.Current.InvokeAsync(this, async () =>
        {
            var __result = await _data.GetByArgsAsync(args, paging).ConfigureAwait(false);
            return __result;
        });
    }
}

#pragma warning restore
#nullable restore