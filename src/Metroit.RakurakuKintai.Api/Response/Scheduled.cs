using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// スケジューリングされた勤怠設定情報を提供します。
    /// </summary>
    [JsonObject]
    public class Scheduled
    {
        /// <summary>
        /// 日付種類を取得します。
        /// </summary>
        [JsonProperty("dayType")]
        public DayType DayType { get; private set; }

        /// <summary>
        /// 勤務パターンIDを取得します。
        /// </summary>
        [JsonProperty("workingPatternId", NullValueHandling = NullValueHandling.Include)]
        public int? WorkingPatternId { get; private set; }

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
        /// 勤務パターンを保持するかどうかを取得します。
        /// </summary>
        [JsonProperty("retainsWorkingPattern")]
        public bool RetainsWorkingPattern { get; private set; }

        /// <summary>
        /// 勤務パターンを取得します。
        /// </summary>
        [JsonProperty("workingPattern", NullValueHandling = NullValueHandling.Include)]
        public WorkingPattern WorkingPattern { get; private set; }

        /// <summary>
        /// 就業時刻を取得します。
        /// </summary>
        [JsonProperty("workingTime", NullValueHandling = NullValueHandling.Include)]
        public WorkingTime WorkingTime { get; private set; }

        /// <summary>
        /// 早残となる終了時刻を取得します。
        /// </summary>
        [JsonProperty("earlyWorkableTime", NullValueHandling = NullValueHandling.Include)]
        public DateTime? EarlyWorkableTime { get; private set; }

        /// <summary>
        /// 遅残となる開始時刻を取得します。
        /// </summary>
        [JsonProperty("lateWorkableTime", NullValueHandling = NullValueHandling.Include)]
        public DateTime? LateWorkableTime { get; private set; }

        /// <summary>
        /// 休憩時刻を取得します。
        /// </summary>
        [JsonProperty("breakTimes")]
        public BreakTime[] BreakTimes { get; private set; }

        /// <summary>
        /// みなし労働の使用設定を取得します。
        /// </summary>
        [JsonProperty("deemedWorkUse")]
        public DeemedWorkUse DeemedWorkUse { get; private set; }

        /// <summary>
        /// 休暇・欠勤設定を取得します。
        /// </summary>
        [JsonProperty("takingLeaves")]
        public TakingLeave[] TakingLeaves { get; private set; }

        /// <summary>
        /// 振替休日を取得します。何もないとnull. DateTimeか？
        /// </summary>
        [JsonProperty("holidayExchange", NullValueHandling = NullValueHandling.Include)]
        public int? HolidayExchange { get; private set; }
    }
}
