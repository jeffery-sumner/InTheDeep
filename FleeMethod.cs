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
                Console.WriteLine("\t --You manage to flee from the encounter!");
            }
            else
            {
                Console.WriteLine("\t --To late to run now, stand and deliver!");
                BattleMethod.
                                Battle();
            }
        }
    }
}