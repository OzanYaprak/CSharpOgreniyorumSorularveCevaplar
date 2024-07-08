using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorNedir
{
	internal class Program
	{
		//Static Constructorlar, sahip olduğu classdan ilk nesne örneği alındığında çalışır, ikinci defa alınan nesne örneklerinde çalışmazlar.
		//STATIC CONSTRUCTORLAR HER ZAMAN NORMAL CONSTRUCTORLARDAN ÖNCE ÇALIŞIRLAR !!
		static void Main(string[] args)
		{
			ornekClass ornekClass = new ornekClass(); //Static Constructor Sadece Bu Nesne Örneğinde Çalıştı.
			ornekClass ornekClass2 = new ornekClass();
			ornekClass ornekClass3 = new ornekClass();
        }
	}

	public class ornekClass
	{
		public static int yas { get; set; }

		static ornekClass() //Static Consturctorlar herhangi bir erişim belirleyicisine sahip olmazlar.
		{
			yas = 21;
            Console.WriteLine("Static Constructor Çalıştı");
        }

		public ornekClass()
		{
			Console.WriteLine("Normal Constructor Çalıştı.");
		}
	}
}