using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 地理位置情報を提供します。
    /// </summary>
    [JsonObject]
    public class Geolocation
    {
        /// <summary>
        /// 緯度を取得または設定します。
        /// </summary>
        [JsonProperty("latitude")]
        public double Latitude { get; set; } = 0;

        /// <summary>
        /// 経度を取得または設定します。
        /// </summary>
        [JsonProperty("longitude")]
        public double Longitude { get; set; } = 0;
    }
}
