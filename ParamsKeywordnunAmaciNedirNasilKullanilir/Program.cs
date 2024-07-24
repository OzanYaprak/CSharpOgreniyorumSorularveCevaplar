using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeywordnunAmaciNedirNasilKullanilir
{
	internal class Program
	{
		// Eger bir methodun sinirsiz sayida arguman almasi isteniyorsa params keyword kullanilabilinir.
		// Bir metodun icerisine yazmis oldugumuz veriler parametredir fakat bir metodu cagirip icerisine vermis oldugumuz veriler ise argumandir.

		static void Main(string[] args)
		{
			var intList = new int[] { 1, 2, 3, 4, 5 };

			Console.WriteLine(TestMethod(intList)); // params keyword kullanilmadan hali

			Console.WriteLine(TestMethod(1,2,4,5,67)); // params keyword oldugu icin artik buradan gonderegimiz veriler ornekteki gibi olabilir.

			// Sadece int veri tipi icin degil, diger veri tipleri icinde kullanilabilinir.
        }

		public static int TestMethod(params int[] sayilar)
		{
			int toplam = 0;

			foreach (int item in sayilar) 
			{
				toplam += item;
			}

			return toplam;
		}
	}
}
