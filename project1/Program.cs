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
			public string pRank { get; set; }
			public string pInstitution { get; set; }
			public int pSalary { get; set; }
			public int Id { get; set; }
			public bool pAvail { get; set; } 

	
		}


        static void Main(string[] args) // Start of main method
        {
			// Creating the 2D arrays and data in them for later integration into player object
			int[,] Id { { 00, 01, 02, 03, 04},
						{ 10, 11, 12, 13, 14},
						{ 20, 21, 22, 23, 24},
						{ 30, 31, 32, 33, 34},
						{ 40, 41, 42, 43, 44},
						{ 50, 51, 52, 53, 54},
						{ 60, 61, 62, 63, 64},
						{ 70, 71, 72, 73, 74},};

			string[,] pName = { { "Dwayne Haskins", "Kyler Murray", "Drew Lock", "Daniel Jones", "Will Grier"},
								{ "Josh Jacobs", "Damien Harris", "David Montgomery", "Justice Hill", "Devin Singletary"},
								{ "D.K. Metcalf", "A.J. Brown", "N'Keal Harry", "Marquise Brown", "Kelvin Harmon"},
								{ "Nick Bosa", "Quinnen Williams", "Ed Oliver", "Jeffery Simmons", "Clelin Ferrell"},
								{ "Greedy Williams", "Deandre Baker", "Byron Murphy", "Deionte Thompson", "Amani Oruwariye"},
								{ "Noah Fant", "Irv Smith", "T.J. Hockenson", "Kaden Smith", "Josh Oliver"},
								{ "Josh Allen", "Devin White", "Montez Sweat", "Mack Wilson", "Devin Bush"},
								{ "Jonah Williams", "Greg Little", "Cody Ford", "Jawaan Taylor", "Yodny Cajuste"},};

			string[,] pInstitution = { { "(Ohio St.)", "(Oklahoma)", "(Missouri)", "(Duke)", "(West Virginia)"},
								       { "(Alabama)", "(Alabama)", "(Iowa St.)", "(Oklahoma St.)", "(FAU)"},
								       { "(Ole Miss)", "(Ole Miss)", "(Arizona St.)", "(Oklahoma)", "(NC State)"},
								       { "(Ohio St.)", "(Alabama)", "(Houston)", "(Miss. State)", "(Clemson)"},
								       { "(LSU)", "(Georgia)", "(Washington)", "(Alabama)", "(Penn State)"},
								       { "(Iowa)", "(Alabama)", "(Iowa)", "(Standford)", "(San Jose St.)"},
								       { "(Kentucky)", "(LSU)", "(Miss. State)", "(Alabama)", "(Michigan)"},
								       { "(Alabama)", "(Ole Miss)", "(Oklahoma)", "(Florida)", "(West Virginia)"},};

			string[,] pPosition = { { "Quarterback", "Quarterback", "Quarterback", "Quarterback", "Quarterback"},
									{ "Running Back", "Running Back", "Running Back", "Running Back", "Running Back"},
									{ "Wide-Receiver", "Wide-Receiver", "Wide-Receiver", "Wide-Receiver", "Wide-Receiver"},
									{ "Defensive Lineman", "Defensive Lineman", "Defensive Lineman", "Defensive Lineman", "Defensive Lineman"},
									{ "Defensive-Back", "Defensive-Back", "Defensive-Back", "Defensive-Back", "Defensive-Back"},
									{ "Tight End", "Tight End", "Tight End", "Tight End", "Tight End"},
									{ "Line-Backer", "Line-Backer", "Line-Backer", "Line-Backer", "Line-Backer"},
									{ "Offensive Tackles", "Offensive Tackles", "Offensive Tackles", "Offensive Tackles", "Offensive Tackles"},};

			string[,] pSalary = { { "26400100", "20300100", "17420300", "13100145", "10300000"},
								  { "24500100", "19890200", "18700800", "15000000", "11600400"},
								  { "23400000", "21900300", "19300230", "13400230", "10000000"},
								  { "26200300", "22000000", "16000000", "18000000", "13000000"},
								  { "24000000", "22500249", "20000100", "16000200", "11899999"},
								  { "27800900", "21000800", "17499233", "27900200", "14900333"},
								  { "22900300", "19000590", "18000222", "12999999", "10000100"},
								  { "23000000", "20000000", "19400000", "16200700", "15900000"},};

			bool[,] pAvail = { { true, true, true, true, true},
								{ true, true, true, true, true},
								{ true, true, true, true, true},
								{ true, true, true, true, true},
								{ true, true, true, true, true},
								{ true, true, true, true, true},
								{ true, true, true, true, true},
								{ true, true, true, true, true},};
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
