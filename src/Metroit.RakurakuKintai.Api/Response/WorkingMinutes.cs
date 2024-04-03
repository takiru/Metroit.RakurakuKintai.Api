using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 労働時間を提供します。
    /// </summary>
    [JsonObject]
    public class WorkingMinutes
    {
        /// <summary>
        /// 日中所定内の実労働時間を取得します。
        /// </summary>
        [JsonProperty("fixed")]
        public int Fixed { get; private set; }

        /// <summary>
        /// 日中所定外の実労働時間を取得します。
        /// </summary>
        [JsonProperty("extra")]
        public int Extra { get; private set; }

        /// <summary>
        /// 日中法定外の実労働時間を取得します。
        /// </summary>
        [JsonProperty("overtime")]
        public int Overtime { get; private set; }

        /// <summary>
        /// 深夜所定内の実労働時間を取得します。
        /// </summary>
        [JsonProperty("midnightFixed")]
        public int MidnightFixed { get; private set; }

        /// <summary>
        /// 深夜所定外の実労働時間を取得します。
        /// </summary>
        [JsonProperty("midnightExtra")]
        public int MidnightExtra { get; private set; }

        /// <summary>
        /// 深夜法定外の実労働時間を取得します。
        /// </summary>
        [JsonProperty("midnightOvertime")]
        public int MidnightOvertime { get; private set; }

        /// <summary>
        /// 実労働時間合計を取得します。
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; private set; }


    }
}
