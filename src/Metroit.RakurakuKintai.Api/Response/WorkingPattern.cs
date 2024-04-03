using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 勤務パターンを取得します。
    /// </summary>
    [JsonObject]
    public class WorkingPattern
    {
        /// <summary>
        /// 勤務パターンIDを取得します。
        /// </summary>
        [JsonProperty("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// 勤務パターンコードを取得します。
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; private set; }

        /// <summary>
        /// 勤務パターン名を取得します。
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// 勤務時刻を取得します。
        /// </summary>
        [JsonProperty("patternOfNoLeaves")]
        public PatternOfTimes PatternOfNoLeaves { get; private set; }

        /// <summary>
        /// みなし労働の使用設定を取得します。
        /// </summary>
        [JsonProperty("deemedWorkUse")]
        public DeemedWorkUse DeemedWorkUse { get; private set; }

        /// <summary>
        /// 午前休暇のパターン設定を取得します。
        /// </summary>
        [JsonProperty("patternOfAmLeave")]
        public PatternOfTimes PatternOfAmLeave { get; private set; }

        /// <summary>
        /// 午後休暇のパターン設定を取得します。
        /// </summary>
        [JsonProperty("patternOfPmLeave")]
        public PatternOfTimes PatternOfPmLeave { get; private set; }

        /// <summary>
        /// 曜日タイプの使用設定を取得します。
        /// </summary>
        [JsonProperty("availabilityOfDayType")]
        public AvailabilityOfDayType AvailabilityOfDayType { get; private set; }
    }
}
