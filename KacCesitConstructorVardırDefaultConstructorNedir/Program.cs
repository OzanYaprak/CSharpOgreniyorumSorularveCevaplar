using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KacCesitConstructorVardırDefaultConstructorNedir
{
	internal class Program
	{
		//Toplam 5 adet constructor bulunuyor ;
		// - Default Constructor
		// - Parameterized Constructor
		// - Copy Constructor
		// - Static Constructor
		// - Private Constructor

		static void Main(string[] args)
		{
			ornekClass ornekClass = new ornekClass();

            Console.WriteLine(ornekClass.deger);
            Console.WriteLine(ornekClass.deger2);
        }
	}

	public class ornekClass
	{
		//Bir class oluşturduğumuzda arka planda otomatik olarak Default bir constructor oluşturuluyor. (System Defined Constructor)
		//Bu constructor bu class altında oluşturduğumuz değişkenlere default değerler atanmasını sağlıyor.

		public int deger;
		public bool deger2;

		//Constructorlar oluşturulurken her zaman oluşturulmuş olduğu class'ın adını alırlar !
		public ornekClass() 
		{
			deger = 1;
			deger2 = false;
		}

	}
}
