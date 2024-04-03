using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 就業時刻を提供します。
    /// </summary>
    [JsonObject]
    public class WorkingTime
    {
        /// <summary>
        /// 出勤時刻を取得します。
        /// </summary>
        [JsonProperty("workIn")]
        public DateTime workIn { get; private set; }

        /// <summary>
        /// 退勤時刻を取得します。
        /// </summary>
        [JsonProperty("workOut")]
        public DateTime workOut { get; private set; }
    }
}
