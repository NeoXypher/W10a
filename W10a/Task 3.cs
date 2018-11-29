using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10a
{
	class Task_3
	{
		public static void Main()
		{
			int[] intArray = new int[100];
			for (int i = 1; i <= 100; i++)
			{
				intArray[i - 1] = i;
			}
			intArray = intArray.Where((Source, Index) => (Index % 5 == 0 || Index % 3 == 0)).ToArray();
			for (int i = 0; i < intArray.Length; i++)
			{
				Console.WriteLine(intArray[i]);
			}
			Console.ReadLine();
		}
	}
}
