using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC2022.days
{

	public class day_1
	{
		private static readonly string[] Input = File.ReadAllLines(@"C:\temp\day_1.txt");

		public static void PartOne()
		{
			var calories = CalorieCalculator();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"The elf with most calories is carrying: {calories.Max()} calories.\n");
			Console.ResetColor();
		}

		public static void PartTwo()
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
	}
}