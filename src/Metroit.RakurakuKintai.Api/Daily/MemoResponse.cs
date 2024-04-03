using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Daily
{
    /// <summary>
    /// 日付メモのレスポンスを提供します。
    /// </summary>
    [JsonObject]
    public class MemoResponse
    {
        /// <summary>
        /// 記載した日付メモを取得します。
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; private set; }

        /// <summary>
        /// ユーザーIDを取得します。
        /// </summary>
        [JsonProperty("employeeId")]
        public ulong EmployeeId { get; private set; }

        /// <summary>
        /// 記載を行った対象日付を取得します。
        /// </summary>
        [JsonProperty("attendanceDate")]
        public DateTime AttendanceDate { get; private set; }
    }
}
