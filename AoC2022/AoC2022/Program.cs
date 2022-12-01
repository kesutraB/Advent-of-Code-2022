using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC2022
{
	internal class Program
	{

		private static readonly string[] Input = File.ReadAllLines(@"C:\temp\input.txt");

		static void Main(string[] args)
		{
			//day 1

			Console.WriteLine("DAY 1\n");
			PartOne();
			PartTwo();

			//day 2

			Console.WriteLine("DAY 2\n");

		}

		#region day 1

		private static void PartOne()
		{
			var calories = CalorieCalculator();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"The elf with most calories is carrying: {calories.Max()} calories.\n");
			Console.ResetColor();
		}

		private static void PartTwo()
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
