using System;
using ProjectEuler.Problems;

namespace ProjectEuler
{
	class Program
	{
		static void Main(string[] args)
		{
			//Problem1.Run(); //to run individual Problem
			RunAllPrograms();
			Console.WriteLine("Press any key to close");
			Console.ReadKey();
		}

		static void RunAllPrograms()
		{
			Problem1.Run();
			Problem2.Run();

		}
	}
}
