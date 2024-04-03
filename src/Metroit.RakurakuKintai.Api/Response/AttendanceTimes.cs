using Newtonsoft.Json;

namespace Metroit.RakurakuKintai.Api.Response
{
    /// <summary>
    /// 打刻されている出勤/退勤時刻を提供します。
    /// </summary>
    public class AttendanceTimes
    {
        /// <summary>
        /// 出勤時刻を取得します。
        /// </summary>
        [JsonProperty("workIn")]
        public WorkTime[] WorkIn { get; private set; }

        /// <summary>
        /// 退勤時刻を取得します。
        /// </summary>
        [JsonProperty("workOut")]
        public WorkTime[] WorkOut { get; private set; }
    }
}
