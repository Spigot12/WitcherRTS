using System;
using WitcherRTS.Core.Models;

namespace WitcherRTS.Core.ProgramTests
{
    class BattleDemo
    {
        static void Main(string[] args)
        {
            Witcher geralt = new Witcher("Geralt");
            Monster griff = new Monster("Greif");
            Soldier soldier = new Soldier("Nilfgaardischer Soldat");

            Console.WriteLine("=== Kampf beginnt ===\n");
            
            geralt.Attack(griff);
            griff.Attack(geralt);
            soldier.Attack(griff);

            Console.WriteLine("\n=== Kampf Ende ===\n");
            
            Console.WriteLine($"{geralt.GetName()} HP: {geralt.GetHealth()}");
            Console.WriteLine($"{griff.GetName()} HP: {griff.GetHealth()}");
            Console.WriteLine($"{soldier.GetName()} HP: {soldier.GetHealth()}");
        }
    }
}