using System;
using WitcherRTS.Core.Models;
using WitcherRTS.Core.Battle;

namespace WitcherRTS.Core.ProgramTests
{
    class BattleDemo
    {
        static void Main(string[] args)
        {
            Witcher geralt = new Witcher("Geralt");
            Monster griff = new Monster("Greif");
            
            Battle.Battle battle = new Battle.Battle(geralt, griff);
            battle.StartBattle();
            
            Console.WriteLine("\n--- Endstatus ---");
            Console.WriteLine($"{geralt.GetName()} HP: {geralt.GetHealth()}");
            Console.WriteLine($"{griff.GetName()} HP: {griff.GetHealth()}");
        }
    }
}