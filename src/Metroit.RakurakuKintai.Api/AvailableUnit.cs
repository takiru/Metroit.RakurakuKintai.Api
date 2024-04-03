namespace Metroit.RakurakuKintai.Api
{
    /// <summary>
    /// 休暇・欠勤の取得単位を定義します。
    /// </summary>
    public enum AvailableUnit
    {
        /// <summary>
        /// 全日 を示します。
        /// </summary>
        OneDay = 0,

        /// <summary>
        /// 半日(午前) を示します。
        /// </summary>
        AM = 1,

        /// <summary>
        /// 半日(午後) を示します。
        /// </summary>
        PM = 2
    }
}
