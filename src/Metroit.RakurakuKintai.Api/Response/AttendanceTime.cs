using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 出退勤情報を提供します。
    /// </summary>
    [JsonObject]
    public class AttendanceTime
    {
        /// <summary>
        /// 勤務時刻IDを取得します。
        /// </summary>
        [JsonProperty("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// 打刻種類を取得します。
        /// </summary>
        [JsonProperty("type")]
        public TimeRecordType Type { get; private set; }

        /// <summary>
        /// 申請日時を取得します。
        /// </summary>
        [JsonProperty("time")]
        public DateTime Time { get; private set; }

        /// <summary>
        /// 打刻IDを取得します。
        /// 打刻を行っていない場合、0 が返却されます。
        /// </summary>
        [JsonProperty("timeRecordId")]
        public ulong TimeRecordId { get; private set; }

        /// <summary>
        /// わからん。
        /// </summary>
        [JsonProperty("requested")]
        public bool Requested { get; private set; }
    }
}
