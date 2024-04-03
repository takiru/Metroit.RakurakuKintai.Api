using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 出勤/退勤時刻を提供します。
    /// </summary>
    [JsonObject]
    public class WorkTime
    {
        /// <summary>
        /// 出勤時刻/退勤時刻を取得します。
        /// </summary>
        [JsonProperty("time")]
        public DateTime time { get; private set; }

        /// <summary>
        /// みなされるかどうか？なんだかわからん。
        /// </summary>
        [JsonProperty("deemed")]
        public bool deemed { get; private set; }
    }
}
