﻿using Newtonsoft.Json;
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
            //string List1 = "C:\\DassaultDUOS\\Matchup_Tester\\Ultra vs custo.json";
            string List2 = "C:\\Users\\alext\\source\\repos\\SimpleMoneyTracker\\Matchup_Tester\\Ultra vs custo.json";

            string jsonString = File.ReadAllText(List2);
            Root Root = JsonConvert.DeserializeObject<Root>(jsonString);
            ProfilUnit unit = new(Root.roster.forces[0].selections[5]);
        }
    }
}