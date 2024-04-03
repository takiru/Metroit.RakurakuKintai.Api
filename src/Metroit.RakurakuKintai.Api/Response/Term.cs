using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 期間情報を提供します。
    /// </summary>
    [JsonObject]
    public class Term
    {
        /// <summary>
        /// 年を取得します。
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; private set; }

        /// <summary>
        /// 月を取得します。
        /// </summary>
        [JsonProperty("month")]
        public int Month { get; private set; }

        /// <summary>
        /// 対象月度の開始日を取得します。
        /// </summary>
        [JsonProperty("from")]
        public DateTime From { get; private set; }

        /// <summary>
        /// 対象月度の終了日を取得します。
        /// </summary>
        [JsonProperty("to")]
        public DateTime To { get; private set; }

        /// <summary>
        /// 対象月度の開始日を取得します。
        /// QUESTION: from との違いがわからない。
        /// </summary>
        [JsonProperty("startDate")]
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// 対象月度の終了日を取得します。
        /// QUESTION: to との違いがわからない。
        /// </summary>
        [JsonProperty("endDate")]
        public DateTime EndDate { get; private set; }

        /// <summary>
        /// 締日を取得します。
        /// </summary>
        [JsonProperty("closingDate")]
        public int ClosingDate { get; private set; }

        /// <summary>
        /// 締め状態を取得します。
        /// </summary>
        [JsonProperty("closingStatus")]
        public ClosingStatus ClosingStatus { get; private set; }
    }
}
