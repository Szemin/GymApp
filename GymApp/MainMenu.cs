using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GymApp;

internal class Wellcome
{
    public static void ShowTList() => Trainers.ShowTrainerList();
    public static void ShowData() => Trainers.ShowTrainerData();

    public static void WellcomeCard()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("                            ");
        sb.AppendLine("^    -----Wellcome-----    ^");
        sb.AppendLine("------------ TO ------------");
        sb.AppendLine("-----     ZYZZ GYM     -----");
        sb.AppendLine("----------------------------");
        sb.AppendLine();
        string result = sb.ToString();
        Console.WriteLine(sb);
    }

}

