using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// みなし労働の使用設定を提供します。
    /// </summary>
    [JsonObject]
    public class DeemedWorkUse
    {
        /// <summary>
        /// 所定労働時間の開始時刻前のみなし労働を行うかどうかを取得します。
        /// </summary>
        [JsonProperty("deemedWorkIn")]
        public bool deemedWorkIn { get; private set; }

        /// <summary>
        /// 所定労働時間の終了時刻後のみなし労働を行うかどうかを取得します。
        /// </summary>
        [JsonProperty("deemedWorkOut")]
        public bool deemedWorkOut { get; private set; }

        /// <summary>
        /// みなし労働とみなすスタンプ？を取得します。
        /// </summary>
        [JsonProperty("deemedHandleOfStamp")]
        public int deemedHandleOfStamp { get; private set; }

    }
}
