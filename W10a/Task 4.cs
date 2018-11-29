using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10a
{
	class Task_4
	{
		public static void Main()
		{
			int[] Numbers = new int[] { 1, 2, 3, 4, 5 };
			string operation = "Square";
			
			for (int i = 0; i < Numbers.Length; i++)
			{
				switch (operation)
				{
					case "Square":
						Numbers[i] *= Numbers[i];
						break;
					case "Double":
						Numbers[i] *= 2;
						break;
					case "Triple":
						Numbers[i] *= 3;
						break;
					case "++":
						Numbers[i]++;
						break;
					case "--":
						Numbers[i]--;
						break;
					default:
						break;
				}
				Console.WriteLine(Numbers[i]);
			}
			Console.ReadLine();
		}
	}
}
