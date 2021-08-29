using System;
using System.Collections;

namespace Riddle
{

	public class Program
	{
		public static void Main()
		{
			ArrayList riddles = new ArrayList();
			riddles.Add("What starts with e, ends with e, and contains one letter?");
			riddles.Add("What's black and white, and red all over?");
			riddles.Add("A rooster lays an egg on top of a roof, facing east. Which direction does the egg roll off the roof?");
			riddles.Add("Where there's rivers but no waters, there are cities but no buildings, there are forest but no trees.");
			riddles.Add("What month of the year has 28 days?");

			ArrayList answers = new ArrayList();
			answers.Add("envelope");
			answers.Add("a penguin in a Blender");
			answers.Add("roosters don't lay eggs");
			answers.Add("a map");
			answers.Add("all of them");
			sphinx();
			// string[] riddles = { "What starts with e, ends with e, and contains one letter?", "What's black and white, and red all over?", "A rooster lays an egg on top of a roof, facing east. Which direction does the egg roll off the roof?", "Where there's rivers but no waters, there are cities but no buildings, there are forest but no trees.", "What month of the year has 28 days?" };
			// string[] answers = { "envelope", "a penguin in a Blender", "roosters don't lay eggs", "a map", "all of them" };

			void sphinx()
			{
				if (riddles.Count > 0)
				{
					int i = chooseRandom(); //get random integer according to riddles.Length
					string currentRiddle = (string)riddles[i]; //get index and store as string
					Console.WriteLine(currentRiddle); //debug
					string userAnswer = Console.ReadLine(); //expect user input
					checkAnswer(userAnswer, i);//compare user input
					Console.Clear();
					sphinx();
				}
			}

			void checkAnswer(string userAnswer, int i)
			{
				if (userAnswer == (string)answers[i])
				{
					Console.WriteLine("correct");
					riddles.Remove((string)riddles[i]);
					answers.Remove((string)answers[i]);

					// Console.WriteLine();
					// riddles = riddles.Where(o=> o != "2").ToArray();

				}
				else
				{
					Console.WriteLine("incorrect");
				}
			}

			int chooseRandom()
			{
				int random = new Random().Next(0, riddles.Count);
				return random;
			}
		}

	}
}

