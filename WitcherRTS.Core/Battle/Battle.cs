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
            Console.WriteLine("--- Battle begins ---\n");

            while (unitA.IsAlive() && unitB.IsAlive())
            {
                PrintAttack(unitA, unitB);
                unitA.Attack(unitB);

                if (!unitB.IsAlive())
                {
                    Console.WriteLine($"{unitB.GetName()} has died!");
                    break;
                }

                PrintAttack(unitB, unitA);
                unitB.Attack(unitA);

                if (!unitA.IsAlive())
                {
                    Console.WriteLine($"{unitA.GetName()} has died!");
                    break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("--- Battle ended ---");
        }
        
        private void PrintAttack(Unit attacker, Unit target)
        {
            Console.WriteLine($"{attacker.GetName()} attacks {target.GetName()}!");
        }
    }
}