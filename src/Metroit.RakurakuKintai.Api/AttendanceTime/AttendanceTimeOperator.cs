using Metroit.RakurakuKintai.Api.Properties;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace Metroit.RakurakuKintai.Api.AttendanceTime
{
    /// <summary>
    /// 勤怠時刻申請操作を提供します。
    /// </summary>
    public class AttendanceTimeOperator : StandardOperator
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        public AttendanceTimeOperator(ApiClient client) : base(client) { }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        /// <param name="timeout">タイムアウト。</param>
        public AttendanceTimeOperator(ApiClient client, int timeout) : base(client, timeout) { }

        /// <summary>
        /// 新規作成の申請を行います。
        /// </summary>
        /// <param name="attendanceDate">申請対象日。</param>
        /// <param name="type">打刻種類。</param>
        /// <param name="time">申請日時。</param>
        /// <param name="reason">申請理由。</param>
        /// <returns>申請結果。</returns>
        public Task<AttendanceTimeResponse> RequestNewAsync(DateTime attendanceDate, TimeRecordType type, DateTime time, string reason)
        {
            var request = Client.CreateRequest(ApiUriResources.AttendanceTimeRequests, Method.Post, Timeout);

            var requestData = AttendanceTimeRequest.CreateNewRequest(attendanceDate, type, time, reason);
            request.AddStringBody(JsonConvert.SerializeObject(requestData), DataFormat.Json);

            return Client.ExecuteRequestAsync<AttendanceTimeResponse>(request);
        }

        /// <summary>
        /// 新規作成の申請を行います。
        /// </summary>
        /// <param name="attendanceDate">申請対象日。</param>
        /// <param name="type">打刻種類。</param>
        /// <param name="time">申請日時。</param>
        /// <param name="reason">申請理由。</param>
        /// <returns>申請結果。</returns>
        public AttendanceTimeResponse RequestNew(DateTime attendanceDate, TimeRecordType type, DateTime time, string reason)
        {
            var task = RequestNewAsync(attendanceDate, type, time, reason);
            task.Wait();

            return task.Result;
        }

        /// <summary>
        /// 変更の申請を行います。
        /// </summary>
        /// <param name="attendanceDate">申請対象日。</param>
        /// <param name="attendanceTime">勤怠打刻情報。</param>
        /// <param name="type">打刻種類。</param>
        /// <param name="time">申請日時。</param>
        /// <param name="reason">申請理由。</param>
        /// <returns>申請結果。</returns>
        public Task<AttendanceTimeResponse> RequestModifyAsync(DateTime attendanceDate, Response.AttendanceTime attendanceTime,
            TimeRecordType type, DateTime time, string reason)
        {
            var request = Client.CreateRequest(ApiUriResources.AttendanceTimeRequests, Method.Post, Timeout);

            var requestData = AttendanceTimeRequest.CreateModifyRequest(attendanceDate, attendanceTime, type, time, reason);
            request.AddStringBody(JsonConvert.SerializeObject(requestData), DataFormat.Json);

            return Client.ExecuteRequestAsync<AttendanceTimeResponse>(request);
        }

        /// <summary>
        /// 変更の申請を行います。
        /// </summary>
        /// <param name="attendanceDate">申請対象日。</param>
        /// <param name="attendanceTime">勤怠打刻情報。</param>
        /// <param name="type">打刻種類。</param>
        /// <param name="time">申請日時。</param>
        /// <param name="reason">申請理由。</param>
        /// <returns>申請結果。</returns>
        public AttendanceTimeResponse RequestModify(DateTime attendanceDate, Response.AttendanceTime attendanceTime,
            TimeRecordType type, DateTime time, string reason)
        {
            var task = RequestModifyAsync(attendanceDate, attendanceTime, type, time, reason);
            task.Wait();

            return task.Result;
        }

        /// <summary>
        /// 削除の申請を行います。
        /// </summary>
        /// <param name="attendanceDate">申請対象日。</param>
        /// <param name="attendanceTime">勤怠打刻情報。</param>
        /// <param name="reason">申請理由。</param>
        /// <returns>申請結果。</returns>
        public Task<AttendanceTimeResponse> RequestDeleteAsync(DateTime attendanceDate, Response.AttendanceTime attendanceTime,
            string reason)
        {
            var request = Client.CreateRequest(ApiUriResources.AttendanceTimeRequests, Method.Post, Timeout);

            var requestData = AttendanceTimeRequest.CreateDeleteRequest(attendanceDate, attendanceTime, reason);
            request.AddStringBody(JsonConvert.SerializeObject(requestData), DataFormat.Json);

            return Client.ExecuteRequestAsync<AttendanceTimeResponse>(request);
        }

        /// <summary>
        /// 削除の申請を行います。
        /// </summary>
        /// <param name="attendanceDate">申請対象日。</param>
        /// <param name="attendanceTime">勤怠打刻情報。</param>
        /// <param name="reason">申請理由。</param>
        /// <returns>申請結果。</returns>
        public AttendanceTimeResponse RequestDelete(DateTime attendanceDate, Response.AttendanceTime attendanceTime,
            string reason)
        {
            var task = RequestDeleteAsync(attendanceDate, attendanceTime, reason);
            task.Wait();

            return task.Result;
        }
    }
}
