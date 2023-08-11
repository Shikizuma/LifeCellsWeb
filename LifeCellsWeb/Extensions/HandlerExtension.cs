using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LifeCellsWeb.Extensions
{
	internal static class HandlerExtension
	{
		static Regex regex = new Regex("([0-9]+)px|([0-9]+)%");
		static Random random = new Random();
		static string dna = "AaTtGgCc";

		public static double GetSize(this string str)
		{
			var collection = regex.Match(str);
			return double.Parse(collection.Groups[1].Value);
		}
		
		public static string GenerateDNA(int length)
		{
			StringBuilder result = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				result.Append(dna[random.Next(0, dna.Length)]);
			}
			return result.ToString();
		}
	}
}
