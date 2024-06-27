using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorNedir
{
	internal class Program
	{
		//Bir class'ın özel bir method tipi olup, nesne oluştuğu zaman (bir classtan new keyword ile nesne oluşturma) otomatik bir şekilde çalışan methodlardır.
		//Constructor isimleri class isimleri ile aynı olmak zorunda
		//Constructorlar herhangi bir data veya veri dönmezler
		//Constructorlar ya public ya da private erişim belirleyicilere sahip olabilirler.
		//Constructorlardan herhangi bir şekilde bir hata fırlatabiliriz.


		static void Main(string[] args)
		{
			baseClass baseClass = new baseClass();

			//Sadece nesne örneği aldığımızda da aşağıda yazdığımız constructor otomatik olarak çalışacaktır.
		}
	}

	public class baseClass
	{
        public baseClass()
        {
            Console.WriteLine("bu method otomatik bir şekilde çağrıldı");
        }
    }

}
