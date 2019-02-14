using System;
using Newtonsoft.Json;
using static System.Console;
using System.Collections.Generic;
using System.IO;

namespace project1
{

	class Program
    {
		public class Player
		{
			public string pName { get; set; }

			public string pPosition { get; set; }

			public string pRank { get; set; }

			public string pInstitution { get; set; }

			public int Id { get; set; }

			public int Price { get; set; }

			public bool pAvail { get; set; }

			public Player(string pName, string pPosition, string pRank, string pInstitution, int Id, int Price, bool pAvail)
			{
				this.pName = pName;
				this.pPosition = pPosition;
				this.pRank = pRank;
				this.pInstitution = pInstitution;
				this.Id = Id;
				this.Price = Price;
				this.pAvail = pAvail;
			}

			public override string ToString()
			{
				return string.Format(pName + " number " + Id + " plays " + pPosition + " for " + pInstitution + " and is ranked " + pRank + " in the league and costs: " + Price + " .");
			}
		}


		static ConsoleKey Initiate() {
			ConsoleKey sentinel;
			WriteLine("Welcome, This is a program that will allow you to make your draft picks!");
			WriteLine("You will be allowed to pick a max of 5 Players and have a max budget of $95,000,000.");
			WriteLine("To procede please press enter or pretty the 'x' key to exit the draft pick: ");
			return sentinel = Console.ReadKey().Key;
		}

		static ConsoleKey KillProgram() {
			ConsoleKey sentinel;
			WriteLine("Thank you, Continue: ENTER || EXIT: X");
			return sentinel = Console.ReadKey().Key;
		}
	
