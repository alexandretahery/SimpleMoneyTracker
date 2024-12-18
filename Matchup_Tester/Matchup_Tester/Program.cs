using Newtonsoft.Json;
using System;
using System.IO;
using TableTopUnitLib.Unit;

namespace Matchup_Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string List = "C:\\DassaultDUOS\\Got\\SimpleMoneyTracker\\Matchup_Tester\\Ultra vs custo.json";
            //string List = "C:\\Users\\alext\\source\\repos\\SimpleMoneyTracker\\Matchup_Tester\\Ultra vs custo.json";

            string jsonString = File.ReadAllText(List);
            Root Root = JsonConvert.DeserializeObject<Root>(jsonString);
            ProfilUnit unit = new(Root.roster.forces[0].selections[5]);
        }
    }
}