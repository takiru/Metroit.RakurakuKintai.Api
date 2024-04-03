using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// エラー時のレスポンス情報 を提供します。
    /// </summary>
    [JsonObject]
    public class ErrorResponse
    {
        /// <summary>
        /// エラーメッセージを取得します。
        /// </summary>
        [JsonProperty("errors")]
        public string[] Errors { get; private set; } = new string[0];
    }
}
