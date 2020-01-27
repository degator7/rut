using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace rut
{
	public class Rut
	{
		public static string DigitCheck(int irut)
		{
			return "0K987654321"[Enumerable.Range(0, (int)Math.Floor(Math.Log10(irut)) + 2).Select(i => ((i % 6) + 2) * ((irut / (int)Math.Pow(10, i)) % 10)).Sum() % 11].ToString();
		}
		public static bool ValidateRut(string rut)
		{
			return (Regex.Match(rut.Replace(".", string.Empty).ToUpper(), "^([0-9]+-[0-9K])$").Success && rut.EndsWith(DigitCheck(Convert.ToInt32(rut.Replace(".", string.Empty).Split("-")[0]))));
		}

		


	}
}
