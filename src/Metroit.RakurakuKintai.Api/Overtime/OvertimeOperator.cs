using Metroit.RakurakuKintai.Api.Overtime;
using Metroit.RakurakuKintai.Api.Properties;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace Metroit.RakurakuKintai.Api.AttendanceTime
{
    /// <summary>
    /// 残業申請操作を提供します。
    /// </summary>
    public class OvertimeOperator : StandardOperator
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        public OvertimeOperator(ApiClient client) : base(client) { }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        /// <param name="timeout">タイムアウト。</param>
        public OvertimeOperator(ApiClient client, int timeout) : base(client, timeout) { }

        /// <summary>
        /// 残業申請を行います。
        /// </summary>
        /// <param name="attendanceDate">対象日。</param>
        /// <param name="overtimeType">残業種類。</param>
        /// <param name="time">残業時刻。</param>
        /// <param name="reason">申請理由。</param>
        /// <returns>申請結果。</returns>
        public Task<OvertimeResponse> RequestOvertimeAsync(DateTime attendanceDate, OvertimeType overtimeType, DateTime time, string reason)
        {
            var request = Client.CreateRequest(ApiUriResources.OvertimeRequests, Method.Post, Timeout);

            var requestData = new OvertimeRequest(attendanceDate, overtimeType, time, reason);
            request.AddStringBody(JsonConvert.SerializeObject(requestData), DataFormat.Json);

            return Client.ExecuteRequestAsync<OvertimeResponse>(request);
        }

        /// <summary>
        /// 残業申請を行います。
        /// </summary>
        /// <param name="attendanceDate">対象日。</param>
        /// <param name="overtimeType">残業種類。</param>
        /// <param name="time">残業時刻。</param>
        /// <param name="reason">申請理由。</param>
        /// <returns>申請結果。</returns>
        public OvertimeResponse RequestOvertime(DateTime attendanceDate, OvertimeType overtimeType, DateTime time, string reason)
        {
            var task = RequestOvertimeAsync(attendanceDate, overtimeType, time, reason);
            task.Wait();

            return task.Result;
        }
    }
}
