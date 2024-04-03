using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// なんだかわからん。
    /// </summary>
    [JsonObject]
    public class CustomItem
    {
        /// <summary>
        /// なんだかわからん。
        /// </summary>
        [JsonProperty("id")]
        public long id { get; private set; }

        /// <summary>
        /// なんだかわからん。
        /// </summary>
        [JsonProperty("value")]
        public long value { get; private set; }

        /// <summary>
        /// なんだかわからん。
        /// </summary>
        [JsonProperty("isError")]
        public bool isError { get; private set; }
    }
}
