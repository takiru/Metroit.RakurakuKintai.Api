using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 取得単位の対象時刻を提供します。
    /// </summary>
    [JsonObject]
    public class TakingTimePeriod
    {
        /// <summary>
        /// 開始時刻を取得します。
        /// 時間指定可能なマスタ設定がされていると取得・設定可能？
        /// レスポンス時は 00:00 固定。
        /// </summary>
        [JsonProperty("startTime")]
        public DateTime StartTime { get; private set; }

        /// <summary>
        /// 終了時刻を取得します。
        /// 時間指定可能なマスタ設定がされていると取得・設定可能？
        /// レスポンス時は 00:00 固定。
        /// </summary>
        [JsonProperty("endTime")]
        public DateTime EndTime { get; private set; }

        /// <summary>
        /// 新しいインスタンスを生成する。
        /// デシリアライズ用。
        /// </summary>
        public TakingTimePeriod() { }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="startTime">開始時刻。</param>
        /// <param name="endTime">終了時刻。</param>
        public TakingTimePeriod(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