		static void Main(string[] args)
		{
			string[,] pName = {
				{ "Dwayne Haskins", "Kyler Murray", "Drew Lock", "Daniel Jones", "Will Grier" },
				{ "Josh Jacobs", "Damien Harris", "David Montgomery", "Justice Hill", "Devin Singletary" },
				{ "D.K. Metcalf", "A.J. Brown", "N'Keal Harry", "Marquise Brown", "Kelvin Harmon" },
				{ "Nick Bosa", "Quinnen Williams", "Ed Oliver", "Jeffery Simmons", "Clelin Ferrell" },
				{ "Greedy Williams", "Deandre Baker", "Byron Murphy", "Deionte Thompson", "Amani Oruwariye" },
				{ "Noah Fant", "Irv Smith", "T.J. Hockenson", "Kaden Smith", "Josh Oliver" },
				{ "Josh Allen", "Devin White", "Montez Sweat", "Mack Wilson", "Devin Bush" },
				{ "Jonah Williams", "Greg Little", "Cody Ford", "Jawaan Taylor", "Yodny Cajuste" }
			};
			string[,] pPosition = {
				{"Quarter-backs","Quarter-backs","Quarter-backs","Quarter-backs","Quarter-backs"},
				{"Running-backs","Running-backs","Running-backs","Running-backs","Running-backs"},
				{"Wide-receivers","Wide-receivers","Wide-receivers","Wide-receivers","Wide-receivers"},
				{"Defensive Linemen","Defensive Linemen","Defensive Linemen","Defensive Linemen","Defensive Linemen"},
				{"Defensive-backs","Defensive-backs","Defensive-backs","Defensive-backs","Defensive-backs"},
				{"Tight-ends","Tight-ends","Tight-ends","Tight-ends","Tight-ends"},
				{"Line-backers","Line-backers","Line-backers","Line-backers","Line-backers"},
				{"Offensive Tackles","Offensive Tackles","Offensive Tackles","Offensive Tackles","Offensive Tackles"}
			};
			string[,] pRank = {
				{ "Best", "2nd Best", "3rd Best", "4th Best", "5th best"},
				{ "Best", "2nd Best", "3rd Best", "4th Best", "5th best"},
				{ "Best", "2nd Best", "3rd Best", "4th Best", "5th best"},
				{ "Best", "2nd Best", "3rd Best", "4th Best", "5th best"},
				{ "Best", "2nd Best", "3rd Best", "4th Best", "5th best"},
				{ "Best", "2nd Best", "3rd Best", "4th Best", "5th best"},
				{ "Best", "2nd Best", "3rd Best", "4th Best", "5th best"},
				{ "Best", "2nd Best", "3rd Best", "4th Best", "5th best"},
			};
			string[,] pInstitution = {
				{ "Ohio State", "Oklahoma", "Missouri", "Duke", "West Virginia" },
				{ "Alabama", "Alabama", "Iowa State", "Oklahoma State", "FAU" },
				{ "Ole Miss", "Ole Miss", "Arizona State", "Oklahoma", "NC State" },
				{ "Ohio State", "Alabama", "Houston", "Miss. State", "Clemson" },
				{ "LSU", "Georgia", "Washington", "Alabama", "Penn State" },
				{ "Iowa", "Alabama", "Iowa", "Stanford", "San Jose State" },
				{ "Kentucky", "LSU", "Miss. State", "Alabama", "Michigan" },
				{ "Alabama", "Ole Miss", "Oklahoma", "Florida", "West Virginia" }
			};
			int[,] Id = {
				{ 00, 01, 02, 03, 04},
				{ 10, 11, 12, 13, 14},
				{ 20, 21, 22, 23, 24},
				{ 30, 31, 32, 33, 34},
				{ 40, 41, 42, 43, 44},
				{ 50, 51, 52, 53, 54},
				{ 60, 61, 62, 63, 64},
				{ 70, 71, 72, 73, 74}
			};
			int[,] Price = {
				{26400100, 20300100, 17420300, 13100145, 10300000},
				{24500100, 19890200, 18700800, 15000000, 11600400},
				{23400000, 21900300, 19300230, 13400230, 10000000},
				{26200300, 22000000, 16000000, 18000000, 13000000},
				{24000000, 22500249, 20000100, 16000200, 11899999},
				{27800900, 21000800, 17499233, 27900200, 14900333},
				{22900300, 19000590, 18000222, 12999999, 10000100},
				{23000000, 20000000, 19400000, 16200700, 15900000}
			};
			bool[,] pAvail = {
				{ true, true, true, true, true},
				{ true, true, true, true, true},
				{ true, true, true, true, true},
				{ true, true, true, true, true},
				{ true, true, true, true, true},
				{ true, true, true, true, true},
				{ true, true, true, true, true},
				{ true, true, true, true, true},
			};

			List<Player> players = new List<Player>();
			List<Player> thisList = players;
			List<Player> coachPicks = new List<Player>();

			for (var i = 0; i < 8; i++) {
				for (var j = 0; j < 5; j++) {
					Player newPlayers = new Player(pName[i, j], pPosition[i, j], pRank[i, j], pInstitution[i, j], Id[i, j], Price[i, j], pAvail[i, j]);
					players.Add(newPlayers);
					
				}
			}

			ConsoleKey sentinel;			
			int budget = 95000000;
			int picks = 0;
			int balSpent = 0;
			int balRemaining = 0;
			sentinel = Initiate();

			while (sentinel != ConsoleKey.X) {
				Console.Clear();
				thisList.ForEach(x => WriteLine(x.ToString()));
				WriteLine("Enter the number of the player you wish to select: ");
				int selection = Convert.ToInt32(Console.ReadLine());
				for (int i = 0; i < thisList.Count; i++) {
					if (thisList[i].Id == selection){
						if (thisList[i].Price > budget) {
							Console.Clear();
							WriteLine("You do not have sufficient funds to make that pick");
							WriteLine("You tried to spend " + thisList[i].Price + " on " + thisList[i].pName + ". You have" + budget + " left to spend.");
							sentinel = ConsoleKey.X;
						}

						else if (picks >= 5){
							WriteLine("You have reached your limit of picks for this draft. I hope you recieved everything you wanted.");
							sentinel = ConsoleKey.X;
						}
						else if (thisList[i].pAvail == false){
							WriteLine("That player has already been drafted. Please pick another.");
						}
						else {
							thisList[i].pAvail = false;
							coachPicks.Add(thisList[i]);
							balSpent = balSpent + thisList[i].Price;
							budget = budget - thisList[i].Price;
							thisList.RemoveAt(i);
							picks = picks + 1;
							Console.Clear();
							WriteLine("The players you have so far : ");
							coachPicks.ForEach(x => WriteLine(x.ToString()));
							WriteLine("");
							WriteLine("Your remaining Balance = " + budget);
							WriteLine("");
							WriteLine("Press anykey to continue:");
							Console.ReadLine();

						}
					}
				}	
			}
		} // End of main method
    }
}
