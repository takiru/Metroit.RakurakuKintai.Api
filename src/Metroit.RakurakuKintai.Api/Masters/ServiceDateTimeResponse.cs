using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Masters
{
    /// <summary>
    /// サービスが提供する現在日時のレスポンスを提供します。
    /// </summary>
    [JsonObject]
    public class ServiceDateTimeResponse
    {
        /// <summary>
        /// サービスの現在日時を取得します。
        /// </summary>
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; private set; }
    }
}
