using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 勤務時刻を提供します。
    /// </summary>
    [JsonObject]
    public class PatternOfTimes
    {
        /// <summary>
        /// 就業時刻を取得します。
        /// </summary>
        [JsonProperty("workingTime")]
        public WorkingTime workingTime { get; private set; }

        /// <summary>
        /// 早残となる終了時刻を取得します。
        /// </summary>
        [JsonProperty("earlyWorkableTime")]
        public DateTime EarlyWorkableTime { get; private set; }

        /// <summary>
        /// 遅残となる開始時刻を取得します。
        /// </summary>
        [JsonProperty("lateWorkableTime")]
        public DateTime LateWorkableTime { get; private set; }

        /// <summary>
        /// 休憩時刻を取得します。
        /// </summary>
        [JsonProperty("breakTimes")]
        public BreakTime[] breakTimes { get; private set; }
    }
}
