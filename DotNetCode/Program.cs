
using System;
using System.Security.Cryptography.X509Certificates;
using DotNetCode;

public class Program
{
	public static void Main(string[] args)
	{
		int a = 1;
		int b = 1;
		string str1 = "w";
		string str2 = "w";
		string str3 = new string("w".ToCharArray());
		string str4 = new string("w".ToCharArray());
		Console.WriteLine(a == b);
		Console.WriteLine(a.Equals(b));

		Console.WriteLine(str1 == str2);
		Console.WriteLine(str3 == str4);
		Console.WriteLine(str1.Equals(str2));
		Console.WriteLine(str3.Equals(str4));
		Console.WriteLine(object.ReferenceEquals(str1,str2));
		Console.WriteLine(object.ReferenceEquals(str3, str4));


		//Console.WriteLine("Class");

		//EmployeeClass emp1 = new EmployeeClass(9, "Bala");
		//EmployeeClass emp2 = emp1;

		//emp2.name = "Bharath";

		//Console.WriteLine("emp1: " + emp1.name);
		//Console.WriteLine("emp2: " + emp2.name);

		//Console.WriteLine("Struct");

		//EmployeeStruct emp3 = new EmployeeStruct(9, "Bala",25);
		//EmployeeStruct emp4 = emp3;

		//emp4.name = "Bharath";

		//Console.WriteLine("emp3: " + emp3.name);
		//Console.WriteLine("emp4: " + emp4.name);

		//// 3. CLASS METHODS
		//Console.WriteLine("\n=== CLASS METHOD ===");
		//emp1.Display();
		//emp1.MessageInterface1();
		//emp1.pointerInterface1(9, 1);

		//// 4. STRUCT METHODS
		//Console.WriteLine("\n=== STRUCT METHOD ===");
		//emp3.Display();
		//emp3.MessageInterface1();
		//emp3.MessageInterface2();
		//emp3.pointerInterface1(9, 11);

		//// 5. NULL DIFFERENCE
		//Console.WriteLine("\n=== NULL EXAMPLE ===");

		//EmployeeClass emp5 = null;
		//Console.WriteLine(emp5 == null);

		//// Nullable struct
		//EmployeeStruct? emp6 = null;
		//Console.WriteLine(emp6 == null);

		Console.ReadLine();
		

	}
}
