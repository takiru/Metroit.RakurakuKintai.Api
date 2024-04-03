using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 従業員の変更可能な設定を提供します。
    /// </summary>
    [JsonObject]
    public class EmployeeSelfModifiableSetting
    {
        /// <summary>
        /// 実際の値変更が可能かどうかを取得します。
        /// </summary>
        [JsonProperty("modifyActual")]
        public bool ModifyActual { get; private set; }

        /// <summary>
        /// スケジュールの変更が可能かどうかを取得します。
        /// </summary>
        [JsonProperty("modifySchedule")]
        public bool ModifySchedule { get; private set; }

        /// <summary>
        /// 休暇取得の変更が可能かどうかを取得します。
        /// </summary>
        [JsonProperty("modifyTakingLeave")]
        public bool ModifyTakingLeave { get; private set; }
    }
}
