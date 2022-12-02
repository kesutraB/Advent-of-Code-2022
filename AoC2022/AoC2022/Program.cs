using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC2022
{
	internal class Program
	{

		private static readonly string[] Input = File.ReadAllLines(@"C:\temp\day_2.txt");

		static void Main(string[] args)
		{
			//day 1

			// PartOneDayOne();
			// PartTwoDayOne();

			//day 2

			PartOneDayTwo();
			PartTwoDayTwo();
		}

		#region day 2

		private static void PartOneDayTwo()
		{
			var totalPoints = PointsCalculator();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"My apparent score is {totalPoints}.\n");
			Console.ResetColor();
		}

		private static void PartTwoDayTwo()
		{
			var totalPoints = PointsCalculator();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"My real score is {totalPoints}.\n");
			Console.ResetColor();
		}

		private static int PointsCalculator()
		{
			var points = 0;

			foreach (var line in Input)
			{
				var choices = line.Split(' ');
				var opponentMove = choices[0];
				var playerMove = choices[1];

				switch (opponentMove)
				{
					case "A" when playerMove == "X":
						points += 3;
						break;
					case "A" when playerMove == "Y":
						points += 4;
						break;
					case "A" when playerMove == "Z":
						points += 8;
						break;
					case "B" when playerMove == "X":
						points += 1;
						break;
					case "B" when playerMove == "Y":
						points += 5;
						break;
					case "B" when playerMove == "Z":
						points += 9;
						break;
					case "C" when playerMove == "X":
						points += 2;
						break;
					case "C" when playerMove == "Y":
						points += 6;
						break;
					case "C" when playerMove == "Z":
						points += 7;
						break;
				}
			}

			return points;
		}

		#endregion

		#region day 1

		private static void PartOneDayOne()
		{
			var calories = CalorieCalculator();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"The elf with most calories is carrying: {calories.Max()} calories.\n");
			Console.ResetColor();
		}

		private static void PartTwoDayOne()
		{
			var calories = CalorieCalculator();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"The three elves carrying most calories carry total of: {calories.OrderByDescending(x => x).Take(3).Sum()} calories.\n");
			Console.ResetColor();
		}

		private static List<int> CalorieCalculator()
		{
			List<int> elves = new List<int>();
			int currentElf = 0;

			foreach (var line in Input)
			{
				if (string.IsNullOrWhiteSpace(line))
				{
					elves.Add(currentElf);
					currentElf = 0;

					continue;
				}

				currentElf += int.Parse(line);
			}

			return elves;
		}

		#endregion
	}
}
