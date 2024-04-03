using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 実際の勤怠状況を提供します。
    /// </summary>
    [JsonObject]
    public class Actual
    {
        /// <summary>
        /// 出退勤情報を取得します。
        /// </summary>
        [JsonProperty("attendanceTimes")]
        public AttendanceTime[] AttendanceTimes { get; private set; }

        /// <summary>
        /// 打刻情報を取得します。
        /// </summary>
        [JsonProperty("timeRecords")]
        public TimeRecord[] TimeRecords { get; private set; }

        /// <summary>
        /// 日付種類を取得します。
        /// </summary>
        [JsonProperty("dayType")]
        public DayType DayType { get; private set; }
    }
}
