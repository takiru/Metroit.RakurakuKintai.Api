using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Users
{
    /// <summary>
    /// ログイン のレスポンスを提供します。
    /// </summary>
    [JsonObject]
    public class LoginResponse
    {
        /// <summary>
        /// CSRFトークンを取得します。
        /// </summary>
        [JsonProperty("csrfToken")]
        public string CsrfToken { get; private set; }
    }
}
