using System;
using System.Diagnostics;
using System.IO;

namespace AoC2022.days
{
	public class day_2
	{
		private static readonly string[] Input = File.ReadAllLines(@"C:\temp\day_2.txt");

		public static void PartOne()
		{
			var apparentPoints = PointsCalculator(false);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"My apparent score is {apparentPoints}.\n");
			Console.ResetColor();
		}

		public static void PartTwo()
		{
			var totalPoints = PointsCalculator(true);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"My real score is {totalPoints}.\n");
			Console.ResetColor();
		}
		
		private static int PointsCalculator(bool explained)
		{
			var apparentPoints = 0;
			var totalPoints = 0;
			var points = 0;

			foreach (var line in Input)
			{
				var choices = line.Split(' ');
				var opponentMove = choices[0];
				var playerMove = choices[1];

				switch (opponentMove)
				{
					case "A" when playerMove == "X":
						totalPoints += 3;
						apparentPoints += 4;
						break;
					case "A" when playerMove == "Y":
						totalPoints += 4;
						apparentPoints += 8;
						break;
					case "A" when playerMove == "Z":
						totalPoints += 8;
						apparentPoints += 3;
						break;
					case "B" when playerMove == "X":
						totalPoints += 1;
						apparentPoints += 1;
						break;
					case "B" when playerMove == "Y":
						totalPoints += 5;
						apparentPoints += 5;
						break;
					case "B" when playerMove == "Z":
						totalPoints += 9;
						apparentPoints += 9;
						break;
					case "C" when playerMove == "X":
						totalPoints += 2;
						apparentPoints += 7;
						break;
					case "C" when playerMove == "Y":
						totalPoints += 6;
						apparentPoints += 2;
						break;
					case "C" when playerMove == "Z":
						totalPoints += 7;
						apparentPoints += 6;
						break;
				}
			}

			if (!explained)
				points = apparentPoints;
			else
				points = totalPoints;

			return points;
		}
	}
}