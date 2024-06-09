using System;

namespace AccessModifiers_ErisimBelirleyiciler
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			#region Bilgi

			Ogrenci ogrenci = new Ogrenci();
			Console.WriteLine(ogrenci.Name);

			ogrenci.Age = 15;

			Console.ReadKey();

			#endregion Bilgi
		}

		private class Ogrenci
		{
			#region Bilgi

			private string _name = "ozan".ToUpper();
			private int _age;

			public string Name
			{ get { return _name; } }

			public int Age
			{ set { _age = value; } }

			#endregion Bilgi
		}
	}
}