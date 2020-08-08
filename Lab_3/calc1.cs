using System;
using System.Reflection;
[assembly : AssemblyVersion("7.0.0.0")]
namespace Calculator
{
	public class Op{
		public int add1(int num1,int num2){
			Console.WriteLine("New version");
			return num1+num2;
		}
		public int mul(int num1,int num2){
			return num1*num2;
		}
	}
}