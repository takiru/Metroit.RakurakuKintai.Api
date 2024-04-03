using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// ユーザー名を提供します。
    /// </summary>
    [JsonObject]
    public class UserName
    {
        /// <summary>
        /// 苗字を取得します。
        /// </summary>
        [JsonProperty("last")]
        public string Last { get; private set; }

        /// <summary>
        /// 名前を取得します。
        /// </summary>
        [JsonProperty("first")]
        public string First { get; private set; }
    }
}
