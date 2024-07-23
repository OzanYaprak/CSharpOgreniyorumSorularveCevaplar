using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIleArrayListArasindakiFarkNedir
{
	internal class Program
	{
		//Ikiside bir dizin yapisindadir yani birden fazla deger tutabilecegimiz yapidadirlar.

		String[] stringList = new String[5]; // Burada stringList icerisine en fazla 5 tane kayit atabilecegimi belirtmis oluyorum. 
											 // Burada mutlaka dizinin boyutunu belirtmemiz gerekiyor.
											 // Hangi tipte olusturduysak o tipte bir data tutabiliriz

		ArrayList arrayList = new ArrayList(); // Dizin boyutu 4 ve katlari olacak sekilde otomatik olarak bellekte tutulur.
											   // Ilk olusturuldugunda 4 birimlik bellekte yer tutarken eger 5nci bir eleman eklememiz durumunda otomatik olarak bellekte 8 birimlik yer aciyor ve bu sinirlara geldiginde otomatik olarak devam ediyor.
											   // Tip sinirlamasi bulunmuyor.
		//arrayList.Add(3);

		static void Main(string[] args)
		{
			String[] stringList = new String[5];
			stringList[0] = "Ozan";
			stringList[4] = "Erhan";

			Console.WriteLine(stringList[0]);
			Console.WriteLine(stringList[4]);


			ArrayList arrayList = new ArrayList();
			arrayList.Add(33);
			arrayList.Add("Yaprak");

			Console.WriteLine(arrayList[1]);
        }
	}
}
