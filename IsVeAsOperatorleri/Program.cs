using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsVeAsOperatorleri
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Object icerisine her turlu veri tipini alir.
			Object[] dizin = { "ozan", 5, 6.7, false, "yaprak", true, 40 };

			#region IS Operatoru
			foreach (var item in dizin)
			{
				if (item is string) { Console.WriteLine(item); }
				//Dizin icerisinde string veri tipleri var ise bunlari konsola yazdirir.
				//Burada veri tipini ne belirtirsek onlari dizin icerisinde arayip konsola yazdiracak.
				if (item is int) { Console.WriteLine(item); }

				//IsNullOrWhiteSpace() veya IsNullOrEmpty() yerine asagidaki gibide bir kullanim yapilabilinir.
				if (item is null) { Console.WriteLine("null deger bulunuyor."); }
			}
			Console.ReadKey();
			#endregion
			#region AS Operatoru
			foreach (var item in dizin)
			{
				string veri = item as string; // Bir tipi bir tipe donusturur, degil ise null atayacak.
				Console.WriteLine(veri);
				Console.ReadKey();
			}
			#endregion
		}
	}
}
