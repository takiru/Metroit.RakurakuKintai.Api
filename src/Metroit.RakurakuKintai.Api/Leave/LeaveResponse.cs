using Metroit.RakurakuKintai.Api.Response;
using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Leave
{
    /// <summary>
    /// 休暇・欠勤申請のレスポンスを提供します。
    /// </summary>
    [JsonObject]
    public class LeaveResponse : ErrorResponse
    {
        /// <summary>
        /// 申請IDを取得します。
        /// </summary>
        [JsonProperty("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// 申請者情報を取得します。
        /// </summary>
        [JsonProperty("applicant")]
        public User Applicant { get; private set; }

        /// <summary>
        /// 削除された申請者かどうかを取得します。
        /// </summary>
        [JsonProperty("isApplicantDeleted")]
        public bool IsApplicantDeleted { get; private set; }

        /// <summary>
        /// 提出日時を取得します。
        /// </summary>
        [JsonProperty("time")]
        public DateTime Time { get; private set; }

        /// <summary>
        /// 申請タイプを取得します。
        /// 休暇・欠勤申請では ApplyType.Leave を取得します。
        /// </summary>
        [JsonProperty("type")]
        public ApplyType Type { get; private set; }

        /// <summary>
        /// 何が入ってくるか分からない。1 が返ってくる。
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; private set; }

        /// <summary>
        /// 最終提出日時を取得します。
        /// </summary>
        [JsonProperty("lastTime")]
        public DateTime LastTime { get; private set; }

        /// <summary>
        /// 次に行う必要がある承認階層レベルを取得します。
        /// </summary>
        [JsonProperty("nextLevel")]
        public int NextLevel { get; private set; }

        /// <summary>
        /// 承認階層レベル情報を取得します。
        /// </summary>
        [JsonProperty("histories")]
        public History[] Histories { get; private set; }

        /// <summary>
        /// 何が入ってくるか分からない。[] が返ってくる。
        /// </summary>
        [JsonProperty("availableAction")]
        public object[] AvailableAction { get; private set; }

        /// <summary>
        /// 対象日を取得します。
        /// </summary>
        [JsonProperty("attendanceDate")]
        public DateTime AttendanceDate { get; private set; }

        /// <summary>
        /// 申請した休暇/欠勤設定を取得します。
        /// </summary>
        [JsonProperty("takingLeave")]
        public TakingLeave[] TakingLeave { get; private set; }

        /// <summary>
        /// 申請理由を取得します。
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; private set; }
    }
}
