using System;

namespace ProjectEuler1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = 1000;
			int sum = 0;

			for (int i = 1; i < n; ++i) {
				sum += (i % 3 == 0 || i % 5 == 0) ? i : 0;
			}
			Console.WriteLine (sum);
		}
	}
}
