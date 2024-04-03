using Metroit.RakurakuKintai.Api.Response;
using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Daily
{
    /// <summary>
    /// 日の登録状況のレスポンスを提供します。
    /// </summary>
    [JsonObject]
    public class RegisteredStatusOfDayResponse
    {
        /// <summary>
        /// 実際の打刻状況を取得します。
        /// </summary>
        [JsonProperty("actual")]
        public Actual Actual { get; private set; }

        /// <summary>
        /// スケジューリングされた勤怠設定情報を取得します。
        /// </summary>
        [JsonProperty("scheduled")]
        public Scheduled Scheduled { get; private set; }

        /// <summary>
        /// 勤務時刻から算出された各種時間を取得します。
        /// </summary>
        [JsonProperty("calculated")]
        public Calculated Calculated { get; private set; }

        /// <summary>
        /// なんだかわからん。
        /// </summary>
        [JsonProperty("customItems")]
        public CustomItem[] CustomItems { get; private set; }

        /// <summary>
        /// 日が含まれる期間情報を取得します。
        /// </summary>
        [JsonProperty("term")]
        public Term Term { get; private set; }

        /// <summary>
        /// メモを取得します。
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; private set; }

        /// <summary>
        /// エラー種類を取得します。
        /// </summary>
        [JsonProperty("systemErrors")]
        public string[] SystemErrors { get; private set; }

        /// <summary>
        /// 警告種類を取得します。
        /// </summary>
        [JsonProperty("systemWarnings")]
        public string[] SystemWarnings { get; private set; }

        /// <summary>
        /// ユーザー情報を取得します。
        /// </summary>
        [JsonProperty("employee")]
        public User Employee { get; private set; }
    }
}
