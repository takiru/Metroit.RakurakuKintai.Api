// See https://aka.ms/new-console-template for more information

using Metroit.RakurakuKintai.Api;
using Metroit.RakurakuKintai.Api.Response;

// APIクライアントを生成
var client = new ApiClient("");
try
{
    // ログインする
    var resLogin = client.Users.Login("", "");

    // ユーザー情報取得する
    var res2 = client.Users.GetMe();
    //var res3 = client.Users.GetDetailMe();

    //// 出勤/退勤する
    //var res4 = client.TimeRecord.CheckIn();
    //var res5 = client.TimeRecord.CheckOut();

    //// メモ記載する
    //var res6 = client.Daily.WriteMemo(new DateTime(2024, 3, 30), "これはテスト");

    //// 日付情報取得する
    //var res7 = client.Daily.GetAttendances(res2.Id, new DateTime(2024, 4, 1), new DateTime(2024, 4, 3));

    //// 勤務パターン取得する
    //var res8 = client.Masters.GetWorkingPatterns(res2.Id);

    // 休暇・欠勤区分取得する
    var res9 = client.Masters.GetAvailableLeaves(res2.Id);

    //// サーバー日時取得する
    //var res10 = client.Masters.GetServiceDateTime();

    //// 出勤の打刻申請する
    //var res11 = client.AttendanceTime.RequestNew(new DateTime(2024, 4, 2),
    //    TimeRecordType.CheckIn, new DateTime(2024, 4, 2, 9, 0, 0), "出勤打刻のテスト申請");

    //// 対象日の打刻状況確認する
    //var res12 = client.Daily.GetRegisteredStatusOfDay(res2, new DateTime(2024, 3, 29));

    //// 残業申請する
    //var res13 = client.Overtime.RequestOvertime(new DateTime(2024, 5, 23), OvertimeType.Late,
    //    new DateTime(2024, 5, 24, 2, 30, 0), "残業申請のテスト申請");

    //// 休暇・欠勤申請する
    //var leaveId = res9.Where(x => x.Name == "年休").Select(x => x.Id).FirstOrDefault();
    //var res15 = client.Leave.RequestLeave(new DateTime(2024, 4, 2), 
    //    new[] { new TakingLeave(leaveId, AvailableUnit.OneDay, null) }, "休暇・欠勤のテスト申請");

    //// ログアウト
    //client.Users.Logout();

    Console.WriteLine("Completed!");
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine("Exception!");
    Console.WriteLine(ex.Message);
    if (client.Error != null)
    {
        foreach (var error in client.Error.Errors)
        {
            Console.WriteLine(error);
        }
    }
    Console.ReadLine();
    return;
}