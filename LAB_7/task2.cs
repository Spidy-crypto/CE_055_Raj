using System;
using System.Linq;
using System.Collections.Generic;
namespace task2{
	public class task2{
		static void Main(string []args){
			string[] names = {"Krunal","monika","shrey","Paras","Krinal","Shreyans","Ajay","Dharmil","Dhruvil","Jay"};
			var k = names.Where(n => n[0]=='K' || n[0] == 'k');
			var less_than_4 = names.Where(n => n.Length < 4);
			var equal_3 = names.Where(n => n.Length == 3);
			var asc = names.OrderBy(n => n);
			
			Console.WriteLine("Name Starts with k");
			foreach(var i in k){
				Console.WriteLine(i);
			}
			
			Console.WriteLine();
			Console.WriteLine("Names Whose length is lessthan 4");
			foreach(var i in less_than_4){
				Console.WriteLine(i);
			}
			
			Console.WriteLine();
			Console.WriteLine("Names Whose lengthis equal to 3");
			foreach(var i in equal_3){
				Console.WriteLine(i);
			}
			
			Console.WriteLine();
			Console.WriteLine("Names in ascending Order ");
			foreach(var i in asc){
				Console.WriteLine(i);
			}
			Console.ReadLine();
			
			
		}
	}
}