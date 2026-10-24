
namespace DotNetCode
{
	public struct EmployeeStruct : InterfaceExample1, InterfaceExample2
	{
		public int id;
		public string name;

		public int Age { get; set; }

		// Explicit parameterless constructor
		public EmployeeStruct()
		{
			id = 0;
			name = "";
			Age = 0;
		}

		// Parameterized constructor
		public EmployeeStruct(int id, string name,int age)
		{
			this.id = id;
			this.name = name;
			this.Age = age;
		}

		public void Display()
		{
			Console.WriteLine(
				$"ID: {id}, Name: {name}, Age: {Age}");
		}

		public void MessageInterface1()
		{
			Console.WriteLine("Point 1 Struct");
		}

		public void MessageInterface2()
		{
			Console.WriteLine("Point 2 Struct");
		}


		public int pointerInterface1(int a, int b)
		{
			int result = a + b;
			Console.WriteLine(a + b);
			return result;
		}
	}
}
