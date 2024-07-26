using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpdaEscapeKarakterleriNelerdir
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string isim = "Ozan \n Yaprak"; // \n yazildiktan sonra gelen string ifadeyi bir alt satirda yazar
			string isim2 = "Ozan \"Erhan\" Yaprak"; // string ifadenin icerisinde cift tirnak kullanmis olduk.
			string isim3 = "Ozan \tErhan Yaprak"; // satirda bir tab alanlik bosluk birakiyor.
			string isim4 = "Ozan \\Erhan Yaprak";

			Console.WriteLine(isim);
			Console.WriteLine(isim2);
			Console.WriteLine(isim3);
			Console.WriteLine(isim4);
        }
	}
}
