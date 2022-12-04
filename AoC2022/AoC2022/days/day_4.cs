using System;
using System.IO;

namespace AoC2022.days
{
	public class day_4
	{
		private static readonly string[] Input = File.ReadAllLines(@"C:\temp\day_4.txt");

		public static void PartOne()
		{
			var sum = OverlappingCalculator();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"One range fully contains the other in {sum} assignment pairs.\n");
			Console.ResetColor();
		}

		private static int OverlappingCalculator()
		{
			var sum = 0;

			foreach (var line in Input)
			{
				var firstRange = line[..line.IndexOf(",")].Split('-');
				var secondRange = line[(line.IndexOf(",") + 1)..].Split('-');
				var firstId = int.Parse(firstRange[0]);
				var secondId = int.Parse(firstRange[1]);
				var thirdId = int.Parse(secondRange[0]);
				var fourthId = int.Parse(secondRange[1]);

				if ((firstId > thirdId || secondId < fourthId) && (thirdId > firstId || fourthId < secondId)) continue;
				sum++;
			}

			return sum;
		}
	}
}