﻿using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 残業申請情報を提供します。
    /// </summary>
    [JsonObject]
    public class Overtime
    {
        /// <summary>
        /// 残業種類を取得します。
        /// </summary>
        [JsonProperty("overtimeType")]
        public OvertimeType overtimeType { get; private set; }

        /// <summary>
        /// 申請前時刻を取得します。
        /// </summary>
        [JsonProperty("timeBefore")]
        public string timeBefore { get; private set; }

        /// <summary>
        /// 申請後時刻を取得します。
        /// </summary>
        [JsonProperty("timeAfter")]
        public string timeAfter { get; private set; }
    }
}
