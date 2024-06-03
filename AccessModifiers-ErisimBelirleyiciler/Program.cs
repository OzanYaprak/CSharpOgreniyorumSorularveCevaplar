using Matematik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_ErisimBelirleyiciler
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Bilgi
			Ogrenci ogrenci = new Ogrenci();
			Console.WriteLine(ogrenci.Name);

			ogrenci.Age = 15;


			Console.ReadKey();
			#endregion

			#region Tip Donusumleri

			#region Implicit Type (Kapali tip donusumu)

			int sayi = 100;
			long sayi2 = sayi; //Long, int dan daha yuksek seviyede bir veri tipidir.

			#endregion
			#region Explicit Type (Acik tip donusumu)

			long sayi3 = 500;
			//int sayi4 = sayi3; 

			//Eger yukaridaki sekilde yaparsak hata aliriz, cunku int veri tipi long veri tipinden daha dusuk seviyededir.
			//Bu yuzden asagidaki gibi kullanim daha dogru olur.

			int sayi4 = (int)sayi3;

			//Fakat

			byte sayi5 = (byte)sayi3; //Bu sekilde kullanimda bir veri kaybi olabilir, cunku byte veri tipi -255 ile +255 arasinda bir deger alabilir fakat biz burada 500 gonderiyoruz.

			#endregion

			#endregion

			#region Value Type Veri Tipleri
			//int,decimal,byte,long vb veri tipleri value type veri tipleridir, bunlar bellegin stack bolgesinde tutuluyor.
			#endregion
			#region Refferance Type Veri Tipleri
			//class,interface,delegate bunlar referans tipinde veri tipleridir.Referans tipleri genellikle bellegin "heap" bölgesinde tutulur.
			#endregion

			#region Boxing/UnBoxing

			#region Boxing Islemi

			//Boxing islemi value type bir degiskenden referans type bir degiskene tip donusumu yapilmasina denilir.

			int deger = 100; // Value Type Degisken => Byte,Int,Long,Decimal..
			object deger2 = deger; // Object Referance Type bir degiskendir.

			#endregion

			#region UnBoxing Islemi

			object deger3 = 100;

			int deger4 = (int)deger3; // (int) Buna Cast Islemi Deniliyor.

			#endregion

			#endregion

			#region Casting Islemi

			long test = 100;
			int say1 = (int)test; // (int)test Casting Islemi

			//Diger bir Casting yontemi ise asagidaki gibidir.

			int say2 = Convert.ToInt32(test);

			#endregion

			#region Int.Parse() Ve Int.TryParse()

			#region Int.Parse()

			//Parse islemi sadece String uzerinden gerceklestirilir.
			string abc = "10";

			int sayi10 = int.Parse(abc); //Donusturebilirse donusturecek, olmaz ise hata firlatacak.
			double sayi11 = double.Parse(abc);
			decimal sayi12 = decimal.Parse(abc);
			byte sayi13 = byte.Parse(abc);
			// Yukaridaki parse metotlarini mutlaka string bir ifade girilmesi gerekir.

			#endregion

			#region Int.TryParse()

			string ozan = "10";
			int result;

			bool isSuccess = int.TryParse(ozan, out result); //Eger donusturebilirse isSuccess true olacak, donusturemez ise false olacak ve out result kisminda 0 yazacak. 

			//Int.Parse() metodunda exception firlatiyordu fakat Int.TryParse() metodunda herhangi bir hata firlatilmiyor.

			Console.WriteLine(isSuccess);
            Console.WriteLine(result);

			Console.ReadLine();

            #endregion

            #endregion
        }

		class Ogrenci
		{
			#region Bilgi
			private string _name = "ozan".ToUpper();
			private int _age;


			public string Name { get { return _name; } }
			public int Age { set { _age = value; } }
			#endregion
		}
	}
}


