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

			PartOne();
			PartTwo();

			//day 2

		}

		#region day 1

		private static void PartOne()
		{
			var calories = CalorieCalculator();
			Console.WriteLine($"The elf with most calories is carrying: {calories.Max()} calories.");
		}

		private static void PartTwo()
		{
			var calories = CalorieCalculator();
			Console.WriteLine($"The three elves carrying most calories carry total of: {calories.OrderByDescending(x => x).Take(3).Sum()} calories.");
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
