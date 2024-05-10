using Metroit.RakurakuKintai.Api.Properties;
using Metroit.RakurakuKintai.Api.Response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace Metroit.RakurakuKintai.Api.Leave
{
    /// <summary>
    /// 休暇・欠勤申請操作を提供します。
    /// </summary>
    [JsonObject]
    public class LeaveOperator : StandardOperator
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        public LeaveOperator(ApiClient client) : base(client) { }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        /// <param name="timeout">タイムアウト。</param>
        public LeaveOperator(ApiClient client, int timeout) : base(client, timeout) { }

        /// <summary>
        /// 休暇・欠勤申請を行います。
        /// </summary>
        /// <param name="attendanceDate">対象日。</param>
        /// <param name="takingLeaves">休暇/欠勤設定。</param>
        /// <param name="reason">申請理由。</param>
        /// <returns>申請結果。</returns>
        public Task<LeaveResponse> RequestLeaveAsync(DateTime attendanceDate, TakingLeave[] takingLeaves, string reason)
        {
            var request = Client.CreateRequest(ApiUriResources.LeaveRequests, Method.Post, Timeout);

            var requestData = new LeaveRequest(attendanceDate, takingLeaves, reason);
            request.AddStringBody(JsonConvert.SerializeObject(requestData), DataFormat.Json);

            return Client.ExecuteRequestAsync<LeaveResponse>(request);
        }

        /// <summary>
        /// 休暇・欠勤申請を行います。
        /// </summary>
        /// <param name="attendanceDate">対象日。</param>
        /// <param name="takingLeaves">休暇/欠勤設定。</param>
        /// <param name="reason">申請理由。</param>
        /// <returns>申請結果。</returns>
        public LeaveResponse RequestLeave(DateTime attendanceDate, TakingLeave[] takingLeaves, string reason)
        {
            var task = RequestLeaveAsync(attendanceDate, takingLeaves, reason);
            task.Wait();

            return task.Result;
        }
    }
}
