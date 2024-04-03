using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 勤務時刻から算出された各種時間を提供します。
    /// </summary>
    [JsonObject]
    public class Calculated
    {
        /// <summary>
        /// 遅刻時間を取得します。
        /// </summary>
        [JsonProperty("lateMinutes")]
        public int LateMinutes { get; private set; }

        /// <summary>
        /// 早退時間を取得します。
        /// </summary>
        [JsonProperty("earlyMinutes")]
        public int EarlyMinutes { get; private set; }

        /// <summary>
        /// 休憩時間を取得します。
        /// </summary>
        [JsonProperty("breakTimeMinutes")]
        public int BreakTimeMinutes { get; private set; }

        /// <summary>
        /// 労働時間を取得します。
        /// </summary>
        [JsonProperty("workingMinutes")]
        public WorkingMinutes WorkingMinutes { get; private set; }

        /// <summary>
        /// 締め状態を取得します。
        /// </summary>
        [JsonProperty("closingStatus")]
        public ClosingStatus ClosingStatus { get; private set; }
    }
}
