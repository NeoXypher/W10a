using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10a
{
	class Program
	{
		static void Main(string[] args)
		{
			string response = "";
			bool looping = true;
			ArrayList NumberArray = new ArrayList();
			for (int i = 0; looping; i++)
			{
				Console.WriteLine("Enter a number between -100 and 100: ");
				response = Console.ReadLine();
				if (response == "Stop")
					looping = false;
				else if (Convert.ToInt32(response) > 100 || Convert.ToInt32(response) < -100)
					Console.WriteLine("Not in Range");
				else
					NumberArray.Add(Convert.ToInt32(response));
			}
			NumberArray.Sort();
			foreach (object Element in NumberArray)
			{
				Console.WriteLine(Element);
			}
			Console.ReadLine();
		}
	}
}
