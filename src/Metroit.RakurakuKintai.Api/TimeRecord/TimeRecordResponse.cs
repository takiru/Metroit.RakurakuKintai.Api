using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.TimeRecord
{
    /// <summary>
    /// 打刻のレスポンスを提供します。
    /// </summary>
    [JsonObject]
    public class TimeRecordResponse
    {
        /// <summary>
        /// 打刻日時を取得します。
        /// </summary>
        [JsonProperty("time")]
        public DateTime Time { get; private set; }

        /// <summary>
        /// 打刻種類を取得します。
        /// </summary>
        [JsonProperty("type")]
        public TimeRecordType Type { get; private set; }

        /// <summary>
        /// 打刻を行った勤務日付を取得します。
        /// </summary>
        [JsonProperty("attendanceDate")]
        public DateTime AttendanceDate { get; private set; }
    }
}
