using System;
using WitcherRTS.Core.Models;

namespace WitcherRTS.Core.Battle
{
    public class Battle
    {
        private Unit unitA;
        private Unit unitB;
        private BattleLogger logger;

        public Battle(Unit unitA, Unit unitB, BattleLogger logger)
        {
            this.unitA = unitA;
            this.unitB = unitB;
            this.logger = logger;
        }

        public void StartBattle()
        {
            logger.Log("--- Battle begins ---\n");

            while (unitA.IsAlive() && unitB.IsAlive())
            {
                logger.Log($"{unitA.GetName()} attacks {unitB.GetName()}!");
                unitA.Attack(unitB);

                if (!unitB.IsAlive())
                {
                    logger.Log($"{unitB.GetName()} has died!");
                    break;
                }

                logger.Log($"{unitB.GetName()} attacks {unitA.GetName()}!");
                unitB.Attack(unitA);

                if (!unitA.IsAlive())
                {
                    logger.Log($"{unitA.GetName()} has died!");
                    break;
                }

                logger.Log("");
            }

            logger.Log("--- Battle ended ---");
        }
    }
}