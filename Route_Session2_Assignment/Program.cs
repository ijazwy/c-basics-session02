using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	internal class Program
	{
		static void Main(string[] args)
		{
		// Every question setted into #region and #endregion to make it easy to test each question by commenting the
		// uncommented code inside any region  and run it to test the assignment question.
		// for best practice we can put every question inseparte class file later
		// waiting for any notes exist


		#region Q1
		Book book = new Book("C# for beginner", 365);
		object obj = book;
		Console.WriteLine(obj);
		#endregion

		#region Q02

		//Book book = new Book("C# for beginner", 365);
		//Console.WriteLine(book.ToString());
		//Console.WriteLine(book.Equals(book));
		//Console.WriteLine(book.GetHashCode());
		//Console.WriteLine(book.GetType());

		#endregion

		#region Q03
		// compile-time error, >> pages should be integer not string
		//int pages = 464;
		//Console.WriteLine(pages);

		#endregion

		#region Q04
		//int x = 10, y = 0;
		//try
		//{
		//	int result = x / y;
		//}
		//catch (DivideByZeroException)
		//{
		//	Console.WriteLine("Cannot divide by zero");
		//}
		//finally
		//{
		//	Console.WriteLine("Done");
		//}

		#endregion

		#region Q05
		//int pages = 300;
		//double doublePages = pages;
		//Console.WriteLine(doublePages);

		#endregion

		#region Q06

		//double price = 49.99;
		//int castedPrice = (int)price;
		//Console.WriteLine(castedPrice);

		#endregion

		#region Q07

		//string pagesText = "464";
		//int convetedPages = Convert.ToInt32(pagesText);
		//Console.WriteLine(convetedPages);

		#endregion

		#region Q08
		//string yearText = "2023";
		//int year = int.Parse(yearText);
		//Console.WriteLine(year);

		//string badText = "abc";
		//if(int.TryParse(badText, out int result))
		//{
		//	Console.WriteLine(result);
		//}
		//else {
		//	Console.WriteLine("Invalid number");
		//}

		#endregion

		#region Q09

		//int pages = 464;
		//string pagesText = pages.ToString();
		//Console.WriteLine(pagesText.GetType());

		#endregion

		#region Q10
		//int copies = 100;
		//object obj = copies;
		//int newCopies = (int)obj;
		//Console.WriteLine(copies);
		//Console.WriteLine(newCopies);

		#endregion

		#region Q11
		//int? year = null;
		//Console.WriteLine(year.HasValue);
		//year = 2023;
		//Console.WriteLine(year);

		#endregion

		#region Q12
		//string? reviewer = null;
		//Console.WriteLine(reviewer == null);

		#endregion

		#region Q13
		//Book? book = null;
		//string bookTitle = book?.Title;
		//Console.WriteLine(bookTitle);

		#endregion

		#region Q14

		//Book? book = null;
		//string bookTitle = book?.Title;

		//// using ?? to returns a default value if null
		//Console.WriteLine(bookTitle ?? "Untitled");

		//// using ??= to assigns a value if null
		//bookTitle ??= "Untitled";

		//Console.WriteLine(bookTitle);

		#endregion

		#region Q15
		//string? name = "Ahmed";
		//string confirmedName = name!;
		//Console.WriteLine(confirmedName);

		#endregion

	}
}