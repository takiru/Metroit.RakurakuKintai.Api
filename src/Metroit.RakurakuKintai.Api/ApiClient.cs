using Metroit.RakurakuKintai.Api.AttendanceTime;
using Metroit.RakurakuKintai.Api.Daily;
using Metroit.RakurakuKintai.Api.Leave;
using Metroit.RakurakuKintai.Api.Masters;
using Metroit.RakurakuKintai.Api.Properties;
using Metroit.RakurakuKintai.Api.Response;
using Metroit.RakurakuKintai.Api.TimeRecord;
using Metroit.RakurakuKintai.Api.Users;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace Metroit.RakurakuKintai.Api
{
    /// <summary>
    /// 楽々勤怠 を操作する基本的な通信クライアントを提供します。
    /// </summary>
    public class ApiClient : ApiClientBase
    {
        /// <summary>
        /// アカウントキーを取得します。
        /// </summary>
        public string AccountKey { get; private set; } = string.Empty;

        /// <summary>
        /// CSRFトークンを取得します。
        /// </summary>
        public string CsrfToken { get; private set; } = string.Empty;

        /// <summary>
        /// リクエストのエラー内容を取得します。
        /// </summary>
        public ErrorResponse Error { get; private set; } = new ErrorResponse();

        private UsersOperator _users = null;

        /// <summary>
        /// ユーザー操作を取得します。
        /// </summary>
        public UsersOperator Users => _users == null ? new UsersOperator(this) : _users;

        private TimeRecordOperator _timeRecord = null;

        /// <summary>
        /// 打刻操作を取得します。
        /// </summary>
        public TimeRecordOperator TimeRecord => _timeRecord == null ? new TimeRecordOperator(this) : _timeRecord;

        private DailyOperator _daily = null;

        /// <summary>
        /// 日付操作を取得します。
        /// </summary>
        public DailyOperator Daily => _daily == null ? new DailyOperator(this) : _daily;

        private MastersOperator _masters = null;

        /// <summary>
        /// マスター操作を取得します。
        /// </summary>
        public MastersOperator Masters => _masters == null ? new MastersOperator(this) : _masters;

        private AttendanceTimeOperator _attendanceTime = null;

        /// <summary>
        /// 勤怠時刻申請操作を取得します。
        /// </summary>
        public AttendanceTimeOperator AttendanceTime => _attendanceTime == null ? new AttendanceTimeOperator(this) : _attendanceTime;

        private OvertimeOperator _overtime = null;

        /// <summary>
        /// 残業申請操作を取得します。
        /// </summary>
        public OvertimeOperator Overtime => _overtime == null ? new OvertimeOperator(this) : _overtime;

        private LeaveOperator _leave = null;

        /// <summary>
        /// 休暇・欠勤申請操作を取得します。
        /// </summary>
        public LeaveOperator Leave => _leave == null ? new LeaveOperator(this) : _leave;

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="accountKey">アカウントキー。</param>
        public ApiClient(string accountKey) : base(new Uri(ApiUriResources.BaseUri))
        {
            AccountKey = accountKey;
        }

        /// <summary>
        /// 新しいリクエストを生成します。
        /// </summary>
        /// <param name="path">パス。</param>
        /// <param name="method">メソッド。</param>
        /// <param name="timeout">リクエストタイムアウトするミリ秒。</param>
        /// <returns>リクエスト。</returns>
        public override sealed RestRequest CreateRequest(string path, Method method, int timeout)
        {
            var requestUriPath = string.Format(ApiUriResources.ApiRelativeUriPath, AccountKey);
            if (!requestUriPath.StartsWith("/"))
            {
                requestUriPath = "/" + requestUriPath;
            }
            if (!requestUriPath.EndsWith("/"))
            {
                requestUriPath += "/";
            }
            if (path.StartsWith("/"))
            {
                requestUriPath += path.Substring(1);
            }
            else
            {
                requestUriPath += path;
            }

            var request = base.CreateRequest(requestUriPath, method, timeout);

            // ログイン済みの時はCSRFトークンを付与する
            if (!string.IsNullOrEmpty(CsrfToken))
            {
                request.AddHeader("X-Csrf-Token", CsrfToken);
            }

            return request;
        }

        /// <summary>
        /// リクエストが失敗した時に呼び出されます。
        /// </summary>
        /// <param name="response">レスポンスオブジェクト。</param>
        protected override sealed void OnFailedRequest(RestResponse response)
        {
            Error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
        }

        /// <summary>
        /// ログイン認証が行われたCSRFトークンを設定します。
        /// </summary>
        /// <param name="csrfToken">CSRFトークン。</param>
        internal void SetCsrfToken(string csrfToken)
        {
            CsrfToken = csrfToken;
        }

        /// <summary>
        /// CSRFトークンをクリアします。
        /// </summary>
        internal void ClearCsrfToken()
        {
            CsrfToken = string.Empty;
        }
    }
}
