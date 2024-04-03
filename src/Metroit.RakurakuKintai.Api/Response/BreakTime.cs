using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 休憩時刻を提供します。
    /// </summary>
    [JsonObject]
    public class BreakTime
    {
        /// <summary>
        /// 開始時刻を取得します。
        /// </summary>
        [JsonProperty("startTime")]
        public DateTime startTime { get; private set; }

        /// <summary>
        /// 終了時刻を取得します。
        /// </summary>
        [JsonProperty("endTime")]
        public DateTime endTime { get; private set; }
    }
}
