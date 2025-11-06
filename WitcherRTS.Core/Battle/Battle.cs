using System;
using WitcherRTS.Core.Models;

namespace WitcherRTS.Core.Battle
{
    public class Battle
    {
        private Unit unitA;
        private Unit unitB;

        public Battle(Unit unitA, Unit unitB)
        {
            this.unitA = unitA;
            this.unitB = unitB;
        }

        public void StartBattle()
        {
            Console.WriteLine("--- Kampf beginnt ---\n");

            while (unitA.IsAlive() && unitB.IsAlive())
            {
                PrintAttack(unitA, unitB);
                unitA.Attack(unitB);

                if (!unitB.IsAlive())
                {
                    Console.WriteLine($"{unitB.GetName()} ist gestorben!");
                    break;
                }

                PrintAttack(unitB, unitA);
                unitB.Attack(unitA);

                if (!unitA.IsAlive())
                {
                    Console.WriteLine($"{unitA.GetName()} ist gestorben!");
                    break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("--- Kampf beendet ---");
        }
        
        private void PrintAttack(Unit attacker, Unit target)
        {
            Console.WriteLine($"{attacker.GetName()} greift {target.GetName()} an!");
        }
    }
}