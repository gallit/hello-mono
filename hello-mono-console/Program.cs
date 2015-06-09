using System;

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
			var data = new { Machine = Environment.MachineName };
			var s = $"C# Hello {data.Machine}, we're on {DateTime.Today:D}";
			Console.WriteLine (s);

		}
	}
}
