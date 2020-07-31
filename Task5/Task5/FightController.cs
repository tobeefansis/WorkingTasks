using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task5
{
    class FightController
    {
        public bool IsOver => first.IsDead || second.IsDead;


        public Monster first;
        public Monster second;

        public FightController(Monster first, Monster second)
        {
            this.first = first;
            first.OnDead += OnDead;
            this.second = second;
            second.OnDead += OnDead;
        }

        private void OnDead(Monster obj)
        {
            Monster monster;
            if (first != obj)
            {
                monster = first;
            }
            else
            {
                monster = second;

            }
            
            ConsoleLogger.StartBlock(ConsoleColor.Yellow);
            ConsoleLogger.LogCenter($"Победил",background: ConsoleColor.Yellow);
            ConsoleLogger.Log(monster, background: ConsoleColor.Yellow);
            ConsoleLogger.EndBlock(ConsoleColor.Yellow);
        }

        public void Fight()
        {
            if (first != null && second != null)
            {
                int CountOfPunch = 1;
                while (!IsOver)
                {
                    Thread.Sleep(200);
                    ConsoleLogger.StartBlock(ConsoleColor.DarkBlue);
                    ConsoleLogger.Log(first,background: ConsoleColor.DarkBlue);
                    ConsoleLogger.Log(second, background: ConsoleColor.DarkBlue);
                    second.SetDamage(first.Hit());
                    ConsoleLogger.EndBlock(ConsoleColor.DarkBlue);
                    CountOfPunch++;
                    if (!IsOver)
                    {
                    Thread.Sleep(200);
                        ConsoleLogger.StartBlock(ConsoleColor.DarkRed);
                        ConsoleLogger.Log(second, background: ConsoleColor.DarkRed);
                        ConsoleLogger.Log(first, background: ConsoleColor.DarkRed);
                        first.SetDamage(second.Hit());
                        ConsoleLogger.EndBlock(ConsoleColor.DarkRed);
                        CountOfPunch++;
                    }
                }

            }
        }
    }
}
