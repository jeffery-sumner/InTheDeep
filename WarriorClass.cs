using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InTheDeep.Program;
using static System.Console;

namespace InTheDeep
{

    public class WarriorClass
    {
        Random fightRandom = new Random();
        int playerHp = 60;
        int playerAttack = 10;
        int healAmount = 10;
        int enemyHp = 40;
        int enemyAttack = 7;
        public  void Start()
        {
            RunBattleMenu();
        }

        private void RunBattleMenu()
        {
            string prompt = "";

            string[] options = { "Attack", "Heal", "Flee" };
            Menu battleMenu = new Menu(prompt, options);
            int selectedIndex = battleMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Attack();
                    break;
                case 1:
                    Heal();
                    break;
                case 2:
                    Flee();
                    break;
            }
        }

        private void Flee()
        {
            WriteLine("You attempt to flee from the beast!");
            ReadKey(true);
            FleeMethod.Flee();
        }

        private void Heal()
        {
            do
            {
                //Fight Mechanic--- ⚔🛡👹
                {
                    // Player Turn--- 🛡🛡🛡
                    Console.WriteLine(" !!--@Player Turn--!! ");
                    Console.WriteLine("Player Hp = " + playerHp + ". Enemy Hp = " + enemyHp);
                    Clear();
                    playerHp += healAmount;
                    WriteLine("\t --You heal " + healAmount + " health points!");

                }
            } while (playerHp > 0 && enemyHp > 0);
        }

        private void Attack()
        {
            do
            {
                //Fight Mechanic--- ⚔🛡👹
                {
                    // Player Turn--- 🛡🛡🛡
                    Console.WriteLine(" !!--@Player Turn--!! ");
                    Console.WriteLine("Player Hp = " + playerHp + ". Enemy Hp = " + enemyHp);

                    enemyHp -= playerAttack;
                    WriteLine("\t --You attack your enemy and deal " + playerAttack + " damage");
                }
            } while (playerHp > 0 && enemyHp > 0);



            //Battle Summary--- 🕮🕮🕮🕮🕮
            if (playerHp > 0)
            {
                Console.WriteLine("\t --Congratulations, you have slain your foe!");
            }
            else
            {
                Console.WriteLine("\t --The enemy roars in victory and begins to feast on your flesh");
            }
            ReadLine();
        }
    }
}
