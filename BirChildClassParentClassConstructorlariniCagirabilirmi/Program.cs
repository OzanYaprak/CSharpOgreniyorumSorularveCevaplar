using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirChildClassParentClassConstructorlariniCagirabilirmi
{
	internal class Program
	{
		//Child classlardan Parent Classların Constructorlarını çağırabiliriz.

		//Bir class new() ile nesne örneği alınmaktan nasıl koruruz ?     //Eğer class içerisinde private constructor kullanırsak o classın new ile nesne örneği alınmamasını sağlarız.


		static void Main(string[] args)
		{
			childClass childClass = new childClass("ozan","yaprak",33);

            Console.WriteLine(childClass.Isim);
        }
	}

	public class baseClass
	{
		public string Isim { get; set; }
		public int Yas { get; set; }

		public baseClass() { } //Parametre alan bir constructor tanımladığımız için default constructor kullanımdan kalktığından, hata almamak için bir tane default constructor tanımladık.

		public baseClass(string isim, int yas)
		{
            Console.WriteLine("baseClass Constructor Çalıştı");

            this.Isim = isim;
			this.Yas = yas;
		}
	}

	public class childClass : baseClass
	{
		public string Soyad { get; set; }
		
		public childClass() { } //Parametre alan bir constructor tanımladığımız için default constructor kullanımdan kalktığından, hata almamak için bir tane default constructor tanımladık.


		//İlk olarak baseClass içerisindeki constructor çalışır, daha sonra aşağıdaki constructor çalışır.
		public childClass(string isim, string soyad, int yas) : base(isim,yas)
		{
			Console.WriteLine("childClass Constructor Çalıştı");
			
			this.Soyad = soyad;
		}
	}
}
