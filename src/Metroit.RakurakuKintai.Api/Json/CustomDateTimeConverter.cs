using Newtonsoft.Json.Converters;

namespace Metroit.RakurakuKintai.Api.Json
{
    /// <summary>
    /// 指定した日付書式のシリアライズを提供します。
    /// </summary>
    internal class CustomDateTimeConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="format">日付書式。</param>
        public CustomDateTimeConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}
