using System;
using System.IO;
using System.Linq;

namespace AoC2022.days
{
	public class day_6
	{
		private static readonly string Input = File.ReadAllText(@"C:\temp\day_6.txt");

		public static void PartOne()
		{
			var index = 0;

			while (index < Input.Length)
			{
				var seq = Input.Substring(index, 4);
				if (seq.ToCharArray().Distinct().Count() == 4)
					break;
				index++;
			}

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"{index + 4} characters need to be processed.\n");
			Console.ResetColor();
		}

		public static void PartTwo()
		{
			var index = 0;

			while (index < Input.Length)
			{
				var seq = Input.Substring(index, 14);
				if (seq.ToCharArray().Distinct().Count() == 14)
					break;
				index++;
			}

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"{index + 14} characters need to be processed.\n");
			Console.ResetColor();
		}
	}
}