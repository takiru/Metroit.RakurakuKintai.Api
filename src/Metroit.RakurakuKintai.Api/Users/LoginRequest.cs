using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Users
{
    /// <summary>
    /// ログインのリクエストを提供します。
    /// </summary>
    [JsonObject]
    public class LoginRequest
    {
        /// <summary>
        /// ユーザーIDを取得します。
        /// </summary>
        [JsonProperty("loginId")]
        public string LoginId { get; } = string.Empty;

        /// <summary>
        /// パスワードを取得します。
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; } = string.Empty;

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="loginId">ユーザーID。</param>
        /// <param name="password">パスワード。</param>
        public LoginRequest(string loginId, string password)
        {
            LoginId = loginId;
            Password = password;
        }
    }
}
