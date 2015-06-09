using System;
using hellomono.model;

namespace hellomonoconsole
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			hello6 ();
		}

		/// <summary>
		/// C# 6 string interpolation
		/// </summary>
		private static void hello6()
		{
			var contact = new Contact () { FirstName = "John", LastName = "Doe" };
			// cf contact.ToString override
			var s = $"Hello {contact}, we're on {DateTime.Today:D}";
			Console.WriteLine (s);

		}
	}
}
