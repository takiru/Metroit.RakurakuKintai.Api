using Metroit.RakurakuKintai.Api.Response;
using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.AttendanceTime
{
    /// <summary>
    /// 勤怠時刻申請のレスポンスを提供します。
    /// </summary>
    [JsonObject]
    public class AttendanceTimeResponse : ErrorResponse
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
        /// 勤怠時刻申請では ApplyType.AttendanceTime を取得します。
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
        /// 勤怠時刻IDを取得します。
        /// 新規の場合は 0 を取得します。
        /// </summary>
        [JsonProperty("attendanceTimeId")]
        public int AttendanceTimeId { get; private set; }

        /// <summary>
        /// 申請前の勤怠時刻情報を取得します。
        /// 新規作成の場合は null, 変更の場合は変更前の情報, 削除の場合は削除前の情報が取得できます。
        /// </summary>
        [JsonProperty("attendanceTimeBeforeRequest")]
        public AttendanceTimeBeforeRequest AttendanceTimeBeforeRequest { get; private set; }

        /// <summary>
        /// 登録後の情報。新規・変更は新規・変更後の情報。削除は削除前の情報。
        /// 新規作成/変更の場合は新規作成/変更後の情報, 削除の場合は削除前の情報が取得できます。
        /// </summary>
        [JsonProperty("attendanceTimeAfterRequest")]
        public AttendanceTimeAfterRequest AttendanceTimeAfterRequest { get; private set; }

        /// <summary>
        /// 申請タイプを取得します。
        /// </summary>
        [JsonProperty("operationType")]
        public OperationType OperationType { get; private set; }

        /// <summary>
        /// 申請理由を取得します。
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; private set; }
    }
}
