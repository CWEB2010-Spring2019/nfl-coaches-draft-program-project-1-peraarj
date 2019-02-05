using System;
using static System.Console;


namespace project1
{
    class Program
    {

		// Creation of global variables

		// Classes and methods

		public class Player {
			public string pName { get; set; }
			public string pPosition { get; set; }
			public string pInstitution { get; set; }
			public int pSalarie { get; set; }
		}


        static void Main(string[] args) // Start of main method
        {

			Player player01 = new Player();
			player01.pName = "Freddy";
			int draftBudget = 95000000;
			int draftSpent = 0;
			int playersPicked = 0;
            Console.WriteLine("Hello World!");
			WriteLine(player01.pName);
			

		} // End of main method
    }
}
