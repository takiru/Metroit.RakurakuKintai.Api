using Metroit.RakurakuKintai.Api.Properties;
using Metroit.RakurakuKintai.Api.Response;
using RestSharp;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Metroit.RakurakuKintai.Api.Masters
{
    /// <summary>
    /// マスター操作を提供します。
    /// </summary>
    public class MastersOperator : StandardOperator
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        public MastersOperator(ApiClient client) : base(client) { }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        /// <param name="timeout">タイムアウト。</param>
        public MastersOperator(ApiClient client, int timeout) : base(client, timeout) { }

        /// <summary>
        /// サービスの現在日時の取得を行います。
        /// </summary>
        /// <returns>サービスの現在日時。</returns>
        public Task<ServiceDateTimeResponse> GetServiceDateTimeAsync()
        {
            var request = Client.CreateRequest(ApiUriResources.DateTimes, Method.Get, Timeout);

            return Client.ExecuteRequestAsync<ServiceDateTimeResponse>(request);
        }

        /// <summary>
        /// サービスの現在日時の取得を行います。
        /// </summary>
        /// <returns>サービスの現在日時。</returns>
        public ServiceDateTimeResponse GetServiceDateTime()
        {
            var task = GetServiceDateTimeAsync();
            task.Wait();

            return task.Result;
        }

        /// <summary>
        /// 指定したユーザーが利用可能な勤務パターンの取得を行います。
        /// </summary>
        /// <param name="userId">ユーザーID。</param>
        /// <returns>指定したユーザーが利用可能な勤務パターン。</returns>
        public Task<WorkingPatternsResponse> GetWorkingPatternsAsync(ulong userId)
        {
            var apiPath = string.Format(ApiUriResources.WorkingPatterns, userId);
            var request = Client.CreateRequest(apiPath, Method.Get, Timeout);

            return Client.ExecuteRequestAsync<WorkingPatternsResponse>(request);
        }

        /// <summary>
        /// 指定したユーザーが利用可能な勤務パターンの取得を行います。
        /// </summary>
        /// <param name="user">ユーザー情報。</param>
        /// <returns>指定したユーザーが利用可能な勤務パターン。</returns>
        public Task<WorkingPatternsResponse> GetWorkingPatternsAsync(User user)
        {
            return GetWorkingPatternsAsync(user.Id);
        }

        /// <summary>
        /// 指定したユーザーが利用可能な勤務パターンの取得を行います。
        /// </summary>
        /// <param name="userId">ユーザーID。</param>
        /// <returns>指定したユーザーが利用可能な勤務パターン。</returns>
        public WorkingPatternsResponse GetWorkingPatterns(ulong userId)
        {
            var task = GetWorkingPatternsAsync(userId);
            task.Wait();

            return task.Result;
        }

        /// <summary>
        /// 指定したユーザーが利用可能な勤務パターンの取得を行います。
        /// </summary>
        /// <param name="user">ユーザー情報。</param>
        /// <returns>指定したユーザーが利用可能な勤務パターン。</returns>
        public WorkingPatternsResponse GetWorkingPatterns(User user)
        {
            return GetWorkingPatterns(user.Id);
        }

        /// <summary>
        /// 指定したユーザーが利用可能な休暇/欠勤区分の取得を行います。
        /// </summary>
        /// <param name="userId">ユーザーID。</param>
        /// <returns>指定したユーザーが利用可能な休暇/欠勤区分。</returns>
        public Task<ReadOnlyCollection<AvailableLeavesResponse>> GetAvailableLeavesAsync(ulong userId)
        {
            var apiPath = string.Format(ApiUriResources.LeavesAvailable, userId);
            var request = Client.CreateRequest(apiPath, Method.Get, Timeout);

            return Client.ExecuteRequestCollectionAsync<AvailableLeavesResponse>(request);
        }

        /// <summary>
        /// 指定したユーザーが利用可能な休暇/欠勤区分の取得を行います。
        /// </summary>
        /// <param name="user">ユーザー情報。</param>
        /// <returns>指定したユーザーが利用可能な休暇/欠勤区分。</returns>
        public Task<ReadOnlyCollection<AvailableLeavesResponse>> GetAvailableLeavesAsync(User user)
        {
            return GetAvailableLeavesAsync(user.Id);
        }

        /// <summary>
        /// 指定したユーザーが利用可能な休暇/欠勤区分の取得を行います。
        /// </summary>
        /// <param name="userId">ユーザーID。</param>
        /// <returns>指定したユーザーが利用可能な休暇/欠勤区分。</returns>
        public ReadOnlyCollection<AvailableLeavesResponse> GetAvailableLeaves(ulong userId)
        {
            var task = GetAvailableLeavesAsync(userId);
            task.Wait();

            return task.Result;
        }

        /// <summary>
        /// 指定したユーザーが利用可能な休暇/欠勤区分の取得を行います。
        /// </summary>
        /// <param name="user">ユーザー情報。</param>
        /// <returns>指定したユーザーが利用可能な休暇/欠勤区分。</returns>
        public ReadOnlyCollection<AvailableLeavesResponse> GetAvailableLeaves(User user)
        {
            return GetAvailableLeaves(user.Id);
        }
    }
}
