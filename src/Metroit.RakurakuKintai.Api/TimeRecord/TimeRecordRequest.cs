using Metroit.RakurakuKintai.Api.Response;
using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.TimeRecord
{
    /// <summary>
    /// 打刻のリクエストを提供します。
    /// </summary>
    [JsonObject]
    public class TimeRecordRequest
    {
        /// <summary>
        /// 打刻種類を取得します。
        /// </summary>
        [JsonProperty("type")]
        public TimeRecordType Type { get; } = TimeRecordType.CheckIn;

        /// <summary>
        /// デバイスを取得または設定します。
        /// </summary>
        [JsonProperty("device")]
        public DeviceType Device { get; set; } = DeviceType.PC;

        /// <summary>
        /// 位置情報を取得します。
        /// </summary>
        [JsonProperty("geolocation")]
        public Geolocation Geolocation { get; } = new Geolocation();

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="type">打刻種類。</param>
        public TimeRecordRequest(TimeRecordType type)
        {
            Type = type;
        }
    }
}
