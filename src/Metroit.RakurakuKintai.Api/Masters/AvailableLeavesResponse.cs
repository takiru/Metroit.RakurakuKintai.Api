using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Masters
{
    /// <summary>
    /// 利用可能な休暇/欠勤区分のレスポンスを提供します。
    /// </summary>
    [JsonObject]
    public class AvailableLeavesResponse
    {
        /// <summary>
        /// 休暇/欠勤IDを取得します。
        /// ex.) 1:年休, 2:欠勤, 3:代休, 5:特別休暇, 6:慶弔休暇 など。
        /// </summary>
        [JsonProperty("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// 休暇/欠勤コードを取得します。
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; private set; }
        
        /// <summary>
        /// 休暇/欠勤名を取得します。
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// 残日数を管理するかどうかを取得します。
        /// </summary>
        [JsonProperty("isManagedRemainings")]
        public bool IsManagedRemainings { get; private set; }

        /// <summary>
        /// 取得単位を取得します。
        /// NOTE: 0:全日, 1:半日(午前), 2:半日(午後) 固定のようだ。
        /// </summary>
        [JsonProperty("availableUnits")]
        public AvailableUnit[] AvailableUnits { get; private set; }
    }
}
