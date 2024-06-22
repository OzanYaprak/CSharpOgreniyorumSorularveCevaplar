using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassNedir
{
	internal class Program
	{
		//Abstract class (Soyut Sinif)
		//Abstract classlar birer main class yani parent class olarak kullanilir
		//Abstract classlar diger siniflarda miras olarak kullanilirlar
		//Abstract classlardan nesne ornegi olusturulamaz. Abstract classlar base classlardir, bu base classlardan miras almis bir class var ise o miras alan classdan yeni bir nesne ornegi olusturabiliriz
		//Buyuk projelerde kullanilir ve kalitim ozelligi kullanilarak kod tekrarini azaltiriz. Ornegin yaptigimiz projede bir cok yerde ad soyad gibi standart propertyler kullanacaksak, bunlari bir Abstract sinif icerisinde belirleyip, kullanacagimiz baska siniflara bu abstract siniftan miras alabiliriz.


		static void Main(string[] args)
		{
			//BaseKisi kisi = new BaseKisi(); //Abstract Class'dan nesne ornegi olusturulamaz.

			Isci isci = new Isci();
			Gorevli gorevli = new Gorevli();
			Yonetici yonetici = new Yonetici();

			isci.ConsoleAciklama();

			isci.TestMethod();
			gorevli.TestMethod();
			yonetici.TestMethod();
		}


		
		abstract class BaseKisi
		{
			public string Ad { get { return "ozan"; } set { } }
			public string Soyad { get; set; } = "yaprak";

			public void ConsoleAciklama()
			{
				Console.WriteLine(Ad + " " + Soyad);
			}

			public abstract void TestMethod();
			//Abstract bir class icerisinde tanimladigimiz govdesiz ve diger classlara implement edilebilir olan methodlar mutlaka Abstract olmak zorunda.
		}



		class Isci : BaseKisi
		{
			public override void TestMethod()
			{
                Console.WriteLine("Isci Sinifi Calisti");
            }
		}
		class Gorevli : BaseKisi
		{
			public string Gorevi { get; set; }

			public override void TestMethod()
			{
				Console.WriteLine("Gorevli Sinifi Calisti");
			}
		}
		class Yonetici : BaseKisi
		{
			public string Unvan { get; set; }

			public override void TestMethod()
			{
				Console.WriteLine("Yonetici Sinifi Calisti");
			}
		}
	}
}
