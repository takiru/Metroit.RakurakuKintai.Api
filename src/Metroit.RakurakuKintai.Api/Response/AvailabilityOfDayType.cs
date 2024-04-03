using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 曜日タイプの使用設定を提供します。
    /// </summary>
    [JsonObject]
    public class AvailabilityOfDayType
    {
        /// <summary>
        /// 平日を使用するかどうかを取得します。
        /// </summary>
        [JsonProperty("onWeekday")]
        public bool onWeekday { get; private set; }

        /// <summary>
        /// 法定休日を使用するかどうかを取得します。
        /// </summary>
        [JsonProperty("onLegalHoliday")]
        public bool onLegalHoliday { get; private set; }

        /// <summary>
        /// 定休日を使用するかどうかを取得します。
        /// </summary>
        [JsonProperty("onRegularHoliday")]
        public bool onRegularHoliday { get; private set; }
    }
}
