using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 時間記録ルールを提供します。
    /// </summary>
    [JsonObject]
    public class TimeRecordRule
    {
        /// <summary>
        /// 地理位置情報を取得します。
        /// </summary>
        [JsonProperty("geolocationInfo")]
        public GeolocationInfo GeolocationInfo { get; private set; }

        /// <summary>
        /// ブラウザからの操作が許容されるかどうかを取得します。
        /// </summary>
        [JsonProperty("isBrowserAllowed")]
        public bool isBrowserAllowed { get; private set; }
    }
}
