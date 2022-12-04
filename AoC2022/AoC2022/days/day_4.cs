using System;
using System.IO;

namespace AoC2022.days
{
	public class day_4
	{
		private static readonly string[] Input = File.ReadAllLines(@"C:\temp\day_4.txt");

		public static void PartOne()
		{
			var sum = OverlappingCalculator(false);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"One range fully contains the other in {sum} assignment pairs.\n");
			Console.ResetColor();
		}

		public static void PartTwo()
		{
			var sum = OverlappingCalculator(true);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"One range overlaps the other in {sum} assignment pairs.\n");
			Console.ResetColor();
		}

		private static int OverlappingCalculator(bool whichPart)
		{
			var partOne = 0;
			var partTwo = 0;

			foreach (var line in Input)
			{
				var firstRange = line[..line.IndexOf(",")].Split('-');
				var secondRange = line[(line.IndexOf(",") + 1)..].Split('-');
				var firstStart = int.Parse(firstRange[0]);
				var firstEnd = int.Parse(firstRange[1]);
				var secondStart = int.Parse(secondRange[0]);
				var secondEnd = int.Parse(secondRange[1]);

				if ((firstStart <= secondStart && firstEnd >= secondEnd) || (secondStart <= firstStart && secondEnd >= firstEnd))
					partOne++;

				if (firstEnd >= secondStart && secondEnd >= firstStart)
					partTwo++;
			}

			return !whichPart ? partOne : partTwo;
		}
	}
}