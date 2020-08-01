using System;
using calc;
namespace driver{
	public class driver{
		static void Main(string[] args){
			Calc c = new Calc();
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			Console.WriteLine(c.addition(num1,num2));
			Console.ReadLine();
		}
	}
}