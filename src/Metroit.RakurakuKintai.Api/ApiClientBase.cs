using Metroit.RakurakuKintai.Api.Response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Metroit.RakurakuKintai.Api
{
    /// <summary>
    /// API通信を操作する通信の基盤クライアントを提供します。
    /// </summary>
    public abstract class ApiClientBase
    {
        /// <summary>
        /// ベースURI を取得します。
        /// </summary>
        public Uri BaseUri { get; private set; } = null;

        /// <summary>
        /// クライアント。
        /// </summary>
        public RestClient Client { get; private set; } = null;

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="baseUri">ベースURI。</param>
        protected ApiClientBase(Uri baseUri)
        {
            BaseUri = baseUri;
            var options = new RestClientOptions(BaseUri);
            options.CookieContainer = new CookieContainer();
            Client = new RestClient(options);
            ConfigureDefaultRequestHeader();
        }

        /// <summary>
        /// 新しいリクエストを生成します。
        /// </summary>
        /// <param name="path">パス。</param>
        /// <param name="method">メソッド。</param>
        /// <param name="timeout">リクエストタイムアウトするミリ秒。</param>
        /// <returns>リクエスト。</returns>
        public virtual RestRequest CreateRequest(string path, Method method, int timeout)
        {
            var request = new RestRequest(path, method);
            request.Timeout = timeout;

            return request;
        }

        /// <summary>
        /// リクエストを実行します。
        /// </summary>
        /// <param name="request">リクエスト。</param>
        /// <returns>タスク。</returns>
        public virtual async Task ExecuteRequestAsync(RestRequest request)
        {
            var response = await Client.ExecuteAsync(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                OnFailedRequest(response);
                throw response.ErrorException;
            }
        }

        /// <summary>
        /// リクエストを実行します。
        /// </summary>
        /// <param name="request">リクエスト。</param>
        /// <returns>レスポンス。</returns>
        public virtual async Task<T> ExecuteRequestAsync<T>(RestRequest request) where T : class
        {
            var response = await Client.ExecuteAsync(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                OnFailedRequest(response);
                throw response.ErrorException;
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        /// <summary>
        /// リクエスト を実行します。
        /// </summary>
        /// <param name="request">リクエスト。</param>
        /// <returns>レスポンス。</returns>
        public virtual async Task<ReadOnlyCollection<T>> ExecuteRequestCollectionAsync<T>(RestRequest request) where T : class
        {
            var response = await Client.ExecuteAsync(request);

            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                OnFailedRequest(response);
                throw response.ErrorException;
            }

            return JsonConvert.DeserializeObject<ReadOnlyCollection<T>>(response.Content);
        }

        /// <summary>
        /// リクエストが失敗した時に呼び出されます。
        /// </summary>
        /// <param name="response">レスポンスオブジェクト。</param>
        protected virtual void OnFailedRequest(RestResponse response) { }

        /// <summary>
        /// クライアントの既定リクエストヘッダー構成を行います。
        /// </summary>
        protected virtual void ConfigureDefaultRequestHeader()
        {
            // NOTE: 同名バッティングしないよう、リクエストヘッダーをすべてクリアする
            foreach (var httpHeaderName in Client.DefaultParameters.Where(x => x.Type == ParameterType.HttpHeader).Select(x => x.Name).ToList())
            {
                Client.DefaultParameters.RemoveParameter(httpHeaderName, ParameterType.HttpHeader);
            }

            Client.AddDefaultHeader("Host", BaseUri.Host);
        }
    }
}
