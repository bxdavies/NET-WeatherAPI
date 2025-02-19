﻿using NETWeatherAPI.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace NETWeatherAPI.Operations.Base
{
    public interface IHistoryOperations : IOperations
    {
        #region Methods
        /// <summary>
        /// Gets historical weather forecast data.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        Task<HistoryResponseEntity> GetHistoryAsync(HistoryRequestEntity request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets historical weather forecast data.
        /// </summary>
        /// <param name="request">The request configuration.</param>
        Task<THistoryResponseEntity> GetHistoryAsync<THistoryResponseEntity>(HistoryRequestEntity request, CancellationToken cancellationToken = default)
            where THistoryResponseEntity : class;
        #endregion
    }
}
