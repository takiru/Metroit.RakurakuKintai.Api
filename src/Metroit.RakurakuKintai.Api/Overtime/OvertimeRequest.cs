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
        public string Time { get; }

        /// <summary>
        /// 申請理由を取得します。
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; }

        /// <summary>
        /// 新しインスタンスを生成します。
        /// 残業時刻は、対象日と残業日時から算出されます。
        /// 残業日時の日付が対象日より未来の時、残業時刻は24:00以上となります。
        /// </summary>
        /// <param name="attendanceDate">対象日。</param>
        /// <param name="overtimeType">残業種類。</param>
        /// <param name="overDateTime">残業日時。</param>
        /// <param name="reason">申請理由。</param>
        /// <exception cref="ArgumentException">算出された残業時刻が 00:00 未満、または 47:59 を超えた場合に発生します。</exception>
        public OvertimeRequest(DateTime attendanceDate, OvertimeType overtimeType, DateTime overDateTime, string reason)
        {
            AttendanceDate = attendanceDate;
            OvertimeType = overtimeType;

            // NOTE: 残業時間は 00:00 ～ 47:59 までを指定可能
            if (overDateTime.Date < attendanceDate.Date)
            {
                throw new ArgumentException("残業日時の日付が対象日未満です。");
            }
            if (overDateTime.Date == attendanceDate.Date)
            {
                Time = overDateTime.ToString("HH:mm");
            }
            else
            {
                var overDay = new DateTime(overDateTime.Year, overDateTime.Month, overDateTime.Day, 0, 0, 0);
                var span = overDateTime.Subtract(overDay);
                var hour = 24 + span.Hours;
                var minute = span.Minutes;

                if (hour > 47)
                {
                    throw new ArgumentException("残業時間が 47:59 を超えています。");
                }

                Time = $"{hour:00}:{minute:00}";
            }

            Reason = reason;
        }
    }
}
