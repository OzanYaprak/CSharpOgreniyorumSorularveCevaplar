using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVeTryParseMetotlari
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Int.Parse() Ve Int.TryParse()

			#region Int.Parse()

			//Parse islemi sadece String uzerinden gerceklestirilir.
			string abc = "10";

			int sayi10 = int.Parse(abc); //Donusturebilirse donusturecek, olmaz ise hata firlatacak.
			double sayi11 = double.Parse(abc);
			decimal sayi12 = decimal.Parse(abc);
			byte sayi13 = byte.Parse(abc);
			// Yukaridaki parse metotlarini mutlaka string bir ifade girilmesi gerekir.

			#endregion Int.Parse()

			#region Int.TryParse()

			string ozan = "10";
			int result;

			bool isSuccess = int.TryParse(ozan, out result); //Eger donusturebilirse isSuccess true olacak, donusturemez ise false olacak ve out result kisminda 0 yazacak.

			//Int.Parse() metodunda exception firlatiyordu fakat Int.TryParse() metodunda herhangi bir hata firlatilmiyor.

			Console.WriteLine(isSuccess);
			Console.WriteLine(result);

			Console.ReadLine();

			#endregion Int.TryParse()

			#endregion
		}
	}
}
