using Metroit.RakurakuKintai.Api.Properties;
using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

namespace Metroit.RakurakuKintai.Api.TimeRecord
{
    /// <summary>
    /// 打刻操作を提供します。
    /// </summary>
    public class TimeRecordOperator : StandardOperator
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        public TimeRecordOperator(ApiClient client) : base(client) { }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="client">通信クライアント。</param>
        /// <param name="timeout">リクエストタイムアウトするミリ秒。</param>
        public TimeRecordOperator(ApiClient client, int timeout) : base(client, timeout) { }

        /// <summary>
        /// 出勤打刻を行います。
        /// </summary>
        /// <returns>打刻結果。</returns>
        public Task<TimeRecordResponse> CheckInAsync()
        {
            return ExecuteCheck(TimeRecordType.CheckIn);
        }

        /// <summary>
        /// 出勤打刻を行います。
        /// </summary>
        /// <returns>打刻結果。</returns>
        public TimeRecordResponse CheckIn()
        {
            var task = CheckInAsync();
            task.Wait();

            return task.Result;
        }

        /// <summary>
        /// 退勤打刻を行います。
        /// </summary>
        /// <returns>打刻結果。</returns>
        public Task<TimeRecordResponse> CheckOutAsync()
        {
            return ExecuteCheck(TimeRecordType.CheckOut);
        }

        /// <summary>
        /// 退勤打刻を行います。
        /// </summary>
        /// <returns>打刻結果。</returns>
        public TimeRecordResponse CheckOut()
        {
            var task = CheckOutAsync();
            task.Wait();

            return task.Result;
        }

        /// <summary>
        /// 打刻を行う。
        /// </summary>
        /// <param name="type">打刻種類。</param>
        /// <returns>打刻結果。</returns>
        private Task<TimeRecordResponse> ExecuteCheck(TimeRecordType type)
        {
            var request = Client.CreateRequest(ApiUriResources.TimeRecords, Method.Post, Timeout);

            var requestData = new TimeRecordRequest(type);
            request.AddStringBody(JsonConvert.SerializeObject(requestData), DataFormat.Json);

            return Client.ExecuteRequestAsync<TimeRecordResponse>(request);
        }
    }
}
