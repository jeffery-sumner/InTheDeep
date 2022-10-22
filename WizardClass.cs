using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InTheDeep
{
    internal class WizardClass
    {
        int playerHp = 30;
        int playerAttack = 20;
        int healAmount = 15;
        int enemyHp = 40;
        public void Start()
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
            WriteLine("You flee from the beast!");
            ReadKey(true);
            FleeMethod.Flee();
        }

        private void Heal()
        {
            Clear();
            playerHp += healAmount;
            WriteLine("\t --You heal " + healAmount + " health points!");
            RunBattleMenu();
        }

        private void Attack()
        {
            enemyHp -= playerAttack;
            WriteLine("\t --You attack your enemy and deal " + playerAttack + " damage");
            ReadLine();
        }
    }
}
