using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace GymApp;

    internal class Trainers : IPersonalTrainers
    {
        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public int MrOlimpiaWins { get; set; }
        public string Message { get; set; }

    public Trainers(string name, string country, int wins, string message)
    {
        Name = name;
        CountryOfOrigin = country;
        MrOlimpiaWins = wins;
        Message = message;
    }
    protected static List<Trainers> GetTrainers()
    {
        var trainers = new List<Trainers>
        {
            new Trainers("Arnold Schwarzenegger","Austria-USA",7,"ASTA LAWISTA"),
            new Trainers("Chris Bumstead","Canada",4,"Nice"),
            new Trainers("Jay Cutler","USA",4,"Oh God"),
            new Trainers("Ronnie Coleman","USA",8,"Lightweight baby"),
        };
        return trainers;
    }
    public static void ShowTrainerList()
    {
        List<Trainers> list = GetTrainers();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i} {list[i].Name}");
            }
    }
    public static void ShowTrainerData()
    {
        List<Trainers> list = GetTrainers();
            foreach (Trainers t in list)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine();
                sb.AppendLine($"Name: {t.Name}");
                sb.AppendLine($"Country: {t.CountryOfOrigin}");
                sb.Append($"Wins at Mr Olimpia: {t.MrOlimpiaWins}");
                sb.AppendLine();
                sb.AppendLine($"Message: {t.Message}");
                string result = sb.ToString();
                Console.WriteLine(result);
            }
    }
    //public static void Test()
    //{
    //    List<Trainers> trainers= GetTrainers();
    //    Trainers arnold = trainers.FirstOrDefault(e => e.Name == "Arnold Schwarzenegger");
    //    Console.WriteLine(arnold);
    //}
}

