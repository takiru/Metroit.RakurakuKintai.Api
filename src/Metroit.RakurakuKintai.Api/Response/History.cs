using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 承認状態を提供します。
    /// </summary>
    [JsonObject]
    public class History
    {
        /// <summary>
        /// 承認階層レベルを取得します。
        /// </summary>
        [JsonProperty("level")]
        public int Level { get; private set; }

        /// <summary>
        /// 最新の承認操作が行われたレベルを取得します。
        /// 一次承認操作が行われていない場合 0 を取得します。
        /// </summary>
        [JsonProperty("action")]
        public int Action { get; private set; }

        /// <summary>
        /// 承認日時を取得します。
        /// 一次承認操作が行われていない場合 null を取得します。
        /// </summary>
        [JsonProperty("time")]
        public DateTime? Time { get; private set; }

        /// <summary>
        /// 最新の承認操作によるコメントを取得します。
        /// 一次承認操作が行われていない場合 空 を取得します。
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; private set; }

        /// <summary>
        /// ロールIDを取得します。
        /// </summary>
        [JsonProperty("roleId")]
        public int RoleId { get; private set; }

        /// <summary>
        /// 最新の承認操作を行ったユーザーを取得します。
        /// 一次承認操作が行われていない場合 null を取得します。
        /// </summary>
        [JsonProperty("operator")]
        public User Operator { get; private set; }

        /// <summary>
        /// 代理承認者による操作かどうかを取得します。
        /// </summary>
        [JsonProperty("isOperatedByProxyApprover")]
        public bool IsOperatedByProxyApprover { get; private set; }

        /// <summary>
        /// 承認者情報を取得します。
        /// </summary>
        [JsonProperty("approvers")]
        public User[] Approvers { get; private set; }

        /// <summary>
        /// 承認者の人数を取得します。
        /// </summary>
        [JsonProperty("numberOfApprovers")]
        public int NumberOfApprovers { get; private set; }

    }
}
