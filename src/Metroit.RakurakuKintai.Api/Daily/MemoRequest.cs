using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Daily
{
    /// <summary>
    /// 日付メモのリクエストを提供します。
    /// </summary>
    [JsonObject]
    public class MemoRequest
    {
        /// <summary>
        /// メモを取得します。
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; } = string.Empty;

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public MemoRequest() { }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="memo">メモ。</param>
        public MemoRequest(string memo)
        {
            Memo = memo;
        }
    }
}
