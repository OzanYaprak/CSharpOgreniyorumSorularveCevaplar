using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasslarConstructorlaraSahipOlabilirMiOlabilirseKullanimAmaciNedir
{
	internal class Program
	{
		//Soyut siniflar constructorlara sahip olabilirler
		//Kullanim amaci soyut siniftaki uyelerin degiskenlerine ilk deger vermek icin kullanilir.

		static void Main(string[] args)
		{
			ChildClass childClass = new ChildClass("ozan","yaprak");

			childClass.ConsoleYaz();
		}

		//Soyut yani abstract bir sinif icerisinde olusturulan constructor her zaman child sinifindan once calisir.
		public abstract class BaseClass
		{
			public string Ad { get; set; }
			public string Soyad { get; set; }

			//Parametreli Constructor
			public BaseClass(string name, string surname)
			{
				Console.WriteLine("BaseClass Constructor Calisti");

				Ad = name;
				Soyad = surname;

				//Parametresiz Ctor icin
				//Ad = "Ozan";
				//Soyad = "Yaprak";
			}

			public void ConsoleYaz()
			{
				Console.WriteLine(Ad + " " + Soyad);
			}
		}

		public class ChildClass : BaseClass
		{
			//public ChildClass()
			//{
			//	Console.WriteLine("ChildClass Constructor Calisti");
			//}
			
			public ChildClass(string name, string surname) : base(name, surname) //Base sinifin parametrelerinden miras alir.
			{
				Console.WriteLine("ChildClass Constructor Calisti");
			}
		}
	}
}
