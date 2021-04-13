﻿using Newtonsoft.Json;

namespace WeatherAPI.Entities
{
    public class ForecastEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the daily forecast.
        /// </summary>
        [JsonProperty("forecastday")]
        public ForecastDayEntity[] ForecastDay { get; set; }
        #endregion
    }
}
