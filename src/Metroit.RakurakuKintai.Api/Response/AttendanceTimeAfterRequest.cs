using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 申請後の勤怠時刻情報を提供します。
    /// </summary>
    [JsonObject]
    public class AttendanceTimeAfterRequest
    {
        /// <summary>
        /// 申請日時を取得します。
        /// </summary>
        [JsonProperty("time")]
        public DateTime Time { get; private set; }

        /// <summary>
        /// 打刻種類を取得します。
        /// </summary>
        [JsonProperty("type")]
        public TimeRecordType Type { get; private set; }
    }
}
