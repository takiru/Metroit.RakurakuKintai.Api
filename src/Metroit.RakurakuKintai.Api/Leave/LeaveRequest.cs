using Metroit.RakurakuKintai.Api.Json;
using Metroit.RakurakuKintai.Api.Response;
using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Leave
{
    /// <summary>
    /// 休暇・欠勤申請のリクエストを提供します。
    /// </summary>
    [JsonObject]
    public class LeaveRequest
    {
        /// <summary>
        /// 対象日を取得します。
        /// </summary>
        [JsonProperty("attendanceDate")]
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-dd")]
        public DateTime AttendanceDate { get; }

        /// <summary>
        /// 休暇/欠勤設定を取得します。
        /// </summary>
        [JsonProperty("takingLeaves")]
        public TakingLeave[] TakingLeaves { get; }

        /// <summary>
        /// 申請理由を取得します。
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; }

        /// <summary>
        /// 新しいインスタンスを生成する。
        /// </summary>
        /// <param name="attendanceDate">対象日。</param>
        /// <param name="takingLeaves">休暇/欠勤設定。</param>
        /// <param name="reason">申請理由。</param>
        public LeaveRequest(DateTime attendanceDate, TakingLeave[] takingLeaves, string reason)
        {
            AttendanceDate = attendanceDate;
            TakingLeaves = takingLeaves;
            Reason = reason;
        }
    }
}
