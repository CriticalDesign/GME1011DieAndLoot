namespace DieProject
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Die d1 = new Die();
            Die d2 = new Die(-6);
            Console.WriteLine(d1);
            Console.WriteLine(d2);


            for (int i = 0; i < 10; i++)
            {
                d2.Roll();
                d1.Roll();
                int sum = d1.LookAtDie() + d2.LookAtDie();
                Console.WriteLine(d1.LookAtDie() + " " + d2.LookAtDie() + " = " + sum);
            }

            //bring on the loot
            LootBox myLootBox = new LootBox();
            Console.WriteLine("Are you open loot box?: " +  myLootBox.IsOpen());
            string prizes = "";
            if(!myLootBox.IsOpen())
                prizes = myLootBox.DispenseLoot();

            Console.WriteLine("I got " + prizes);

        }
    }

}
