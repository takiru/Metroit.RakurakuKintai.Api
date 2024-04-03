namespace Metroit.RakurakuKintai.Api
{
    /// <summary>
    /// 申請タイプを定義します。
    /// </summary>
    public enum ApplyType
    {
        /// <summary>
        /// 勤怠時刻申請 を示します。
        /// </summary>
        AttendanceTime = 2,

        /// <summary>
        /// 休暇・欠勤申請 を示します。
        /// </summary>
        Leave = 3,

        /// <summary>
        /// 残業申請 を示します。
        /// </summary>
        Overtime = 4
    }
}
