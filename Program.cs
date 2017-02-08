using System;
using System.Numerics;

namespace BigFacturial
{
	public class MainClass
	{
		public static void Main()
		{
			var number = int.Parse(Console.ReadLine());

			BigInteger bigNum = 1;

			for (var i = 2; i <= number; i++)
			{
				bigNum *= i;
			}

			Console.WriteLine(bigNum);
		}
	}
}
