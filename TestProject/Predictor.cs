using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	public class Predictor
	{
		public bool IsPalindrom(string input)
		{
			var isPalindrom = false;

			var inputArray = input.ToCharArray();

			Array.Reverse(inputArray);

			var reversedInput = new string(inputArray);

			if (input == reversedInput)
			{
				isPalindrom = true;
			}

			return isPalindrom;

		}
	}
}
