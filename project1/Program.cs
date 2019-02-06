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
			public int pSalary { get; set; }

			
			
		}


        static void Main(string[] args) // Start of main method
        {
			string[,] pName = { { "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},};

			string[,] pPosition = { { "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},};

			string[,] pInstitution = { { "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},};

			string[,] pSalary = { { "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},
								{ "", "", "", "", ""},};

			Player player01 = new Player();
			player01.pName = "Freddy";
			player01.pPosition = "QBack";
			player01.pInstitution = "MN";
			player01.pSalary = 12000000;
			int draftBudget = 95000000;
			int draftSpent = 0;
			int playersPicked = 0;
            Console.WriteLine("Hello World!");
			WriteLine(player01.pName, player01.pPosition, player01.pInstitution, player01.pSalary);
			

		} // End of main method
    }
}
