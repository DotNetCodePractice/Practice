using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotNetCode
{
	public class Manager : EmployeeClass
	{
		public void Display()
		{
			Console.WriteLine(name);
		}
	}

	public struct Point
	{
		public int X;
		public int Y;
	}
}

