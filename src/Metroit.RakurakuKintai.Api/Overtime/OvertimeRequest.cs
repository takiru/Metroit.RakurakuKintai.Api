using Metroit.RakurakuKintai.Api.Json;
using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Overtime
{
    /// <summary>
    /// 残業申請のリクエストを提供します。
    /// </summary>
    public class OvertimeRequest
    {
        /// <summary>
        /// 対象日を取得します。
        /// </summary>
        [JsonProperty("attendanceDate")]
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-dd")]
        public DateTime AttendanceDate { get; }

        /// <summary>
        /// 残業種類を取得します。
        /// </summary>
        [JsonProperty("overtimeType")]
        public OvertimeType OvertimeType { get; }

        /// <summary>
        /// 残業時刻を取得します。
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(CustomDateTimeConverter), "HH:mm")]
        public DateTime Time { get; }

        /// <summary>
        /// 申請理由を取得します。
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; }

        /// <summary>
        /// 新しインスタンスを生成します。
        /// </summary>
        /// <param name="attendanceDate">対象日。</param>
        /// <param name="overtimeType">残業種類。</param>
        /// <param name="time">残業時刻。</param>
        /// <param name="reason">申請理由。</param>
        public OvertimeRequest(DateTime attendanceDate, OvertimeType overtimeType, DateTime time, string reason)
        {
            AttendanceDate = attendanceDate;
            OvertimeType = overtimeType;
            Time = time;
            Reason = reason;
        }
    }
}
