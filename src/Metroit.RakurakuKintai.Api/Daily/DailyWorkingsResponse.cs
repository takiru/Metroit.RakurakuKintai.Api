using Metroit.RakurakuKintai.Api.Response;
using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Daily
{
    /// <summary>
    /// 日付範囲の勤怠状況のレスポンスを提供します。
    /// </summary>
    [JsonObject]
    public class DailyWorkingsResponse
    {
        /// <summary>
        /// 勤怠状況を取得します。
        /// </summary>
        [JsonProperty("dailyWorkings")]
        public DailyWorking[] DailyWorkings { get; private set; }
    }
}
