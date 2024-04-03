using Metroit.RakurakuKintai.Api.Properties;
using Metroit.RakurakuKintai.Api.Response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace Metroit.RakurakuKintai.Api.Daily
{
    /// <summary>
    /// 日に対する操作を提供します。
    /// </summary>
    public class DailyOperator : StandardOperator
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        public DailyOperator(ApiClient client) : base(client) { }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        /// <param name="timeout">タイムアウト。</param>
        public DailyOperator(ApiClient client, int timeout) : base(client, timeout) { }

        /// <summary>
        /// メモ記載を行います。
        /// </summary>
        /// <param name="date">メモ記載を行う日付。</param>
        /// <param name="memo">メモ。</param>
        /// <returns>メモ記載結果。</returns>
        public Task<MemoResponse> WriteMemoAsync(DateTime date, string memo)
        {
            var apiPath = string.Format(ApiUriResources.Memo, date);
            var request = Client.CreateRequest(apiPath, Method.Put, Timeout);

            var requestData = new MemoRequest(memo);
            request.AddStringBody(JsonConvert.SerializeObject(requestData), DataFormat.Json);

            return Client.ExecuteRequestAsync<MemoResponse>(request);
        }

        /// <summary>
        /// メモ記載を行います。
        /// </summary>
        /// <param name="date">メモ記載を行う日付。</param>
        /// <param name="memo">メモ。</param>
        /// <returns>メモ記載結果。</returns>
        public MemoResponse WriteMemo(DateTime date, string memo)
        {
            var task = WriteMemoAsync(date, memo);
            task.Wait();

            return task.Result;
        }

        /// <summary>
        /// 指定した日付範囲の勤怠状況の取得を行います。
        /// </summary>
        /// <param name="userId">ユーザーID。</param>
        /// <param name="from">開始日。</param>
        /// <param name="to">終了日。</param>
        /// <returns>指定した日付範囲の日付状況。</returns>
        public Task<DailyWorkingsResponse> GetAttendancesAsync(ulong userId, DateTime from, DateTime to)
        {
            var apiPath = string.Format(ApiUriResources.DailyWorkings, userId);
            var request = Client.CreateRequest(apiPath, Method.Get, Timeout);

            request.AddQueryParameter("from", $"{from:yyyy-MM-dd}");
            request.AddQueryParameter("to", $"{to:yyyy-MM-dd}");

            return Client.ExecuteRequestAsync<DailyWorkingsResponse>(request);
        }

        /// <summary>
        /// 指定した日付範囲の勤怠状況の取得を行います。
        /// </summary>
        /// <param name="user">ユーザー情報。</param>
        /// <param name="from">開始日。</param>
        /// <param name="to">終了日。</param>
        /// <returns>指定した日付範囲の日付状況。</returns>
        public Task<DailyWorkingsResponse> GetAttendancesAsync(User user, DateTime from, DateTime to)
        {
            return GetAttendancesAsync(user.Id, from, to);
        }

        /// <summary>
        /// 指定した日付範囲の勤怠状況の取得を行います。
        /// </summary>
        /// <param name="userId">ユーザーID。</param>
        /// <param name="from">開始日。</param>
        /// <param name="to">終了日。</param>
        /// <returns>指定した日付範囲の日付状況。</returns>
        public DailyWorkingsResponse GetAttendances(ulong userId, DateTime from, DateTime to)
        {
            var task = GetAttendancesAsync(userId, from, to);
            task.Wait();

            return task.Result;
        }

        /// <summary>
        /// 指定した日付範囲の勤怠状況の取得を行います。
        /// </summary>
        /// <param name="user">ユーザー情報。</param>
        /// <param name="from">開始日。</param>
        /// <param name="to">終了日。</param>
        /// <returns>指定した日付範囲の日付状況。</returns>
        public DailyWorkingsResponse GetAttendances(User user, DateTime from, DateTime to)
        {
            return GetAttendances(user.Id, from, to);
        }

        /// <summary>
        /// 指定した日の登録状況の取得を行います。
        /// </summary>
        /// <param name="userId">ユーザーID。</param>
        /// <param name="day">状況を取得する日付。</param>
        public Task<RegisteredStatusOfDayResponse> GetRegisteredStatusOfDayAsync(ulong userId, DateTime day)
        {
            var apiPath = string.Format(ApiUriResources.RegisteredStatusOfDay, userId, day);
            var request = Client.CreateRequest(apiPath, Method.Put, Timeout);

            return Client.ExecuteRequestAsync<RegisteredStatusOfDayResponse>(request);
        }

        /// <summary>
        /// 指定した日の登録状況の取得を行います。
        /// </summary>
        /// <param name="user">ユーザー情報。</param>
        /// <param name="day">状況を取得する日付。</param>
        public Task<RegisteredStatusOfDayResponse> GetRegisteredStatusOfDayAsync(User user, DateTime day)
        {
            return GetRegisteredStatusOfDayAsync(user.Id, day);
        }

        /// <summary>
        /// 指定した日の登録状況の取得を行います。
        /// </summary>
        /// <param name="userId">ユーザーID。</param>
        /// <param name="day">状況を取得する日付。</param>
        public RegisteredStatusOfDayResponse GetRegisteredStatusOfDay(ulong userId, DateTime day)
        {
            var task = GetRegisteredStatusOfDayAsync(userId, day);
            task.Wait();

            return task.Result;
        }

        /// <summary>
        /// 指定した日の登録状況の取得を行います。
        /// </summary>
        /// <param name="user">ユーザー情報。</param>
        /// <param name="day">状況を取得する日付。</param>
        public RegisteredStatusOfDayResponse GetRegisteredStatusOfDay(User user, DateTime day)
        {
            return GetRegisteredStatusOfDay(user.Id, day);
        }
    }
}
