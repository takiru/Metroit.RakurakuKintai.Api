using Metroit.RakurakuKintai.Api.Json;
using Newtonsoft.Json;
using System;

namespace Metroit.RakurakuKintai.Api.AttendanceTime
{
    /// <summary>
    /// 勤怠時刻申請のリクエストを提供します。
    /// </summary>
    [JsonObject]
    public class AttendanceTimeRequest
    {
        /// <summary>
        /// 対象日を取得します。
        /// </summary>
        [JsonProperty("attendanceDate")]
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-dd")]
        public DateTime AttendanceDate { get; private set; }

        /// <summary>
        /// 勤怠時刻IDを取得します。
        /// 新規作成の場合は null です。
        /// </summary>
        [JsonProperty("attendanceTimeId")]
        public ulong? AttendanceTimeId { get; private set; } = null;

        /// <summary>
        /// 打刻種類を取得します。
        /// </summary>
        [JsonProperty("type")]
        public TimeRecordType Type { get; private set; } = TimeRecordType.CheckIn;

        /// <summary>
        /// 申請日時を取得します。
        /// </summary>
        [JsonProperty("time")]
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-dd HH:mm")]
        public DateTime Time { get; private set; }

        /// <summary>
        /// 申請タイプを取得します。
        /// </summary>
        [JsonProperty("operationType")]
        public OperationType OperationType { get; private set; } = OperationType.New;

        /// <summary>
        /// 申請理由を取得します。
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; private set; } = string.Empty;

        /// <summary>
        /// 新規作成の申請リクエストオブジェクトを生成します。
        /// </summary>
        /// <param name="attendanceDate">申請対象日。</param>
        /// <param name="type">打刻種類。</param>
        /// <param name="time">申請日時。</param>
        /// <param name="reason">申請理由。</param>
        /// <returns>新規作成における勤怠時刻申請のリクエストオブジェクト。</returns>
        public static AttendanceTimeRequest CreateNewRequest(DateTime attendanceDate, TimeRecordType type,
            DateTime time, string reason)
        {
            var request = new AttendanceTimeRequest();
            request.AttendanceDate = attendanceDate;
            request.AttendanceTimeId = null;
            request.Type = type;
            request.Time = time;
            request.OperationType = OperationType.New;
            request.Reason = reason;

            return request;
        }

        /// <summary>
        /// 変更の申請リクエストオブジェクトを生成します。
        /// </summary>
        /// <param name="attendanceDate">申請対象日。</param>
        /// <param name="attendanceTime">勤怠打刻情報。</param>
        /// <param name="type">打刻種類。</param>
        /// <param name="time">申請日時。</param>
        /// <param name="reason">申請理由。</param>
        /// <returns>変更における勤怠時刻申請のリクエストオブジェクト。</returns>
        public static AttendanceTimeRequest CreateModifyRequest(DateTime attendanceDate, Response.AttendanceTime attendanceTime,
            TimeRecordType type, DateTime time, string reason)
        {
            var request = new AttendanceTimeRequest();
            request.AttendanceDate = attendanceDate;
            request.AttendanceTimeId = attendanceTime.Id;
            request.Type = type;
            request.Time = time;
            request.OperationType = OperationType.Modify;
            request.Reason = reason;

            return request;
        }

        /// <summary>
        /// 削除の申請リクエストオブジェクトを生成します。
        /// </summary>
        /// <param name="attendanceDate">申請対象日。</param>
        /// <param name="attendanceTime">勤怠打刻情報。</param>
        /// <param name="reason">申請理由。</param>
        /// <returns>削除における勤怠時刻申請のリクエストオブジェクト。</returns>
        public static AttendanceTimeRequest CreateDeleteRequest(DateTime attendanceDate, Response.AttendanceTime attendanceTime,
            string reason)
        {
            var request = new AttendanceTimeRequest();
            request.AttendanceDate = attendanceDate;
            request.AttendanceTimeId = attendanceTime.Id;
            request.Type = attendanceTime.Type;
            request.Time = attendanceTime.Time;
            request.OperationType = OperationType.Delete;
            request.Reason = reason;

            return request;
        }
    }
}
