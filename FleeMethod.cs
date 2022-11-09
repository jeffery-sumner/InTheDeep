using static System.Console;

namespace InTheDeep
{
    internal static class FleeMethod
    {

        //Flee Mechanic--- 🏃🏃🏃🏃🏃
        public static void Flee()
        {
            Random random = new Random();

            int flee = random.Next(0, 2);

            if (flee == 0)
            {
                ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t --You manage to flee from the encounter!");
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t --To late to run now, stand and deliver!");
                BattleMethod.Battle();
            }

            ResetColor();
        }
    }
}