using System;
using System.IO;
using System.Linq;

namespace AoC2022.days
{
	public class day_3
	{
		private static readonly string[] Input = File.ReadAllLines(@"C:\temp\day_3.txt");

		public static void PartOne()
		{
			var sum = PriorityCalculator(false);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Sum of priority items is {sum}.\n");
			Console.ResetColor();
		}

		public static void PartTwo()
		{
			var sum = PriorityCalculator(true);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"Second sum of priority items is {sum}.\n");
			Console.ResetColor();
		}

		private static int PriorityCalculator( bool whichPart)
		{
			var partOne = 0;
			var partTwo = 0;
			const string alphabet = "0abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

			foreach (var line in Input)
			{
				var firstHalf = line[..(line.Length / 2)];
				var secondHalf = line[(line.Length / 2)..];

				foreach (var letter in firstHalf.Where(letter => secondHalf.Contains(letter)))
				{
					partOne += alphabet.IndexOf(letter);
					break;
				}
			}

			for (var i = 0; i < Input.Length; i += 3)
			{
				foreach (var letter in Input[i].Where(letter => Input[i + 1].Contains(letter) && Input[i + 2].Contains(letter)))
				{
					partTwo += alphabet.IndexOf(letter);
					break;
				}
			}

			return !whichPart ? partOne : partTwo;
		}
	}
}