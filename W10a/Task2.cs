using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10a
{
	class Task2
	{
		public static void Main()
		{
			double[] DoubleArray = new double[] { 0.2, 0.3, 0.8, 1.2, 3.4 };
			Console.WriteLine("Enter a size for the string array:");
			string[] StringArray = new string[Convert.ToInt32(Console.ReadLine())];
			for (int i = 0; i < StringArray.Length; i++)
			{
				Console.WriteLine("Enter a string value:");
				StringArray[i] = Console.ReadLine();
			}
			ArrayList NewList = new ArrayList();
			NewList.Add(DoubleArray);
			NewList.Add(StringArray);
			foreach (object Element in NewList)
			{
				Console.WriteLine(Element);
			}
			Console.ReadLine();
		}
	}
}
