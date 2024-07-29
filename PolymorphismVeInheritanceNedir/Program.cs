using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismVeInheritanceNedir
{
	internal class Program
	{
		// Inheritance : Bir ust sinifin ozelliklerinin bir alt sinifa gecmesidir.
		// Polymorphism : Bir nesnenin farkli amaclar icinde kullanilabilecegi anlamina gelir. Statik ve dinamik olarak ikiye ayrilir.
		// - Statik : Bir metotun overload olmasi demek statik cok bicimlilik deniliyor.
		// - Dinamik : USt siniflarda kullanilan virtual abstract classlarin alt siniflarda ezilmesi.

		static void Main(string[] args)
		{
		}
	}

	#region Statik Polymorphism

	public class TestClass
	{
		public void Yazdir() 
		{
            Console.WriteLine("Sekil Yazdiriliyor");
        }

		public void Yazdir(string veritabani) 
		{
            Console.WriteLine("Sekil veritabanina yazdiriliyor. Ilgili veritabani: " + veritabani);
        }
	}

	#endregion

	#region Dinamik Polymorphism

	public class BaseClass
	{
		public virtual void Olustur() // Virtual bir method oldugu icin alt methodlarda bunu ezebiliriz.
		{
			Console.WriteLine("Olusturuluyor..");
		}
	}

	public class ChildClass : BaseClass
	{
		// Yukarida olusturmus oldugumuz methodu burada override keyword u yazarak ezebildik.
		// Ayni metot a biz farkli bir is yaptirabildik, polymorphism bu oluyor. Bir nesnenin ozelliklerini farkli amaclar icin kulladirtabiliyoruz.
		// Ana metotu cesitlendirdik, cok cesitlilik ( Polymorphism ) buradan geliyor.

		public override void Olustur()
		{
			Console.WriteLine("Miras Olusturuluyor..");
		}
	}

	public class ThirdChildClass : ChildClass 
	{
		public override void Olustur()
		{
            Console.WriteLine("Ozan YAPRAK");
        }
	}

	#endregion
}
