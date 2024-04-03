using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// ユーザー情報を提供します。
    /// </summary>
    [JsonObject]
    public class User
    {
        /// <summary>
        /// ユーザーIDを取得します。
        /// </summary>
        [JsonProperty("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// ユーザーコードを取得します。
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; private set; }

        /// <summary>
        /// ユーザー名を取得します。
        /// </summary>
        [JsonProperty("name")]
        public UserName Name { get; private set; }

        /// <summary>
        /// 所属部署名を取得します。
        /// </summary>
        [JsonProperty("departmentName", NullValueHandling = NullValueHandling.Ignore)]
        public string DepartmentName { get; private set; }

        /// <summary>
        /// 役職名を取得します。
        /// </summary>
        [JsonProperty("positionName", NullValueHandling = NullValueHandling.Ignore)]
        public string PositionName { get; private set; }

        /// <summary>
        /// ロールを取得します。
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public Roles Roles { get; private set; }

        /// <summary>
        /// 代理承認者を設定できるかどうかを取得します。
        /// </summary>
        [JsonProperty("isSetProxyApprover", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSetProxyApprover { get; private set; }

        /// <summary>
        /// 時間記録ルールを取得します。
        /// </summary>
        [JsonProperty("timeRecordRule", NullValueHandling = NullValueHandling.Ignore)]
        public TimeRecordRule TimeRecordRule { get; private set; }

        /// <summary>
        /// 従業員の変更可能な設定を取得します。
        /// </summary>
        [JsonProperty("employeeSelfModifiableSetting", NullValueHandling = NullValueHandling.Ignore)]
        public EmployeeSelfModifiableSetting EmployeeSelfModifiableSetting { get; private set; }
    }
}
