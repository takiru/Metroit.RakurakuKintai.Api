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

        /// <summary>
        /// エラーメッセージが得られなかった時の生コンテンツを取得します。
        /// </summary>
        [JsonIgnore]
        public string Content { get; private set; } = string.Empty;

        /// <summary>
        /// エラーメッセージが得られなかった時の生コンテンツを設定します。
        /// </summary>
        /// <param name="content">生コンテンツ。</param>
        internal void SetContent(string content)
        {
            Content = content;
        }
    }
}
