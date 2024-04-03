using Metroit.RakurakuKintai.Api.Response;
using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Masters
{
    /// <summary>
    /// 勤務パターン情報のレスポンスを提供します。
    /// </summary>
    [JsonObject]
    public class WorkingPatternsResponse
    {
        /// <summary>
        /// 勤務パターンを取得します。
        /// </summary>
        [JsonProperty("workingPatterns")]
        public WorkingPattern[] WorkingPatterns { get; private set; }
    }
}
