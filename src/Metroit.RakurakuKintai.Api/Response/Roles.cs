using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// ユーザーのロール情報を提供します。
    /// </summary>
    [JsonObject]
    public class Roles
    {
        /// <summary>
        /// 管理者かどうかを取得します。
        /// </summary>
        [JsonProperty("isAdministrator")]
        public bool IsAdministrator { get; private set; }

        /// <summary>
        /// マネージャーかどうかを取得します。
        /// </summary>
        [JsonProperty("isManager")]
        public bool IsManager { get; private set; }

        /// <summary>
        /// 従業員かどうかを取得します。
        /// </summary>
        [JsonProperty("isEmployee")]
        public bool IsEmployee { get; private set; }

        /// <summary>
        /// 給与計算管理者かどうかを取得します。
        /// </summary>
        [JsonProperty("isPayrollAdministrator")]
        public bool IsPayrollAdministrator { get; private set; }

        /// <summary>
        /// 給与計算担当者かどうかを取得します。
        /// </summary>
        [JsonProperty("isPayrollEmployee")]
        public bool IsPayrollEmployee { get; private set; }
    }
}
