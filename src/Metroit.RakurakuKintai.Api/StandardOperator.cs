namespace Metroit.RakurakuKintai.Api
{
    /// <summary>
    /// 標準的な操作命令の基盤情報を提供します。
    /// </summary>
    public abstract class StandardOperator : OperatorBase<ApiClient>
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">基本的な通信クライアント。</param>
        protected StandardOperator(ApiClient client) : base(client) { }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">基本的な通信クライアント。</param>
        /// <param name="timeout">リクエストのタイムアウト時間。</param>
        protected StandardOperator(ApiClient client, int timeout) : base(client, timeout) { }
    }
}
