using Metroit.RakurakuKintai.Api.Properties;
using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

namespace Metroit.RakurakuKintai.Api.Users
{
    /// <summary>
    /// ユーザー操作を提供します。
    /// </summary>
    public class UsersOperator : StandardOperator
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        public UsersOperator(ApiClient client) : base(client) { }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        /// <param name="timeout">リクエストタイムアウトするミリ秒。</param>
        public UsersOperator(ApiClient client, int timeout) : base(client, timeout) { }

        /// <summary>
        /// ログインを行います。
        /// </summary>
        /// <param name="requestData">リクエストデータ。</param>
        /// <returns>ログイン結果。</returns>
        public Task<LoginResponse> LoginAsync(LoginRequest requestData)
        {
            var request = Client.CreateRequest(ApiUriResources.Login, Method.Post, Timeout);

            request.AddStringBody(JsonConvert.SerializeObject(requestData), DataFormat.Json);

            var task = Client.ExecuteRequestAsync<LoginResponse>(request);
            task.ContinueWith((x) =>
            {
                // ログインリクエストが正常終了していない場合はトークンをクリアして何も行わない
                if (x.Status != TaskStatus.RanToCompletion)
                {
                    Client.ClearCsrfToken();
                    return;
                }
                Client.SetCsrfToken(x.Result.CsrfToken);
            }).Wait();

            return task;
        }

        /// <summary>
        /// ログインを行います。
        /// </summary>
        /// <param name="userId">ユーザーID。</param>
        /// <param name="password">パスワード。</param>
        /// <returns>ログイン結果。</returns>
        public Task<LoginResponse> LoginAsync(string userId, string password)
        {
            return LoginAsync(new LoginRequest(userId, password));
        }

        /// <summary>
        /// ログインを行います。
        /// </summary>
        /// <param name="requestData">リクエストデータ。</param>
        /// <returns>ログイン結果。</returns>
        public LoginResponse Login(LoginRequest requestData)
        {
            var task = LoginAsync(requestData);
            task.Wait();

            return task.Result;
        }

        /// <summary>
        /// ログインを行います。
        /// </summary>
        /// <param name="userId">ユーザーID。</param>
        /// <param name="password">パスワード。</param>
        /// <returns>ログイン結果。</returns>
        public LoginResponse Login(string userId, string password)
        {
            var task = LoginAsync(userId, password);
            task.Wait();

            return task.Result;
        }

        /// <summary>
        /// ログアウトを行います。
        /// </summary>
        /// <returns>タスク。</returns>
        public Task LogoutAsync()
        {
            var request = Client.CreateRequest(ApiUriResources.Logout, Method.Delete, Timeout);

            var task = Client.ExecuteRequestAsync(request);
            task.ContinueWith(x =>
            {
                Client.ClearCsrfToken();
            }).Wait();

            return task;
        }

        /// <summary>
        /// ログアウトを行います。
        /// </summary>
        public void Logout()
        {
            var task = LogoutAsync();
            task.Wait();
        }

        /// <summary>
        /// ログインユーザーのユーザー情報の取得を行います。
        /// </summary>
        /// <returns>ログインユーザーのユーザー情報。</returns>
        public Task<UserResponse> GetMeAsync()
        {
            var request = Client.CreateRequest(ApiUriResources.EmployeesMe, Method.Get, Timeout);

            return Client.ExecuteRequestAsync<UserResponse>(request);
        }

        /// <summary>
        /// ログインユーザーのユーザー情報の取得を行います。
        /// </summary>
        /// <returns>ログインユーザーのユーザー情報。</returns>
        public UserResponse GetMe()
        {
            var task = GetMeAsync();
            task.Wait();

            return task.Result;
        }

        /// <summary>
        /// ログインユーザーの詳細なユーザー情報の取得を行います。
        /// </summary>
        /// <returns>ログインユーザーの詳細なユーザー情報。</returns>
        public Task<UserResponse> GetDetailMeAsync()
        {
            var request = Client.CreateRequest(ApiUriResources.EmployeesMeAffiliationAndAvailability, Method.Get, Timeout);

            return Client.ExecuteRequestAsync<UserResponse>(request);
        }

        /// <summary>
        /// ログインユーザーの詳細なユーザー情報の取得を行います。
        /// </summary>
        /// <returns>ログインユーザーの詳細なユーザー情報。</returns>
        public UserResponse GetDetailMe()
        {
            var task = GetDetailMeAsync();
            task.Wait();

            return task.Result;
        }
    }
}
