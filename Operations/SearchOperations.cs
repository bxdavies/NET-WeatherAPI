﻿using NETWeatherAPI.Base;
using NETWeatherAPI.Entities;
using NETWeatherAPI.Operations.Base;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace NETWeatherAPI.Operations
{
    public class SearchOperations : BaseOperations, ISearchOperations
    {
        #region Public Methods
        /// <summary>
        /// Searches for a location based on a query.
        /// </summary>
        /// <param name="query">The location query.</param>
        public virtual Task<SearchEntity[]> SearchAsync(string query, CancellationToken cancellationToken = default)
        {
            return ((ISearchOperations)this).SearchAsync<SearchEntity>(query, cancellationToken);
        }

        /// <summary>
        /// Searches for a location based on a query.
        /// </summary>
        /// <param name="query">The location query.</param>
        public virtual Task<TSearchEntity[]> SearchAsync<TSearchEntity>(string query, CancellationToken cancellationToken = default)
        {
            return ApiRequestor.RequestJsonSerializedAsync<TSearchEntity[]>(HttpMethod.Get, "search.json", new[] { $"q={query}" }, null, cancellationToken);
        }
        #endregion

        #region Constructors
        public SearchOperations(IApiRequestor apiRequestor)
            : base(apiRequestor)
        {
        }
        #endregion
    }
}
