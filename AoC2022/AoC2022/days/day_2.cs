using System;
using System.IO;

namespace AoC2022.days
{
	public class day_2
	{
		private static readonly string[] Input = File.ReadAllLines(@"C:\temp\day_2.txt");

		public static void PartOne()
		{
			var apparentPoints = PointsCalculatorOne();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"My apparent score is {apparentPoints}.\n");
			Console.ResetColor();
		}

		public static void PartTwo()
		{
			var totalPoints = PointsCalculatorTwo();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"My real score is {totalPoints}.\n");
			Console.ResetColor();
		}
		
		private static int PointsCalculatorOne()
		{
			var apparentPoints = 0;

			foreach (var line in Input)
			{
				var choices = line.Split(' ');
				var opponentMove = choices[0];
				var playerMove = choices[1];

				switch (opponentMove)
				{
					case "A" when playerMove == "X":
						apparentPoints += 4;
						break;
					case "A" when playerMove == "Y":
						apparentPoints += 8;
						break;
					case "A" when playerMove == "Z":
						apparentPoints += 3;
						break;
					case "B" when playerMove == "X":
						apparentPoints += 1;
						break;
					case "B" when playerMove == "Y":
						apparentPoints += 5;
						break;
					case "B" when playerMove == "Z":
						apparentPoints += 9;
						break;
					case "C" when playerMove == "X":
						apparentPoints += 7;
						break;
					case "C" when playerMove == "Y":
						apparentPoints += 2;
						break;
					case "C" when playerMove == "Z":
						apparentPoints += 6;
						break;
				}
			}

			return apparentPoints;
		}

		private static int PointsCalculatorTwo()
		{
			var totalPoints = 0;

			foreach (var line in Input)
			{
				var choices = line.Split(' ');
				var opponentMove = choices[0];
				var playerMove = choices[1];

				switch (opponentMove)
				{
					case "A" when playerMove == "X":
						totalPoints += 3;
						break;
					case "A" when playerMove == "Y":
						totalPoints += 4;
						break;
					case "A" when playerMove == "Z":
						totalPoints += 8;
						break;
					case "B" when playerMove == "X":
						totalPoints += 1;
						break;
					case "B" when playerMove == "Y":
						totalPoints += 5;
						break;
					case "B" when playerMove == "Z":
						totalPoints += 9;
						break;
					case "C" when playerMove == "X":
						totalPoints += 2;
						break;
					case "C" when playerMove == "Y":
						totalPoints += 6;
						break;
					case "C" when playerMove == "Z":
						totalPoints += 7;
						break;
				}
			}

			return totalPoints;
		}
	}
}