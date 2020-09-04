using System;
using System.Linq;
using System.Collections.Generic;
namespace task1
{
	public class Task1{
		static void Main(string []args){
			int[] num= new int[100];
			for(int i=0;i<100;i++)
			{
				num[i] = i+1;
			}
			var even = num.Where(n => n%2==0);
			var odd = num.Where(n => n%2==1);
			var all = num.Select(n => n);
			var max = num.Max();
			var min = num.Min();
			var avg = num.Average();
			Console.Write("Even Number is :- ");
			foreach(var i in even){
				Console.Write(i);
				Console.Write(" ");
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.Write("Odd Number is :- ");
			foreach(var i in even){
				Console.Write(i);
				Console.Write(" ");
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.Write("All Number is :- ");
			foreach(var i in all){
				Console.Write(i);
				Console.Write(" ");
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Max Number is {0}",max);
			Console.WriteLine();
			Console.WriteLine("Min Number is {0}",min);
			Console.WriteLine();
			Console.WriteLine("Avrage is {0}",avg);
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}