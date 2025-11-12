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
            Monster griffin = new Monster("Griffin");
            Soldier nilfgaardian = new Soldier("Nilfgaardian Soldier");

            BattleLogger logger = new BattleLogger();

            Console.WriteLine("=== Battle 1: Geralt vs Griffin ===\n");
            Battle.Battle battle1 = new Battle.Battle(geralt, griffin, logger);
            battle1.StartBattle();

            Console.WriteLine("\n--- End Status ---");
            Console.WriteLine($"{geralt.GetName()} HP: {geralt.GetHealth()}");
            Console.WriteLine($"{griffin.GetName()} HP: {griffin.GetHealth()}");

            if (geralt.IsAlive())
            {
                Console.WriteLine("\n\n=== Battle 2: Geralt vs Nilfgaardian Soldier ===\n");
                Battle.Battle battle2 = new Battle.Battle(geralt, nilfgaardian, logger);
                battle2.StartBattle();

                Console.WriteLine("\n--- End Status ---");
                Console.WriteLine($"{geralt.GetName()} HP: {geralt.GetHealth()}");
                Console.WriteLine($"{nilfgaardian.GetName()} HP: {nilfgaardian.GetHealth()}");
            }
        }
    }
}