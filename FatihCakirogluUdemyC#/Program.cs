using System;

namespace FatihCakirogluUdemyC_
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			ogrenciler ogrenciler = new ogrenciler();

			ogrenciler.Name = "ozan";
			ogrenciler.Age = 20;
			ogrenciler.Surname = "yaprak";

			Console.WriteLine(ogrenciler.Name);
			Console.WriteLine(ogrenciler.Surname);
			Console.WriteLine(ogrenciler.Age);
			
			Console.ReadLine();
		}

		private class ogrenciler
		{
			private string _name;
			private string _surname;
			private int _age;

			public string Name { get { return _name.ToUpper(); } set { _name = value; } }
			// * get * kisminda degisken okuma yapilir, * set * kisminda degisken atama islemi yapilir.
			public string Surname { get { return _surname.ToUpper(); } set { _surname = value; } }

			public int Age
			{
				get { return _age; }
				set
				{
					if (value > 20)
					{
						throw new Exception("ogrenci yasi 20 den buyuk olamaz !");
					}
					_age = value;
				}
			}
		}
	}
}