using System;
namespace Add{
	public class Add{
		static void Main(string[] args){
			Console.WriteLine("Enter 1st Nummber = ");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter 2nd Nummber = ");
			int num2 = int.Parse(Console.ReadLine());
			int result = num1+num2;
			Console.WriteLine(result);
			Console.ReadLine();
		}
	}
}