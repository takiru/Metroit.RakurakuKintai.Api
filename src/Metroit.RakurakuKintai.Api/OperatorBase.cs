namespace Metroit.RakurakuKintai.Api
{
    /// <summary>
    /// 操作命令の基盤情報を提供します。
    /// </summary>
    public abstract class OperatorBase<T> where T : ApiClientBase
    {
        /// <summary>
        /// API通信を操作する通信クライアントを取得します。
        /// </summary>
        protected T Client { get; } = null;

        /// <summary>
        /// リクエストタイムアウトするミリ秒を取得します。
        /// </summary>
        public int Timeout { get; } = 0;

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">基本的な通信クライアント。</param>
        protected OperatorBase(T client)
        {
            Client = client;
        }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">基本的な通信クライアント。</param>
        /// <param name="timeout">リクエストタイムアウトするミリ秒。</param>
        protected OperatorBase(T client, int timeout) : this(client)
        {
            Timeout = timeout;
        }
    }
}
