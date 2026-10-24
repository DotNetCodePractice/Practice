
namespace DotNetCode
{
	public class EmployeeClass : InterfaceExample1
	{
		// Fields
		public int id;
		public string name = "";

		// Property
		public int Age { get; set; }

		// Parameterless constructor
		public EmployeeClass()
		{
			Console.WriteLine("Class constructor called");
		}

		// Parameterized constructor
		public EmployeeClass(int id, string name)
		{
			this.id = id;
			this.name = name;
		}

		// Method
		public void Display()
		{
			Console.WriteLine(
				$"ID: {id}, Name: {name}, Age: {Age}");
		}

		// Destructor (called by garbage collection,
		// not manually)
		~EmployeeClass()
		{
			Console.WriteLine("Class cleanup");
		}

		public void MessageInterface1()
		{
			Console.WriteLine("Point 1 Struct");
		}
		public int pointerInterface1(int a, int b)
		{
			int result = a + b;
			Console.WriteLine(a+b);
			return result;
		}
	}
}
