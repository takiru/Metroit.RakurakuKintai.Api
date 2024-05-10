using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 休暇/欠勤設定を提供します。
    /// </summary>
    [JsonObject]
    public class TakingLeave
    {
        /// <summary>
        /// 休暇/欠勤IDを取得します。
        /// MastersOperator::GetAvailableLeaves() で取得した 休暇/欠勤ID となります。
        /// </summary>
        [JsonProperty("id")]
        public ulong Id { get; private set; }

        /// <summary>
        /// 休暇/欠勤名を取得します。
        /// 申請時は利用できません。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; private set; }

        /// <summary>
        /// 申請の結果、どのような操作が行われたかを取得します。
        /// 申請時は利用できません。
        /// </summary>
        [JsonProperty("operationType", NullValueHandling = NullValueHandling.Ignore)]
        public OperationType? operationType { get; private set; }

        /// <summary>
        /// 取得単位を取得します。
        ///  MastersOperator::GetAvailableLeaves() で取得した 取得単位 となります。
        /// </summary>
        [JsonProperty("takingLeaveUnit")]
        public AvailableUnit TakingLeaveUnit { get; private set; }

        /// <summary>
        /// 取得単位の対象時刻を取得します。
        /// 申請時は null 固定？時間指定可能なマスタ設定がされていると設定可能？
        /// </summary>
        [JsonProperty("takingTimePeriod")]
        public TakingTimePeriod TakingTimePeriod { get; private set; }

        /// <summary>
        /// 新しいインスタンスを生成する。
        /// デシリアライズ用。
        /// </summary>
        private TakingLeave() { }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="id">休暇/欠勤ID。</param>
        /// <param name="takingLeaveUnit">取得単位。</param>
        /// <param name="takingTimePeriod">取得単位の対象時刻。</param>
        public TakingLeave(ulong id, AvailableUnit takingLeaveUnit, TakingTimePeriod takingTimePeriod)
        {
            Id = id;
            TakingLeaveUnit = takingLeaveUnit;
            TakingTimePeriod = takingTimePeriod;
        }
    }
}
