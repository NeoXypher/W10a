using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10a
{
	class Task_5
	{
		
		public static void Main()
		{
			Dictionary<string, int> NewDict = new Dictionary<string, int>();
			NewDict.Add("Steve", 34);
			NewDict.Add("Jimmy", 78);
			var List = NewDict.Keys.ToList();
			List.Sort();
			foreach (var key in List)
			{
				Console.WriteLine("{0} : {1}", key, NewDict[key]);
			}
			Console.ReadLine();
		}
	}
}
