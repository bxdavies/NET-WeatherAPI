﻿using Newtonsoft.Json;
using System;

namespace NETWeatherAPI.Entities
{
    public class ForecastDayEntity
    {
        #region Properties
        /// <summary>
        /// Gets or sets the astronomy information.
        /// </summary>
        [JsonProperty("astro")]
        public AstroEntity Astronomy { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the forecast date, in unix time.
        /// </summary>
        [JsonProperty("date_epoch")]
        public long DateEpoch { get; set; }

        /// <summary>
        /// Gets or sets the forecast information for the day.
        /// </summary>
        [JsonProperty("day")]
        public DayEntity Day { get; set; }

        /// <summary>
        /// Gets or sets the hourly forecast.
        /// </summary>
        [JsonProperty("hour")]
        public HourEntity[] Hour { get; set; }
        #endregion
    }
}
