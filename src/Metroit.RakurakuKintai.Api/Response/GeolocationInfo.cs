using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 地理位置設定情報を提供します。
    /// </summary>
    [JsonObject]
    public class GeolocationInfo
    {
        /// <summary>
        /// 地理位置情報を使用するかどうかを取得します。
        /// </summary>
        [JsonProperty("useGeolocation")]
        public bool UseGeolocation { get; private set; }

        /// <summary>
        /// 地理位置情報を受け入れるかどうかを取得します。
        /// </summary>
        [JsonProperty("isAcceptNoGeolocationInfo")]
        public bool IsAcceptNoGeolocationInfo { get; private set; }
    }
}
