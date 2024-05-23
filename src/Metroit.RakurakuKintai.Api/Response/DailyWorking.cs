using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 勤怠状況を提供します。
    /// </summary>
    [JsonObject]
    public class DailyWorking
    {
        /// <summary>
        /// 日付を取得します。
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; private set; }

        /// <summary>
        /// 暦の日付種類？を取得します。
        /// </summary>
        [JsonProperty("scheduledDayType")]
        public DayType ScheduledDayType { get; private set; }

        /// <summary>
        /// 会社によって定義された日付種類？を取得します。
        /// </summary>
        [JsonProperty("actualDayType")]
        public DayType ActualDayType { get; private set; }

        /// <summary>
        /// 労働時間が変更されたかどうかを取得します。
        /// </summary>
        [JsonProperty("isWorkingTimeModified")]
        public bool IsWorkingTimeModified { get; private set; }

        /// <summary>
        /// 勤務パターンが削除されたかどうかを取得します。
        /// </summary>
        [JsonProperty("isWorkingPatternDeleted")]
        public bool IsWorkingPatternDeleted { get; private set; }

        /// <summary>
        /// 利用できない勤務パターンかどうかを取得します。
        /// </summary>
        [JsonProperty("isWorkingPatternUnAvailable")]
        public bool IsWorkingPatternUnAvailable { get; private set; }

        /// <summary>
        /// なんだろ？休暇申請状態かな？
        /// </summary>
        [JsonProperty("takingLeaves")]
        public TakingLeave[] TakingLeaves { get; private set; }

        /// <summary>
        /// 勤務パターンによる就業時刻を取得します。
        /// </summary>
        [JsonProperty("scheduledWorkingTime", NullValueHandling = NullValueHandling.Include)]
        public WorkingTime ScheduledWorkingTime { get; private set; }

        /// <summary>
        /// 遅刻時間を取得します。
        /// </summary>
        [JsonProperty("lateMinutes")]
        public int LateMinutes { get; private set; }

        /// <summary>
        /// 早退時間を取得します。
        /// </summary>
        [JsonProperty("earlyMinutes")]
        public int EarlyMinutes { get; private set; }

        /// <summary>
        /// 休憩時間を取得します。
        /// </summary>
        [JsonProperty("breakTimeMinutes")]
        public int BreakTimeMinutes { get; private set; }

        /// <summary>
        /// 労働時間を取得します。
        /// </summary>
        [JsonProperty("workingMinutes")]
        public WorkingMinutes WorkingMinutes { get; private set; }

        /// <summary>
        /// 振替休日を取得します。何もないとnull. DateTimeか？
        /// </summary>
        [JsonProperty("holidayExchange")]
        public int? HolidayExchange { get; private set; }

        /// <summary>
        /// なんだかわからん。
        /// </summary>
        [JsonProperty("customItems")]
        public CustomItem[] CustomItems { get; private set; }

        /// <summary>
        /// メモを取得します。
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; private set; }

        /// <summary>
        /// エラー種類を取得します。
        /// </summary>
        [JsonProperty("systemErrors")]
        public string[] SystemErrors { get; private set; }

        /// <summary>
        /// 警告種類を取得します。
        /// </summary>
        [JsonProperty("systemWarnings")]
        public string[] SystemWarnings { get; private set; }

        /// <summary>
        /// 勤務パターンを取得します。
        /// </summary>
        [JsonProperty("workingPattern", NullValueHandling = NullValueHandling.Include)]
        public WorkingPattern WorkingPattern { get; private set; }

        /// <summary>
        /// 打刻されている出勤/退勤時刻を取得します。
        /// </summary>
        [JsonProperty("attendanceTimes")]
        public AttendanceTimes AttendanceTimes { get; private set; }
    }
}
