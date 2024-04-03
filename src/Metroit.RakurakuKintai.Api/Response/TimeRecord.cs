using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 打刻情報を提供します。
    /// </summary>
    [JsonObject]
    public class TimeRecord
    {
        /// <summary>
        /// 打刻種類を取得します。
        /// </summary>
        [JsonProperty("type")]
        public TimeRecordType Type { get; private set; }

        /// <summary>
        /// 打刻日時を取得します。
        /// </summary>
        [JsonProperty("time")]
        public DateTime Time { get; private set; }

        /// <summary>
        /// わからん。
        /// </summary>
        [JsonProperty("authMethod")]
        public int AuthMethod { get; private set; }

        /// <summary>
        /// 位置情報を取得します。
        /// </summary>
        [JsonProperty("geolocation")]
        public Geolocation Geolocation { get; private set; }

        /// <summary>
        /// デバイス種類を取得します。
        /// </summary>
        [JsonProperty("device")]
        public DeviceType Device { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("isOffline")]
        public bool IsOffline { get; private set; }
    }
}
