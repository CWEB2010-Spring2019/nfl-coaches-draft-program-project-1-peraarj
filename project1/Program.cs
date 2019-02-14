using System;
using Newtonsoft.Json;
using static System.Console;
using System.Collections.Generic;
using System.IO;

namespace project1
{


	public class Player
	{
		
		public string pName { get; set; }
		
		public string pPosition { get; set; }
		
		public string pRank { get; set; }
		
		public string pInstitution { get; set; }
		
		
		public int Id { get; set; }
		
		public bool pAvail { get; set; }


	}
	class Program
    {
		static void Main(string[] args)
		{
			TextReader draftRoster = new StreamReader(@"C:\Users\peraarj\Desktop\Advanced Programming\NFL Console App\project1");
			string serializedData = draftRoster.ReadToEnd();
			//draftRoster.Close();
			List<Player> players;
			players = JsonConvert.DeserializeObject<List<Player>>(serializedData);
			List<Player> coachPicks = new List<Player>();
			Console.WriteLine(players);

		} // End of main method
    }
}
